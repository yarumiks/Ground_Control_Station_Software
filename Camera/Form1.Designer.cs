namespace Camera
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Connect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StartRecording = new System.Windows.Forms.Button();
            this.StopRecording = new System.Windows.Forms.Button();
            this.baslatKamera = new System.Windows.Forms.Button();
            this.durdurKamera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 475);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(706, 79);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(96, 50);
            this.Connect.TabIndex = 1;
            this.Connect.Text = "Bağlan";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(485, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // StartRecording
            // 
            this.StartRecording.Location = new System.Drawing.Point(485, 265);
            this.StartRecording.Name = "StartRecording";
            this.StartRecording.Size = new System.Drawing.Size(96, 39);
            this.StartRecording.TabIndex = 5;
            this.StartRecording.Text = "Video başlat";
            this.StartRecording.UseVisualStyleBackColor = true;
            this.StartRecording.Click += new System.EventHandler(this.StartRecording_Click);
            // 
            // StopRecording
            // 
            this.StopRecording.Location = new System.Drawing.Point(485, 321);
            this.StopRecording.Name = "StopRecording";
            this.StopRecording.Size = new System.Drawing.Size(96, 35);
            this.StopRecording.TabIndex = 6;
            this.StopRecording.Text = "video durdur";
            this.StopRecording.UseVisualStyleBackColor = true;
            this.StopRecording.Click += new System.EventHandler(this.StopRecording_Click);
            // 
            // baslatKamera
            // 
            this.baslatKamera.Location = new System.Drawing.Point(485, 136);
            this.baslatKamera.Name = "baslatKamera";
            this.baslatKamera.Size = new System.Drawing.Size(96, 33);
            this.baslatKamera.TabIndex = 7;
            this.baslatKamera.Text = "başlat";
            this.baslatKamera.UseVisualStyleBackColor = true;
            this.baslatKamera.Click += new System.EventHandler(this.baslatKamera_Click);
            // 
            // durdurKamera
            // 
            this.durdurKamera.Location = new System.Drawing.Point(485, 190);
            this.durdurKamera.Name = "durdurKamera";
            this.durdurKamera.Size = new System.Drawing.Size(96, 37);
            this.durdurKamera.TabIndex = 8;
            this.durdurKamera.Text = "Durdur";
            this.durdurKamera.UseVisualStyleBackColor = true;
            this.durdurKamera.Click += new System.EventHandler(this.durdurKamera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 499);
            this.Controls.Add(this.durdurKamera);
            this.Controls.Add(this.baslatKamera);
            this.Controls.Add(this.StopRecording);
            this.Controls.Add(this.StartRecording);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button StartRecording;
        private System.Windows.Forms.Button StopRecording;
        private System.Windows.Forms.Button baslatKamera;
        private System.Windows.Forms.Button durdurKamera;
    }
}

