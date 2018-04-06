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
    public partial class Register : Form
    {
        private List<User> Users { get; set; }
        private Login Login { get; set; }

        public Register()
        {
            InitializeComponent();
        }

        public Register(Login login)
        {
            InitializeComponent();
            this.Login = login;
            this.Users = login.Users;
        }


        private void lblLink_MouseHover(object sender, EventArgs e)
        {
            lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline);
        }
        private void lblLink_MouseLeave(object sender, EventArgs e)
        {
            lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
        }
        private void lblLink_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            if (validation())
            {
                lblMessage.Hide();

                var result = MessageBox.Show("Data berhasil disimpan", "Success", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    var email = textBox1.Text;
                    var password = textBox2.Text;
                    var name = textBox4.Text;
                    var gender = radioFemale.Checked ? "Female" : "Male";

                    Users.Add(new User
                    {
                        Email = email,
                        Password = password,
                        Name = name,
                        Gender = gender
                    });
                    this.Close();
                }
            }
                        
        }

        private bool validation()
        {
            lblMessage.Show();

            string email = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string confPassword = textBox3.Text.Trim();
            string fullName = textBox4.Text.Trim();

            if (email.Length == 0 ||
                password.Length == 0 ||
                confPassword.Length == 0 ||
                fullName.Length == 0)
            {
                lblMessage.Text = "All inputs must be filled";
                return false;
            }
            else if (!radioFemale.Checked && !radioMale.Checked)
            {
                lblMessage.Text = "Please choose your gender";
                return false;
            }
            else if (!ckAgree.Checked)
            {
                lblMessage.Text = "You must agree to terms and conditions";
                return false;
            }
            else if (!validateEmail(email))
            {
                lblMessage.Text = "Incorrect Email";
                return false;
            }
            else if (!existedEmail(email))
            {
                lblMessage.Text = "Email already exists";
                return false;
            }
            else if (confPassword != password)
            {
                lblMessage.Text = "Confirmation password must be same";
                return false;
            }

            return true;
        }

        private bool validateEmail(string email)
        {
            if(email[0] == '@' ||
                email[0] == '.') return false;

            var index = email.IndexOf('@');
            if (index == -1) return false;

            var substr = email.Substring(index);
            if (substr != "@yahoo.com" &&
                 substr != "@gmail.com") return false;

            return true;
        }

        private bool existedEmail(string email)
        {
            if (Users.Find(user => user.Email == email) != null) return false;
            return true;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // hide lblMessage on initiating
            lblMessage.Hide();

            // adding event handler for multiples textboxes
            var textBoxes_Changed = new System.EventHandler(this.textBoxes_Changed);
            this.textBox1.TextChanged += textBoxes_Changed;
            this.textBox2.TextChanged += textBoxes_Changed;
            this.textBox3.TextChanged += textBoxes_Changed;
            this.textBox4.TextChanged += textBoxes_Changed;
        }

        private void textBoxes_Changed(object sender, EventArgs e)
        {
            lblMessage.Hide();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Back to Login Form
            Login.Show();
        }




    }
}
