namespace Medic
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnalm = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtMname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdes = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbotime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.edate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.addDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbodosge = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbotype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.btnDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnRecord = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemaind = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Details = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Home1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Record = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Remainder = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Reminder1 = new Medic.UC_Reminder();
            this.uC_Record1 = new Medic.UC_Record();
            this.uC_Home11 = new Medic.UC_Home1();
            this.uC_Details1 = new Medic.UC_Details();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 499);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.uC_Reminder1);
            this.panel4.Controls.Add(this.uC_Record1);
            this.panel4.Controls.Add(this.uC_Home11);
            this.panel4.Controls.Add(this.uC_Details1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnalm);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.txtMname);
            this.panel4.Controls.Add(this.txtdes);
            this.panel4.Controls.Add(this.cbotime);
            this.panel4.Controls.Add(this.edate);
            this.panel4.Controls.Add(this.addDate);
            this.panel4.Controls.Add(this.cbodosge);
            this.panel4.Controls.Add(this.cbotype);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(72, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(884, 499);
            this.panel4.TabIndex = 156;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(47, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 172;
            this.label1.Text = "Add Medicine";
            // 
            // btnalm
            // 
            this.btnalm.BackColor = System.Drawing.Color.Transparent;
            this.btnalm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnalm.BorderRadius = 8;
            this.btnalm.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnalm.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnalm.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnalm.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnalm.CheckedState.Image")));
            this.btnalm.CheckedState.Parent = this.btnalm;
            this.btnalm.CustomImages.Parent = this.btnalm;
            this.btnalm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnalm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnalm.ForeColor = System.Drawing.Color.White;
            this.btnalm.HoverState.Parent = this.btnalm;
            this.btnalm.Image = ((System.Drawing.Image)(resources.GetObject("btnalm.Image")));
            this.btnalm.ImageSize = new System.Drawing.Size(18, 18);
            this.btnalm.Location = new System.Drawing.Point(662, 428);
            this.btnalm.Name = "btnalm";
            this.btnalm.ShadowDecoration.Parent = this.btnalm;
            this.btnalm.Size = new System.Drawing.Size(133, 33);
            this.btnalm.TabIndex = 171;
            this.btnalm.Text = "Set Alarm";
            this.btnalm.Click += new System.EventHandler(this.btnalm_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnSave.BorderRadius = 8;
            this.btnSave.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnSave.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSave.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnSave.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.CheckedState.Image")));
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(18, 18);
            this.btnSave.Location = new System.Drawing.Point(513, 428);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(118, 33);
            this.btnSave.TabIndex = 170;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // txtMname
            // 
            this.txtMname.BackColor = System.Drawing.Color.Transparent;
            this.txtMname.BorderRadius = 8;
            this.txtMname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMname.DefaultText = "";
            this.txtMname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMname.DisabledState.Parent = this.txtMname;
            this.txtMname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMname.FocusedState.Parent = this.txtMname;
            this.txtMname.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtMname.ForeColor = System.Drawing.Color.Black;
            this.txtMname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMname.HoverState.Parent = this.txtMname;
            this.txtMname.Location = new System.Drawing.Point(93, 159);
            this.txtMname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMname.Name = "txtMname";
            this.txtMname.PasswordChar = '\0';
            this.txtMname.PlaceholderText = "";
            this.txtMname.SelectedText = "";
            this.txtMname.ShadowDecoration.Parent = this.txtMname;
            this.txtMname.Size = new System.Drawing.Size(260, 31);
            this.txtMname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMname.TabIndex = 163;
            // 
            // txtdes
            // 
            this.txtdes.BackColor = System.Drawing.Color.Transparent;
            this.txtdes.BorderRadius = 3;
            this.txtdes.BorderThickness = 0;
            this.txtdes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdes.DefaultText = "";
            this.txtdes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdes.DisabledState.Parent = this.txtdes;
            this.txtdes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdes.FocusedState.Parent = this.txtdes;
            this.txtdes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtdes.ForeColor = System.Drawing.Color.Black;
            this.txtdes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdes.HoverState.Parent = this.txtdes;
            this.txtdes.Location = new System.Drawing.Point(93, 430);
            this.txtdes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdes.Name = "txtdes";
            this.txtdes.PasswordChar = '\0';
            this.txtdes.PlaceholderText = "";
            this.txtdes.SelectedText = "";
            this.txtdes.ShadowDecoration.Parent = this.txtdes;
            this.txtdes.Size = new System.Drawing.Size(260, 31);
            this.txtdes.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtdes.TabIndex = 169;
            // 
            // cbotime
            // 
            this.cbotime.BackColor = System.Drawing.Color.Transparent;
            this.cbotime.BorderRadius = 3;
            this.cbotime.BorderThickness = 0;
            this.cbotime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbotime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbotime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbotime.FocusedState.Parent = this.cbotime;
            this.cbotime.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbotime.ForeColor = System.Drawing.Color.Black;
            this.cbotime.HoverState.Parent = this.cbotime;
            this.cbotime.ItemHeight = 25;
            this.cbotime.Items.AddRange(new object[] {
            "One time per day",
            "Two times per day",
            "Three timed per day"});
            this.cbotime.ItemsAppearance.Parent = this.cbotime;
            this.cbotime.Location = new System.Drawing.Point(513, 341);
            this.cbotime.Name = "cbotime";
            this.cbotime.ShadowDecoration.Parent = this.cbotime;
            this.cbotime.Size = new System.Drawing.Size(282, 31);
            this.cbotime.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbotime.TabIndex = 168;
            // 
            // edate
            // 
            this.edate.BackColor = System.Drawing.Color.Transparent;
            this.edate.BorderRadius = 3;
            this.edate.CheckedState.Parent = this.edate;
            this.edate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.edate.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.edate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edate.HoverState.Parent = this.edate;
            this.edate.Location = new System.Drawing.Point(513, 250);
            this.edate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.edate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.edate.Name = "edate";
            this.edate.ShadowDecoration.Parent = this.edate;
            this.edate.Size = new System.Drawing.Size(282, 31);
            this.edate.TabIndex = 167;
            this.edate.Value = new System.DateTime(2021, 6, 11, 13, 44, 38, 38);
            // 
            // addDate
            // 
            this.addDate.BackColor = System.Drawing.Color.Transparent;
            this.addDate.BorderRadius = 3;
            this.addDate.CheckedState.Parent = this.addDate;
            this.addDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.addDate.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.addDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addDate.HoverState.Parent = this.addDate;
            this.addDate.Location = new System.Drawing.Point(513, 159);
            this.addDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.addDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.addDate.Name = "addDate";
            this.addDate.ShadowDecoration.Parent = this.addDate;
            this.addDate.Size = new System.Drawing.Size(282, 31);
            this.addDate.TabIndex = 166;
            this.addDate.Value = new System.DateTime(2021, 6, 11, 13, 44, 38, 38);
            // 
            // cbodosge
            // 
            this.cbodosge.BackColor = System.Drawing.Color.Transparent;
            this.cbodosge.BorderRadius = 3;
            this.cbodosge.BorderThickness = 0;
            this.cbodosge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbodosge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbodosge.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbodosge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbodosge.FocusedState.Parent = this.cbodosge;
            this.cbodosge.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbodosge.ForeColor = System.Drawing.Color.Black;
            this.cbodosge.HoverState.Parent = this.cbodosge;
            this.cbodosge.ItemHeight = 25;
            this.cbodosge.ItemsAppearance.Parent = this.cbodosge;
            this.cbodosge.Location = new System.Drawing.Point(93, 341);
            this.cbodosge.Name = "cbodosge";
            this.cbodosge.ShadowDecoration.Parent = this.cbodosge;
            this.cbodosge.Size = new System.Drawing.Size(260, 31);
            this.cbodosge.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbodosge.TabIndex = 165;
            // 
            // cbotype
            // 
            this.cbotype.BackColor = System.Drawing.Color.Transparent;
            this.cbotype.BorderRadius = 3;
            this.cbotype.BorderThickness = 0;
            this.cbotype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbotype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbotype.FocusedState.Parent = this.cbotype;
            this.cbotype.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.cbotype.ForeColor = System.Drawing.Color.Black;
            this.cbotype.HoverState.Parent = this.cbotype;
            this.cbotype.ItemHeight = 25;
            this.cbotype.Items.AddRange(new object[] {
            "Capsule",
            "Drops",
            "Inhaler",
            "Injection",
            "Ointment",
            "Pill"});
            this.cbotype.ItemsAppearance.Parent = this.cbotype;
            this.cbotype.Location = new System.Drawing.Point(93, 250);
            this.cbotype.Name = "cbotype";
            this.cbotype.ShadowDecoration.Parent = this.cbotype;
            this.cbotype.Size = new System.Drawing.Size(260, 31);
            this.cbotype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbotype.TabIndex = 164;
            this.cbotype.SelectedValueChanged += new System.EventHandler(this.cbotype_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.label9.Location = new System.Drawing.Point(89, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 162;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.label8.Location = new System.Drawing.Point(509, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 161;
            this.label8.Text = "Take Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.label7.Location = new System.Drawing.Point(509, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 160;
            this.label7.Text = "Expire Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.label6.Location = new System.Drawing.Point(509, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 159;
            this.label6.Text = "Add Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.label5.Location = new System.Drawing.Point(89, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 158;
            this.label5.Text = "Medicine type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.label4.Location = new System.Drawing.Point(89, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 157;
            this.label4.Text = "Dosage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.label2.Location = new System.Drawing.Point(89, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 156;
            this.label2.Text = "Medicine Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.pbBack);
            this.panel2.Controls.Add(this.btnDetails);
            this.panel2.Controls.Add(this.btnRecord);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnRemaind);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 499);
            this.panel2.TabIndex = 1;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(21, 431);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(25, 25);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 5;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDetails.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnDetails.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.CheckedState.Image")));
            this.btnDetails.CheckedState.Parent = this.btnDetails;
            this.btnDetails.CustomImages.Parent = this.btnDetails;
            this.btnDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnDetails.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.HoverState.Image")));
            this.btnDetails.HoverState.Parent = this.btnDetails;
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.ImageSize = new System.Drawing.Size(33, 33);
            this.btnDetails.Location = new System.Drawing.Point(15, 271);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnDetails.ShadowDecoration.Parent = this.btnDetails;
            this.btnDetails.Size = new System.Drawing.Size(40, 40);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnRecord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRecord.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnRecord.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.CheckedState.Image")));
            this.btnRecord.CheckedState.Parent = this.btnRecord;
            this.btnRecord.CustomImages.Parent = this.btnRecord;
            this.btnRecord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnRecord.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.HoverState.Image")));
            this.btnRecord.HoverState.Parent = this.btnRecord;
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.ImageSize = new System.Drawing.Size(33, 33);
            this.btnRecord.Location = new System.Drawing.Point(11, 351);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnRecord.ShadowDecoration.Parent = this.btnRecord;
            this.btnRecord.Size = new System.Drawing.Size(40, 40);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnAdd.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedState.Image")));
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnAdd.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.HoverState.Image")));
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(33, 33);
            this.btnAdd.Location = new System.Drawing.Point(15, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemaind
            // 
            this.btnRemaind.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRemaind.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnRemaind.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnRemaind.CheckedState.Image")));
            this.btnRemaind.CheckedState.Parent = this.btnRemaind;
            this.btnRemaind.CustomImages.Parent = this.btnRemaind;
            this.btnRemaind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnRemaind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemaind.ForeColor = System.Drawing.Color.White;
            this.btnRemaind.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnRemaind.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnRemaind.HoverState.Image")));
            this.btnRemaind.HoverState.Parent = this.btnRemaind;
            this.btnRemaind.Image = ((System.Drawing.Image)(resources.GetObject("btnRemaind.Image")));
            this.btnRemaind.ImageSize = new System.Drawing.Size(33, 33);
            this.btnRemaind.Location = new System.Drawing.Point(15, 191);
            this.btnRemaind.Name = "btnRemaind";
            this.btnRemaind.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnRemaind.ShadowDecoration.Parent = this.btnRemaind;
            this.btnRemaind.Size = new System.Drawing.Size(40, 40);
            this.btnRemaind.TabIndex = 1;
            this.btnRemaind.Click += new System.EventHandler(this.btnRemaind_Click);
            // 
            // btnHome
            // 
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnHome.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.CheckedState.Image")));
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnHome.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.HoverState.Image")));
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageSize = new System.Drawing.Size(33, 33);
            this.btnHome.Location = new System.Drawing.Point(16, 31);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(40, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 56;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 56;
            this.guna2Elipse2.TargetControl = this.panel1;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 56;
            this.guna2Elipse3.TargetControl = this;
            // 
            // Details
            // 
            this.Details.TargetControl = this.panel4;
            // 
            // Home1
            // 
            this.Home1.TargetControl = this.panel4;
            // 
            // Record
            // 
            this.Record.TargetControl = this.panel4;
            // 
            // Remainder
            // 
            this.Remainder.TargetControl = this.panel4;
            // 
            // uC_Reminder1
            // 
            this.uC_Reminder1.BackColor = System.Drawing.Color.White;
            this.uC_Reminder1.Location = new System.Drawing.Point(0, 0);
            this.uC_Reminder1.Name = "uC_Reminder1";
            this.uC_Reminder1.Size = new System.Drawing.Size(884, 499);
            this.uC_Reminder1.TabIndex = 176;
            this.uC_Reminder1.Load += new System.EventHandler(this.uC_Reminder1_Load);
            // 
            // uC_Record1
            // 
            this.uC_Record1.BackColor = System.Drawing.Color.White;
            this.uC_Record1.Location = new System.Drawing.Point(0, 0);
            this.uC_Record1.Name = "uC_Record1";
            this.uC_Record1.Size = new System.Drawing.Size(884, 499);
            this.uC_Record1.TabIndex = 175;
            // 
            // uC_Home11
            // 
            this.uC_Home11.BackColor = System.Drawing.Color.White;
            this.uC_Home11.Location = new System.Drawing.Point(0, 0);
            this.uC_Home11.Name = "uC_Home11";
            this.uC_Home11.Size = new System.Drawing.Size(884, 499);
            this.uC_Home11.TabIndex = 174;
            // 
            // uC_Details1
            // 
            this.uC_Details1.BackColor = System.Drawing.Color.White;
            this.uC_Details1.Location = new System.Drawing.Point(0, 0);
            this.uC_Details1.Name = "uC_Details1";
            this.uC_Details1.Size = new System.Drawing.Size(884, 499);
            this.uC_Details1.TabIndex = 173;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(962, 505);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnDetails;
        private Guna.UI2.WinForms.Guna2Button btnRecord;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnRemaind;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnalm;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtMname;
        private Guna.UI2.WinForms.Guna2TextBox txtdes;
        private Guna.UI2.WinForms.Guna2ComboBox cbotime;
        private Guna.UI2.WinForms.Guna2DateTimePicker edate;
        private Guna.UI2.WinForms.Guna2DateTimePicker addDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbodosge;
        private Guna.UI2.WinForms.Guna2ComboBox cbotype;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbBack;
        private UC_Reminder uC_Reminder1;
        private UC_Record uC_Record1;
        private UC_Home1 uC_Home11;
        private UC_Details uC_Details1;
        private Guna.UI2.WinForms.Guna2Elipse Details;
        private Guna.UI2.WinForms.Guna2Elipse Home1;
        private Guna.UI2.WinForms.Guna2Elipse Record;
        private Guna.UI2.WinForms.Guna2Elipse Remainder;
    }
}

