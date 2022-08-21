namespace Medic
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDos = new System.Windows.Forms.Label();
            this.rdotaked = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdomissed = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Remind";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 47);
            this.panel1.TabIndex = 142;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(12, 14);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(20, 20);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 137;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.label9.Location = new System.Drawing.Point(8, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 141;
            this.label9.Text = "Description";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(132)))), ((int)(((byte)(186)))));
            this.btnStop.BorderRadius = 8;
            this.btnStop.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.btnStop.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStop.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.btnStop.CheckedState.Parent = this.btnStop;
            this.btnStop.CustomImages.Parent = this.btnStop;
            this.btnStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.HoverState.Parent = this.btnStop;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageSize = new System.Drawing.Size(18, 18);
            this.btnStop.Location = new System.Drawing.Point(272, 166);
            this.btnStop.Name = "btnStop";
            this.btnStop.ShadowDecoration.Parent = this.btnStop;
            this.btnStop.Size = new System.Drawing.Size(118, 33);
            this.btnStop.TabIndex = 135;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(8, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 133;
            this.label5.Text = "Medicine Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(8, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 132;
            this.label4.Text = "Dosage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 131;
            this.label3.Text = "Medicine Name";
            // 
            // lbltime
            // 
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lbltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.lbltime.Location = new System.Drawing.Point(301, 10);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(108, 20);
            this.lbltime.TabIndex = 130;
            this.lbltime.Text = "time";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.lblDate.Location = new System.Drawing.Point(301, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 17);
            this.lblDate.TabIndex = 129;
            this.lblDate.Text = "date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.lblName.Location = new System.Drawing.Point(127, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 143;
            this.lblName.Text = "hhhhh";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.lblMsg.Location = new System.Drawing.Point(127, 116);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(48, 17);
            this.lblMsg.TabIndex = 144;
            this.lblMsg.Text = "hhhhh";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.lblType.Location = new System.Drawing.Point(127, 56);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 17);
            this.lblType.TabIndex = 145;
            this.lblType.Text = "hhhhh";
            // 
            // lblDos
            // 
            this.lblDos.AutoSize = true;
            this.lblDos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblDos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.lblDos.Location = new System.Drawing.Point(127, 86);
            this.lblDos.Name = "lblDos";
            this.lblDos.Size = new System.Drawing.Size(48, 17);
            this.lblDos.TabIndex = 146;
            this.lblDos.Text = "hhhhh";
            // 
            // rdotaked
            // 
            this.rdotaked.AutoSize = true;
            this.rdotaked.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.rdotaked.CheckedState.BorderThickness = 0;
            this.rdotaked.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.rdotaked.CheckedState.InnerColor = System.Drawing.Color.WhiteSmoke;
            this.rdotaked.CheckedState.InnerOffset = -4;
            this.rdotaked.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdotaked.FlatAppearance.BorderSize = 0;
            this.rdotaked.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdotaked.Location = new System.Drawing.Point(11, 166);
            this.rdotaked.Name = "rdotaked";
            this.rdotaked.Size = new System.Drawing.Size(63, 21);
            this.rdotaked.TabIndex = 147;
            this.rdotaked.Text = "Taken";
            this.rdotaked.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdotaked.UncheckedState.BorderThickness = 2;
            this.rdotaked.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdotaked.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdomissed
            // 
            this.rdomissed.AutoSize = true;
            this.rdomissed.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.rdomissed.CheckedState.BorderThickness = 0;
            this.rdomissed.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.rdomissed.CheckedState.InnerColor = System.Drawing.Color.WhiteSmoke;
            this.rdomissed.CheckedState.InnerOffset = -4;
            this.rdomissed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rdomissed.FlatAppearance.BorderSize = 0;
            this.rdomissed.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rdomissed.Location = new System.Drawing.Point(130, 166);
            this.rdomissed.Name = "rdomissed";
            this.rdomissed.Size = new System.Drawing.Size(67, 21);
            this.rdomissed.TabIndex = 148;
            this.rdomissed.Text = "Missed";
            this.rdomissed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdomissed.UncheckedState.BorderThickness = 2;
            this.rdomissed.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdomissed.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblDos);
            this.panel2.Controls.Add(this.rdomissed);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.rdotaked);
            this.panel2.Controls.Add(this.lbltime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblType);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblMsg);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 212);
            this.panel2.TabIndex = 149;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(432, 261);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alarm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.Shown += new System.EventHandler(this.Alarm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDos;
        private Guna.UI2.WinForms.Guna2RadioButton rdotaked;
        private Guna.UI2.WinForms.Guna2RadioButton rdomissed;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}