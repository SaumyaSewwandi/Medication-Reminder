using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Media;
using System.Threading;

namespace Medic
{
    public partial class UC_Reminder : UserControl
    {
        delegate void Updatelbl(Label lbl, string value);
        delegate void Updatetime(DateTimePicker ta, string value);
        SqlConnection con = new SqlConnection("Data Source=SEWWANDI\\SQLEXPRESS;Initial Catalog=MedicalReminder;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource TblContactsBS = new BindingSource();

        Alarm alarm;

        string msg;
        string MedicineName;
        string MedicineType;
        string Dosage;

        System.Timers.Timer timer;

        public void UpdateDatelbl(Label lbl, string value)
        {
            lbl.Text = value;
        }
        public void UpdateTimetrimm(DateTimePicker ta, string value)
        {
            ta.Text = value;
        }

        public void SelectTime()
        {
            if ((checkMng.Checked == true) && (checkeve.Checked == false) && (checkNt.Checked == false))
            {
                checkeve.Invoke((MethodInvoker)(() => checkeve.Checked = false));
                timer.Stop();
            }
            else if ((checkMng.Checked == true) && (checkeve.Checked == true) && (checkNt.Checked == false))
            {


                checkMng.Invoke((MethodInvoker)(() => checkMng.Checked = false));
                timer.Stop();
                checkeve.Invoke((MethodInvoker)(() => checkeve.Checked = true));

                if (checkeve.Checked == true)
                {

                    //Updatetime tim = UpdateTimetrimm;
                    //if (timm.InvokeRequired)
                    //    Invoke(tim, timm, "12:00:00 PM");
                    //timm.Value = Convert.ToDateTime("7:00:00 AM");
                    DateTime Time = timm.Value;
                    timm.Invoke((MethodInvoker)(() => timm.Value = Time.AddSeconds(20)));
                    // timm.Invoke((MethodInvoker)(() => timm.Value = Time.AddHours(6)));
                    timer.Start();
                    Updatelbl Upd = UpdateDatelbl;
                    if (lblStatus.InvokeRequired)
                        Invoke(Upd, lblStatus, "Running....");

                    checkeve.Invoke((MethodInvoker)(() => checkeve.Checked = true));
                    // timer.Stop();

                }

            }
            else if ((checkMng.Checked == true) && (checkeve.Checked == false) && (checkNt.Checked == true))
            {

                checkMng.Invoke((MethodInvoker)(() => checkMng.Checked = false));
                timer.Stop();
                // checkNt.Invoke((MethodInvoker)(() => checkNt.Checked = true));

                if (checkNt.Checked == true)
                {

                    //Updatetime tim = UpdateTimetrimm;
                    //if (timm.InvokeRequired)
                    //    Invoke(tim, timm, "06:00:00 PM");
                    //timm.Value = Convert.ToDateTime("7:00:00 AM");
                    DateTime Time = timm.Value;
                    timm.Invoke((MethodInvoker)(() => timm.Value = Time.AddSeconds(40)));
                    //timm.Invoke((MethodInvoker)(() => timm.Value = Time.AddHours(12)));
                    timer.Start();
                    Updatelbl Upd = UpdateDatelbl;
                    if (lblStatus.InvokeRequired)
                        Invoke(Upd, lblStatus, "Running....");

                    checkNt.Invoke((MethodInvoker)(() => checkNt.Checked = true));

                    // timer.Stop();

                }

            }
            else if ((checkMng.Checked == false) && (checkeve.Checked == true) && (checkNt.Checked == true))
            {



                checkeve.Invoke((MethodInvoker)(() => checkeve.Checked = false));
                timer.Stop();

                if (checkNt.Checked == true)
                {

                    //Updatetime tim = UpdateTimetrimm;
                    //if (timm.InvokeRequired)
                    //    Invoke(tim, timm, "09:57:00 AM");
                    //timm.Value = Convert.ToDateTime("7:00:00 AM");
                    DateTime Time = timm.Value;
                    //timm.Invoke((MethodInvoker)(() => timm.Value = Time.AddHours(6)));
                    timm.Invoke((MethodInvoker)(() => timm.Value = Time.AddSeconds(40)));
                    timer.Start();
                    Updatelbl Upd = UpdateDatelbl;
                    if (lblStatus.InvokeRequired)
                        Invoke(Upd, lblStatus, "Running....");

                    checkNt.Invoke((MethodInvoker)(() => checkNt.Checked = true));

                    // timer.Stop();

                }


            }
            else if ((checkMng.Checked == true) && (checkeve.Checked == true) && (checkNt.Checked == true))
            {


                checkMng.Invoke((MethodInvoker)(() => checkMng.Checked = false));
                timer.Stop();

                if ((checkeve.Checked == true) && (checkNt.Checked == true))
                {

                    //Updatetime tim = UpdateTimetrimm;
                    //if (timm.InvokeRequired)
                    //    Invoke(tim, timm, "09:57:00 AM");
                    //timm.Value = Convert.ToDateTime("7:00:00 AM");
                    DateTime Time = timm.Value;
                    //timm.Invoke((MethodInvoker)(() => timm.Value = Time.AddHours(6)));
                    timm.Invoke((MethodInvoker)(() => timm.Value = Time.AddSeconds(20)));
                    timer.Start();
                    Updatelbl Upd = UpdateDatelbl;
                    if (lblStatus.InvokeRequired)
                        Invoke(Upd, lblStatus, "Running....");

                    checkeve.Invoke((MethodInvoker)(() => checkeve.Checked = true));

                    //  timer.Stop();

                }

                checkNt.Invoke((MethodInvoker)(() => checkNt.Checked = true));

            }
            else if ((checkMng.Checked == false) && (checkeve.Checked == true) && (checkNt.Checked == false))
            {
                checkeve.Invoke((MethodInvoker)(() => checkeve.Checked = false));
                timer.Stop();

            }
            else if ((checkMng.Checked == false) && (checkeve.Checked == false) && (checkNt.Checked == true))
            {

                checkNt.Invoke((MethodInvoker)(() => checkNt.Checked = false));
                timer.Stop();

            }
        }

        public UC_Reminder()
        {
            InitializeComponent();
            alarm = new Alarm(this);
        }
       
        private void btnStart_Click(object sender, EventArgs e)
        {
            msg = txtMsg.Text;
            MedicineType = cboName.Text;
            MedicineName = cboType2.Text;
            Dosage = cbodosge.Text;

            alarm.Message(msg);
            alarm.MName(MedicineName);
            alarm.Mtype(MedicineType);
            alarm.Mdsg(Dosage);

            timer.Start();
            lblStatus.Text = "Running.....";

            if (checkMng.Checked == true)
            {
                //timm.Value = Convert.ToDateTime("7:00:00 AM");
                DateTime Time = timm.Value;

            }
            else if (checkeve.Checked == true)
            {

                //timm.Value = Convert.ToDateTime("1:00:00 PM");
                DateTime Time = timm.Value;
            }
            else if (checkNt.Checked == true)
            {

                //timm.Value = Convert.ToDateTime("7:00:00 PM");
                DateTime Time = timm.Value;
            }

        }

        private void cboType2_SelectedValueChanged(object sender, EventArgs e)
        {
            cboName.Items.Clear();
            String str2 = "Select MedicineName from Medicine where MedicineType ='" + cboType2.Text + "'";
            SqlCommand cmd2 = new SqlCommand(str2, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cboName.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

            //dosage value
            cbodosge.Items.Clear();

            if (cboType2.Text == "Capsule")
            {
                cbodosge.Items.Add("1 Tablet");
                cbodosge.Items.Add("2 Tablets");
                cbodosge.Items.Add("3 Tablets");
            }
            if (cboType2.Text == "Drops")
            {
                cbodosge.Items.Add("10 ml");
                cbodosge.Items.Add("50 ml");
                cbodosge.Items.Add("100 ml");
            }
            if (cboType2.Text == "Inhaler")
            {
                cbodosge.Items.Add("10 mg");
                cbodosge.Items.Add("50 mg");
                cbodosge.Items.Add("100 mg");
            }
            if (cboType2.Text == "Injection")
            {
                cbodosge.Items.Add("10 ml");
                cbodosge.Items.Add("50 ml");
                cbodosge.Items.Add("100 ml");
            }
            if (cboType2.Text == "Ointment")
            {
                cbodosge.Items.Add("10 mg");
                cbodosge.Items.Add("50 mg");
                cbodosge.Items.Add("100 mg");
            }
            if (cboType2.Text == "Pill")
            {
                cbodosge.Items.Add("10 mg");
                cbodosge.Items.Add("25 mg");
                cbodosge.Items.Add("50 mg");
                cbodosge.Items.Add("100 mg");
                cbodosge.Items.Add("125 mg");
                cbodosge.Items.Add("250 mg");
            }

           // cbotime.Items.Clear();
           // txtMsg.Clear();
        }

        private void cbotime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbotime.SelectedItem == "Two times per day") || (cbotime.SelectedItem == "Three times per day"))
            {
                gbSelect.Show();

            }
            else if (cbotime.SelectedItem == "One time per day")
            {
                gbSelect.Hide();

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblStatus.Text = "Stop!!";
            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }

