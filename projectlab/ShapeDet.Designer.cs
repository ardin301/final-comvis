namespace projectlab
{
    partial class ShapeDet
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
            this.imgMain = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCircle = new System.Windows.Forms.CheckBox();
            this.chkRect = new System.Windows.Forms.CheckBox();
            this.chkLine = new System.Windows.Forms.CheckBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgMain
            // 
            this.imgMain.Location = new System.Drawing.Point(87, 10);
            this.imgMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgMain.Name = "imgMain";
            this.imgMain.Size = new System.Drawing.Size(359, 366);
            this.imgMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMain.TabIndex = 0;
            this.imgMain.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(226, 398);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(85, 32);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCircle);
            this.groupBox1.Controls.Add(this.chkRect);
            this.groupBox1.Controls.Add(this.chkLine);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(494, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(147, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shape Mode";
            // 
            // chkCircle
            // 
            this.chkCircle.AutoSize = true;
            this.chkCircle.Location = new System.Drawing.Point(21, 109);
            this.chkCircle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCircle.Name = "chkCircle";
            this.chkCircle.Size = new System.Drawing.Size(52, 17);
            this.chkCircle.TabIndex = 2;
            this.chkCircle.Text = "Circle";
            this.chkCircle.UseVisualStyleBackColor = true;
            // 
            // chkRect
            // 
            this.chkRect.AutoSize = true;
            this.chkRect.Location = new System.Drawing.Point(21, 73);
            this.chkRect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkRect.Name = "chkRect";
            this.chkRect.Size = new System.Drawing.Size(75, 17);
            this.chkRect.TabIndex = 1;
            this.chkRect.Text = "Rectangle";
            this.chkRect.UseVisualStyleBackColor = true;
            // 
            // chkLine
            // 
            this.chkLine.AutoSize = true;
            this.chkLine.Location = new System.Drawing.Point(21, 41);
            this.chkLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkLine.Name = "chkLine";
            this.chkLine.Size = new System.Drawing.Size(46, 17);
            this.chkLine.TabIndex = 0;
            this.chkLine.Text = "Line";
            this.chkLine.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(525, 204);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(94, 31);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 25);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ShapeDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 464);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.imgMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShapeDet";
            this.Text = "ShapeDet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShapeDet_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgMain;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCircle;
        private System.Windows.Forms.CheckBox chkRect;
        private System.Windows.Forms.CheckBox chkLine;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}