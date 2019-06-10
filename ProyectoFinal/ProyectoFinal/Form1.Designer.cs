namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelEstadoDescarga = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCancion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarTiempo = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBarSonido = new System.Windows.Forms.TrackBar();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSonido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(853, 0);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(18, 22);
            this.reproductor.TabIndex = 0;
            this.reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(361, 354);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 62;
            this.button7.Text = "Back";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(503, 132);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 17);
            this.checkBox2.TabIndex = 61;
            this.checkBox2.Text = "solo Biblioteca";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(606, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 134);
            this.listBox1.TabIndex = 60;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // labelEstadoDescarga
            // 
            this.labelEstadoDescarga.AutoSize = true;
            this.labelEstadoDescarga.Location = new System.Drawing.Point(11, 146);
            this.labelEstadoDescarga.Name = "labelEstadoDescarga";
            this.labelEstadoDescarga.Size = new System.Drawing.Size(13, 13);
            this.labelEstadoDescarga.TabIndex = 59;
            this.labelEstadoDescarga.Text = "--";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(95, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "MP3";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(50, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 20);
            this.textBox2.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "URL:";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(11, 116);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 55;
            this.button9.Text = "Descargar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_ClickAsync);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(443, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 54;
            this.button8.Text = "Mostrar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(203, 87);
            this.dataGridView1.TabIndex = 53;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(138, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 23);
            this.button6.TabIndex = 52;
            this.button6.Text = "Guardar nueva lista";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(361, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 45);
            this.button5.TabIndex = 51;
            this.button5.Text = "Guardar pista en lista de reproduccion";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Nombre de nueva lista: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Guarda la nueva lista";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 47;
            this.button3.Text = "Eliminar Lista";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "Eliminar Cancion";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Listas Guardadas";
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Location = new System.Drawing.Point(110, 275);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(13, 13);
            this.lblCancion.TabIndex = 44;
            this.lblCancion.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nombre Cancion: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(753, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "--";
            // 
            // trackBarTiempo
            // 
            this.trackBarTiempo.Location = new System.Drawing.Point(15, 304);
            this.trackBarTiempo.Maximum = 100;
            this.trackBarTiempo.Name = "trackBarTiempo";
            this.trackBarTiempo.Size = new System.Drawing.Size(762, 45);
            this.trackBarTiempo.TabIndex = 39;
            this.trackBarTiempo.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(199, 355);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 37;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(118, 355);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 23);
            this.btnplay.TabIndex = 36;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.Btnplay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 57);
            this.button1.TabIndex = 35;
            this.button1.Text = "Agregar cancion a lista actual";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // trackBarSonido
            // 
            this.trackBarSonido.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarSonido.Location = new System.Drawing.Point(453, 333);
            this.trackBarSonido.Maximum = 100;
            this.trackBarSonido.Name = "trackBarSonido";
            this.trackBarSonido.Size = new System.Drawing.Size(83, 45);
            this.trackBarSonido.TabIndex = 63;
            this.trackBarSonido.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSonido.ValueChanged += new System.EventHandler(this.TrackBarSonido_ValueChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 173);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 87);
            this.dataGridView2.TabIndex = 64;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellDoubleClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(280, 264);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 65;
            this.button10.Text = "Mostrar";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 389);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.trackBarSonido);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelEstadoDescarga);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarTiempo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reproductor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSonido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelEstadoDescarga;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarTiempo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBarSonido;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button10;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

