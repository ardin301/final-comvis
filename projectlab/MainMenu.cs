using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projectlab
{
    public partial class MainMenu : Form
    {
        public User User { get; set; }
        public Login Login { get; set; }

        FormEdge FormEdge;
        ImageProc ImageProc;
        ShapeDet ShapeDet;

        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(Login Login)
        {
            InitializeComponent();
            this.Login = Login;
            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // change title label
            if (Login.User != null)
            {
                this.User = Login.User;
            }
            else
            {
                this.User = new User 
                {
                    Email = "aaa@gmail.com",
                    Password = "123",
                    Name = "abc",
                    Gender = "Male"
                };
            }

            lblMenu.Text += User.Gender == "Female" ? "Mrs. " : "Mr. ";
            lblMenu.Text += User.Name;

            // initiate all menus
            this.FormEdge = new FormEdge(this);
            this.ImageProc = new ImageProc(this);
            this.ShapeDet = new ShapeDet(this);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Login.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.FormEdge.Dispose();
            this.ImageProc.Dispose();
            this.ShapeDet.Dispose();
            Application.Exit();
            //this.Login.Show();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //string msg = Enum.GetName(typeof(CloseReason), e.CloseReason);
            //Login.debug(msg);

        }

        private void btnEdge_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEdge.Show();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImageProc.Show();
        }

        private void btnShape_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShapeDet.Show();
        }


    }
}
