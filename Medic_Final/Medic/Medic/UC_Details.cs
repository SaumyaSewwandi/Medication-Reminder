using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medic
{
    public partial class UC_Details : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=SEWWANDI\\SQLEXPRESS;Initial Catalog=MedicalReminder;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource TblContactsBS = new BindingSource();
        string query;

        public UC_Details()
        {
            InitializeComponent();
        }

        private void UC_Details_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from Medicine";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            SA.Fill(dt);
            dg1.DataSource = dt;
            con.Close();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * From Medicine Where MedicineName like '" + txtSearch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter SA = new SqlDataAdapter(cmd);
            SA.Fill(dt);
            dg1.DataSource = dt;
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg1_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = dg1.SelectedRows[0].Cells[1].Value.ToString();
            cbotype.Text = dg1.SelectedRows[0].Cells[2].Value.ToString();
            cbodosge.Text = dg1.SelectedRows[0].Cells[3].Value.ToString();
            addDate.Text = dg1.SelectedRows[0].Cells[4].Value.ToString();
            edate.Text = dg1.SelectedRows[0].Cells[5].Value.ToString();
            cbotime.Text = dg1.SelectedRows[0].Cells[6].Value.ToString();
            txtdes.Text = dg1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();

            int Id = int.Parse(dg1.SelectedRows[0].Cells[0].Value.ToString());
            query = "Update Medicine set MedicineName = '" + txtSearch.Text + "',MedicineType = '" + cbotype.Text + "',Dosage = '" + cbodosge.Text + "',StartDate ='" + addDate.Text + "',ExpireDate = '" + edate.Text + "',NTimes = '" + cbotime.Text + "',Description ='" + txtdes.Text + "' Where MID = " + Id + "";

            SqlDataAdapter SA = new SqlDataAdapter(query, con);
            SA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Update Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearAll();
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(dg1.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult dr;
            dr = MessageBox.Show("Are you sure\nThere is no undo after delete ", "Confirm Deletion ", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                con.Open();
                query = "DELETE FROM Medicine WHERE MID = " + Id + "";
                SqlDataAdapter SA = new SqlDataAdapter(query, con);
                SA.SelectCommand.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Delete Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
                loadData();
            }
            else
            {
                MessageBox.Show("Deletion Cancelled");
            }
        }

        public void clearAll()
        {
            txtSearch.Clear();
            cbotype.SelectedIndex = -1;
            cbodosge.SelectedIndex = -1;
            addDate.Text = "";
            edate.Text = "";
            cbotime.SelectedIndex = -1;
            txtdes.Clear();
        }

        private void dg1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbotype_SelectedValueChanged(object sender, EventArgs e)
        {
            cbodosge.Items.Clear();

            if (cbotype.Text == "Capsule")
            {
                cbodosge.Items.Add("1 Tablet");
                cbodosge.Items.Add("2 Tablets");
                cbodosge.Items.Add("3 Tablets");
            }
            if (cbotype.Text == "Drops")
            {
                cbodosge.Items.Add("10 ml");
                cbodosge.Items.Add("50 ml");
                cbodosge.Items.Add("100 ml");
            }
            if (cbotype.Text == "Inhaler")
            {
                cbodosge.Items.Add("10 mg");
                cbodosge.Items.Add("50 mg");
                cbodosge.Items.Add("100 mg");
            }
            if (cbotype.Text == "Injection")
            {
                cbodosge.Items.Add("10 ml");
                cbodosge.Items.Add("50 ml");
                cbodosge.Items.Add("100 ml");
            }
            if (cbotype.Text == "Ointment")
            {
                cbodosge.Items.Add("10 mg");
                cbodosge.Items.Add("50 mg");
                cbodosge.Items.Add("100 mg");
            }
            if (cbotype.Text == "Pill")
            {
                cbodosge.Items.Add("10 mg");
                cbodosge.Items.Add("25 mg");
                cbodosge.Items.Add("50 mg");
                cbodosge.Items.Add("100 mg");
                cbodosge.Items.Add("125 mg");
                cbodosge.Items.Add("250 mg");
            }
        }

        private void cbodosge_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadData();
            clearAll();
        }
    }
}
