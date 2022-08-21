namespace Medic
{
    partial class UC_Record
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Record));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Record = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dg2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnMissed = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaken = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.label3.Location = new System.Drawing.Point(384, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 120;
            this.label3.Text = "Date To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.label2.Location = new System.Drawing.Point(88, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 119;
            this.label2.Text = "Date From";
            // 
            // dg2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dg2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg2.BackgroundColor = System.Drawing.Color.White;
            this.dg2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg2.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg2.EnableHeadersVisualStyles = false;
            this.dg2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg2.Location = new System.Drawing.Point(92, 188);
            this.dg2.Name = "dg2";
            this.dg2.ReadOnly = true;
            this.dg2.RowHeadersVisible = false;
            this.dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg2.Size = new System.Drawing.Size(741, 202);
            this.dg2.TabIndex = 128;
            this.dg2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dg2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dg2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dg2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dg2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.dg2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dg2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg2.ThemeStyle.HeaderStyle.Height = 21;
            this.dg2.ThemeStyle.ReadOnly = true;
            this.dg2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dg2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.dg2.ThemeStyle.RowsStyle.Height = 22;
            this.dg2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg2_CellContentClick);
            // 
            // dateTo
            // 
            this.dateTo.BackColor = System.Drawing.Color.Transparent;
            this.dateTo.BorderRadius = 3;
            this.dateTo.CheckedState.Parent = this.dateTo;
            this.dateTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.dateTo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.HoverState.Parent = this.dateTo;
            this.dateTo.Location = new System.Drawing.Point(388, 126);
            this.dateTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.ShadowDecoration.Parent = this.dateTo;
            this.dateTo.Size = new System.Drawing.Size(214, 31);
            this.dateTo.TabIndex = 127;
            this.dateTo.Value = new System.DateTime(2021, 6, 11, 13, 44, 38, 38);
            this.dateTo.ValueChanged += new System.EventHandler(this.dateTo_ValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.BackColor = System.Drawing.Color.Transparent;
            this.dateFrom.BorderRadius = 3;
            this.dateFrom.CheckedState.Parent = this.dateFrom;
            this.dateFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.dateFrom.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.HoverState.Parent = this.dateFrom;
            this.dateFrom.Location = new System.Drawing.Point(92, 126);
            this.dateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.ShadowDecoration.Parent = this.dateFrom;
            this.dateFrom.Size = new System.Drawing.Size(214, 31);
            this.dateFrom.TabIndex = 126;
            this.dateFrom.Value = new System.DateTime(2021, 6, 11, 13, 44, 38, 38);
            this.dateFrom.ValueChanged += new System.EventHandler(this.dateFrom_ValueChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnPrint.BorderRadius = 8;
            this.btnPrint.BorderThickness = 1;
            this.btnPrint.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnPrint.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPrint.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnPrint.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.CheckedState.Image")));
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageSize = new System.Drawing.Size(18, 18);
            this.btnPrint.Location = new System.Drawing.Point(715, 428);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(118, 33);
            this.btnPrint.TabIndex = 124;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnMissed
            // 
            this.btnMissed.BackColor = System.Drawing.Color.Transparent;
            this.btnMissed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnMissed.BorderRadius = 8;
            this.btnMissed.BorderThickness = 1;
            this.btnMissed.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnMissed.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMissed.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnMissed.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnMissed.CheckedState.Image")));
            this.btnMissed.CheckedState.Parent = this.btnMissed;
            this.btnMissed.CustomImages.Parent = this.btnMissed;
            this.btnMissed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnMissed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnMissed.ForeColor = System.Drawing.Color.White;
            this.btnMissed.HoverState.Parent = this.btnMissed;
            this.btnMissed.Image = ((System.Drawing.Image)(resources.GetObject("btnMissed.Image")));
            this.btnMissed.ImageSize = new System.Drawing.Size(18, 18);
            this.btnMissed.Location = new System.Drawing.Point(237, 428);
            this.btnMissed.Name = "btnMissed";
            this.btnMissed.ShadowDecoration.Parent = this.btnMissed;
            this.btnMissed.Size = new System.Drawing.Size(118, 33);
            this.btnMissed.TabIndex = 123;
            this.btnMissed.Text = "Missed";
            this.btnMissed.Click += new System.EventHandler(this.btnMissed_Click);
            // 
            // btnTaken
            // 
            this.btnTaken.BackColor = System.Drawing.Color.Transparent;
            this.btnTaken.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnTaken.BorderRadius = 8;
            this.btnTaken.BorderThickness = 1;
            this.btnTaken.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnTaken.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnTaken.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnTaken.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnTaken.CheckedState.Image")));
            this.btnTaken.CheckedState.Parent = this.btnTaken;
            this.btnTaken.CustomImages.Parent = this.btnTaken;
            this.btnTaken.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnTaken.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnTaken.ForeColor = System.Drawing.Color.White;
            this.btnTaken.HoverState.Parent = this.btnTaken;
            this.btnTaken.Image = ((System.Drawing.Image)(resources.GetObject("btnTaken.Image")));
            this.btnTaken.ImageSize = new System.Drawing.Size(18, 18);
            this.btnTaken.Location = new System.Drawing.Point(92, 428);
            this.btnTaken.Name = "btnTaken";
            this.btnTaken.ShadowDecoration.Parent = this.btnTaken;
            this.btnTaken.Size = new System.Drawing.Size(118, 33);
            this.btnTaken.TabIndex = 122;
            this.btnTaken.Text = "Taken";
            this.btnTaken.Click += new System.EventHandler(this.btnTaken_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 28);
            this.label1.TabIndex = 121;
            this.label1.Text = "Medication Record";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(296, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 130;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbLoad
            // 
            this.pbLoad.Image = ((System.Drawing.Image)(resources.GetObject("pbLoad.Image")));
            this.pbLoad.Location = new System.Drawing.Point(636, 122);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(35, 35);
            this.pbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoad.TabIndex = 131;
            this.pbLoad.TabStop = false;
            this.pbLoad.Click += new System.EventHandler(this.pbLoad_Click);
            // 
            // UC_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dg2);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnMissed);
            this.Controls.Add(this.btnTaken);
            this.Controls.Add(this.label1);
            this.Name = "UC_Record";
            this.Size = new System.Drawing.Size(884, 499);
            this.Load += new System.EventHandler(this.UC_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse Record;
        private Guna.UI2.WinForms.Guna2DataGridView dg2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFrom;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnMissed;
        private Guna.UI2.WinForms.Guna2Button btnTaken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbLoad;
    }
}
