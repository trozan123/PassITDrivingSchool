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
    public partial class BookLesson : Form
    {

        public static BookLesson bookLesson;
        public Label lablefirstname, lablesurname;
        public BookLesson()
        {
            InitializeComponent();
            bookLesson = this;
            lablefirstname = lblLBNameDisplay;
            lablesurname = lblLBLastnameDisplay;
        }

        int indexRow;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Record Saved successfully!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                gvBookLesson.Rows.Add(dateTimePicker1.Text, numericUpDown1.Text);

            }
            btnCancle.Hide();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = gvBookLesson.Rows[indexRow];

            if (newDataRow != null)
            {
                if (dateTimePicker1.Value > DateTime.Now)
                {
                    if (MessageBox.Show("Cancle this booking?", "Cancle Booking", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
                  == DialogResult.OK)
                    {
                        gvBookLesson.Rows.RemoveAt(indexRow);
                    }
                }
                else
                {
                    MessageBox.Show("Select a date.", "Select Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                MessageBox.Show("Select a date.", "Select Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnCancle.Hide();

        }

        private void BookLesson_Load(object sender, EventArgs e)
        {
            btnCancle.Hide();
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void gvBookLesson_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gvBookLesson.CurrentRow.Index != 0)
            {
                indexRow = gvBookLesson.CurrentRow.Index;
                DataGridViewRow dataGridViewRow = gvBookLesson.CurrentRow;
                dateTimePicker1.Text = dataGridViewRow.Cells[0].Value.ToString();
                numericUpDown1.Text = dataGridViewRow.Cells[1].Value.ToString();
                btnCancle.Show();
            }
            else
            {
                MessageBox.Show("This date is already gone. Cannot cancel this record!!", "Cancel Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
