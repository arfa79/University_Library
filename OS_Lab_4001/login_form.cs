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
    public partial class login_form : Form
    {
        private SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public login_form()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=LAPTOP-L9GSU0TJ\\SQL2017;Initial Catalog=Library_DB;Integrated Security=True");
        }
       
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * From tblAdmin where aUser ='" + textBox1.Text + "' And aPass = '" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("ورود موفقیت آمیز بود");

                this.Visible = false;     //testing gitignore rule
                dashboard s = new dashboard();
                s.Visible = true;
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
            }
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
