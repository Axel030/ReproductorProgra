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
        string[] rutas, archivos;
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
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Multiselect = true;
            if (abrir.ShowDialog() == DialogResult.OK){
                archivos = abrir.SafeFileNames;
                rutas = abrir.FileNames;
                reproductor.URL = openFileDialog1.FileName;

                foreach (var s in archivos)
                {
                    listBox1.Items.Add(s);


                }
                reproductor.URL = rutas[0];
                listBox1.SelectedIndex = 0;
            }
        }


        //Detener la reproducción en Windows Player
        private void button2_Click(object sender, EventArgs e)
        {
            reproductor.Ctlcontrols.stop();
        }
        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        //Detener la reproducción del MP3 en el MCI
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            reproductor.URL = rutas[listBox1.SelectedIndex];
            lblCancion.Text = archivos[listBox1.SelectedIndex];
        }

        private void Button5_Click(object sender, EventArgs e)
        {
        }
        static TimeSpan tiempo;
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

        private void TrackBarSonido_ValueChanged(object sender, EventArgs e)
        {
            reproductor.settings.volume = trackBarSonido.Value;
        }

        public void ActualizarDatosTrack()
        {
           
            if (reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackBarTiempo.Maximum=(int)reproductor.Ctlcontrols.currentItem.duration;
                double s = (int)reproductor.Ctlcontrols.currentItem.duration;
                TimeSpan p = TimeSpan.FromSeconds(s);
                label4.Text = p.ToString("mm\\:ss");
                timer1.Start();
               

            }
            else if(reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
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
