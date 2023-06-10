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
    public partial class Books_form : Form
    {
        private SqlConnection cont;
        SqlCommand cmd ;

        public Books_form()
        {
            InitializeComponent();
            cont = new SqlConnection("Data Source=LAPTOP-L9GSU0TJ\\SQL2017;Initial Catalog=Library_DB;Integrated Security=True");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Books_Load(object sender, EventArgs e)
        {
            cont.Open();            
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from tblBook", cont);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            book_dataGridView.DataSource = dtbl;
            cont.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dashboard d = new dashboard();
            d.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            user_form o = new user_form();
            o.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            lend_form l = new lend_form();
            l.Visible = true;
        }

        private void scale_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            category_form cf = new category_form();
            cf.Visible = true;
        }

        private void eddit_button_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(book_dataGridView.SelectedCells[0].Value.ToString());
            try
            {
                cmd = new SqlCommand();
                cont.Open();
                cmd.Connection = cont;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tblBook set bName='" + book_name_search.Text + "',bAuthor='" + author_books.Text + "',bYear='" + year_books.Text + "',bCategory='" + category_books.Text + "',bTags='" + tags_books.Text + "',bLocation='" + location_books.Text + "',bPublisher='" + publisher_books.Text + "',bTranslator='" + translator_books.Text + "' where bID=" + i + "";
                cmd.ExecuteNonQuery();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from tblBook", cont);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);
                book_dataGridView.DataSource = dtbl;
                cont.Close();
                MessageBox.Show("کتاب مورد نظر با موفقیت ویرایش شد");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void book_name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void publisher_name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            cont.Open();
            string bns = book_name_search.Text;
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from tblBook where bName like '" + bns + "'", cont);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            book_dataGridView.DataSource = dtbl;
            cont.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {            
            cmd = new SqlCommand();
            cont.Open();
            cmd.Connection = cont;
            cmd.CommandText = "INSERT INTO tblBook (bName , bAuthor, bYear , bCategory , bTags , bBorrowd , bLocation , bPublisher , bTranslator) VALUES ('" + book_name_search.Text + "','" + author_books.Text + "','" + year_books.Text + "','" + category_books.Text + "','" + tags_books.Text + "','0','" + location_books.Text + "','" + publisher_books.Text + "','" + translator_books.Text + "')";
            cmd.ExecuteNonQuery();
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from tblBook", cont);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            book_dataGridView.DataSource = dtbl;
            cont.Close();      
            MessageBox.Show("کتاب مورد نظر با موفقیت ثبت شد");
            

        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cont.Open();
            cmd.Connection = cont;
            DialogResult dialog = MessageBox.Show("آیا از حذف این کتاب مطمئن هستید؟", "حذف کتاب", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string bns = book_name_search.Text;
                SqlDataAdapter sqlDA = new SqlDataAdapter("DELETE from tblBook where bName like '" + bns + "'", cont);
                DataTable dtbl = new DataTable();
                sqlDA.Fill(dtbl);
                MessageBox.Show("کتاب مورد نظر با موفقیت حذف شد");
            }
            else
            {
                MessageBox.Show("کتاب مورد نظر حذف نشد");
            }
            SqlDataAdapter sqlDA2 = new SqlDataAdapter("SELECT * FROM tblBook", cont);
            DataTable dtbl2 = new DataTable();
            sqlDA2.Fill(dtbl2);
            book_dataGridView.DataSource = dtbl2;
            cont.Close();            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(book_dataGridView.SelectedCells[0].Value.ToString());
            try
            {
                cmd = new SqlCommand();
                cont.Open();
                cmd.Connection = cont;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblbook WHERE bID=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    book_name_search.Text = dr["bName"].ToString();                    
                    author_books.Text = dr["bAuthor"].ToString();
                    year_books.Text = dr["bYear"].ToString();
                    location_books.Text = dr["bLocation"].ToString();
                    translator_books.Text = dr["bTranslator"].ToString();
                    publisher_books.Text = dr["bPublisher"].ToString();
                    category_books.Text = dr["bCategory"].ToString();
                    tags_books.Text = dr["bTags"].ToString();                    
                }                     
                cont.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void book_name_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * from tblBook", cont);
            DataTable dtbl = new DataTable();
            sqlDA.Fill(dtbl);
            book_dataGridView.DataSource = dtbl;
            cont.Close();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
