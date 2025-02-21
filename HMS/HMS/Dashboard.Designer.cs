namespace HMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnAddPatient = new Button();
            btnAddDiagnosis = new Button();
            btnHospital = new Button();
            btnFullHistory = new Button();
            btnExit = new Button();
            pictureBox2 = new PictureBox();
            labelIndicator1 = new Label();
            labelIndicator2 = new Label();
            labelIndicator3 = new Label();
            labelIndicator4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label19 = new Label();
            dataGridView2 = new DataGridView();
            button1 = new Button();
            comboBxWardType = new ComboBox();
            comboBxWard = new ComboBox();
            txtBxMedicines = new TextBox();
            txtBxDiagonosis = new TextBox();
            txtBxSymptoms = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            btnSave = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboGender = new ComboBox();
            txtBlood = new TextBox();
            txtAny = new TextBox();
            txtPid = new TextBox();
            txtAge = new TextBox();
            txtContact = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(274, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 401);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 23);
            label1.Name = "label1";
            label1.Size = new Size(194, 34);
            label1.TabIndex = 1;
            label1.Text = "Controller";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(361, 37);
            label2.Name = "label2";
            label2.Size = new Size(411, 38);
            label2.TabIndex = 2;
            label2.Text = "Hospital Management System";
            // 
            // btnAddPatient
            // 
            btnAddPatient.BackColor = SystemColors.ActiveCaption;
            btnAddPatient.Location = new Point(60, 86);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(208, 29);
            btnAddPatient.TabIndex = 3;
            btnAddPatient.Text = "Add New Patient Record";
            btnAddPatient.UseVisualStyleBackColor = false;
            btnAddPatient.Click += button1_Click;
            // 
            // btnAddDiagnosis
            // 
            btnAddDiagnosis.BackColor = SystemColors.ActiveCaption;
            btnAddDiagnosis.Location = new Point(60, 138);
            btnAddDiagnosis.Name = "btnAddDiagnosis";
            btnAddDiagnosis.Size = new Size(208, 29);
            btnAddDiagnosis.TabIndex = 4;
            btnAddDiagnosis.Text = "Add Diagnosis Information";
            btnAddDiagnosis.UseVisualStyleBackColor = false;
            btnAddDiagnosis.Click += btnAddDiagnosis_Click;
            // 
            // btnHospital
            // 
            btnHospital.BackColor = SystemColors.ActiveCaption;
            btnHospital.Location = new Point(60, 240);
            btnHospital.Name = "btnHospital";
            btnHospital.Size = new Size(208, 29);
            btnHospital.TabIndex = 5;
            btnHospital.Text = "Hospital Information";
            btnHospital.UseVisualStyleBackColor = false;
            btnHospital.Click += button3_Click;
            // 
            // btnFullHistory
            // 
            btnFullHistory.BackColor = SystemColors.ActiveCaption;
            btnFullHistory.Location = new Point(60, 187);
            btnFullHistory.Name = "btnFullHistory";
            btnFullHistory.Size = new Size(208, 29);
            btnFullHistory.TabIndex = 6;
            btnFullHistory.Text = "Full History of the patient";
            btnFullHistory.UseVisualStyleBackColor = false;
            btnFullHistory.Click += btnFullHistory_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.OrangeRed;
            btnExit.Location = new Point(112, 291);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 344);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // labelIndicator1
            // 
            labelIndicator1.AutoSize = true;
            labelIndicator1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIndicator1.Location = new Point(12, 86);
            labelIndicator1.Name = "labelIndicator1";
            labelIndicator1.Size = new Size(46, 31);
            labelIndicator1.TabIndex = 9;
            labelIndicator1.Text = ">>";
            // 
            // labelIndicator2
            // 
            labelIndicator2.AutoSize = true;
            labelIndicator2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIndicator2.Location = new Point(8, 138);
            labelIndicator2.Name = "labelIndicator2";
            labelIndicator2.Size = new Size(46, 31);
            labelIndicator2.TabIndex = 10;
            labelIndicator2.Text = ">>";
            // 
            // labelIndicator3
            // 
            labelIndicator3.AutoSize = true;
            labelIndicator3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIndicator3.Location = new Point(8, 187);
            labelIndicator3.Name = "labelIndicator3";
            labelIndicator3.Size = new Size(46, 31);
            labelIndicator3.TabIndex = 11;
            labelIndicator3.Text = ">>";
            labelIndicator3.Click += label5_Click;
            // 
            // labelIndicator4
            // 
            labelIndicator4.AutoSize = true;
            labelIndicator4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIndicator4.Location = new Point(8, 240);
            labelIndicator4.Name = "labelIndicator4";
            labelIndicator4.Size = new Size(46, 31);
            labelIndicator4.TabIndex = 12;
            labelIndicator4.Text = ">>";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboGender);
            panel1.Controls.Add(txtBlood);
            panel1.Controls.Add(txtAny);
            panel1.Controls.Add(txtPid);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(txtContact);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(274, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 401);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBxWardType);
            panel2.Controls.Add(comboBxWard);
            panel2.Controls.Add(txtBxMedicines);
            panel2.Controls.Add(txtBxDiagonosis);
            panel2.Controls.Add(txtBxSymptoms);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(-2, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 401);
            panel2.TabIndex = 32;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(dataGridView2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(514, 401);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(-1, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(512, 400);
            panel4.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(509, 401);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(133, 7);
            label19.Name = "label19";
            label19.Size = new Size(263, 28);
            label19.TabIndex = 1;
            label19.Text = "Full History of The Patient";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(0, 39);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(514, 362);
            dataGridView2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Location = new Point(347, 265);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // comboBxWardType
            // 
            comboBxWardType.FormattingEnabled = true;
            comboBxWardType.Items.AddRange(new object[] { "Ac", "Non-Ac", "None" });
            comboBxWardType.Location = new Point(347, 231);
            comboBxWardType.Name = "comboBxWardType";
            comboBxWardType.Size = new Size(151, 28);
            comboBxWardType.TabIndex = 13;
            // 
            // comboBxWard
            // 
            comboBxWard.FormattingEnabled = true;
            comboBxWard.Items.AddRange(new object[] { "Yes", "No" });
            comboBxWard.Location = new Point(347, 182);
            comboBxWard.Name = "comboBxWard";
            comboBxWard.Size = new Size(151, 28);
            comboBxWard.TabIndex = 12;
            // 
            // txtBxMedicines
            // 
            txtBxMedicines.Location = new Point(87, 267);
            txtBxMedicines.Name = "txtBxMedicines";
            txtBxMedicines.Size = new Size(125, 27);
            txtBxMedicines.TabIndex = 11;
            // 
            // txtBxDiagonosis
            // 
            txtBxDiagonosis.Location = new Point(87, 227);
            txtBxDiagonosis.Name = "txtBxDiagonosis";
            txtBxDiagonosis.Size = new Size(125, 27);
            txtBxDiagonosis.TabIndex = 10;
            // 
            // txtBxSymptoms
            // 
            txtBxSymptoms.Location = new Point(87, 179);
            txtBxSymptoms.Name = "txtBxSymptoms";
            txtBxSymptoms.Size = new Size(125, 27);
            txtBxSymptoms.TabIndex = 9;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(222, 234);
            label18.Name = "label18";
            label18.Size = new Size(97, 20);
            label18.TabIndex = 8;
            label18.Text = "Type of Ward";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(222, 186);
            label17.Name = "label17";
            label17.Size = new Size(119, 20);
            label17.TabIndex = 7;
            label17.Text = "Ward Required ?";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 270);
            label16.Name = "label16";
            label16.Size = new Size(76, 20);
            label16.TabIndex = 6;
            label16.Text = "Medicines";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 230);
            label15.Name = "label15";
            label15.Size = new Size(74, 20);
            label15.TabIndex = 5;
            label15.Text = "Diagnosis";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 182);
            label14.Name = "label14";
            label14.Size = new Size(82, 20);
            label14.TabIndex = 4;
            label14.Text = "Symptom's";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(504, 96);
            dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(87, 45);
            label13.Name = "label13";
            label13.Size = new Size(30, 20);
            label13.TabIndex = 1;
            label13.Text = "Pid";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(72, 0);
            label12.Name = "label12";
            label12.Size = new Size(393, 28);
            label12.TabIndex = 0;
            label12.Text = "Adding More Information About Patient";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Orange;
            btnSave.Location = new Point(21, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(189, 0);
            label11.Name = "label11";
            label11.Size = new Size(245, 28);
            label11.TabIndex = 30;
            label11.Text = "Add New Patient Record";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 305);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 29;
            label10.Text = "Patient ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 242);
            label9.Name = "label9";
            label9.Size = new Size(238, 20);
            label9.TabIndex = 28;
            label9.Text = "Any Major Disease Suffered Earlier";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 215);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 27;
            label8.Text = "Blood Group";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 184);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 26;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 148);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 25;
            label6.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 108);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 24;
            label5.Text = "Contact Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 70);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 23;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 36);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 22;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboGender.Location = new Point(151, 178);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(331, 28);
            comboGender.TabIndex = 21;
            // 
            // txtBlood
            // 
            txtBlood.Location = new Point(151, 212);
            txtBlood.Name = "txtBlood";
            txtBlood.Size = new Size(331, 27);
            txtBlood.TabIndex = 20;
            // 
            // txtAny
            // 
            txtAny.Location = new Point(21, 265);
            txtAny.Name = "txtAny";
            txtAny.Size = new Size(461, 27);
            txtAny.TabIndex = 19;
            // 
            // txtPid
            // 
            txtPid.Location = new Point(21, 328);
            txtPid.Name = "txtPid";
            txtPid.Size = new Size(461, 27);
            txtPid.TabIndex = 18;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(151, 141);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(331, 27);
            txtAge.TabIndex = 17;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(151, 105);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(331, 27);
            txtContact.TabIndex = 16;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(151, 70);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(331, 27);
            txtAddress.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(151, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(331, 27);
            txtName.TabIndex = 14;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 452);
            Controls.Add(panel1);
            Controls.Add(labelIndicator4);
            Controls.Add(labelIndicator3);
            Controls.Add(labelIndicator2);
            Controls.Add(labelIndicator1);
            Controls.Add(pictureBox2);
            Controls.Add(btnExit);
            Controls.Add(btnFullHistory);
            Controls.Add(btnHospital);
            Controls.Add(btnAddDiagnosis);
            Controls.Add(btnAddPatient);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnAddPatient;
        private Button btnAddDiagnosis;
        private Button btnHospital;
        private Button btnFullHistory;
        private Button btnExit;
        private PictureBox pictureBox2;
        private Label labelIndicator1;
        private Label labelIndicator2;
        private Label labelIndicator3;
        private Label labelIndicator4;
        private Panel panel1;
        private TextBox txtBlood;
        private TextBox txtAny;
        private TextBox txtPid;
        private TextBox txtAge;
        private TextBox txtContact;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboGender;
        private Label label10;
        private Label label11;
        private Button btnSave;
        private Panel panel2;
        private Label label12;
        private Label label13;
        private TextBox txtBxMedicines;
        private TextBox txtBxDiagonosis;
        private TextBox txtBxSymptoms;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBxWardType;
        private ComboBox comboBxWard;
        private Panel panel3;
        private Label label19;
        private DataGridView dataGridView2;
        private Panel panel4;
        private PictureBox pictureBox3;
    }
}