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
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
            txtUserName.Focus();
            txtPassword.UseSystemPasswordChar = true;
            txtConformPassword.UseSystemPasswordChar = true;
        }


        private void llbLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form log_In = new Login_Form();
            this.Close();
            log_In.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.Text != "" && txtPassword.Text != "" && txtConformPassword.Text != "")
                {
                    if (txtPassword.Text == txtConformPassword.Text)
                    {
                        if (MessageBox.Show("New admin added successfully!!", "Add Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            == DialogResult.OK)
                        {
                            this.Close();
                        }
                        else
                        {

                        }

                    }
                    else
                    {
                        lblMessage.Text = "Password does not match!!!";
                        lblMessage.ForeColor = System.Drawing.Color.White;
                        lblMessage.BackColor = System.Drawing.Color.Red;
                    }

                }
                else
                {
                    lblMessage.Text = "All fields are required!!!";
                    txtUserName.Focus();
                    lblMessage.ForeColor = System.Drawing.Color.White;
                    lblMessage.BackColor = System.Drawing.Color.Red;
                }
            }

            catch
            {

            }

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblMessage.Text = "User name must have letters and digits only!!!";
                lblMessage.ForeColor = System.Drawing.Color.White;
                lblMessage.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConformPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConformPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {


        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
