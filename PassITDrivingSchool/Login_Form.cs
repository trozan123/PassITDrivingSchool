using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassItDrivingSchool
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
            txtUserName.Focus();
            txtPassword.UseSystemPasswordChar = true;
        }


        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_Form registration_Page = new Registration_Form();
            this.Close();
            registration_Page.Show();
        }


        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                llblMessage.Text = "User name must have letters and digits only!!!";
                llblMessage.ForeColor = System.Drawing.Color.White;
                llblMessage.BackColor = System.Drawing.Color.Red;
            }
            else
            { e.Handled = false; }
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                if (txtPassword.Text.Length >= 5)
                {
                    if (txtUserName.Text == "Trozan" && txtPassword.Text == "Trozan")
                    {
                        Admin_Form admin_Page = new Admin_Form();
                        //this.Close();
                        admin_Page.Show();
                    }
                    else
                    {
                        llblMessage.Text = "User name/password incorrect!!!";
                        llblMessage.BackColor = Color.Red;
                        llblMessage.ForeColor = System.Drawing.Color.White;
                    }

                }
                else
                {
                    llblMessage.Text = "Password should be at least of 5 character!!!";
                    llblMessage.BackColor = Color.Red;
                    llblMessage.ForeColor = System.Drawing.Color.White;
                }
            }
            else
            {
                txtUserName.Focus();
                llblMessage.Text = "Please enter user name and password.";
                llblMessage.ForeColor = System.Drawing.Color.White;
                llblMessage.BackColor = System.Drawing.Color.Red;
            }
        }

        private void lchkBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (lchkBox.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
