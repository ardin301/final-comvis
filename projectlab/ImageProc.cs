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
    public partial class ImageProc : Form
    {
        Form Form;

        Image image;

        Image<Bgr, Byte> ori;
        Image<Bgr, Byte> smooth;
        Image<Gray, Byte> gray;
        Image<Gray, Byte> thres;

        enum MainImage { ori, smooth, gray, thres };

        MainImage flag;


        public ImageProc()
        {
            InitializeComponent();
        }
        public ImageProc(Form Form) {
            InitializeComponent();
            this.Form = Form;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Form.Show();
        }

        private void ImageProc_Load(object sender, EventArgs e)
        {
            resetControl();
            // new eventhandler for multiple changed values
            var valuesChanged = new System.EventHandler(this.valuesChanged);
            this.trackSmooth.ValueChanged += valuesChanged;
            this.trackThres.ValueChanged += valuesChanged;
            this.trackBottom.ValueChanged += valuesChanged;
        }

        private void valuesChanged(object sender, EventArgs e)
        {
            if (this.image != null)
            {
                generateImages();
            }
            
        }

        private void firstLoadImage()
        {
            this.ori = new Image<Bgr, byte>(new Bitmap(this.image));
            this.gray = new Image<Gray, byte>(this.ori.Width, this.ori.Height);
            this.smooth = new Image<Bgr, byte>(this.ori.Width, this.ori.Height);
            this.thres = gray.Clone();

            CvInvoke.cvCvtColor(this.ori, this.gray, COLOR_CONVERSION.CV_BGR2GRAY);

            CvInvoke.cvThreshold(this.gray, this.thres, 41, 141, THRESH.CV_THRESH_BINARY);
            CvInvoke.cvSmooth(this.ori, this.smooth, SMOOTH_TYPE.CV_BLUR, 10, 10, 0, 0);

            imgMain.Image = this.ori.ToBitmap();
            imgSmooth.Image = this.smooth.ToBitmap();
            imgGray.Image = this.gray.ToBitmap();
            imgThres.Image = this.thres.ToBitmap();
        }

        private void generateImages()
        {

                this.ori = new Image<Bgr, byte>(new Bitmap(this.image));
                this.gray = new Image<Gray, byte>(this.ori.Width, this.ori.Height);
                this.smooth = new Image<Bgr, byte>(this.ori.Width, this.ori.Height);

                CvInvoke.cvCvtColor(this.ori, this.gray, COLOR_CONVERSION.CV_BGR2GRAY);
                this.thres = gray.Clone();

                CvInvoke.cvThreshold(this.gray, this.thres, (Double)trackThres.Value, 41, THRESH.CV_THRESH_BINARY);
                CvInvoke.cvSmooth(this.ori, this.smooth, SMOOTH_TYPE.CV_BLUR, (Int32)trackSmooth.Value, (Int32)trackSmooth.Value, 0, 0);

                bindImages();
        }

        private void bindImages()
        {
            imgSmooth.Image = this.smooth.ToBitmap();
            imgGray.Image = this.gray.ToBitmap();
            imgThres.Image = this.thres.ToBitmap();

            if (this.flag == MainImage.ori) imgMain.Image = this.ori.ToBitmap();
            else if (this.flag == MainImage.smooth) imgMain.Image = imgSmooth.Image;
            else if (this.flag == MainImage.gray) imgMain.Image = imgGray.Image;
            else if (this.flag == MainImage.thres) imgMain.Image = imgThres.Image;
        }


        private void resetControl()
        {
            gbEditor.Enabled = true;

            lblTop.Hide();
            trackSmooth.Hide();
            trackThres.Hide();

            lblBottom.Hide();
            trackBottom.Hide();

            this.lblSmooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
            this.lblGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
            this.lblThres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);

            this.lblSmooth.ForeColor = System.Drawing.Color.Black;
            this.lblGray.ForeColor = System.Drawing.Color.Black;
            this.lblThres.ForeColor = System.Drawing.Color.Black;

            this.flag = MainImage.ori;

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg|*.jpg" +
                                   "| jpeg|*.jpeg" +
                                   "| png|*.png" +
                                   "| bmp|*.bmp";

            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.image = Image.FromFile(openFileDialog1.FileName);
                firstLoadImage();
            }
        }

        private void imgSmooth_Click(object sender, EventArgs e)
        {
            resetControl();
            if (this.image == null)
            {
                MessageBox.Show("Please upload image first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblTop.Text = "Smooth";
                lblTop.Show();
                trackSmooth.Show();

                this.lblSmooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                this.lblSmooth.ForeColor = System.Drawing.Color.Aqua;

                this.imgMain.Image = this.smooth.ToBitmap();

                this.flag = MainImage.smooth;
            }
        }

        private void imgGray_Click(object sender, EventArgs e)
        {
            resetControl();
            if (this.image == null)
            {
                MessageBox.Show("Please upload image first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.lblGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                this.lblGray.ForeColor = System.Drawing.Color.Aqua;

                this.imgMain.Image = this.gray.ToBitmap();

                this.flag = MainImage.gray;
            }
        }

        private void imgThres_Click(object sender, EventArgs e)
        {
            resetControl();
            if (this.image == null)
            {
                MessageBox.Show("Please upload image first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                lblTop.Text = "Threshold";
                lblTop.Show();
                trackThres.Show();

                this.lblThres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                this.lblThres.ForeColor = System.Drawing.Color.Aqua;

                this.imgMain.Image = this.thres.ToBitmap();

                this.flag = MainImage.thres;
            }
        }
        
    }
}
