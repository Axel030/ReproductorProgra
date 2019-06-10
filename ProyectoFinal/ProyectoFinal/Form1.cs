using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;
using Newtonsoft.Json;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        List<ClassCancion> listaLibro = new List<ClassCancion>();
        string rutascancion;
        string nombrecancion;

       

        string[] archivos, rutas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {///////////////////////////////////////////////////////////
        }

        private void Btnplay_Click(object sender, EventArgs e)
        {
            reproductor.Ctlcontrols.play();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            reproductor.Ctlcontrols.stop();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            reproductor.Ctlcontrols.next();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            reproductor.Ctlcontrols.previous();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Multiselect = true;
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                archivos = abrir.SafeFileNames;
                rutas = abrir.FileNames;
                reproductor.URL = openFileDialog1.FileName;

                foreach (var s in archivos)
                {
                    listBox1.Items.Add(s);


                }
                reproductor.URL = rutas[0];
            }
                listBox1.SelectedIndex = 0;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] stringArray = new string[] { rutascancion };
            reproductor.URL = stringArray[listBox1.SelectedIndex];
            lblCancion.Text = archivos[listBox1.SelectedIndex];
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }
        static TimeSpan tiempo;

        private void TrackBarSonido_ValueChanged(object sender, EventArgs e)
        {
            reproductor.settings.volume = trackBarSonido.Value;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();
            tiempo = TimeSpan.FromSeconds(reproductor.Ctlcontrols.currentPosition);
            label3.Text = tiempo.ToString("mm\\:ss");
            trackBarTiempo.Value = (int)reproductor.Ctlcontrols.currentPosition;
            trackBarSonido.Value = reproductor.settings.volume;
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();
        }

        private static string NormalizeVideoId(string input)
        {
            string videoID = string.Empty;
            return YoutubeClient.TryParseVideoId(input, out videoID)
                ? videoID
                : input;
        }

        private async void Button9_ClickAsync(object sender, EventArgs e)
        {
            //nuevo cliente de Youtube
            var client = new YoutubeClient();
            //lee la dirección de youtube que le escribimos en el textbox
            var videoId = NormalizeVideoId(textBox2.Text); //normaliza
            var video = await client.GetVideoAsync(videoId); //descarga el video
            var streamInfoSet = await client.GetVideoMediaStreamInfosAsync(videoId); //descarga la informacion del video

            // Busca la mejor resolución en la que está disponible el video
            var streamInfo = streamInfoSet.Muxed.WithHighestVideoQuality(); //descarga el video con la maxima calidad

            // Compone el nombre que tendrá el video en base a su título y extensión
            var fileExtension = streamInfo.Container.GetFileExtension(); //mira la extencion mp4
            var fileName = $"{video.Title}.{fileExtension}"; //agrega el titulo del video y la extencion mp4

            //TODO: Reemplazar los caractéres ilegales del nombre
            //fileName = RemoveIllegalFileNameChars(fileName);

            //Activa el timer para que el proceso funcione de forma asincrona
            timer1.Enabled = true;

            // mensajes indicando que el video se está descargando
            labelEstadoDescarga.Text = "Descargando el video ... "; //mensaje 

            //TODO: se pude usar una barra de progreso para ver el avance
            //using (var progress = new ProgressBar())

            //Empieza la descarga
            await client.DownloadMediaStreamAsync(streamInfo, fileName); //empieza la descarga

            //Ya descargado se inicia la conversión a MP3
            var Convert = new NReco.VideoConverter.FFMpegConverter(); //convierte el video
            //Especificar la carpeta donde se van a guardar los archivos, recordar la \ del final
            String SaveMP3File = @"C:\DescargasMP3\" + fileName.Replace(".mp4", ".mp3"); //en donde se va a guardar el archivo
            //Guarda el archivo convertido en la ubicación indicada
            Convert.ConvertMedia(fileName, SaveMP3File, "mp3");

            //Si el checkbox de solo audio está chequeado, borrar el mp4 despues de la conversión
            if (checkBox1.Checked) //funcion checkbox
                File.Delete(fileName); // si quemos solo el audio manda a borrar el mp4 y nos quedamos con el mp3


            //Indicar que se terminó la conversion
            labelEstadoDescarga.Text = "Archivo Convertido en MP3";
            timer1.Enabled = false;
            labelEstadoDescarga.BackColor = Color.White;

            //TODO: Cargar el MP3 al reproductor o a la lista de reproducción
            //CargarMP3s();
            //Se puede incluir un checkbox para indicar que de una vez se reproduzca el MP3
            //if (ckbAutoPlay.Checked) 
            //  ReproducirMP3(SaveMP3File);


            //Declarar un objeto de Clase cliente
            ClassCancion cancionJson = new ClassCancion();

            //Asignarle valores al cliente
            cancionJson.DireccionCancion = SaveMP3File;
            cancionJson.NombreCancion = fileName.Replace("Mp4", "MP3");

            //Convertir el objeto en una cadena JSON
            string salida = JsonConvert.SerializeObject(cancionJson);
            //Guardar el archivo de texto, con extension Json
            FileStream stream = new FileStream("Cancion.json", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            MessageBox.Show("La Canción: " + cancionJson.NombreCancion + " Se Registro Correctamente");

            writer.WriteLine(salida);
            writer.Close();

            nombrecancion = cancionJson.NombreCancion;
            rutascancion = cancionJson.DireccionCancion;
            object rowmidex = dataGridView1.CurrentRow.Index;
            reproductor.URL = cancionJson.DireccionCancion; ;
            string[] stringArray = new string[] { rutascancion };
            reproductor.URL = stringArray[0];
            //////////////////////////////////////////

            return;
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] stringArray = new string[] { rutascancion };
            reproductor.URL = stringArray[0];
            object DWIndex = dataGridView1.CurrentRow.Index;
            reproductor.URL = stringArray[dataGridView1.CurrentRow.Index];
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            //Una lista de objetos libro
            
            //Leer el archivo
            FileStream stream = new FileStream("Cancion.json", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                string lectura = reader.ReadLine();
                ClassCancion libroLeido = JsonConvert.DeserializeObject<ClassCancion>(lectura);
                listaLibro.Add(libroLeido);
            }
            reader.Close();
            //Mostrar la lista de libros en el gridview
            dataGridView2.DataSource = listaLibro;
            dataGridView2.Refresh();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] stringArray = new string[] { rutascancion };
            reproductor.URL = stringArray[0];
            object DWIndex = dataGridView1.CurrentRow.Index;
            reproductor.URL = stringArray[dataGridView1.CurrentRow.Index];

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string nombre = "";
            string medicion = "";
            string fecha = "";
            //Ciclo para recorrer cada fila del gridview
            
                for (int j = 0; j < listaLibro.Count; j++)
                {
                   
                       
                            nombre = listaLibro[j].NombreCancion;
                            medicion = listaLibro[j].DireccionCancion;

                listBox1.Items.Add("Nombre: " + nombre + "," + " Medición Registrada (mm): " + medicion + "," );
                        
                }
           
        }

        public void ActualizarDatosTrack()
        {

            if (reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackBarTiempo.Maximum = (int)reproductor.Ctlcontrols.currentItem.duration;
                double s = (int)reproductor.Ctlcontrols.currentItem.duration;
                TimeSpan p = TimeSpan.FromSeconds(s);
                label4.Text = p.ToString("mm\\:ss");
                timer1.Start();


            }
            else if (reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                label3.Text = "00:00";
                tiempo = TimeSpan.Zero;
                trackBarTiempo.Value = 0;
            }
        }

    }
}
