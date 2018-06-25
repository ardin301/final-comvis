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
    public partial class ShapeDet : Form
    {
        Form Form;
        Image image;

        Image<Bgr, Byte> ori, edit;
        Image<Gray, Byte> gray;

        enum MainImage { ori, gray};
        MainImage flag;

        public ShapeDet()
        {
            InitializeComponent();
        }

        public ShapeDet(Form Form) {
            InitializeComponent();
            this.Form = Form;
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
                firstLoadImage();
            }
        }

        private void firstLoadImage()
        {
            this.ori = new Image<Bgr, byte>(new Bitmap(this.image));
            this.gray = new Image<Gray, byte>(this.ori.Width, this.ori.Height);
            this.edit = new Image<Bgr, byte>(this.ori.Width, this.ori.Height);
            CvInvoke.cvCvtColor(this.ori, this.gray, COLOR_CONVERSION.CV_BGR2GRAY);
            CvInvoke.cvCanny(this.gray, this.gray, 150, 60, 3);
            this.edit = this.ori.Copy();
            imgMain.Image = this.ori.ToBitmap();
            groupBox1.Enabled = true;
            btnProcess.Enabled = true;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            this.edit = this.ori.Copy();
            if (!chkCircle.Checked && !chkLine.Checked && !chkRect.Checked) {
                MessageBox.Show("Choose Shape Detection Mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (chkLine.Checked) {
                LineSegment2D[] lines = this.gray.HoughLinesBinary(2, Math.PI / 45, 25, 20, 5)[0];
                foreach (LineSegment2D l in lines) {
                    edit.Draw(l, new Bgr(Color.Green), 5);
                }
            }
            if (chkRect.Checked) {
                List<MCvBox2D> boxlist = new List<MCvBox2D>();
                MemStorage storage = new MemStorage();

                for (Contour<Point> con = gray.FindContours(); con != null; con = con.HNext) {
                    Contour<Point> con2 = con.ApproxPoly(con.Perimeter * 0.16, storage);

                    if (con.Area > 250) {
                        if (con2.Total == 4) {
                            bool rect = true;
                            Point[] pts = con2.ToArray();
                            LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                            for (int i = 0; i < edges.Length; i++) {
                                double angle = Math.Abs(edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                                if (angle < 80 || angle > 100) {
                                    rect = false;
                                    break;
                                }
                            }

                            if (rect) {
                                boxlist.Add(con2.GetMinAreaRect());
                            }
                        }
                    }
                }
                foreach (MCvBox2D b in boxlist) {
                    edit.Draw(b, new Bgr(Color.Brown), 5);
                }
            }
            if (chkCircle.Checked) {
                CircleF[] circle = gray.HoughCircles(new Gray(100), new Gray(80), 7, 400, 0, 100)[0];

                foreach (CircleF c in circle) {
                    edit.Draw(c, new Bgr(Color.Blue), 5);
                }
            }
            imgMain.Image = this.edit.ToBitmap();

        }



    }
}
