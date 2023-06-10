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
    public partial class lend_return : Form
    {
        public lend_return()
        {
            InitializeComponent();
        }

        SqlConnection lr_con = new SqlConnection("Data Source =.; Initial Catalog = Library_DB; Integrated Security = True");
        SqlCommand lr_cmd = new SqlCommand();
        SqlDataReader lr_dr;
        public static int lr_book_id;
        public static int lr_user_id;
        private void lend_return_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lr_cmd = new SqlCommand();
            int lr_lend_id = Convert.ToInt32(textBox1.Text);
            lr_con.Open();
            lr_cmd.CommandText = "SELECT * FROM tblLend WHERE lId = '" + lr_lend_id + "' AND lReturned = 0 ";
            lr_cmd.Connection = lr_con;
            lr_dr = lr_cmd.ExecuteReader();


            if (lr_dr.Read())
            {
                MessageBox.Show("کد امانت معتبر است. می توانید ادامه دهید");
                button1.Visible = true;
                button2.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label4.Visible = true;
                lr_con.Close();

                
                //finding book id and user id
                lr_con.Open();
                SqlDataAdapter lr_da = new SqlDataAdapter("Select lBook, lUser From tblLend Where lId = '" + textBox1.Text + "'", lr_con);
                DataTable lr_dt = new DataTable();
                lr_da.Fill(lr_dt);
                DataRow row = lr_dt.Rows[0];
                lr_book_id = Convert.ToInt32(row["lBook"].ToString());
                lr_user_id = Convert.ToInt32(row["lUser"].ToString());
                lr_con.Close();

                //finding book name
                lr_con.Open();
                SqlDataAdapter lr_da1 = new SqlDataAdapter ("Select bName From tblBook Where bID = '" + lr_book_id + "'", lr_con);
                DataTable lr_dt1 = new DataTable();
                lr_da1.Fill(lr_dt1);
                DataRow row1 = lr_dt1.Rows[0];
                string lr_book_name = row1["bName"].ToString();
                lr_con.Close();

                //finding user name 
                lr_con.Open();
                SqlDataAdapter lr_da2 = new SqlDataAdapter("Select uFirstname, uLastname From tblUser Where uId = '" + lr_user_id + "'", lr_con);
                DataTable lr_dt2 = new DataTable();
                lr_da2.Fill(lr_dt2);
                DataRow row2 = lr_dt2.Rows[0];
                string lr_firstname = row2["uFirstname"].ToString();
                string lr_lastname = row2["uLastname"].ToString();
                string lr_name = lr_firstname + " " + lr_lastname;


                //setting labels
                label5.Text = lr_book_name;
                label6.Text = lr_name;

            }
            else 
            {
                MessageBox.Show("امانت نامعتبر. این کد قبلا بازگشت داده شده یا اشتباه است.");
                lr_con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //runnig tblLend query
            using (var lr_con1 = new SqlConnection("Data Source=.;Initial Catalog=Library_DB;Integrated Security=True"))
            {
                lr_con1.Open();

                using (var command = lr_con1.CreateCommand())
                {
                    //executing query on tblLends
                    command.CommandText = "UPDATE tblLend SET lReturned = 1 WHERE lId = @lid;";
                    command.Parameters.Add(new SqlParameter("lid",textBox1.Text ));
                    command.ExecuteNonQuery();

                    //executing query on tblUser
                    command.CommandText = "UPDATE tblUser SET uBorrowedcount = uBorrowedcount -1 WHERE uId = @uid;";
                    command.Parameters.Add(new SqlParameter("uid", lr_user_id));
                    command.ExecuteNonQuery();

                    //executing query on tblBook
                    command.CommandText = "UPDATE tblBook SET bBorrowd = 0 WHERE bID = @bid1;";
                    command.Parameters.Add(new SqlParameter("bid1", lr_book_id));
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("برگشت امانت با موفقیت ثبت شد");
            this.Hide();

        }
    }
}
