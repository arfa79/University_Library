using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OS_Lab_4001
{
    public partial class user_form : Form
    {
        private SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public user_form()
        {
            //*** connection string ***
            InitializeComponent();
            con = new SqlConnection("Data Source=LAPTOP-L9GSU0TJ\\SQL2017;Initial Catalog=Library_DB;Integrated Security=True");
        }

        private void user_form_Load(object sender, EventArgs e)
        {
            user_dataGridView.AutoGenerateColumns = false;
            con.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from tblUser", con);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            user_dataGridView.DataSource = dtbl;
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dashboard d = new dashboard();
            d.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            add_new_user_form mf = new add_new_user_form();
            mf.Visible = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            DialogResult dialog = MessageBox.Show("آیا از حذف این عضو مطمئن هستید؟", "حذف عضویت", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string bns = deleteuserbox.Text;
                SqlDataAdapter sqlDA = new SqlDataAdapter("DELETE from tbluser where uId like '" + bns + "'", con);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);
                user_dataGridView.Refresh();
                MessageBox.Show("حذف غضویت با موفقیت انجام شد");
            }
            else
            {
                MessageBox.Show("حذف غضویت انجام نشد");
            }

            con.Close();
            
        }

        private void user_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string bns = user_id.Text;
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from tbluser where uId like '" + bns + "'", con);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            user_dataGridView.DataSource = dtbl;
            user_dataGridView.Refresh();
            con.Close(); ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string bns = user_familyname.Text;
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from tbluser where User_LastName like '" + bns + "'", con);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            user_dataGridView.DataSource = dtbl;
            con.Close();
        }

        private void user_familyname_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            edit_user eu = new edit_user();
            eu.Visible = true;
        }
    }
}
