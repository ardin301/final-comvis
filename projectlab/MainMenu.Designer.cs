namespace projectlab
{
    partial class MainMenu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdge = new System.Windows.Forms.Button();
            this.btnShape = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnPattern = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(260, 74);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(340, 29);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Welcome to LOmo Camera, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose menu for this application";
            // 
            // btnEdge
            // 
            this.btnEdge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdge.Location = new System.Drawing.Point(152, 202);
            this.btnEdge.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdge.Name = "btnEdge";
            this.btnEdge.Size = new System.Drawing.Size(272, 118);
            this.btnEdge.TabIndex = 2;
            this.btnEdge.Text = "Edge Detection";
            this.btnEdge.UseVisualStyleBackColor = true;
            this.btnEdge.Click += new System.EventHandler(this.btnEdge_Click);
            // 
            // btnShape
            // 
            this.btnShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShape.Location = new System.Drawing.Point(495, 202);
            this.btnShape.Margin = new System.Windows.Forms.Padding(4);
            this.btnShape.Name = "btnShape";
            this.btnShape.Size = new System.Drawing.Size(272, 118);
            this.btnShape.TabIndex = 3;
            this.btnShape.Text = "Shape Detection";
            this.btnShape.UseVisualStyleBackColor = true;
            this.btnShape.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnImage.Location = new System.Drawing.Point(152, 361);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(272, 118);
            this.btnImage.TabIndex = 4;
            this.btnImage.Text = "Image Processing";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnPattern
            // 
            this.btnPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPattern.Location = new System.Drawing.Point(495, 361);
            this.btnPattern.Margin = new System.Windows.Forms.Padding(4);
            this.btnPattern.Name = "btnPattern";
            this.btnPattern.Size = new System.Drawing.Size(272, 118);
            this.btnPattern.TabIndex = 5;
            this.btnPattern.Text = "Pattern Recognition and Classification ";
            this.btnPattern.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(787, 15);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 37);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPattern);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnShape);
            this.Controls.Add(this.btnEdge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdge;
        private System.Windows.Forms.Button btnShape;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnPattern;
        private System.Windows.Forms.Button btnLogout;
    }
}