using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;

namespace Medic
{
    public partial class Alarm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SEWWANDI\\SQLEXPRESS;Initial Catalog=MedicalReminder;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource TblContactsBS = new BindingSource();

        static UC_Reminder form;

        string msg;
        string MedicineName;
        string MedicineType;
        string Dosage;
        string mark;

        public void Message(string message)
        {
            msg = message;
        }
        public void MName(string name)
        {
            MedicineName = name;
        }
        public void Mtype(string type)
        {
            MedicineType = type;
        }
        public void Mdsg(string dosage)
        {
            Dosage = dosage;
        }
        public Alarm(UC_Reminder uC_Remainder)
        {
            InitializeComponent();
            form = uC_Remainder;
        }
      
        private void btnStop_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();

            if (rdotaked.Checked)
            {

                mark = "Taken";
            }
            else if (rdomissed.Checked)
            {

                mark = "Missed";

            }

            da.InsertCommand = new SqlCommand("INSERT INTO Reminder VALUES(@MedicineName, @MedicineType,@Dosage,@DateTaken,@Timetaken,@msg,@Mark )", con);
            da.InsertCommand.Parameters.Add("@MedicineName", SqlDbType.VarChar).Value = lblName.Text;
            da.InsertCommand.Parameters.Add("@MedicineType", SqlDbType.VarChar).Value = lblType.Text;
            da.InsertCommand.Parameters.Add("@Dosage", SqlDbType.VarChar).Value = lblDos.Text;
            da.InsertCommand.Parameters.Add("@DateTaken", SqlDbType.DateTime).Value = lblDate.Text;
            da.InsertCommand.Parameters.Add("@Timetaken", SqlDbType.DateTime).Value = lbltime.Text;
            da.InsertCommand.Parameters.Add("@msg", SqlDbType.VarChar).Value = lblMsg.Text;
            da.InsertCommand.Parameters.Add("@Mark", SqlDbType.VarChar).Value = mark;


            con.Open();
            da.InsertCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblName.Text = "";
            lblType.Text = "";
            lblDos.Text = "";
            lblMsg.Text = "";
            rdotaked.Checked = false;
            rdomissed.Checked = false;
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lbltime.Text = DateTime.Now.ToString("h:mm:ss tt");

        }

        private void btncls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alarm_Shown(object sender, EventArgs e)
        {
            lblName.Text = MedicineName;
            lblType.Text = MedicineType;
            lblMsg.Text = msg;
            lblDos.Text = Dosage;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
