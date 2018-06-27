using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace projectlab
{
    public partial class FormEdge : Form
    {
        Form Form;

        Image image;

        Image<Bgr, Byte> ori;
        Image<Gray, Byte> canny;
        Image<Gray, float> laplace;
        Image<Gray, float> sobel;

        enum MainImage { ori, canny, laplace, sobel };

        MainImage flag;

        public FormEdge()
        {
            InitializeComponent();
        }

        public FormEdge(Form Form)
        {
            InitializeComponent();
            this.Form = Form;

        }

        private void FormEdge_Load(object sender, EventArgs e)
        {

            resetControl();
            // new eventhandler for multiple changed values
            var valuesChanged = new System.EventHandler(this.valuesChanged);
            this.comboAperture.SelectedValueChanged += valuesChanged;
            this.trackHigh.ValueChanged += valuesChanged;
            this.trackLow.ValueChanged += valuesChanged;

            
            //var debug = System.IO.Directory.GetCurrentDirectory();
            //imgUploaded.Image = Image.FromFile(
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Form.Show();
        }

        private void FormEdge_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Form.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg|*.jpg"+
                                   "| jpeg|*.jpeg" + 
                                   "| png|*.png"+
                                   "| bmp|*.bmp";

            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.image = Image.FromFile(openFileDialog1.FileName);
                firstLoadImage();
            }

        }
        private void firstLoadImage()
        {
            Image<Gray, byte> gray;
            Image<Gray, float> grayFloat;

            this.ori = new Image<Bgr, byte>(new Bitmap(this.image));
            gray = new Image<Gray, byte>(this.ori.Width, this.ori.Height);
            this.canny = gray.Clone();

            CvInvoke.cvCvtColor(this.ori, gray, COLOR_CONVERSION.CV_BGR2GRAY);
            grayFloat = gray.Convert<Gray, float>();

            CvInvoke.cvCanny(gray, this.canny, 150, 60, 3);
            this.laplace = grayFloat.Laplace(7);
            this.sobel = grayFloat.Sobel(1, 0, 3);

            imgMain.Image       = this.ori.ToBitmap();
            imgCanny.Image      = this.canny.ToBitmap();
            imgLaplace.Image    = this.laplace.ToBitmap();
            imgSobel.Image      = this.sobel.ToBitmap();
        }


        private void generateImages()
        {
            int aperture = Convert.ToInt32(comboAperture.SelectedItem);

            if (aperture != 0 && aperture % 2 != 0)
            {
                Image<Gray, byte> gray;
                Image<Gray, float> grayFloat;

                this.ori = new Image<Bgr, byte>(new Bitmap(this.image));
                gray = new Image<Gray, byte>(this.ori.Width, this.ori.Height);
                this.canny = gray.Clone();

                CvInvoke.cvCvtColor(this.ori, gray, COLOR_CONVERSION.CV_BGR2GRAY);
                grayFloat = gray.Convert<Gray, float>();

                CvInvoke.cvCanny(gray, this.canny, trackHigh.Value, trackLow.Value, aperture);
                this.laplace = grayFloat.Laplace(aperture);
                this.sobel = grayFloat.Sobel(1, 0, aperture);

                bindImages();
            }

        }

        private void bindImages()
        {
            imgCanny.Image = this.canny.ToBitmap();
            imgLaplace.Image = this.laplace.ToBitmap();
            imgSobel.Image = this.sobel.ToBitmap();

            if (this.flag == MainImage.ori)          imgMain.Image = this.ori.ToBitmap();
            else if (this.flag == MainImage.canny)   imgMain.Image = imgCanny.Image;
            else if (this.flag == MainImage.laplace) imgMain.Image = imgLaplace.Image;
            else if (this.flag == MainImage.sobel)   imgMain.Image = imgSobel.Image;
        }



        private void valuesChanged(object sender, EventArgs e)
        {
            if (this.image != null)
            {
                generateImages();
            }
            else
            {
                this.image = Properties.Resources.cat;
                generateImages();
            }
        }

        private void imgCanny_Click(object sender, EventArgs e)
        {
            resetControl();
            if (this.image == null)
            {
                MessageBox.Show("Please upload image first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblHigh.Show();
                trackHigh.Show();

                lblLow.Show();
                trackLow.Show();

                lblAperture.Show();
                comboAperture.Show();

                this.lblCanny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                this.lblCanny.ForeColor = System.Drawing.Color.Aqua;

                this.imgMain.Image = this.canny.ToBitmap();

                this.flag = MainImage.canny;
            }
        }

        private void imgLaplace_Click(object sender, EventArgs e)
        {
            resetControl();
            if (this.image == null)
            {
                MessageBox.Show("Please upload image first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblAperture.Show();
                comboAperture.Show();

                this.lblLaplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                this.lblLaplace.ForeColor = System.Drawing.Color.Aqua;

                this.imgMain.Image = this.laplace.ToBitmap();

                this.flag = MainImage.laplace;

            }
        }

        private void imgSobel_Click(object sender, EventArgs e)
        {
            resetControl();
            if (this.image == null)
            {
                MessageBox.Show("Please upload image first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblAperture.Show();
                comboAperture.Show();

                this.lblSobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                this.lblSobel.ForeColor = System.Drawing.Color.Aqua;

                this.imgMain.Image = this.sobel.ToBitmap();

                this.flag = MainImage.sobel;

            }
        }

        private void resetControl()
        {
            comboAperture.SelectedIndex = 0;

            gbEditor.Enabled = true;

            lblAperture.Hide();
            comboAperture.Hide();

            lblHigh.Hide();
            trackHigh.Hide();

            lblLow.Hide();
            trackLow.Hide();

            this.lblCanny.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
            this.lblLaplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
            this.lblSobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);

            this.lblCanny.ForeColor = System.Drawing.Color.Black;
            this.lblLaplace.ForeColor = System.Drawing.Color.Black;
            this.lblSobel.ForeColor = System.Drawing.Color.Black;

            this.flag = MainImage.ori;

        }
       
    }
}
