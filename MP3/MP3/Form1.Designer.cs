namespace MP3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnplay = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.trackBarTiempo = new System.Windows.Forms.TrackBar();
            this.trackBarSonido = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCancion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSonido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1149, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Con Windows Media";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar cancion a lista actual";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(1292, 99);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(20, 31);
            this.reproductor.TabIndex = 2;
            this.reproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Reproductor_PlayStateChange);
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(119, 317);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 23);
            this.btnplay.TabIndex = 3;
            this.btnplay.Text = "Stop";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1174, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Con MCI";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(281, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(566, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 160);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // trackBarTiempo
            // 
            this.trackBarTiempo.Location = new System.Drawing.Point(20, 266);
            this.trackBarTiempo.Maximum = 100;
            this.trackBarTiempo.Name = "trackBarTiempo";
            this.trackBarTiempo.Size = new System.Drawing.Size(762, 45);
            this.trackBarTiempo.TabIndex = 8;
            this.trackBarTiempo.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarSonido
            // 
            this.trackBarSonido.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarSonido.Location = new System.Drawing.Point(392, 317);
            this.trackBarSonido.Maximum = 100;
            this.trackBarSonido.Name = "trackBarSonido";
            this.trackBarSonido.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSonido.Size = new System.Drawing.Size(45, 83);
            this.trackBarSonido.TabIndex = 9;
            this.trackBarSonido.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSonido.ValueChanged += new System.EventHandler(this.TrackBarSonido_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(769, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre Cancion: ";
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Location = new System.Drawing.Point(119, 231);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(13, 13);
            this.lblCancion.TabIndex = 13;
            this.lblCancion.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 405);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarSonido);
            this.Controls.Add(this.trackBarTiempo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.reproductor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSonido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar trackBarTiempo;
        private System.Windows.Forms.TrackBar trackBarSonido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Timer timer1;
    }
}

