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
    public partial class edit_user : Form
    {
        public edit_user()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Library_DB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public int user_id;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            user_id = int.Parse(textBox1.Text);
            con.Open();
            cmd.CommandText = "Select * From tblUser Where uId = '" + user_id + "' ";
            cmd.Connection = con;

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("کاربر موجود است ، می توانید ادامه دهید");
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                con.Close();

            }
            else
            {
                MessageBox.Show("متاسفانه کاربر موجود نمی باشد");
                con.Close();
            }
        }

        private void edit_user_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname = textBox2.Text;
            string lname = textBox3.Text;
            int gender = Convert.ToInt32(textBox4.Text);
            DateTime bd = dateTimePicker1.Value.Date;
            int phone = Convert.ToInt32(textBox5.Text);
            string address = textBox6.Text;
            DateTime regdate = dateTimePicker2.Value.Date;
            int bcount = Convert.ToInt32(textBox7.Text);

            using (var ncon = new SqlConnection("Data Source=.;Initial Catalog=Library_DB;Integrated Security=True"))
            {
                ncon.Open();

                using (var command = ncon.CreateCommand())
                {
                    command.CommandText = "UPDATE tblUser SET uFirstname = @fname, uLastname = @lname, uGender = @gender, uBirthday = @bd, uPhonenumber = @phone, uAddress = @address, uRegisteratiodate = @regdate, uBorrowedcount = @bcount WHERE  uId = @uid  ";
                    command.Parameters.Add(new SqlParameter("uid", user_id));
                    command.Parameters.Add(new SqlParameter("fname", fname));
                    command.Parameters.Add(new SqlParameter("lname", lname));
                    command.Parameters.Add(new SqlParameter("gender", gender));
                    command.Parameters.Add(new SqlParameter("bd", bd));
                    command.Parameters.Add(new SqlParameter("phone", phone));
                    command.Parameters.Add(new SqlParameter("address", address));
                    command.Parameters.Add(new SqlParameter("regdate", regdate));
                    command.Parameters.Add(new SqlParameter("bcount", bcount));
                    command.ExecuteNonQuery();

                }
            }

            MessageBox.Show("امانت با موفقیت ثبت شد");
            this.Hide();


        }
    }
}
