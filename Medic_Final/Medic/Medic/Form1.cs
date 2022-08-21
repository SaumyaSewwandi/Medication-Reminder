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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SEWWANDI-PC\\SQLEXPRESS;Initial Catalog=MedicalReminder;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource TblContactsBS = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();
            uC_Details1.Visible = false;
            uC_Record1.Visible = false;
            uC_Reminder1.Visible = false;
            uC_Home11.Visible = false;

        }

        private void btnRemaind_Click(object sender, EventArgs e)
        {
            uC_Reminder1.Visible = true;
            uC_Reminder1.BringToFront();
            
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            uC_Record1.Visible = true;
            uC_Record1.BringToFront();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            uC_Details1.Visible = true;
            uC_Details1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_Details1.Visible = false;
            uC_Record1.Visible = false;
            uC_Reminder1.Visible = false;
            panel4.Visible = true;
            uC_Home11.Visible = true;
            btnHome.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void uC_Record1_Load(object sender, EventArgs e)
        {

        }

        private void btnalm_Click(object sender, EventArgs e)
        {
            btnRemaind.PerformClick();

        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            uC_Home11.Visible = true;
            uC_Home11.BringToFront();

        }

        private void uC_Remainder1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            da.InsertCommand = new SqlCommand("INSERT INTO Medicine VALUES(@MedicineName, @MedicineType,@Dosage,@StartDate,@ExpireDate,@NTimes,@Description )", con);
            da.InsertCommand.Parameters.Add("@MedicineName", SqlDbType.VarChar).Value = txtMname.Text;
            da.InsertCommand.Parameters.Add("@MedicineType", SqlDbType.VarChar).Value = cbotype.SelectedItem;
            da.InsertCommand.Parameters.Add("@Dosage", SqlDbType.VarChar).Value = cbodosge.SelectedItem;
            da.InsertCommand.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = addDate.Text;
            da.InsertCommand.Parameters.Add("@ExpireDate", SqlDbType.DateTime).Value = edate.Text;
            da.InsertCommand.Parameters.Add("@NTimes", SqlDbType.VarChar).Value = cbotime.SelectedItem;
            da.InsertCommand.Parameters.Add("@Description", SqlDbType.VarChar).Value = txtdes.Text;


            con.Open();
            da.InsertCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtMname.Clear();
            cbotype.SelectedIndex = -1;
            cbodosge.SelectedIndex = -1;
            addDate.Text = "";
            edate.Text = "";
            cbotime.SelectedIndex = -1;
            txtdes.Clear();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbodosge_SelectedValueChanged(object sender, EventArgs e)
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

        private void uC_Reminder1_Load(object sender, EventArgs e)
        {

        }
    }
}
