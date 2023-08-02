namespace WindowsFormsApp2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnUpdateEvnt = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnViewEvnt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddEvnt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtAddReq = new System.Windows.Forms.RichTextBox();
            this.txtEvntDescr = new System.Windows.Forms.RichTextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtEvntName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gbAttendEvent = new System.Windows.Forms.GroupBox();
            this.btnRegisterForEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listEvent1 = new System.Windows.Forms.ListBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtEnteredEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gbAttendEvent.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 59);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 566);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.btnDisplay);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(952, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(166, 146);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 22);
            this.txtPassword.TabIndex = 35;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Non Premium",
            "Premium"});
            this.comboBox3.Location = new System.Drawing.Point(577, 139);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(223, 24);
            this.comboBox3.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Change Membership";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Change Password";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 19);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(896, 100);
            this.listBox1.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(213, 191);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 43);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(50, 191);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(129, 43);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteEvent);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.btnUpdateEvnt);
            this.tabPage2.Controls.Add(this.btnHistory);
            this.tabPage2.Controls.Add(this.btnViewEvnt);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(952, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Host Event";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(684, 326);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(175, 44);
            this.btnDeleteEvent.TabIndex = 29;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(25, 17);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(894, 84);
            this.listBox2.TabIndex = 28;
            // 
            // btnUpdateEvnt
            // 
            this.btnUpdateEvnt.Location = new System.Drawing.Point(684, 127);
            this.btnUpdateEvnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateEvnt.Name = "btnUpdateEvnt";
            this.btnUpdateEvnt.Size = new System.Drawing.Size(175, 44);
            this.btnUpdateEvnt.TabIndex = 27;
            this.btnUpdateEvnt.Text = "Update Event";
            this.btnUpdateEvnt.UseVisualStyleBackColor = true;
            this.btnUpdateEvnt.Click += new System.EventHandler(this.btnUpdateEvnt_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(684, 259);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(175, 44);
            this.btnHistory.TabIndex = 15;
            this.btnHistory.Text = "View Event History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnViewEvnt
            // 
            this.btnViewEvnt.Location = new System.Drawing.Point(684, 194);
            this.btnViewEvnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewEvnt.Name = "btnViewEvnt";
            this.btnViewEvnt.Size = new System.Drawing.Size(175, 44);
            this.btnViewEvnt.TabIndex = 14;
            this.btnViewEvnt.Text = "View Event";
            this.btnViewEvnt.UseVisualStyleBackColor = true;
            this.btnViewEvnt.Click += new System.EventHandler(this.btnViewEvnt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddEvnt);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtAddReq);
            this.groupBox1.Controls.Add(this.txtEvntDescr);
            this.groupBox1.Controls.Add(this.txtCapacity);
            this.groupBox1.Controls.Add(this.txtEvntName);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(611, 398);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Event";
            // 
            // btnAddEvnt
            // 
            this.btnAddEvnt.Location = new System.Drawing.Point(422, 328);
            this.btnAddEvnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEvnt.Name = "btnAddEvnt";
            this.btnAddEvnt.Size = new System.Drawing.Size(93, 44);
            this.btnAddEvnt.TabIndex = 28;
            this.btnAddEvnt.Text = "Add Event";
            this.btnAddEvnt.UseVisualStyleBackColor = true;
            this.btnAddEvnt.Click += new System.EventHandler(this.btnAddEvnt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Crystal Gardens Convention Center",
            "Starlight Ballroom",
            "Serenity Plaza",
            "Golden Pavilion",
            "Emerald Hall",
            "Moonbeam Theater",
            "Harmony Lounge"});
            this.comboBox1.Location = new System.Drawing.Point(201, 172);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // txtAddReq
            // 
            this.txtAddReq.Location = new System.Drawing.Point(201, 246);
            this.txtAddReq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddReq.Name = "txtAddReq";
            this.txtAddReq.Size = new System.Drawing.Size(315, 64);
            this.txtAddReq.TabIndex = 25;
            this.txtAddReq.Text = "";
            // 
            // txtEvntDescr
            // 
            this.txtEvntDescr.Location = new System.Drawing.Point(201, 80);
            this.txtEvntDescr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEvntDescr.Name = "txtEvntDescr";
            this.txtEvntDescr.Size = new System.Drawing.Size(178, 46);
            this.txtEvntDescr.TabIndex = 24;
            this.txtEvntDescr.Text = "";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(201, 208);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(178, 22);
            this.txtCapacity.TabIndex = 23;
            // 
            // txtEvntName
            // 
            this.txtEvntName.Location = new System.Drawing.Point(201, 38);
            this.txtEvntName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEvntName.Name = "txtEvntName";
            this.txtEvntName.Size = new System.Drawing.Size(178, 22);
            this.txtEvntName.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 141);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Additional Requirements :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Capacity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Venue :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date And Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Description :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Event Name :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox3);
            this.tabPage3.Controls.Add(this.dateTimePicker2);
            this.tabPage3.Controls.Add(this.gbAttendEvent);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(952, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Register for Event";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(14, 10);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(901, 180);
            this.listBox3.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(447, 199);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // gbAttendEvent
            // 
            this.gbAttendEvent.Controls.Add(this.btnRegisterForEvent);
            this.gbAttendEvent.Controls.Add(this.label1);
            this.gbAttendEvent.Controls.Add(this.richTextBox1);
            this.gbAttendEvent.Controls.Add(this.textBox1);
            this.gbAttendEvent.Controls.Add(this.label8);
            this.gbAttendEvent.Controls.Add(this.listEvent1);
            this.gbAttendEvent.Location = new System.Drawing.Point(33, 255);
            this.gbAttendEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAttendEvent.Name = "gbAttendEvent";
            this.gbAttendEvent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAttendEvent.Size = new System.Drawing.Size(521, 266);
            this.gbAttendEvent.TabIndex = 28;
            this.gbAttendEvent.TabStop = false;
            this.gbAttendEvent.Text = "Register For Event";
            // 
            // btnRegisterForEvent
            // 
            this.btnRegisterForEvent.Location = new System.Drawing.Point(394, 185);
            this.btnRegisterForEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterForEvent.Name = "btnRegisterForEvent";
            this.btnRegisterForEvent.Size = new System.Drawing.Size(99, 40);
            this.btnRegisterForEvent.TabIndex = 5;
            this.btnRegisterForEvent.Text = "Register";
            this.btnRegisterForEvent.UseVisualStyleBackColor = true;
            this.btnRegisterForEvent.Click += new System.EventHandler(this.btnRegisterForEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Additional Details :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(145, 148);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 78);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Names :";
            // 
            // listEvent1
            // 
            this.listEvent1.FormattingEnabled = true;
            this.listEvent1.ItemHeight = 16;
            this.listEvent1.Location = new System.Drawing.Point(15, 28);
            this.listEvent1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listEvent1.Name = "listEvent1";
            this.listEvent1.Size = new System.Drawing.Size(478, 68);
            this.listEvent1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Crystal Gardens Convention Center",
            "Starlight Ballroom",
            "Serenity Plaza",
            "Golden Pavilion",
            "Emerald Hall",
            "Moonbeam Theater",
            "Harmony Lounge"});
            this.comboBox2.Location = new System.Drawing.Point(33, 198);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(178, 24);
            this.comboBox2.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Controls.Add(this.btnReport);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Size = new System.Drawing.Size(952, 537);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "User Report";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(444, 376);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(141, 57);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Display Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtEnteredEmail
            // 
            this.txtEnteredEmail.Location = new System.Drawing.Point(220, 22);
            this.txtEnteredEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEnteredEmail.Name = "txtEnteredEmail";
            this.txtEnteredEmail.Size = new System.Drawing.Size(216, 22);
            this.txtEnteredEmail.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Please Enter your email :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 321);
            this.dataGridView1.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 633);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEnteredEmail);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.gbAttendEvent.ResumeLayout(false);
            this.gbAttendEvent.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdateEvnt;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnViewEvnt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddEvnt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox txtAddReq;
        private System.Windows.Forms.RichTextBox txtEvntDescr;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtEvntName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox gbAttendEvent;
        private System.Windows.Forms.Button btnRegisterForEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listEvent1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtEnteredEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}