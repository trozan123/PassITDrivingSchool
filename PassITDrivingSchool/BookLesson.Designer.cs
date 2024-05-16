namespace PassItDrivingSchool
{
    partial class BookLesson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gvBookLesson = new DataGridView();
            Booking_Date = new DataGridViewTextBoxColumn();
            Time_Duration = new DataGridViewTextBoxColumn();
            btnCancle = new Button();
            btnSave = new Button();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            lalblTimeDuration = new Label();
            lblDate = new Label();
            lblLBLastnameDisplay = new Label();
            lblLBNameDisplay = new Label();
            lblLBName = new Label();
            ((System.ComponentModel.ISupportInitialize)gvBookLesson).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // gvBookLesson
            // 
            gvBookLesson.BackgroundColor = SystemColors.AppWorkspace;
            gvBookLesson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvBookLesson.Columns.AddRange(new DataGridViewColumn[] { Booking_Date, Time_Duration });
            gvBookLesson.GridColor = SystemColors.ActiveCaption;
            gvBookLesson.Location = new Point(437, 81);
            gvBookLesson.Margin = new Padding(3, 4, 3, 4);
            gvBookLesson.Name = "gvBookLesson";
            gvBookLesson.RowHeadersWidth = 62;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            gvBookLesson.RowsDefaultCellStyle = dataGridViewCellStyle1;
            gvBookLesson.RowTemplate.Height = 25;
            gvBookLesson.Size = new Size(393, 288);
            gvBookLesson.TabIndex = 19;
            gvBookLesson.MouseDoubleClick += gvBookLesson_MouseDoubleClick;
            // 
            // Booking_Date
            // 
            Booking_Date.HeaderText = "Booking Date";
            Booking_Date.MinimumWidth = 8;
            Booking_Date.Name = "Booking_Date";
            Booking_Date.Width = 200;
            // 
            // Time_Duration
            // 
            Time_Duration.HeaderText = "Time Duration";
            Time_Duration.MinimumWidth = 8;
            Time_Duration.Name = "Time_Duration";
            Time_Duration.Width = 150;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.Red;
            btnCancle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCancle.ForeColor = Color.White;
            btnCancle.Location = new Point(151, 303);
            btnCancle.Margin = new Padding(3, 4, 3, 4);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(129, 54);
            btnCancle.TabIndex = 18;
            btnCancle.Text = "Cancel";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(12, 303);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 54);
            btnSave.TabIndex = 17;
            btnSave.Text = "Book";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            numericUpDown1.Location = new Point(150, 227);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(240, 34);
            numericUpDown1.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(150, 165);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(239, 34);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Value = new DateTime(2023, 10, 1, 0, 0, 0, 0);
            // 
            // lalblTimeDuration
            // 
            lalblTimeDuration.AutoSize = true;
            lalblTimeDuration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lalblTimeDuration.ForeColor = Color.Black;
            lalblTimeDuration.Location = new Point(12, 227);
            lalblTimeDuration.Name = "lalblTimeDuration";
            lalblTimeDuration.Size = new Size(142, 28);
            lalblTimeDuration.TabIndex = 14;
            lalblTimeDuration.Text = "Time Duration";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(12, 165);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(114, 28);
            lblDate.TabIndex = 13;
            lblDate.Text = "Select Date";
            // 
            // lblLBLastnameDisplay
            // 
            lblLBLastnameDisplay.AutoSize = true;
            lblLBLastnameDisplay.Font = new Font("Segoe UI", 12F);
            lblLBLastnameDisplay.ForeColor = Color.Black;
            lblLBLastnameDisplay.Location = new Point(88, 123);
            lblLBLastnameDisplay.Name = "lblLBLastnameDisplay";
            lblLBLastnameDisplay.Size = new Size(0, 28);
            lblLBLastnameDisplay.TabIndex = 12;
            // 
            // lblLBNameDisplay
            // 
            lblLBNameDisplay.AutoSize = true;
            lblLBNameDisplay.Font = new Font("Segoe UI", 12F);
            lblLBNameDisplay.ForeColor = Color.Black;
            lblLBNameDisplay.Location = new Point(88, 81);
            lblLBNameDisplay.Name = "lblLBNameDisplay";
            lblLBNameDisplay.Size = new Size(0, 28);
            lblLBNameDisplay.TabIndex = 11;
            // 
            // lblLBName
            // 
            lblLBName.AutoSize = true;
            lblLBName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLBName.ForeColor = Color.Black;
            lblLBName.Location = new Point(12, 81);
            lblLBName.Name = "lblLBName";
            lblLBName.Size = new Size(77, 28);
            lblLBName.TabIndex = 10;
            lblLBName.Text = "Name :";
            // 
            // BookLesson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(843, 401);
            Controls.Add(gvBookLesson);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lalblTimeDuration);
            Controls.Add(lblDate);
            Controls.Add(lblLBLastnameDisplay);
            Controls.Add(lblLBNameDisplay);
            Controls.Add(lblLBName);
            Name = "BookLesson";
            Text = "BookLesson";
            Load += BookLesson_Load;
            ((System.ComponentModel.ISupportInitialize)gvBookLesson).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvBookLesson;
        private DataGridViewTextBoxColumn Booking_Date;
        private DataGridViewTextBoxColumn Time_Duration;
        private Button btnCancle;
        private Button btnSave;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Label lalblTimeDuration;
        private Label lblDate;
        private Label lblLBLastnameDisplay;
        private Label lblLBNameDisplay;
        private Label lblLBName;
    }
}