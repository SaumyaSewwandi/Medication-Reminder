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
using DGVPrinterHelper;

namespace Medic
{
    public partial class UC_Record : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=SEWWANDI\\SQLEXPRESS;Initial Catalog=MedicalReminder;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource TblContactsBS = new BindingSource();

        public UC_Record()
        {
            InitializeComponent();
        }

        private void UC_Record_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from Reminder";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            SA.Fill(dt);
            dg2.DataSource = dt;
            con.Close();
        }

        private void bntlord_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Reminder where DateTaken between'" + dateFrom.Text + "' and '" + dateTo.Text + "'and Mark ='Taken'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            SA.Fill(dt);
            dg2.DataSource = dt;
            con.Close();
        }

        private void btnMissed_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Reminder where  Mark ='Missed'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            SA.Fill(dt);
            dg2.DataSource = dt;
            con.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //print
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Medication  Records";
            printer.SubTitle = string.Format("Date : {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dg2);
        }

        private void btnTaken_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Reminder where  Mark ='Taken'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            SA.Fill(dt);
            dg2.DataSource = dt;
            con.Close();
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dg2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbLoad_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Reminder where DateTaken between'" + dateFrom.Text + "' and '" + dateTo.Text + "'and Mark ='Taken'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            SA.Fill(dt);
            dg2.DataSource = dt;
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from Reminder";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            SA.Fill(dt);
            dg2.DataSource = dt;
            con.Close();
        }
    }
}
