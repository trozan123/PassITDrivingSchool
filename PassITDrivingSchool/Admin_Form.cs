using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PassItDrivingSchool
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        int indexRow;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Form frm = new Login_Form();
            this.Close();
            frm.Show();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {

            string[,] rows = new string[,]
            {
            };

            for (int i = 0; i < rows.GetLength(0); i++)
            {
                string[] row = new string[rows.GetLength(1)];
                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    row[j] = rows[i, j];
                }
                gvStudent.Rows.Add(row);
            }


            string[,] rows1 = new string[,]
           {
                {"Trozan","","Sapkota","Full Time","Nepal","9813141516"},
                {"Alex","","Sterling","Full Time","England","9841000000"},
                {"Phil","","Foden","Part Time","Denmark","9841111111"},
                {"Cole","Palmer","Haaland","Full Time","Norway","9841222222" },

           };

            for (int i = 0; i < rows1.GetLength(0); i++)
            {
                string[] row = new string[rows1.GetLength(1)];
                for (int j = 0; j < rows1.GetLength(1); j++)
                {
                    row[j] = rows1[i, j];
                }
                gvInstructor.Rows.Add(row);
            }
            dispdgvInstructorRegistration();
            dispddgvStudentRegistration();
            hidestar();
            hidebutton();
        }

        private void btnInstructorSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInstructorFirstName.Text != "" && txtInstructorLastName.Text != "" && cmbInstructorJobType.Text != ""
                        && txtInstructorAddress.Text != "" && txtInstructorPhoneNumber.Text != "")
                {
                    if (MessageBox.Show("Record saved successfully!!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        == DialogResult.OK)
                    {
                        gvInstructor.Rows.Add(txtInstructorFirstName.Text, txtInstructorMiddleName.Text, txtInstructorLastName.Text, cmbInstructorJobType.Text, txtInstructorAddress.Text, txtInstructorPhoneNumber.Text);
                        tabHome.SelectedIndex = 2;
                        clear();
                        hidestar();
                    }

                }
                else
                {
                    lblMessage.Text = "Field with * marked are required!!!";
                    lblMessage.ForeColor = System.Drawing.Color.White;
                    lblMessage.BackColor = System.Drawing.Color.Red;
                    showstar();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }


        }

        private void btnInstructorUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = gvInstructor.Rows[indexRow];
            if (txtInstructorFirstName.Text != "" && txtInstructorLastName.Text != "" && cmbInstructorJobType.Text != ""
                && txtInstructorAddress.Text != "" && txtInstructorPhoneNumber.Text != "")
            {
                if (MessageBox.Show("Update this record?", "Update Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    == DialogResult.OK)
                {
                    newDataRow.Cells[0].Value = txtInstructorFirstName.Text;
                    newDataRow.Cells[1].Value = txtInstructorMiddleName.Text;
                    newDataRow.Cells[2].Value = txtInstructorLastName.Text;
                    newDataRow.Cells[3].Value = cmbInstructorJobType.Text;
                    newDataRow.Cells[4].Value = txtInstructorAddress.Text;
                    newDataRow.Cells[5].Value = txtInstructorPhoneNumber.Text;
                    tabHome.SelectedIndex = 4;
                    clear();
                    hidestar();
                }
            }
            else
            {
                lblMessage.Text = "No records to update!!!";
                lblMessage.ForeColor = System.Drawing.Color.White;
                lblMessage.BackColor = System.Drawing.Color.Red;
            }

        }

        private void btnInstructorDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = gvStudent.Rows[indexRow];
            if (txtInstructorFirstName.Text != "" && txtInstructorLastName.Text != "" && cmbInstructorJobType.Text != ""
                && txtInstructorAddress.Text != "" && txtInstructorPhoneNumber.Text != "")
            {
                if (MessageBox.Show("Delete this record?", "Delete Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
                    == DialogResult.OK)
                {
                    gvInstructor.Rows.RemoveAt(indexRow);
                    tabHome.SelectedIndex = 4;
                    clear();
                    hidestar();
                }

            }
            else
            {
                lblMessage.Text = "No records to delete!!!";
                lblMessage.ForeColor = System.Drawing.Color.White;
                lblMessage.BackColor = System.Drawing.Color.Red;
            }

        }


        private void btnInstructorClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear this record?", "Clear Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                clear();
                hidestar();
                hideinstructorbutton();
                dispdgvInstructorRegistration();
                btnInstructorSave.Show();
            }

        }

        public void dispdgvInstructorRegistration()
        {

        }

        private void dgvInstructorRegistration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInstructorRegistration_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void clear()
        {
            txtInstructorFirstName.Text = string.Empty;
            txtInstructorMiddleName.Text = string.Empty;
            txtInstructorLastName.Text = string.Empty;
            cmbInstructorJobType.Text = string.Empty;
            txtInstructorAddress.Text = string.Empty;
            txtInstructorPhoneNumber.Text = string.Empty;
        }

        public void hidestar()
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;
            label5.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        public void showstar()
        {
            label1.Text = "*";
            label2.Text = "*";
            label3.Text = "*";
            label4.Text = "*";
            label5.Text = "*";
            lblMessage.ForeColor = System.Drawing.Color.White;
            lblMessage.BackColor = System.Drawing.Color.Red;
        }

        public void studentshowstar()
        {
            label6.Text = "*";
            label7.Text = "*";
            label8.Text = "*";
            label10.Text = "*";
            label11.Text = "*";
            label12.Text = "*";
            lblStudentMessage.Text = "Fields with * signs are required!!";
            lblStudentMessage.ForeColor = System.Drawing.Color.White;
            lblStudentMessage.BackColor = System.Drawing.Color.Red;
        }

        public void studenthidestar()
        {
            label6.Text = string.Empty;
            label7.Text = string.Empty;
            label8.Text = string.Empty;
            label10.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            lblStudentMessage.Text = string.Empty;
        }

        public void clearstudentfield()
        {
            txtFirstName.Text = string.Empty;
            txtMiddleName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cmbGender.Text = "";
            cmbCourse.Text = "";
            cmbInstructor.Text = "";
        }

        public void hidebutton()
        {
            btnUpdate.Hide();
            btnDelete.Hide();
            btnClear.Hide();
            btnInstructorUpdate.Hide();
            btnInstructorDelete.Hide();
            btnInstructorClear.Hide();
            button1.Hide();
            btnProgressTrack.Hide();
        }

        public void hidestudentbutton()
        {
            btnUpdate.Hide();
            btnDelete.Hide();
            btnClear.Hide();
            button1.Hide();
            btnProgressTrack.Hide();
        }

        public void hideinstructorbutton()
        {
            btnInstructorUpdate.Hide();
            btnInstructorDelete.Hide();
            btnInstructorClear.Hide();
        }
        public void showbuttonstudent()
        {
            btnUpdate.Show();
            btnDelete.Show();
            btnClear.Show();
            button1.Show();
            btnProgressTrack.Show();
        }

        public void showbuttoninstructor()
        {
            btnInstructorUpdate.Show();
            btnInstructorDelete.Show();
            btnInstructorClear.Show();
        }


        private void tabInstructorRegistration_Click(object sender, EventArgs e)
        {

        }

        public void FilterInstructorGridview()
        {

        }
        private void btnInstructorSearch_Click(object sender, EventArgs e)
        {
            FilterInstructorGridview();
        }


        //Code for Student Registration

        //Save Studnts details 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && cmbGender.Text != "" && txtAddress.Text != ""
                && cmbInstructor.Text != "" && dateTimePicker1.Text != "" && cmbCourse.Text != "")
            {
                if (MessageBox.Show("Record Saved successfully!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    == DialogResult.OK)
                {
                    gvStudent.Rows.Add(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text, cmbGender.Text, txtAddress.Text, cmbInstructor.Text, dateTimePicker1.Text, cmbCourse.Text);
                    tabHome.SelectedIndex = 1;
                    clearstudentfield();
                    studenthidestar();

                }
                else
                {
                    lblStudentMessage.Text = "No recors to save!!!";
                    lblStudentMessage.ForeColor = System.Drawing.Color.White;
                    lblStudentMessage.BackColor = System.Drawing.Color.Red;
                }

            }
            else
            {
                lblStudentMessage.Text = "Field with * marked are required!!!";
                lblStudentMessage.ForeColor = System.Drawing.Color.White;
                lblStudentMessage.BackColor = System.Drawing.Color.Red;
                studentshowstar();
            }

        }

        //Displaying students record from database.
        public void dispddgvStudentRegistration()
        {

        }


        //Code to update student data into database.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = gvStudent.Rows[indexRow];
            if (txtFirstName.Text != "" && txtLastName.Text != "" && cmbGender.Text != "" && txtAddress.Text != ""
                && cmbInstructor.Text != "" && dateTimePicker1.Text != "" && cmbCourse.Text != "")
            {
                if (MessageBox.Show("Update this record?", "Update Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                    == DialogResult.OK)
                {
                    newDataRow.Cells[0].Value = txtFirstName.Text;
                    newDataRow.Cells[1].Value = txtMiddleName.Text;
                    newDataRow.Cells[2].Value = txtLastName.Text;
                    newDataRow.Cells[3].Value = cmbGender.Text;
                    newDataRow.Cells[4].Value = txtAddress.Text;
                    newDataRow.Cells[5].Value = cmbInstructor.Text;
                    newDataRow.Cells[6].Value = dateTimePicker1.Text;
                    newDataRow.Cells[7].Value = cmbCourse.Text;
                    tabHome.SelectedIndex = 2;
                    clearstudentfield();
                    studenthidestar();
                }
                else
                {
                    lblStudentMessage.Text = "No record to update!!!";
                    lblStudentMessage.ForeColor = System.Drawing.Color.White;
                    lblStudentMessage.BackColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblStudentMessage.Text = "No record to update!!!";
                lblStudentMessage.ForeColor = System.Drawing.Color.White;
                lblStudentMessage.BackColor = System.Drawing.Color.Red;
                studentshowstar();
            }

        }

        //Delete Student from database.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = gvStudent.Rows[indexRow];
            if (txtFirstName.Text != "" && txtLastName.Text != "" && cmbGender.Text != "" && txtAddress.Text != ""
                && cmbInstructor.Text != "" && dateTimePicker1.Text != "" && cmbCourse.Text != "")
            {
                if (MessageBox.Show("Delete this record?", "Delete Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
                    == DialogResult.OK)
                {
                    gvStudent.Rows.RemoveAt(indexRow);
                    tabHome.SelectedIndex = 2;
                    clearstudentfield();
                    studenthidestar();
                }
                else
                {
                    lblStudentMessage.Text = "No record to delete!!!";
                    lblStudentMessage.ForeColor = System.Drawing.Color.White;
                    lblStudentMessage.BackColor = System.Drawing.Color.Red;

                }

            }
            else
            {
                lblStudentMessage.Text = "No record to delete!!!";
                lblStudentMessage.ForeColor = System.Drawing.Color.White;
                lblStudentMessage.BackColor = System.Drawing.Color.Red;
            }

        }

        //Clearing the control fields.
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear the field?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clearstudentfield();
                studenthidestar();
                hidestudentbutton();
                btnSave.Show();
            }
        }

        private void tabStudentRegistration_Click(object sender, EventArgs e)
        {

        }

        // Instructor Field Validation. 
        private void txtInstructorFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblMessage.Text = "First name must have letters only!!!";
                lblMessage.ForeColor = System.Drawing.Color.White;
                lblMessage.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void txtInstructorMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblMessage.Text = "Middle name must have letters only!!!";
                lblMessage.ForeColor = System.Drawing.Color.White;
                lblMessage.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void txtInstructorLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInstructorLastName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblMessage.Text = "Last name must have letters only!!!";
                lblMessage.ForeColor = System.Drawing.Color.White;
                lblMessage.BackColor = System.Drawing.Color.Red;
            }
            else { e.Handled = false; }
        }

        private void txtInstructorUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblMessage.Text = "User name must have letters and digits only!!!";
                lblMessage.ForeColor = System.Drawing.Color.White;
                lblMessage.BackColor = System.Drawing.Color.Red;
            }
            else
            { e.Handled = false; }
        }

        private void txtInstructorPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblMessage.Text = "Phone number must have digits only!!!";
                lblMessage.ForeColor = System.Drawing.Color.White;
                lblMessage.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblStudentMessage.Text = "First name must have letters only!!!";
                lblStudentMessage.ForeColor = System.Drawing.Color.White;
                lblStudentMessage.BackColor = System.Drawing.Color.Red;
            }
            else
            { e.Handled = false; }
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblStudentMessage.Text = "Middle name must have letters only!!!";
                lblStudentMessage.ForeColor = System.Drawing.Color.White;
                lblStudentMessage.BackColor = System.Drawing.Color.Red;
            }
            else
            { e.Handled = false; }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblStudentMessage.Text = "Last name must have letters only!!!";
                lblStudentMessage.ForeColor = System.Drawing.Color.White;
                lblStudentMessage.BackColor = System.Drawing.Color.Red;
            }
            else
            { e.Handled = false; }
        }

        private void tabStudentList_Click(object sender, EventArgs e)
        {

        }

        private void gvStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gvStudent.CurrentRow.Index != -1)
            {
                indexRow = gvStudent.CurrentRow.Index;
                DataGridViewRow dataGridViewRow = gvStudent.CurrentRow;
                txtFirstName.Text = dataGridViewRow.Cells[0].Value.ToString();
                txtMiddleName.Text = dataGridViewRow.Cells[1].Value.ToString();
                txtLastName.Text = dataGridViewRow.Cells[2].Value.ToString();
                cmbGender.Text = dataGridViewRow.Cells[3].Value.ToString();
                txtAddress.Text = dataGridViewRow.Cells[4].Value.ToString();
                cmbInstructor.Text = dataGridViewRow.Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridViewRow.Cells[6].Value.ToString();
                cmbCourse.Text = dataGridViewRow.Cells[7].Value.ToString();
                tabHome.SelectedIndex = 4;
                showbuttonstudent();
                btnSave.Hide();
            }
        }

        private void gvInstructor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gvInstructor.CurrentRow.Index != -1)
            {
                indexRow = gvInstructor.CurrentRow.Index;
                DataGridViewRow dataGridViewRow = gvInstructor.CurrentRow;
                txtInstructorFirstName.Text = dataGridViewRow.Cells[0].Value.ToString();
                txtInstructorMiddleName.Text = dataGridViewRow.Cells[1].Value.ToString();
                txtInstructorLastName.Text = dataGridViewRow.Cells[2].Value.ToString();
                cmbInstructorJobType.Text = dataGridViewRow.Cells[3].Value.ToString();
                txtInstructorAddress.Text = dataGridViewRow.Cells[4].Value.ToString();
                txtInstructorPhoneNumber.Text = dataGridViewRow.Cells[5].Value.ToString();
                tabHome.SelectedIndex = 3;
                showbuttoninstructor();
                btnInstructorSave.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "")
            {
                BookLesson bookLesson = new BookLesson();
                bookLesson.Show();
                BookLesson.bookLesson.lablefirstname.Text = txtFirstName.Text;
                BookLesson.bookLesson.lablesurname.Text = txtLastName.Text;
            }
            else if (MessageBox.Show("No Student record selected.", "Select record.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                == DialogResult.OK)
            {
                tabHome.SelectedIndex = 2;
            }

        }

        private void btnProgressTrack_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "")
            {
                /*ProgressCard progressCard = new ProgressCard();
                progressCard.Show();
                ProgressCard.progressCard.firstname.Text = txtFirstName.Text;
                ProgressCard.progressCard.lastname.Text = txtLastName.Text;*/
            }
            else if (MessageBox.Show("No Student selected.", "Select Student.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                == DialogResult.OK)
            {
                tabHome.SelectedIndex = 2;
            }

        }

        private void gvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            Registration_Form registration_Form = new Registration_Form();
            registration_Form.Show();
        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 4;
            clearstudentfield();
            studenthidestar();
            hidestudentbutton();
            btnSave.Show();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 1;
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 3;
            clear();
            hideinstructorbutton();
            dispdgvInstructorRegistration();
            btnInstructorSave.Show();
        }

        private void btnEditInstructor_Click(object sender, EventArgs e)
        {
            tabHome.SelectedIndex = 2;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblHomeAddress_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcometext_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
