namespace projectlab
{
    partial class FormEdge
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
            this.btnBack = new System.Windows.Forms.Button();
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.imgCanny = new System.Windows.Forms.PictureBox();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.lblSobel = new System.Windows.Forms.Label();
            this.lblLaplace = new System.Windows.Forms.Label();
            this.lblCanny = new System.Windows.Forms.Label();
            this.imgSobel = new System.Windows.Forms.PictureBox();
            this.imgLaplace = new System.Windows.Forms.PictureBox();
            this.gbEditor = new System.Windows.Forms.GroupBox();
            this.trackLow = new System.Windows.Forms.TrackBar();
            this.trackHigh = new System.Windows.Forms.TrackBar();
            this.comboAperture = new System.Windows.Forms.ComboBox();
            this.lblAperture = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCanny)).BeginInit();
            this.gbMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSobel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLaplace)).BeginInit();
            this.gbEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(73, 48);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imgMain
            // 
            this.imgMain.Location = new System.Drawing.Point(97, 15);
            this.imgMain.Margin = new System.Windows.Forms.Padding(4);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(520, 391);
            this.imgMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMain.TabIndex = 1;
            this.imgMain.TabStop = false;
            // 
            // imgCanny
            // 
            this.imgCanny.Location = new System.Drawing.Point(13, 30);
            this.imgCanny.Margin = new System.Windows.Forms.Padding(4);
            this.imgCanny.Name = "imgCanny";
            this.imgCanny.Size = new System.Drawing.Size(173, 130);
            this.imgCanny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCanny.TabIndex = 2;
            this.imgCanny.TabStop = false;
            this.imgCanny.Click += new System.EventHandler(this.imgCanny_Click);
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.lblSobel);
            this.gbMode.Controls.Add(this.lblLaplace);
            this.gbMode.Controls.Add(this.lblCanny);
            this.gbMode.Controls.Add(this.imgSobel);
            this.gbMode.Controls.Add(this.imgLaplace);
            this.gbMode.Controls.Add(this.imgCanny);
            this.gbMode.Location = new System.Drawing.Point(625, 15);
            this.gbMode.Margin = new System.Windows.Forms.Padding(4);
            this.gbMode.Name = "gbMode";
            this.gbMode.Padding = new System.Windows.Forms.Padding(4);
            this.gbMode.Size = new System.Drawing.Size(557, 210);
            this.gbMode.TabIndex = 3;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Mode";
            // 
            // lblSobel
            // 
            this.lblSobel.AutoSize = true;
            this.lblSobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobel.Location = new System.Drawing.Point(448, 177);
            this.lblSobel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSobel.Name = "lblSobel";
            this.lblSobel.Size = new System.Drawing.Size(46, 18);
            this.lblSobel.TabIndex = 7;
            this.lblSobel.Text = "Sobel";
            // 
            // lblLaplace
            // 
            this.lblLaplace.AutoSize = true;
            this.lblLaplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaplace.Location = new System.Drawing.Point(257, 177);
            this.lblLaplace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaplace.Name = "lblLaplace";
            this.lblLaplace.Size = new System.Drawing.Size(59, 18);
            this.lblLaplace.TabIndex = 6;
            this.lblLaplace.Text = "Laplace";
            // 
            // lblCanny
            // 
            this.lblCanny.AutoSize = true;
            this.lblCanny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanny.ForeColor = System.Drawing.Color.Black;
            this.lblCanny.Location = new System.Drawing.Point(73, 177);
            this.lblCanny.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCanny.Name = "lblCanny";
            this.lblCanny.Size = new System.Drawing.Size(50, 18);
            this.lblCanny.TabIndex = 5;
            this.lblCanny.Text = "Canny";
            // 
            // imgSobel
            // 
            this.imgSobel.Location = new System.Drawing.Point(376, 30);
            this.imgSobel.Margin = new System.Windows.Forms.Padding(4);
            this.imgSobel.Name = "imgSobel";
            this.imgSobel.Size = new System.Drawing.Size(173, 130);
            this.imgSobel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSobel.TabIndex = 4;
            this.imgSobel.TabStop = false;
            this.imgSobel.Click += new System.EventHandler(this.imgSobel_Click);
            // 
            // imgLaplace
            // 
            this.imgLaplace.Location = new System.Drawing.Point(195, 30);
            this.imgLaplace.Margin = new System.Windows.Forms.Padding(4);
            this.imgLaplace.Name = "imgLaplace";
            this.imgLaplace.Size = new System.Drawing.Size(173, 130);
            this.imgLaplace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLaplace.TabIndex = 3;
            this.imgLaplace.TabStop = false;
            this.imgLaplace.Click += new System.EventHandler(this.imgLaplace_Click);
            // 
            // gbEditor
            // 
            this.gbEditor.Controls.Add(this.trackLow);
            this.gbEditor.Controls.Add(this.trackHigh);
            this.gbEditor.Controls.Add(this.comboAperture);
            this.gbEditor.Controls.Add(this.lblAperture);
            this.gbEditor.Controls.Add(this.lblHigh);
            this.gbEditor.Controls.Add(this.lblLow);
            this.gbEditor.Location = new System.Drawing.Point(625, 233);
            this.gbEditor.Margin = new System.Windows.Forms.Padding(4);
            this.gbEditor.Name = "gbEditor";
            this.gbEditor.Padding = new System.Windows.Forms.Padding(4);
            this.gbEditor.Size = new System.Drawing.Size(557, 239);
            this.gbEditor.TabIndex = 4;
            this.gbEditor.TabStop = false;
            this.gbEditor.Text = "Editor";
            // 
            // trackLow
            // 
            this.trackLow.LargeChange = 1;
            this.trackLow.Location = new System.Drawing.Point(150, 169);
            this.trackLow.Margin = new System.Windows.Forms.Padding(4);
            this.trackLow.Maximum = 100;
            this.trackLow.Name = "trackLow";
            this.trackLow.Size = new System.Drawing.Size(399, 56);
            this.trackLow.TabIndex = 13;
            // 
            // trackHigh
            // 
            this.trackHigh.LargeChange = 1;
            this.trackHigh.Location = new System.Drawing.Point(151, 106);
            this.trackHigh.Margin = new System.Windows.Forms.Padding(4);
            this.trackHigh.Maximum = 200;
            this.trackHigh.Name = "trackHigh";
            this.trackHigh.Size = new System.Drawing.Size(399, 56);
            this.trackHigh.TabIndex = 12;
            this.trackHigh.TickFrequency = 5;
            // 
            // comboAperture
            // 
            this.comboAperture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAperture.FormattingEnabled = true;
            this.comboAperture.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.comboAperture.Location = new System.Drawing.Point(151, 46);
            this.comboAperture.Margin = new System.Windows.Forms.Padding(4);
            this.comboAperture.Name = "comboAperture";
            this.comboAperture.Size = new System.Drawing.Size(124, 26);
            this.comboAperture.TabIndex = 11;
            // 
            // lblAperture
            // 
            this.lblAperture.AutoSize = true;
            this.lblAperture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAperture.Location = new System.Drawing.Point(29, 46);
            this.lblAperture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAperture.Name = "lblAperture";
            this.lblAperture.Size = new System.Drawing.Size(96, 18);
            this.lblAperture.TabIndex = 8;
            this.lblAperture.Text = "Aperture Size";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigh.Location = new System.Drawing.Point(31, 106);
            this.lblHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(38, 18);
            this.lblHigh.TabIndex = 9;
            this.lblHigh.Text = "High";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLow.Location = new System.Drawing.Point(31, 169);
            this.lblLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(36, 18);
            this.lblLow.TabIndex = 10;
            this.lblLow.Text = "Low";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(303, 423);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(73, 48);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormEdge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 494);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.gbEditor);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.imgMain);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEdge";
            this.Text = "FormEdge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEdge_FormClosing);
            this.Load += new System.EventHandler(this.FormEdge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCanny)).EndInit();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSobel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLaplace)).EndInit();
            this.gbEditor.ResumeLayout(false);
            this.gbEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHigh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox imgMain;
        private System.Windows.Forms.PictureBox imgCanny;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.PictureBox imgSobel;
        private System.Windows.Forms.PictureBox imgLaplace;
        private System.Windows.Forms.GroupBox gbEditor;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblSobel;
        private System.Windows.Forms.Label lblLaplace;
        private System.Windows.Forms.Label lblCanny;
        private System.Windows.Forms.ComboBox comboAperture;
        private System.Windows.Forms.Label lblAperture;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.TrackBar trackLow;
        private System.Windows.Forms.TrackBar trackHigh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}