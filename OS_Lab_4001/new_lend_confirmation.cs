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
    public partial class new_lend_confirmation : Form
    {
        public new_lend_confirmation()
        {
            InitializeComponent();
        }

        private void new_lend_confirmation_Load(object sender, EventArgs e)
        {
            label6.Text = new_lend_form.nl_book_name;
            label7.Text = new_lend_form.nlc_name;
            label9.Text = Convert.ToString(new_lend_form.nl_duration);
            
    }
            
                   
          
        

        private void button1_Click(object sender, EventArgs e)
        {
            int uid = new_lend_form.nl_user_id;
            int bid = new_lend_form.nl_book_id;
            int daycount = new_lend_form.nl_duration;
            DateTime nlcdate = new_lend_form.nl_date;

            using (var nlc_con = new SqlConnection("Data Source=.;Initial Catalog=Library_DB;Integrated Security=True"))
            {
                nlc_con.Open();

                using (var command = nlc_con.CreateCommand())
                {
                    command.CommandText = "INSERT INTO tblLend (lBook, lUser, lDate, lDaycount, lReturned) VALUES(@bid, @uid, @date, @dc, 0);";
                    command.Parameters.Add(new SqlParameter("uid",uid));
                    command.Parameters.Add(new SqlParameter("bid", bid));
                    command.Parameters.Add(new SqlParameter("dc", daycount));
                    command.Parameters.Add(new SqlParameter("date", nlcdate));
                    command.ExecuteNonQuery();

                    command.CommandText = "UPDATE tblUser SET uBorrowedcount = uBorrowedcount + 1 WHERE uId = @uid1;";
                    command.Parameters.Add(new SqlParameter("uid1", uid));
                    command.ExecuteNonQuery();

                    command.CommandText = "UPDATE tblBook SET bBorrowd = 1 WHERE bID = @bid1;";
                    command.Parameters.Add(new SqlParameter("bid1", bid));
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("امانت با موفقیت ثبت شد");
            this.Hide();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}