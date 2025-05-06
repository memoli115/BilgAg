namespace DataLinkLayerSimulator
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
            this.lblHataTespitAlg = new System.Windows.Forms.Label();
            this.lblSimulasyonTuru = new System.Windows.Forms.Label();
            this.lblHataOrani = new System.Windows.Forms.Label();
            this.lblMetin = new System.Windows.Forms.Label();
            this.cbxHataTespitAlg = new System.Windows.Forms.ComboBox();
            this.cbxSimulasyonTuru = new System.Windows.Forms.ComboBox();
            this.numHataOrani = new System.Windows.Forms.NumericUpDown();
            this.txbMetin = new System.Windows.Forms.TextBox();
            this.gbxHataTespitParametreleri = new System.Windows.Forms.GroupBox();
            this.btnSimulasyon = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblGirilenMetin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHataOrani)).BeginInit();
            this.gbxHataTespitParametreleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHataTespitAlg
            // 
            this.lblHataTespitAlg.AutoSize = true;
            this.lblHataTespitAlg.Location = new System.Drawing.Point(28, 37);
            this.lblHataTespitAlg.Name = "lblHataTespitAlg";
            this.lblHataTespitAlg.Size = new System.Drawing.Size(150, 16);
            this.lblHataTespitAlg.TabIndex = 0;
            this.lblHataTespitAlg.Text = "Hata Tespit Algoritması ";
            // 
            // lblSimulasyonTuru
            // 
            this.lblSimulasyonTuru.AutoSize = true;
            this.lblSimulasyonTuru.Location = new System.Drawing.Point(28, 79);
            this.lblSimulasyonTuru.Name = "lblSimulasyonTuru";
            this.lblSimulasyonTuru.Size = new System.Drawing.Size(107, 16);
            this.lblSimulasyonTuru.TabIndex = 2;
            this.lblSimulasyonTuru.Text = "Simülasyon Türü";
            // 
            // lblHataOrani
            // 
            this.lblHataOrani.AutoSize = true;
            this.lblHataOrani.Location = new System.Drawing.Point(28, 124);
            this.lblHataOrani.Name = "lblHataOrani";
            this.lblHataOrani.Size = new System.Drawing.Size(94, 16);
            this.lblHataOrani.TabIndex = 3;
            this.lblHataOrani.Text = "Hata Oranı (%)";
            // 
            // lblMetin
            // 
            this.lblMetin.AutoSize = true;
            this.lblMetin.Location = new System.Drawing.Point(28, 165);
            this.lblMetin.Name = "lblMetin";
            this.lblMetin.Size = new System.Drawing.Size(39, 16);
            this.lblMetin.TabIndex = 4;
            this.lblMetin.Text = "Metin";
            // 
            // cbxHataTespitAlg
            // 
            this.cbxHataTespitAlg.FormattingEnabled = true;
            this.cbxHataTespitAlg.Items.AddRange(new object[] {
            "CRC-16",
            "CRC-32",
            "Hamming Code"});
            this.cbxHataTespitAlg.Location = new System.Drawing.Point(275, 34);
            this.cbxHataTespitAlg.Name = "cbxHataTespitAlg";
            this.cbxHataTespitAlg.Size = new System.Drawing.Size(337, 24);
            this.cbxHataTespitAlg.TabIndex = 5;
            // 
            // cbxSimulasyonTuru
            // 
            this.cbxSimulasyonTuru.FormattingEnabled = true;
            this.cbxSimulasyonTuru.Items.AddRange(new object[] {
            "Normal",
            "MAC Spoofing",
            "ARP Spoofing"});
            this.cbxSimulasyonTuru.Location = new System.Drawing.Point(275, 76);
            this.cbxSimulasyonTuru.Name = "cbxSimulasyonTuru";
            this.cbxSimulasyonTuru.Size = new System.Drawing.Size(337, 24);
            this.cbxSimulasyonTuru.TabIndex = 7;
            // 
            // numHataOrani
            // 
            this.numHataOrani.Location = new System.Drawing.Point(490, 122);
            this.numHataOrani.Name = "numHataOrani";
            this.numHataOrani.Size = new System.Drawing.Size(122, 22);
            this.numHataOrani.TabIndex = 8;
            // 
            // txbMetin
            // 
            this.txbMetin.Location = new System.Drawing.Point(275, 162);
            this.txbMetin.MaxLength = 1500;
            this.txbMetin.Name = "txbMetin";
            this.txbMetin.Size = new System.Drawing.Size(337, 22);
            this.txbMetin.TabIndex = 9;
            // 
            // gbxHataTespitParametreleri
            // 
            this.gbxHataTespitParametreleri.Controls.Add(this.cbxHataTespitAlg);
            this.gbxHataTespitParametreleri.Controls.Add(this.txbMetin);
            this.gbxHataTespitParametreleri.Controls.Add(this.lblHataTespitAlg);
            this.gbxHataTespitParametreleri.Controls.Add(this.numHataOrani);
            this.gbxHataTespitParametreleri.Controls.Add(this.cbxSimulasyonTuru);
            this.gbxHataTespitParametreleri.Controls.Add(this.lblSimulasyonTuru);
            this.gbxHataTespitParametreleri.Controls.Add(this.lblHataOrani);
            this.gbxHataTespitParametreleri.Controls.Add(this.lblMetin);
            this.gbxHataTespitParametreleri.Location = new System.Drawing.Point(12, 450);
            this.gbxHataTespitParametreleri.Name = "gbxHataTespitParametreleri";
            this.gbxHataTespitParametreleri.Size = new System.Drawing.Size(629, 211);
            this.gbxHataTespitParametreleri.TabIndex = 10;
            this.gbxHataTespitParametreleri.TabStop = false;
            this.gbxHataTespitParametreleri.Text = "Hata Tespit Parametreleri";
            // 
            // btnSimulasyon
            // 
            this.btnSimulasyon.Location = new System.Drawing.Point(12, 667);
            this.btnSimulasyon.Name = "btnSimulasyon";
            this.btnSimulasyon.Size = new System.Drawing.Size(199, 39);
            this.btnSimulasyon.TabIndex = 11;
            this.btnSimulasyon.Text = "Simülasyonu Başlat";
            this.btnSimulasyon.UseVisualStyleBackColor = true;
            this.btnSimulasyon.Click += new System.EventHandler(this.btnSimulasyon_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(744, 394);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(616, 156);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(744, 559);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(616, 142);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 375);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(679, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(681, 375);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // lblGirilenMetin
            // 
            this.lblGirilenMetin.AutoSize = true;
            this.lblGirilenMetin.Location = new System.Drawing.Point(658, 470);
            this.lblGirilenMetin.Name = "lblGirilenMetin";
            this.lblGirilenMetin.Size = new System.Drawing.Size(80, 16);
            this.lblGirilenMetin.TabIndex = 14;
            this.lblGirilenMetin.Text = "Girilen Metin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 713);
            this.Controls.Add(this.lblGirilenMetin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSimulasyon);
            this.Controls.Add(this.gbxHataTespitParametreleri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHataOrani)).EndInit();
            this.gbxHataTespitParametreleri.ResumeLayout(false);
            this.gbxHataTespitParametreleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHataTespitAlg;
        private System.Windows.Forms.Label lblSimulasyonTuru;
        private System.Windows.Forms.Label lblHataOrani;
        private System.Windows.Forms.Label lblMetin;
        private System.Windows.Forms.ComboBox cbxHataTespitAlg;
        private System.Windows.Forms.ComboBox cbxSimulasyonTuru;
        private System.Windows.Forms.NumericUpDown numHataOrani;
        private System.Windows.Forms.TextBox txbMetin;
        private System.Windows.Forms.GroupBox gbxHataTespitParametreleri;
        private System.Windows.Forms.Button btnSimulasyon;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblGirilenMetin;
    }
}

