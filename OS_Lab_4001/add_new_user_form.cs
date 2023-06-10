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
   
    public partial class add_new_user_form : Form
    {
        private SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public add_new_user_form()
        {
            //*** connection string ***
            InitializeComponent();
            con = new SqlConnection("Data Source=LAPTOP-L9GSU0TJ\\SQL2017;Initial Catalog=Library_DB;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime user_bd = dateTimePicker1.Value.Date;
            DateTime user_reg_date = dateTimePicker2.Value.Date;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO tblUser (uFirstname, uLastname, uGender, uBirthday, uPhonenumber, uAddress, uRegisteratiodate, uBorrowedcount) VALUES ('" + name.Text + "','" + familyname.Text + "','" + gender.Text + "','" + user_bd + "','" + phonenumber.Text + "','" + address.Text + "','" + user_reg_date + "', 0);";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("عضویت با موفقیت انجام شد");
            this.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            user_form lm = new user_form();
            lm.Visible = true;
        }

        private void add_new_user_form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
