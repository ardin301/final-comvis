namespace projectlab
{
    partial class ImageProc
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.lblThres = new System.Windows.Forms.Label();
            this.lblGray = new System.Windows.Forms.Label();
            this.lblSmooth = new System.Windows.Forms.Label();
            this.imgThres = new System.Windows.Forms.PictureBox();
            this.imgGray = new System.Windows.Forms.PictureBox();
            this.imgSmooth = new System.Windows.Forms.PictureBox();
            this.gbEditor = new System.Windows.Forms.GroupBox();
            this.trackThres = new System.Windows.Forms.TrackBar();
            this.trackBottom = new System.Windows.Forms.TrackBar();
            this.trackSmooth = new System.Windows.Forms.TrackBar();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSmooth)).BeginInit();
            this.gbEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackThres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSmooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(10, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 39);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(235, 346);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(55, 39);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.lblThres);
            this.gbMode.Controls.Add(this.lblGray);
            this.gbMode.Controls.Add(this.lblSmooth);
            this.gbMode.Controls.Add(this.imgThres);
            this.gbMode.Controls.Add(this.imgGray);
            this.gbMode.Controls.Add(this.imgSmooth);
            this.gbMode.Location = new System.Drawing.Point(474, 11);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(418, 171);
            this.gbMode.TabIndex = 7;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Mode";
            // 
            // lblThres
            // 
            this.lblThres.AutoSize = true;
            this.lblThres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThres.Location = new System.Drawing.Point(317, 144);
            this.lblThres.Name = "lblThres";
            this.lblThres.Size = new System.Drawing.Size(62, 15);
            this.lblThres.TabIndex = 7;
            this.lblThres.Text = "Threshold";
            // 
            // lblGray
            // 
            this.lblGray.AutoSize = true;
            this.lblGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGray.Location = new System.Drawing.Point(186, 144);
            this.lblGray.Name = "lblGray";
            this.lblGray.Size = new System.Drawing.Size(61, 15);
            this.lblGray.TabIndex = 6;
            this.lblGray.Text = "Grayscale";
            // 
            // lblSmooth
            // 
            this.lblSmooth.AutoSize = true;
            this.lblSmooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmooth.ForeColor = System.Drawing.Color.Black;
            this.lblSmooth.Location = new System.Drawing.Point(55, 144);
            this.lblSmooth.Name = "lblSmooth";
            this.lblSmooth.Size = new System.Drawing.Size(50, 15);
            this.lblSmooth.TabIndex = 5;
            this.lblSmooth.Text = "Smooth";
            // 
            // imgThres
            // 
            this.imgThres.Location = new System.Drawing.Point(282, 24);
            this.imgThres.Name = "imgThres";
            this.imgThres.Size = new System.Drawing.Size(130, 106);
            this.imgThres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgThres.TabIndex = 4;
            this.imgThres.TabStop = false;
            this.imgThres.Click += new System.EventHandler(this.imgThres_Click);
            // 
            // imgGray
            // 
            this.imgGray.Location = new System.Drawing.Point(146, 24);
            this.imgGray.Name = "imgGray";
            this.imgGray.Size = new System.Drawing.Size(130, 106);
            this.imgGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGray.TabIndex = 3;
            this.imgGray.TabStop = false;
            this.imgGray.Click += new System.EventHandler(this.imgGray_Click);
            // 
            // imgSmooth
            // 
            this.imgSmooth.Location = new System.Drawing.Point(10, 24);
            this.imgSmooth.Name = "imgSmooth";
            this.imgSmooth.Size = new System.Drawing.Size(130, 106);
            this.imgSmooth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSmooth.TabIndex = 2;
            this.imgSmooth.TabStop = false;
            this.imgSmooth.Click += new System.EventHandler(this.imgSmooth_Click);
            // 
            // gbEditor
            // 
            this.gbEditor.Controls.Add(this.trackThres);
            this.gbEditor.Controls.Add(this.trackBottom);
            this.gbEditor.Controls.Add(this.trackSmooth);
            this.gbEditor.Controls.Add(this.lblTop);
            this.gbEditor.Controls.Add(this.lblBottom);
            this.gbEditor.Location = new System.Drawing.Point(474, 198);
            this.gbEditor.Name = "gbEditor";
            this.gbEditor.Size = new System.Drawing.Size(418, 194);
            this.gbEditor.TabIndex = 8;
            this.gbEditor.TabStop = false;
            this.gbEditor.Text = "Editor";
            // 
            // trackThres
            // 
            this.trackThres.Location = new System.Drawing.Point(113, 68);
            this.trackThres.Margin = new System.Windows.Forms.Padding(2);
            this.trackThres.Maximum = 200;
            this.trackThres.Minimum = 1;
            this.trackThres.Name = "trackThres";
            this.trackThres.Size = new System.Drawing.Size(299, 45);
            this.trackThres.TabIndex = 14;
            this.trackThres.Value = 1;
            // 
            // trackBottom
            // 
            this.trackBottom.LargeChange = 1;
            this.trackBottom.Location = new System.Drawing.Point(113, 106);
            this.trackBottom.Maximum = 100;
            this.trackBottom.Name = "trackBottom";
            this.trackBottom.Size = new System.Drawing.Size(299, 45);
            this.trackBottom.TabIndex = 13;
            // 
            // trackSmooth
            // 
            this.trackSmooth.LargeChange = 1;
            this.trackSmooth.Location = new System.Drawing.Point(112, 41);
            this.trackSmooth.Maximum = 200;
            this.trackSmooth.Minimum = 1;
            this.trackSmooth.Name = "trackSmooth";
            this.trackSmooth.Size = new System.Drawing.Size(299, 45);
            this.trackSmooth.TabIndex = 12;
            this.trackSmooth.TickFrequency = 5;
            this.trackSmooth.Value = 1;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(23, 41);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(47, 15);
            this.lblTop.TabIndex = 9;
            this.lblTop.Text = "[lblTop]";
            // 
            // lblBottom
            // 
            this.lblBottom.AutoSize = true;
            this.lblBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottom.Location = new System.Drawing.Point(23, 106);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(65, 15);
            this.lblBottom.TabIndex = 10;
            this.lblBottom.Text = "[lblBottom]";
            // 
            // imgMain
            // 
            this.imgMain.Location = new System.Drawing.Point(73, 11);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(390, 318);
            this.imgMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMain.TabIndex = 2;
            this.imgMain.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImageProc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 403);
            this.Controls.Add(this.gbEditor);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.imgMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImageProc";
            this.Text = "ImageProc";
            this.Load += new System.EventHandler(this.ImageProc_Load);
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSmooth)).EndInit();
            this.gbEditor.ResumeLayout(false);
            this.gbEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackThres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSmooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMain;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.Label lblThres;
        private System.Windows.Forms.Label lblGray;
        private System.Windows.Forms.Label lblSmooth;
        private System.Windows.Forms.PictureBox imgThres;
        private System.Windows.Forms.PictureBox imgGray;
        private System.Windows.Forms.PictureBox imgSmooth;
        private System.Windows.Forms.GroupBox gbEditor;
        private System.Windows.Forms.TrackBar trackBottom;
        private System.Windows.Forms.TrackBar trackSmooth;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar trackThres;

    }
}