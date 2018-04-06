using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using projectlab;

namespace projectlab
{
    public partial class Login : Form
    {
        public List<User> Users { get; set; }
        public User User { get; set; }

        public Login()
        {
            InitializeComponent();
            lblMessage.Hide();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            var register = new Register(this);
            register.Show();
            
        }

        private void lblLink_MouseHover(object sender, EventArgs e)
        {
            lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline);
        }

        private void lblLink_MouseLeave(object sender, EventArgs e)
        {
            lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;
            lblMessage.Hide();

            if (validateEmail(email) && validatePassword(password))
            {
                this.Hide();
                var mainMenu = new MainMenu(this);
                mainMenu.Show();               
                
            }
            else
            {
                lblMessage.Text = "Invalid Email or Password";
                lblMessage.Show();
            }
            
        }


        private bool validateEmail(string email)
        {
            User user = Users.Find(x => x.Email == email);
            if (user == null) return false;
            else this.User = user;
            return true;
        }

        private bool validatePassword(string password)
        {
            User user = Users.Find(x => x.Password == password);
            if (user == null) return false;
            return true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Register register = new Register(Users);
            //register.Show();
            
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            string str = "";
            foreach (var item in Users)
            {
                str = str + " " + item.Email;
            }
            lblMessage.Text = str;
            lblMessage.Show();
        }

        public void debug(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