        private void UC_Remainder_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer_Elapsed;

            gbSelect.Hide();
            
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime CurrentTime = DateTime.Now;
            DateTime userTime = timm.Value;
            if (CurrentTime.Hour == userTime.Hour && CurrentTime.Minute == userTime.Minute && CurrentTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    Thread t1 = new Thread(SelectTime);
                    t1.Start();

                    Updatelbl Upd = UpdateDatelbl;
                    if (lblStatus.InvokeRequired)
                        Invoke(Upd, lblStatus, "Time to Take Medicine");
                    SoundPlayer player = new SoundPlayer();

                    player.SoundLocation = @"D:\My Projects\Medical_Final\Medic_Final/notify.wav";
                    player.PlayLooping();

                    alarm.ShowDialog();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void cboType2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            String str2 = "Select * from Medicine where MedicineName ='" + cboName.Text + "'";
            SqlCommand cmd2 = new SqlCommand(str2, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cbodosge.Text = ds.Tables[0].Rows[0][3].ToString();
                cbotime.Text = ds.Tables[0].Rows[0][6].ToString();
                txtMsg.Text = ds.Tables[0].Rows[0][7].ToString();
            }       
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void cbotime_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        public void clearAll()
        {

            txtMsg.Clear();
            cboName.SelectedIndex = -1;
            cboType2.SelectedIndex = -1;
            cbodosge.Text = "";
            cbotime.SelectedIndex = -1;
            lblStatus.Text = "";
            gbSelect.Hide();
        
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
