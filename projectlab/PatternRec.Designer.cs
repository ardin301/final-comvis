namespace projectlab
{
    partial class PatternRec
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
            this.btnBack = new System.Windows.Forms.Button();
            this.chkCanny = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.chkEye = new System.Windows.Forms.CheckBox();
            this.chkFace = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnUpload2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 40);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 25);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chkCanny
            // 
            this.chkCanny.AutoSize = true;
            this.chkCanny.Location = new System.Drawing.Point(21, 109);
            this.chkCanny.Margin = new System.Windows.Forms.Padding(2);
            this.chkCanny.Name = "chkCanny";
            this.chkCanny.Size = new System.Drawing.Size(133, 17);
            this.chkCanny.TabIndex = 2;
            this.chkCanny.Text = "Canny Edge Detectors";
            this.chkCanny.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(480, 253);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 71);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop Video";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // imgMain
            // 
            this.imgMain.Location = new System.Drawing.Point(100, 40);
            this.imgMain.Margin = new System.Windows.Forms.Padding(2);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(359, 366);
            this.imgMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMain.TabIndex = 5;
            this.imgMain.TabStop = false;
            // 
            // chkEye
            // 
            this.chkEye.AutoSize = true;
            this.chkEye.Location = new System.Drawing.Point(21, 73);
            this.chkEye.Margin = new System.Windows.Forms.Padding(2);
            this.chkEye.Name = "chkEye";
            this.chkEye.Size = new System.Drawing.Size(44, 17);
            this.chkEye.TabIndex = 1;
            this.chkEye.Text = "Eye";
            this.chkEye.UseVisualStyleBackColor = true;
            // 
            // chkFace
            // 
            this.chkFace.AutoSize = true;
            this.chkFace.Location = new System.Drawing.Point(21, 41);
            this.chkFace.Margin = new System.Windows.Forms.Padding(2);
            this.chkFace.Name = "chkFace";
            this.chkFace.Size = new System.Drawing.Size(50, 17);
            this.chkFace.TabIndex = 0;
            this.chkFace.Text = "Face";
            this.chkFace.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCanny);
            this.groupBox1.Controls.Add(this.chkEye);
            this.groupBox1.Controls.Add(this.chkFace);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(492, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(162, 148);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object to Detect";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(153, 435);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(85, 32);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload Image";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(574, 253);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 71);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play Video";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnUpload2
            // 
            this.btnUpload2.Location = new System.Drawing.Point(272, 435);
            this.btnUpload2.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload2.Name = "btnUpload2";
            this.btnUpload2.Size = new System.Drawing.Size(85, 32);
            this.btnUpload2.TabIndex = 11;
            this.btnUpload2.Text = "Upload Video";
            this.btnUpload2.UseVisualStyleBackColor = true;
            this.btnUpload2.Click += new System.EventHandler(this.btnUpload2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PatternRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 500);
            this.Controls.Add(this.btnUpload2);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.imgMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpload);
            this.Name = "PatternRec";
            this.Text = "PatternRec";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PatternRec_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkCanny;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox imgMain;
        private System.Windows.Forms.CheckBox chkEye;
        private System.Windows.Forms.CheckBox chkFace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnUpload2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Timer timer1;

    }
}