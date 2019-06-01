using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace MP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Al cargar el formulario ponemos el reproductor como invisible
        private void Form1_Load(object sender, EventArgs e)
        {
            reproductor.uiMode = "invisible";
        }
        
        //Reproducir A través de Windows Player
        private void button1_Click(object sender, EventArgs e)
        {           

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reproductor.URL = openFileDialog1.FileName;                 
            }
            reproductor.Ctlcontrols.play();
        }
      

        //Detener la reproducción en Windows Player
        private void button2_Click(object sender, EventArgs e)
        {
            reproductor.Ctlcontrols.stop();
        }


        //DLL a utilizar para poder reproducir MP3
       [DllImport("winmm.dll")]

        //Método externo (esta definido en winmm.dll) tipo long que se encargara de enviar comandos al MCI
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);


        //Método para reproducir MP3 a través de MCI
        //Recibe: Nombre y ruta del archivo a reproducir
        public void PlayMP3(string rutaArchivo)
        {
            //Comandos multimedia de MCI http://msdn.microsoft.com/en-us/library/ms712587        

            //Abrir el dispositivo MCI
            //miMP3 es el alias con el que manejaremos el archivo MP3 recibido como parametro en rutaArchivo
            string comandoMCI = string.Format("open \"{0}\" type mpegvideo alias miMP3", rutaArchivo);
            //a traves de mciSendString, enviamos el comando anterior, para abrir el dispositivo MCO
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
            //Ahora en comandoMCI daremos la orden de reproducir el archivo, recordando que lo hacemos
            //a traves del alias que definimos anteriormente miMP3
            comandoMCI = "play miMP3";
            //enviamos a ejecutar el comando play
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
        }

       //Reproducir a través de MCI, 
        //Envia: el nombre del archivo se envia hacia el método PlayMP3
        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PlayMP3(openFileDialog1.FileName); 
            }
            

        }

        //Detener la reproducción del MP3 en el MCI
        private void button4_Click(object sender, EventArgs e)
        {
            //Comandos multimedia de MCI http://msdn.microsoft.com/en-us/library/ms712587            
            //el comando es stop y se le envia al alias miMP3, que se definio cuando se dio Play
            string comandoMCI = "stop miMP3";
            //Enviar el comando stop al MCI
            mciSendString(comandoMCI, null, 0, IntPtr.Zero);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //nuevo cliente de Youtube
            var client = new YoutubeClient();s
            //lee la dirección de youtube que le escribimos en el textbox
            var videoId = NormalizeVideoId(txtURL.Text);
            var video = await client.GetVideoAsync(videoId);
            var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(videoId);

            // Busca la mejor resolución en la que está disponible el video
            var streamInfo = streamInfoSet.Muxed.WithHighestVideoQuality();

            // Compone el nombre que tendrá el video en base a su título y extensión
            var fileExtension = streamInfo.Container.GetFileExtension();
            var fileName = $"{video.Title}.{fileExtension}";

            //TODO: Reemplazar los caractéres ilegales del nombre
            //fileName = RemoveIllegalFileNameChars(fileName);

            //Activa el timer para que el proceso funcione de forma asincrona
            tmrVideo.Enabled = true;

            // mensajes indicando que el video se está descargando
            txtMensaje.Text = "Descargando el video ... ";

            //TODO: se pude usar una barra de progreso para ver el avance
            //using (var progress = new ProgressBar())

            //Empieza la descarga
            await client.DownloadMediaStreamAsync(streamInfo, fileName);

            //Ya descargado se inicia la conversión a MP3
            var Convert = new NReco.VideoConverter.FFMpegConverter();
            //Especificar la carpeta donde se van a guardar los archivos, recordar la \ del final
            String SaveMP3File = @"E:\MP3\" + fileName.Replace(".mp4", ".mp3");
            //Guarda el archivo convertido en la ubicación indicada
            Convert.ConvertMedia(fileName, SaveMP3File, "mp3");

            //Si el checkbox de solo audio está chequeado, borrar el mp4 despues de la conversión
            if (ckbAudio.Checked)
                File.Delete(fileName);


            //Indicar que se terminó la conversion
            txtMensaje.Text = "Archivo Convertido en MP3";
            tmrVideo.Enabled = false;
            txtMensaje.BackColor = Color.White;

            //TODO: Cargar el MP3 al reproductor o a la lista de reproducción
            //CargarMP3s();
            //Se puede incluir un checkbox para indicar que de una vez se reproduzca el MP3
            //if (ckbAutoPlay.Checked) 
            //  ReproducirMP3(SaveMP3File);
            return;
        }
        private static string NormalizeVideoId(string input)
        {
            string videoId = string.Empty;

            return YoutubeClient.TryParseVideoId(input, out videoId)
                ? videoId
                : input;
        }
    }
}
