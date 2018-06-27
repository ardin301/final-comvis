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
    public partial class PatternRec : Form
    {
        Form Form;
        Image image;

        Image<Bgr, Byte> ori, edit;
        Image<Gray, Byte> gray;

        Capture cap;
        Image<Bgr, byte> frame;
        bool isPlaying = false;

        HaarCascade facecascade = new HaarCascade("haarcascade_frontalface_alt.xml");
        HaarCascade eyecascade = new HaarCascade("haarcascade_eye.xml");

        public PatternRec()
        {
            InitializeComponent();
        }

        public PatternRec(Form Form)
        {
            InitializeComponent();

            this.Form = Form;

            btnPlay.Enabled = false;
            btnStop.Enabled = false;
            groupBox1.Enabled = false;

            var valuesChanged = new System.EventHandler(this.valuesChanged);
            chkFace.CheckedChanged += this.valuesChanged;
            chkEye.CheckedChanged += this.valuesChanged;
            chkCanny.CheckedChanged += this.valuesChanged;
        }

        private void valuesChanged(object sender, EventArgs e)
        {
            //count++;
            //MessageBox.Show(count.ToString());
            if (ori == null) return;
            if (!isPlaying)
            {
                edit = ori.Clone();
                edit = edit.Resize(0.2, INTER.CV_INTER_CUBIC);

                if(chkFace.Checked)
                {
                    edit = scanFace(edit);
                }
                if (chkEye.Checked)
                {
                    edit = scanEye(edit);
                }
                if (chkCanny.Checked)
                {
                    edit = getCanny(edit);
                }

                imgMain.Image = edit.ToBitmap();
            }
        }

        private Image<Bgr, byte> scanFace(Image<Bgr, byte> inp)
        {
            var res = inp.Clone();

            var gray = new Image<Gray, byte>(res.Width, res.Height);
            CvInvoke.cvCvtColor(res, gray, COLOR_CONVERSION.CV_BGR2GRAY);

            var faces = facecascade.Detect(gray);

            foreach (var face in faces)
            {
                res.Draw(face.rect, new Bgr(Color.MediumVioletRed), 2);
            }

            return res;
        }

        private Image<Bgr, byte> scanEye(Image<Bgr, byte> inp)
        {
            var res = inp.Clone();

            var gray = new Image<Gray, byte>(res.Width, res.Height);
            CvInvoke.cvCvtColor(res, gray, COLOR_CONVERSION.CV_BGR2GRAY);

            var faces = eyecascade.Detect(gray);

            foreach (var face in faces)
            {
                res.Draw(face.rect, new Bgr(Color.MediumBlue), 2);
            }

            return res;
        }

        private Image<Bgr, byte> getCanny(Image<Bgr, byte> inp)
        {
            var res = inp.Clone();

            return res;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Form.Show();
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
                this.ori = new Image<Bgr, byte>(new Bitmap(this.image));
                firstLoadImage();

                groupBox1.Enabled = true;
                btnStop.Enabled = false;
                btnPlay.Enabled = false;
            }
        }

        private void btnUpload2_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "mp4|*.mp4" +
                                   "| gid|*.gif" +
                                   "| avi|*.avi" +
                                   "| mkv|*.mkv";

            var result = openFileDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                timer1.Start();
                cap = new Capture(openFileDialog2.FileName);
                frame = cap.QueryFrame();

                ori = frame.Clone();
                firstLoadImage();

                groupBox1.Enabled = true;
                btnStop.Enabled = true;
                btnPlay.Enabled = true;
            }
        }

        private void firstLoadImage()
        {
            this.gray = new Image<Gray, byte>(this.ori.Width, this.ori.Height);
            this.edit = new Image<Bgr, byte>(this.ori.Width, this.ori.Height);
            CvInvoke.cvCvtColor(this.ori, this.gray, COLOR_CONVERSION.CV_BGR2GRAY);
            this.edit = this.ori.Copy();
            imgMain.Image = this.ori.ToBitmap();
            btnStop.Enabled = true;
        }

        private void processFrame()
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            this.edit = this.ori.Copy();
            if (!chkCanny.Checked && !chkFace.Checked && !chkEye.Checked)
            {
                MessageBox.Show("Choose Shape Detection Mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chkFace.Checked)
            {
                LineSegment2D[] lines = this.gray.HoughLinesBinary(2, Math.PI / 45, 25, 20, 5)[0];
                foreach (LineSegment2D l in lines)
                {
                    edit.Draw(l, new Bgr(Color.Green), 5);
                }
            }
            if (chkEye.Checked)
            {
                List<MCvBox2D> boxlist = new List<MCvBox2D>();
                MemStorage storage = new MemStorage();

                for (Contour<Point> con = gray.FindContours(); con != null; con = con.HNext)
                {
                    Contour<Point> con2 = con.ApproxPoly(con.Perimeter * 0.16, storage);

                    if (con.Area > 250)
                    {
                        if (con2.Total == 4)
                        {
                            bool rect = true;
                            Point[] pts = con2.ToArray();
                            LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                            for (int i = 0; i < edges.Length; i++)
                            {
                                double angle = Math.Abs(edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                                if (angle < 80 || angle > 100)
                                {
                                    rect = false;
                                    break;
                                }
                            }

                            if (rect)
                            {
                                boxlist.Add(con2.GetMinAreaRect());
                            }
                        }
                    }
                }
                foreach (MCvBox2D b in boxlist)
                {
                    edit.Draw(b, new Bgr(Color.Brown), 5);
                }
            }
            if (chkCanny.Checked)
            {
                CircleF[] circle = gray.HoughCircles(new Gray(100), new Gray(80), 7, 400, 0, 100)[0];

                foreach (CircleF c in circle)
                {
                    edit.Draw(c, new Bgr(Color.Blue), 5);
                }
            }
            imgMain.Image = this.edit.ToBitmap();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isPlaying = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            isPlaying = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                edit = cap.QueryFrame();
                edit = edit.Resize(0.3, INTER.CV_INTER_CUBIC);

                if (chkFace.Checked)
                {
                    edit = scanFace(edit);
                }
                if (chkEye.Checked)
                {
                    edit = scanEye(edit);
                }
                if (chkCanny.Checked)
                {
                    edit = getCanny(edit);
                }
                imgMain.Image = edit.ToBitmap();
            }
        }

        private void PatternRec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Close();
        }



    }
}
