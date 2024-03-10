namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDepartment = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtPhone = new TextBox();
            addressBox = new TextBox();
            panel2 = new Panel();
            label8 = new Label();
            panel3 = new Panel();
            btnOhsYes = new RadioButton();
            btnOHSNo = new RadioButton();
            label9 = new Label();
            label10 = new Label();
            militarySBox = new CheckBox();
            fLanguageBox = new CheckBox();
            btnNew = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            childNum = new NumericUpDown();
            panel4 = new Panel();
            panel5 = new Panel();
            btnMasteryNo = new RadioButton();
            btnMasteryYes = new RadioButton();
            btnSave = new Button();
            lblPerson = new Label();
            personelList = new ListBox();
            panel6 = new Panel();
            label11 = new Label();
            info = new Label();
            errPro = new ErrorProvider(components);
            timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)childNum).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errPro).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(146, 30);
            label1.Name = "label1";
            label1.Size = new Size(456, 45);
            label1.TabIndex = 1;
            label1.Text = "Employee Tracking Application";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(21, 144);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(21, 182);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(21, 222);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(21, 258);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // txtDepartment
            // 
            txtDepartment.FormattingEnabled = true;
            txtDepartment.Items.AddRange(new object[] { "Human Resources", "Finance", "Marketing", "Sales", "Research and Development", "Customer Service", "Information Technology (IT)", "Operations", "Legal", "Administration" });
            txtDepartment.Location = new Point(121, 329);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(149, 23);
            txtDepartment.TabIndex = 5;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(21, 332);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 6;
            label6.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(21, 393);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 7;
            label7.Text = "Start day of work";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Location = new Point(121, 385);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(121, 136);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 23);
            txtName.TabIndex = 9;
            txtName.Validating += txtName_Validating;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(121, 174);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(149, 23);
            txtSurname.TabIndex = 10;
            txtSurname.Validating += txtSurname_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(121, 214);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(149, 23);
            txtPhone.TabIndex = 11;
            // 
            // addressBox
            // 
            addressBox.Location = new Point(121, 250);
            addressBox.Multiline = true;
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(149, 68);
            addressBox.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Location = new Point(21, 461);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 10);
            panel2.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(21, 433);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 14;
            label8.Text = "Num. of Children";
            // 
            // panel3
            // 
            panel3.Location = new Point(21, 554);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 10);
            panel3.TabIndex = 17;
            // 
            // btnOhsYes
            // 
            btnOhsYes.AutoSize = true;
            btnOhsYes.Location = new Point(20, 9);
            btnOhsYes.Name = "btnOhsYes";
            btnOhsYes.Size = new Size(42, 19);
            btnOhsYes.TabIndex = 19;
            btnOhsYes.TabStop = true;
            btnOhsYes.Text = "Yes";
            btnOhsYes.UseVisualStyleBackColor = true;
            // 
            // btnOHSNo
            // 
            btnOHSNo.AutoSize = true;
            btnOHSNo.Location = new Point(73, 9);
            btnOHSNo.Name = "btnOHSNo";
            btnOHSNo.Size = new Size(41, 19);
            btnOHSNo.TabIndex = 22;
            btnOHSNo.TabStop = true;
            btnOHSNo.Text = "No";
            btnOHSNo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 578);
            label9.Name = "label9";
            label9.Size = new Size(152, 15);
            label9.TabIndex = 23;
            label9.Text = "OHS Training is completed?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 606);
            label10.Name = "label10";
            label10.Size = new Size(163, 15);
            label10.TabIndex = 24;
            label10.Text = "Is There a Mastery Certificate?";
            // 
            // militarySBox
            // 
            militarySBox.AutoSize = true;
            militarySBox.Location = new Point(22, 495);
            militarySBox.Name = "militarySBox";
            militarySBox.Size = new Size(158, 19);
            militarySBox.TabIndex = 25;
            militarySBox.Text = "Military service was done";
            militarySBox.UseVisualStyleBackColor = true;
            // 
            // fLanguageBox
            // 
            fLanguageBox.AutoSize = true;
            fLanguageBox.Location = new Point(22, 520);
            fLanguageBox.Name = "fLanguageBox";
            fLanguageBox.Size = new Size(197, 19);
            fLanguageBox.TabIndex = 26;
            fLanguageBox.Text = "Does it have a foreign language?";
            fLanguageBox.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(30, 700);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(109, 48);
            btnNew.TabIndex = 27;
            btnNew.Text = "New Record";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 700);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 48);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(324, 700);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 48);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // childNum
            // 
            childNum.Location = new Point(121, 425);
            childNum.Name = "childNum";
            childNum.Size = new Size(149, 23);
            childNum.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnOHSNo);
            panel4.Controls.Add(btnOhsYes);
            panel4.Location = new Point(183, 568);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 31);
            panel4.TabIndex = 31;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnMasteryNo);
            panel5.Controls.Add(btnMasteryYes);
            panel5.Location = new Point(183, 597);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 31);
            panel5.TabIndex = 32;
            // 
            // btnMasteryNo
            // 
            btnMasteryNo.AutoSize = true;
            btnMasteryNo.Location = new Point(73, 9);
            btnMasteryNo.Name = "btnMasteryNo";
            btnMasteryNo.Size = new Size(41, 19);
            btnMasteryNo.TabIndex = 22;
            btnMasteryNo.TabStop = true;
            btnMasteryNo.Text = "No";
            btnMasteryNo.UseVisualStyleBackColor = true;
            // 
            // btnMasteryYes
            // 
            btnMasteryYes.AutoSize = true;
            btnMasteryYes.Location = new Point(20, 9);
            btnMasteryYes.Name = "btnMasteryYes";
            btnMasteryYes.Size = new Size(42, 19);
            btnMasteryYes.TabIndex = 19;
            btnMasteryYes.TabStop = true;
            btnMasteryYes.Text = "Yes";
            btnMasteryYes.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(598, 700);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 48);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblPerson
            // 
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(406, 520);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(43, 15);
            lblPerson.TabIndex = 34;
            lblPerson.Text = "Person";
            // 
            // personelList
            // 
            personelList.FormattingEnabled = true;
            personelList.ItemHeight = 15;
            personelList.Location = new Point(406, 153);
            personelList.Name = "personelList";
            personelList.Size = new Size(273, 349);
            personelList.TabIndex = 35;
            personelList.SelectedIndexChanged += personelList_SelectedIndexChanged;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Info;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label11);
            panel6.Location = new Point(406, 129);
            panel6.Name = "panel6";
            panel6.Size = new Size(273, 30);
            panel6.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(116, 30);
            label11.TabIndex = 0;
            label11.Text = "List of staff";
            // 
            // info
            // 
            info.AutoSize = true;
            info.ForeColor = Color.IndianRed;
            info.Location = new Point(125, 118);
            info.Name = "info";
            info.Size = new Size(71, 15);
            info.TabIndex = 38;
            info.Text = "New Record";
            // 
            // errPro
            // 
            errPro.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Turquoise;
            ClientSize = new Size(782, 783);
            Controls.Add(info);
            Controls.Add(panel6);
            Controls.Add(personelList);
            Controls.Add(lblPerson);
            Controls.Add(btnSave);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(childNum);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(fLanguageBox);
            Controls.Add(militarySBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(addressBox);
            Controls.Add(txtPhone);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDepartment);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)childNum).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errPro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox txtDepartment;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtPhone;
        private TextBox addressBox;
        private Panel panel2;
        private Label label8;
        private Panel panel3;
        private RadioButton btnOhsYes;
        private RadioButton btnOHSNo;
        private Label label9;
        private Label label10;
        private CheckBox militarySBox;
        private CheckBox fLanguageBox;
        private Button btnNew;
        private Button btnDelete;
        private Button btnUpdate;
        private NumericUpDown childNum;
        private Panel panel4;
        private Panel panel5;
        private RadioButton btnMasteryNo;
        private RadioButton btnMasteryYes;
        private Button btnSave;
        private Label lblPerson;
        private ListBox personelList;
        private Panel panel6;
        private Label label11;
        private Label info;
        private ErrorProvider errPro;
        private System.Windows.Forms.Timer timer;
    }
}
