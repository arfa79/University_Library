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
    public partial class lend_form : Form
    {
        SqlConnection lend_con = new SqlConnection("Data Source=LAPTOP-L9GSU0TJ\\SQL2017;Initial Catalog=Library_DB;Integrated Security=True");
        SqlCommand lend_cmd;
        
        public lend_form()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            new_lend_form nlf = new new_lend_form();
            nlf.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lend_return lr = new lend_return();
            lr.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dashboard d = new dashboard();
            d.Visible = true;
        }

        private void lend_form_Load(object sender, EventArgs e)
        {
            //Showing values in DataGrid on Form Load Event
            lend_con.Open();
            SqlDataAdapter lend_da = new SqlDataAdapter("SELECT * FROM tblLend", lend_con);
            DataTable lend_dt = new DataTable();
            lend_da.Fill(lend_dt);
            lend_dg.DataSource = lend_dt;
            lend_dg.Refresh();
            lend_con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int lend_search_field3 = Convert.ToInt32(textBox3.Text);
            lend_con.Open();
            SqlDataAdapter lend_da = new SqlDataAdapter("SELECT * FROM tblLend WHERE lUser = ' " + lend_search_field3 + " ' ", lend_con);
            DataTable lend_dt = new DataTable();
            lend_da.Fill(lend_dt);
            lend_dg.DataSource = lend_dt;
            lend_con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lend_search_field1 = Convert.ToInt32(textBox1.Text);
            lend_con.Open();
            SqlDataAdapter lend_da = new SqlDataAdapter("SELECT * FROM tblLend WHERE lLend_id = ' " + lend_search_field1 + " ' ", lend_con);
            DataTable lend_dt = new DataTable();
            lend_da.Fill(lend_dt);
            lend_dg.DataSource = lend_dt;
            lend_con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lend_search_field2 = Convert.ToInt32(textBox2.Text);
            lend_con.Open();
            SqlDataAdapter lend_da = new SqlDataAdapter("SELECT * FROM tblLend WHERE lBook_id = ' " + lend_search_field2 + " ' ", lend_con);
            DataTable lend_dt = new DataTable();
            lend_da.Fill(lend_dt);
            lend_dg.DataSource = lend_dt;
            lend_con.Close();

        }

        private void lend_dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lend_dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void lend_dg_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
