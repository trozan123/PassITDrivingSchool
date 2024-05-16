namespace PassItDrivingSchool
{
    partial class Admin_Form
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            toolTipHome = new ToolTip(components);
            gvStudent = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            gvInstructor = new DataGridView();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnProgressTrack = new Button();
            tabStudentRegistration = new TabPage();
            button1 = new Button();
            label12 = new Label();
            label10 = new Label();
            lblStudentMessage = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            cmbCourse = new ComboBox();
            lblCourseChoosen = new Label();
            cmbInstructor = new ComboBox();
            cmbGender = new ComboBox();
            txtAddress = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblEnrollDate = new Label();
            lblInstructor = new Label();
            lblAddress = new Label();
            lblGender = new Label();
            lblLastName = new Label();
            lblMiddleName = new Label();
            lblFirstName = new Label();
            label2 = new Label();
            lblMessage = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabInstructorRegistration = new TabPage();
            btnInstructorUpdate = new Button();
            btnInstructorClear = new Button();
            btnInstructorDelete = new Button();
            btnInstructorSave = new Button();
            cmbInstructorJobType = new ComboBox();
            txtInstructorMiddleName = new TextBox();
            txtInstructorLastName = new TextBox();
            txtInstructorAddress = new TextBox();
            txtInstructorPhoneNumber = new TextBox();
            txtInstructorFirstName = new TextBox();
            lblPhoneNumber = new Label();
            lblInstructorAddredd = new Label();
            lblInstructorJobType = new Label();
            lblInstructorLastName = new Label();
            lblInstructorMiddleName = new Label();
            lblInstructorFirstName = new Label();
            lblLogout = new LinkLabel();
            label9 = new Label();
            lblHomeAddress = new Label();
            tabHome = new TabControl();
            tabAdmin = new TabPage();
            btnAddAdmin = new Button();
            pictureBox1 = new PictureBox();
            lblSchoolName = new Label();
            lblWelcometext = new Label();
            tabStudentList = new TabPage();
            btnStudentSearch = new Button();
            txtStudentSearch = new TextBox();
            tabInstructorList = new TabPage();
            btnSearchInstructor = new Button();
            txtSearchInstructor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gvStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvInstructor).BeginInit();
            tabStudentRegistration.SuspendLayout();
            tabInstructorRegistration.SuspendLayout();
            tabHome.SuspendLayout();
            tabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabStudentList.SuspendLayout();
            tabInstructorList.SuspendLayout();
            SuspendLayout();
            // 
            // toolTipHome
            // 
            toolTipHome.BackColor = Color.FromArgb(191, 209, 92);
            toolTipHome.ForeColor = Color.Red;
            toolTipHome.ShowAlways = true;
            toolTipHome.ToolTipIcon = ToolTipIcon.Info;
            toolTipHome.ToolTipTitle = "Double click to Edit";
            // 
            // gvStudent
            // 
            gvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, Column5, Column7, Column8 });
            gvStudent.Location = new Point(0, 81);
            gvStudent.Name = "gvStudent";
            gvStudent.ReadOnly = true;
            gvStudent.RowHeadersWidth = 62;
            gvStudent.RowTemplate.Height = 25;
            gvStudent.Size = new Size(1228, 406);
            gvStudent.TabIndex = 2;
            toolTipHome.SetToolTip(gvStudent, ".");
            gvStudent.MouseDoubleClick += gvStudent_MouseDoubleClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 150F;
            Column1.HeaderText = "First Name";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.FillWeight = 150F;
            Column2.HeaderText = "Middle Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.FillWeight = 150F;
            Column3.HeaderText = "Last Name";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Gender";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column6
            // 
            Column6.FillWeight = 200F;
            Column6.HeaderText = "Address";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 200;
            // 
            // Column5
            // 
            Column5.FillWeight = 200F;
            Column5.HeaderText = "Instructor";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 200;
            // 
            // Column7
            // 
            Column7.FillWeight = 150F;
            Column7.HeaderText = "Enrolled Date";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.HeaderText = "Course";
            Column8.MinimumWidth = 8;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 150;
            // 
            // gvInstructor
            // 
            gvInstructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInstructor.Columns.AddRange(new DataGridViewColumn[] { Column9, Column10, Column11, Column12, Column13, Column14 });
            gvInstructor.Location = new Point(7, 69);
            gvInstructor.Name = "gvInstructor";
            gvInstructor.RowHeadersWidth = 62;
            gvInstructor.RowTemplate.Height = 25;
            gvInstructor.Size = new Size(1228, 432);
            gvInstructor.TabIndex = 2;
            toolTipHome.SetToolTip(gvInstructor, ".");
            gvInstructor.MouseDoubleClick += gvInstructor_MouseDoubleClick;
            // 
            // Column9
            // 
            Column9.FillWeight = 150F;
            Column9.HeaderText = "First Name";
            Column9.MinimumWidth = 8;
            Column9.Name = "Column9";
            Column9.Width = 150;
            // 
            // Column10
            // 
            Column10.FillWeight = 150F;
            Column10.HeaderText = "Middle Name";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.Width = 150;
            // 
            // Column11
            // 
            Column11.FillWeight = 150F;
            Column11.HeaderText = "Last Name";
            Column11.MinimumWidth = 8;
            Column11.Name = "Column11";
            Column11.Width = 150;
            // 
            // Column12
            // 
            Column12.FillWeight = 150F;
            Column12.HeaderText = "Job Type";
            Column12.MinimumWidth = 8;
            Column12.Name = "Column12";
            Column12.Width = 150;
            // 
            // Column13
            // 
            Column13.FillWeight = 400F;
            Column13.HeaderText = "Address";
            Column13.MinimumWidth = 8;
            Column13.Name = "Column13";
            Column13.Width = 400;
            // 
            // Column14
            // 
            Column14.FillWeight = 200F;
            Column14.HeaderText = "Phone Number";
            Column14.MinimumWidth = 8;
            Column14.Name = "Column14";
            Column14.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(513, 156);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 29;
            // 
            // btnProgressTrack
            // 
            btnProgressTrack.BackColor = Color.LimeGreen;
            btnProgressTrack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnProgressTrack.ForeColor = SystemColors.ButtonFace;
            btnProgressTrack.Location = new Point(882, 450);
            btnProgressTrack.Margin = new Padding(4);
            btnProgressTrack.Name = "btnProgressTrack";
            btnProgressTrack.Size = new Size(237, 62);
            btnProgressTrack.TabIndex = 36;
            btnProgressTrack.Text = "View Progress";
            btnProgressTrack.UseVisualStyleBackColor = false;
            btnProgressTrack.Click += btnProgressTrack_Click;
            // 
            // tabStudentRegistration
            // 
            tabStudentRegistration.BackColor = Color.LightGreen;
            tabStudentRegistration.Controls.Add(btnProgressTrack);
            tabStudentRegistration.Controls.Add(button1);
            tabStudentRegistration.Controls.Add(label12);
            tabStudentRegistration.Controls.Add(label10);
            tabStudentRegistration.Controls.Add(lblStudentMessage);
            tabStudentRegistration.Controls.Add(label11);
            tabStudentRegistration.Controls.Add(label8);
            tabStudentRegistration.Controls.Add(label7);
            tabStudentRegistration.Controls.Add(label6);
            tabStudentRegistration.Controls.Add(btnUpdate);
            tabStudentRegistration.Controls.Add(btnClear);
            tabStudentRegistration.Controls.Add(btnDelete);
            tabStudentRegistration.Controls.Add(btnSave);
            tabStudentRegistration.Controls.Add(dateTimePicker1);
            tabStudentRegistration.Controls.Add(cmbCourse);
            tabStudentRegistration.Controls.Add(lblCourseChoosen);
            tabStudentRegistration.Controls.Add(cmbInstructor);
            tabStudentRegistration.Controls.Add(cmbGender);
            tabStudentRegistration.Controls.Add(txtAddress);
            tabStudentRegistration.Controls.Add(txtMiddleName);
            tabStudentRegistration.Controls.Add(txtLastName);
            tabStudentRegistration.Controls.Add(txtFirstName);
            tabStudentRegistration.Controls.Add(lblEnrollDate);
            tabStudentRegistration.Controls.Add(lblInstructor);
            tabStudentRegistration.Controls.Add(lblAddress);
            tabStudentRegistration.Controls.Add(lblGender);
            tabStudentRegistration.Controls.Add(lblLastName);
            tabStudentRegistration.Controls.Add(lblMiddleName);
            tabStudentRegistration.Controls.Add(lblFirstName);
            tabStudentRegistration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tabStudentRegistration.Location = new Point(4, 29);
            tabStudentRegistration.Margin = new Padding(4);
            tabStudentRegistration.Name = "tabStudentRegistration";
            tabStudentRegistration.Padding = new Padding(4);
            tabStudentRegistration.Size = new Size(1253, 537);
            tabStudentRegistration.TabIndex = 0;
            tabStudentRegistration.Text = "Register Student";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(659, 450);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(194, 62);
            button1.TabIndex = 35;
            button1.Text = "Book Lesson";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(1155, 327);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(0, 28);
            label12.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(1155, 250);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 28);
            label10.TabIndex = 33;
            // 
            // lblStudentMessage
            // 
            lblStudentMessage.AutoSize = true;
            lblStudentMessage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStudentMessage.Location = new Point(178, 401);
            lblStudentMessage.Margin = new Padding(4, 0, 4, 0);
            lblStudentMessage.Name = "lblStudentMessage";
            lblStudentMessage.Size = new Size(0, 28);
            lblStudentMessage.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(536, 250);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 28);
            label11.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(1155, 165);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 28);
            label8.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(536, 165);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(536, 77);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 21;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(176, 450);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 62);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(498, 450);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 62);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Tomato;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(345, 450);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 62);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(13, 450);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 62);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd-mm-yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(174, 321);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 34);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.Value = new DateTime(2024, 5, 11, 0, 0, 0, 0);
            // 
            // cmbCourse
            // 
            cmbCourse.Font = new Font("Segoe UI", 12F);
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Introductary", "Standard", "Pass Plus", "Driving Test" });
            cmbCourse.Location = new Point(792, 312);
            cmbCourse.Margin = new Padding(4);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(350, 36);
            cmbCourse.TabIndex = 14;
            // 
            // lblCourseChoosen
            // 
            lblCourseChoosen.AutoSize = true;
            lblCourseChoosen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCourseChoosen.Location = new Point(622, 323);
            lblCourseChoosen.Margin = new Padding(4, 0, 4, 0);
            lblCourseChoosen.Name = "lblCourseChoosen";
            lblCourseChoosen.Size = new Size(75, 28);
            lblCourseChoosen.TabIndex = 13;
            lblCourseChoosen.Text = "Course";
            // 
            // cmbInstructor
            // 
            cmbInstructor.Font = new Font("Segoe UI", 12F);
            cmbInstructor.FormattingEnabled = true;
            cmbInstructor.Items.AddRange(new object[] { "Trozan Sapkota", "Alex Sterling", "Phil Foden", "Cole Palmer Haaland" });
            cmbInstructor.Location = new Point(792, 232);
            cmbInstructor.Margin = new Padding(4);
            cmbInstructor.Name = "cmbInstructor";
            cmbInstructor.Size = new Size(350, 36);
            cmbInstructor.TabIndex = 12;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F);
            cmbGender.FormattingEnabled = true;
            cmbGender.ImeMode = ImeMode.NoControl;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(792, 153);
            cmbGender.Margin = new Padding(4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(350, 36);
            cmbGender.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F);
            txtAddress.Location = new Point(792, 81);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(350, 34);
            txtAddress.TabIndex = 10;
            txtAddress.KeyPress += txtLastName_KeyPress;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 12F);
            txtMiddleName.Location = new Point(178, 148);
            txtMiddleName.Margin = new Padding(4);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(350, 34);
            txtMiddleName.TabIndex = 9;
            txtMiddleName.KeyPress += txtMiddleName_KeyPress;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.Location = new Point(178, 245);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(350, 34);
            txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.Location = new Point(174, 76);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(350, 34);
            txtFirstName.TabIndex = 7;
            txtFirstName.KeyPress += txtFirstName_KeyPress;
            // 
            // lblEnrollDate
            // 
            lblEnrollDate.AutoSize = true;
            lblEnrollDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEnrollDate.Location = new Point(4, 336);
            lblEnrollDate.Margin = new Padding(4, 0, 4, 0);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(134, 28);
            lblEnrollDate.TabIndex = 6;
            lblEnrollDate.Text = "Enrolled Date";
            // 
            // lblInstructor
            // 
            lblInstructor.AutoSize = true;
            lblInstructor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblInstructor.Location = new Point(622, 245);
            lblInstructor.Margin = new Padding(4, 0, 4, 0);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(100, 28);
            lblInstructor.TabIndex = 5;
            lblInstructor.Text = "Instructor";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAddress.Location = new Point(622, 87);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(85, 28);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblGender.Location = new Point(622, 166);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(79, 28);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblLastName.Location = new Point(17, 246);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(108, 28);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMiddleName.Location = new Point(8, 154);
            lblMiddleName.Margin = new Padding(4, 0, 4, 0);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(135, 28);
            lblMiddleName.TabIndex = 1;
            lblMiddleName.Text = "Middle Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFirstName.Location = new Point(13, 80);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(110, 28);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(513, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 19;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(136, 299);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(1122, 160);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(1122, 250);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(513, 244);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 20;
            // 
            // tabInstructorRegistration
            // 
            tabInstructorRegistration.BackColor = Color.LightGreen;
            tabInstructorRegistration.Controls.Add(label1);
            tabInstructorRegistration.Controls.Add(lblMessage);
            tabInstructorRegistration.Controls.Add(label5);
            tabInstructorRegistration.Controls.Add(label4);
            tabInstructorRegistration.Controls.Add(label3);
            tabInstructorRegistration.Controls.Add(label2);
            tabInstructorRegistration.Controls.Add(btnInstructorUpdate);
            tabInstructorRegistration.Controls.Add(btnInstructorClear);
            tabInstructorRegistration.Controls.Add(btnInstructorDelete);
            tabInstructorRegistration.Controls.Add(btnInstructorSave);
            tabInstructorRegistration.Controls.Add(cmbInstructorJobType);
            tabInstructorRegistration.Controls.Add(txtInstructorMiddleName);
            tabInstructorRegistration.Controls.Add(txtInstructorLastName);
            tabInstructorRegistration.Controls.Add(txtInstructorAddress);
            tabInstructorRegistration.Controls.Add(txtInstructorPhoneNumber);
            tabInstructorRegistration.Controls.Add(txtInstructorFirstName);
            tabInstructorRegistration.Controls.Add(lblPhoneNumber);
            tabInstructorRegistration.Controls.Add(lblInstructorAddredd);
            tabInstructorRegistration.Controls.Add(lblInstructorJobType);
            tabInstructorRegistration.Controls.Add(lblInstructorLastName);
            tabInstructorRegistration.Controls.Add(lblInstructorMiddleName);
            tabInstructorRegistration.Controls.Add(lblInstructorFirstName);
            tabInstructorRegistration.Location = new Point(4, 29);
            tabInstructorRegistration.Margin = new Padding(4);
            tabInstructorRegistration.Name = "tabInstructorRegistration";
            tabInstructorRegistration.Padding = new Padding(4);
            tabInstructorRegistration.Size = new Size(1253, 537);
            tabInstructorRegistration.TabIndex = 2;
            tabInstructorRegistration.Text = "Register Instructor";
            // 
            // btnInstructorUpdate
            // 
            btnInstructorUpdate.BackColor = Color.Yellow;
            btnInstructorUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnInstructorUpdate.Location = new Point(407, 352);
            btnInstructorUpdate.Margin = new Padding(4);
            btnInstructorUpdate.Name = "btnInstructorUpdate";
            btnInstructorUpdate.Size = new Size(111, 50);
            btnInstructorUpdate.TabIndex = 16;
            btnInstructorUpdate.Text = "Update";
            btnInstructorUpdate.UseVisualStyleBackColor = false;
            btnInstructorUpdate.Click += btnInstructorUpdate_Click;
            // 
            // btnInstructorClear
            // 
            btnInstructorClear.BackColor = Color.White;
            btnInstructorClear.ForeColor = SystemColors.ActiveCaptionText;
            btnInstructorClear.Location = new Point(763, 352);
            btnInstructorClear.Margin = new Padding(4);
            btnInstructorClear.Name = "btnInstructorClear";
            btnInstructorClear.Size = new Size(111, 50);
            btnInstructorClear.TabIndex = 15;
            btnInstructorClear.Text = "Clear";
            btnInstructorClear.UseVisualStyleBackColor = false;
            btnInstructorClear.Click += btnInstructorClear_Click;
            // 
            // btnInstructorDelete
            // 
            btnInstructorDelete.BackColor = Color.Red;
            btnInstructorDelete.ForeColor = SystemColors.ButtonFace;
            btnInstructorDelete.Location = new Point(585, 352);
            btnInstructorDelete.Margin = new Padding(4);
            btnInstructorDelete.Name = "btnInstructorDelete";
            btnInstructorDelete.Size = new Size(111, 50);
            btnInstructorDelete.TabIndex = 14;
            btnInstructorDelete.Text = "Delete";
            btnInstructorDelete.UseVisualStyleBackColor = false;
            btnInstructorDelete.Click += btnInstructorDelete_Click;
            // 
            // btnInstructorSave
            // 
            btnInstructorSave.BackColor = Color.Green;
            btnInstructorSave.ForeColor = SystemColors.ButtonFace;
            btnInstructorSave.Location = new Point(229, 352);
            btnInstructorSave.Margin = new Padding(4);
            btnInstructorSave.Name = "btnInstructorSave";
            btnInstructorSave.Size = new Size(111, 50);
            btnInstructorSave.TabIndex = 13;
            btnInstructorSave.Text = "Save";
            btnInstructorSave.UseVisualStyleBackColor = false;
            btnInstructorSave.Click += btnInstructorSave_Click;
            // 
            // cmbInstructorJobType
            // 
            cmbInstructorJobType.FormattingEnabled = true;
            cmbInstructorJobType.Items.AddRange(new object[] { "Full Time", "Part Time" });
            cmbInstructorJobType.Location = new Point(788, 153);
            cmbInstructorJobType.Margin = new Padding(4);
            cmbInstructorJobType.Name = "cmbInstructorJobType";
            cmbInstructorJobType.Size = new Size(369, 28);
            cmbInstructorJobType.TabIndex = 11;
            // 
            // txtInstructorMiddleName
            // 
            txtInstructorMiddleName.Location = new Point(178, 161);
            txtInstructorMiddleName.Margin = new Padding(4);
            txtInstructorMiddleName.Name = "txtInstructorMiddleName";
            txtInstructorMiddleName.Size = new Size(369, 27);
            txtInstructorMiddleName.TabIndex = 10;
            txtInstructorMiddleName.KeyPress += txtInstructorMiddleName_KeyPress;
            // 
            // txtInstructorLastName
            // 
            txtInstructorLastName.Location = new Point(178, 251);
            txtInstructorLastName.Margin = new Padding(4);
            txtInstructorLastName.Name = "txtInstructorLastName";
            txtInstructorLastName.Size = new Size(369, 27);
            txtInstructorLastName.TabIndex = 9;
            // 
            // txtInstructorAddress
            // 
            txtInstructorAddress.Location = new Point(788, 64);
            txtInstructorAddress.Margin = new Padding(4);
            txtInstructorAddress.Name = "txtInstructorAddress";
            txtInstructorAddress.Size = new Size(369, 27);
            txtInstructorAddress.TabIndex = 8;
            txtInstructorAddress.KeyPress += txtInstructorLastName_KeyPress;
            // 
            // txtInstructorPhoneNumber
            // 
            txtInstructorPhoneNumber.Location = new Point(788, 243);
            txtInstructorPhoneNumber.Margin = new Padding(4);
            txtInstructorPhoneNumber.Name = "txtInstructorPhoneNumber";
            txtInstructorPhoneNumber.Size = new Size(369, 27);
            txtInstructorPhoneNumber.TabIndex = 7;
            txtInstructorPhoneNumber.KeyPress += txtInstructorPhoneNumber_KeyPress;
            // 
            // txtInstructorFirstName
            // 
            txtInstructorFirstName.Location = new Point(178, 75);
            txtInstructorFirstName.Margin = new Padding(4);
            txtInstructorFirstName.Name = "txtInstructorFirstName";
            txtInstructorFirstName.Size = new Size(369, 27);
            txtInstructorFirstName.TabIndex = 6;
            txtInstructorFirstName.KeyPress += txtInstructorFirstName_KeyPress;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPhoneNumber.Location = new Point(600, 247);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(152, 28);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblInstructorAddredd
            // 
            lblInstructorAddredd.AutoSize = true;
            lblInstructorAddredd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblInstructorAddredd.Location = new Point(600, 67);
            lblInstructorAddredd.Margin = new Padding(4, 0, 4, 0);
            lblInstructorAddredd.Name = "lblInstructorAddredd";
            lblInstructorAddredd.Size = new Size(85, 28);
            lblInstructorAddredd.TabIndex = 4;
            lblInstructorAddredd.Text = "Address";
            // 
            // lblInstructorJobType
            // 
            lblInstructorJobType.AutoSize = true;
            lblInstructorJobType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblInstructorJobType.Location = new Point(600, 154);
            lblInstructorJobType.Margin = new Padding(4, 0, 4, 0);
            lblInstructorJobType.Name = "lblInstructorJobType";
            lblInstructorJobType.Size = new Size(93, 28);
            lblInstructorJobType.TabIndex = 3;
            lblInstructorJobType.Text = "Job Type";
            // 
            // lblInstructorLastName
            // 
            lblInstructorLastName.AutoSize = true;
            lblInstructorLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblInstructorLastName.Location = new Point(12, 247);
            lblInstructorLastName.Margin = new Padding(4, 0, 4, 0);
            lblInstructorLastName.Name = "lblInstructorLastName";
            lblInstructorLastName.Size = new Size(108, 28);
            lblInstructorLastName.TabIndex = 2;
            lblInstructorLastName.Text = "Last Name";
            // 
            // lblInstructorMiddleName
            // 
            lblInstructorMiddleName.AutoSize = true;
            lblInstructorMiddleName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblInstructorMiddleName.Location = new Point(12, 157);
            lblInstructorMiddleName.Margin = new Padding(4, 0, 4, 0);
            lblInstructorMiddleName.Name = "lblInstructorMiddleName";
            lblInstructorMiddleName.Size = new Size(135, 28);
            lblInstructorMiddleName.TabIndex = 1;
            lblInstructorMiddleName.Text = "Middle Name";
            // 
            // lblInstructorFirstName
            // 
            lblInstructorFirstName.AutoSize = true;
            lblInstructorFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblInstructorFirstName.Location = new Point(12, 71);
            lblInstructorFirstName.Margin = new Padding(4, 0, 4, 0);
            lblInstructorFirstName.Name = "lblInstructorFirstName";
            lblInstructorFirstName.Size = new Size(110, 28);
            lblInstructorFirstName.TabIndex = 0;
            lblInstructorFirstName.Text = "First Name";
            // 
            // lblLogout
            // 
            lblLogout.ActiveLinkColor = Color.Red;
            lblLogout.AutoSize = true;
            lblLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLogout.LinkColor = Color.Red;
            lblLogout.Location = new Point(627, 238);
            lblLogout.Margin = new Padding(4, 0, 4, 0);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(84, 28);
            lblLogout.TabIndex = 5;
            lblLogout.TabStop = true;
            lblLogout.Text = "Log out";
            lblLogout.LinkClicked += lblLogout_LinkClicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label9.Location = new Point(152, 181);
            label9.Name = "label9";
            label9.Size = new Size(0, 28);
            label9.TabIndex = 10;
            // 
            // lblHomeAddress
            // 
            lblHomeAddress.AutoSize = true;
            lblHomeAddress.Location = new Point(165, 123);
            lblHomeAddress.Name = "lblHomeAddress";
            lblHomeAddress.Size = new Size(178, 20);
            lblHomeAddress.TabIndex = 9;
            lblHomeAddress.Text = "Oxford Street, London UK";
            // 
            // tabHome
            // 
            tabHome.Controls.Add(tabAdmin);
            tabHome.Controls.Add(tabStudentList);
            tabHome.Controls.Add(tabInstructorList);
            tabHome.Controls.Add(tabInstructorRegistration);
            tabHome.Controls.Add(tabStudentRegistration);
            tabHome.Location = new Point(1, 15);
            tabHome.Margin = new Padding(4);
            tabHome.Name = "tabHome";
            tabHome.SelectedIndex = 0;
            tabHome.Size = new Size(1261, 570);
            tabHome.TabIndex = 4;
            // 
            // tabAdmin
            // 
            tabAdmin.BackColor = Color.LightGreen;
            tabAdmin.Controls.Add(lblLogout);
            tabAdmin.Controls.Add(label9);
            tabAdmin.Controls.Add(lblHomeAddress);
            tabAdmin.Controls.Add(btnAddAdmin);
            tabAdmin.Controls.Add(pictureBox1);
            tabAdmin.Controls.Add(lblSchoolName);
            tabAdmin.Controls.Add(lblWelcometext);
            tabAdmin.Location = new Point(4, 29);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(1253, 537);
            tabAdmin.TabIndex = 4;
            tabAdmin.Text = "Home";
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.Green;
            btnAddAdmin.ForeColor = SystemColors.Control;
            btnAddAdmin.Location = new Point(564, 175);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(241, 51);
            btnAddAdmin.TabIndex = 3;
            btnAddAdmin.Text = "Add Admin";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(441, 339);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblSchoolName
            // 
            lblSchoolName.AutoSize = true;
            lblSchoolName.Font = new Font("Arial Black", 20.25F, FontStyle.Bold);
            lblSchoolName.Location = new Point(46, 38);
            lblSchoolName.Name = "lblSchoolName";
            lblSchoolName.Size = new Size(507, 48);
            lblSchoolName.TabIndex = 1;
            lblSchoolName.Text = "PASS IT DRIVING SCHOOL";
            // 
            // lblWelcometext
            // 
            lblWelcometext.AutoSize = true;
            lblWelcometext.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            lblWelcometext.Location = new Point(225, 13);
            lblWelcometext.Name = "lblWelcometext";
            lblWelcometext.Size = new Size(0, 29);
            lblWelcometext.TabIndex = 0;
            // 
            // tabStudentList
            // 
            tabStudentList.BackColor = Color.LightGreen;
            tabStudentList.Controls.Add(gvStudent);
            tabStudentList.Controls.Add(btnStudentSearch);
            tabStudentList.Controls.Add(txtStudentSearch);
            tabStudentList.Location = new Point(4, 29);
            tabStudentList.Margin = new Padding(4);
            tabStudentList.Name = "tabStudentList";
            tabStudentList.Padding = new Padding(4);
            tabStudentList.Size = new Size(1253, 537);
            tabStudentList.TabIndex = 1;
            tabStudentList.Text = "Students";
            // 
            // btnStudentSearch
            // 
            btnStudentSearch.Location = new Point(1135, 20);
            btnStudentSearch.Name = "btnStudentSearch";
            btnStudentSearch.Size = new Size(104, 40);
            btnStudentSearch.TabIndex = 1;
            btnStudentSearch.Text = "Search";
            btnStudentSearch.UseVisualStyleBackColor = true;
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.Location = new Point(909, 21);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.Size = new Size(220, 27);
            txtStudentSearch.TabIndex = 0;
            // 
            // tabInstructorList
            // 
            tabInstructorList.BackColor = Color.LightGreen;
            tabInstructorList.Controls.Add(gvInstructor);
            tabInstructorList.Controls.Add(btnSearchInstructor);
            tabInstructorList.Controls.Add(txtSearchInstructor);
            tabInstructorList.Location = new Point(4, 29);
            tabInstructorList.Margin = new Padding(4);
            tabInstructorList.Name = "tabInstructorList";
            tabInstructorList.Padding = new Padding(4);
            tabInstructorList.Size = new Size(1253, 537);
            tabInstructorList.TabIndex = 3;
            tabInstructorList.Text = "Instructors";
            // 
            // btnSearchInstructor
            // 
            btnSearchInstructor.Location = new Point(1104, 20);
            btnSearchInstructor.Name = "btnSearchInstructor";
            btnSearchInstructor.Size = new Size(129, 43);
            btnSearchInstructor.TabIndex = 1;
            btnSearchInstructor.Text = "Search";
            btnSearchInstructor.UseVisualStyleBackColor = true;
            btnSearchInstructor.Click += btnInstructorSearch_Click;
            // 
            // txtSearchInstructor
            // 
            txtSearchInstructor.Location = new Point(888, 23);
            txtSearchInstructor.Name = "txtSearchInstructor";
            txtSearchInstructor.Size = new Size(210, 27);
            txtSearchInstructor.TabIndex = 0;
            // 
            // Admin_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1275, 601);
            Controls.Add(tabHome);
            Name = "Admin_Form";
            Text = "Admin_Form";
            Load += Admin_Form_Load;
            ((System.ComponentModel.ISupportInitialize)gvStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvInstructor).EndInit();
            tabStudentRegistration.ResumeLayout(false);
            tabStudentRegistration.PerformLayout();
            tabInstructorRegistration.ResumeLayout(false);
            tabInstructorRegistration.PerformLayout();
            tabHome.ResumeLayout(false);
            tabAdmin.ResumeLayout(false);
            tabAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabStudentList.ResumeLayout(false);
            tabStudentList.PerformLayout();
            tabInstructorList.ResumeLayout(false);
            tabInstructorList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnProgressTrack;
        private TabPage tabStudentRegistration;
        private Button button1;
        private Label label12;
        private Label label10;
        private Label lblStudentMessage;
        private Label label11;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbCourse;
        private Label lblCourseChoosen;
        private ComboBox cmbInstructor;
        private ComboBox cmbGender;
        private TextBox txtAddress;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblEnrollDate;
        private Label lblInstructor;
        private Label lblAddress;
        private Label lblGender;
        private Label lblLastName;
        private Label lblMiddleName;
        private Label lblFirstName;
        private Label label2;
        private Label lblMessage;
        private Label label5;
        private Label label4;
        private Label label3;
        private TabPage tabInstructorRegistration;
        private Button btnInstructorUpdate;
        private Button btnInstructorClear;
        private Button btnInstructorDelete;
        private Button btnInstructorSave;
        private ComboBox cmbInstructorJobType;
        private TextBox txtInstructorMiddleName;
        private TextBox txtInstructorLastName;
        private TextBox txtInstructorAddress;
        private TextBox txtInstructorPhoneNumber;
        private TextBox txtInstructorFirstName;
        private Label lblPhoneNumber;
        private Label lblInstructorAddredd;
        private Label lblInstructorJobType;
        private Label lblInstructorLastName;
        private Label lblInstructorMiddleName;
        private Label lblInstructorFirstName;
        private LinkLabel lblLogout;
        private Label label9;
        private Label lblHomeAddress;
        private TabControl tabHome;
        private TabPage tabAdmin;
        private Button btnAddAdmin;
        private PictureBox pictureBox1;
        private Label lblSchoolName;
        private Label lblWelcometext;
        private TabPage tabStudentList;
        private DataGridView gvStudent;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button btnStudentSearch;
        private TextBox txtStudentSearch;
        private TabPage tabInstructorList;
        private DataGridView gvInstructor;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private Button btnSearchInstructor;
        private TextBox txtSearchInstructor;
        private ToolTip toolTipHome;
    }
}