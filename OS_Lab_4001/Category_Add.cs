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

namespace OS_Lab_4001
{
    public partial class Category_Add : Form
    {
        private SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Category_Add()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=LAPTOP-L9GSU0TJ\\SQL2017;Initial Catalog=Library_DB;Integrated Security=True");
        }
        private void backToCategoryEvent(object sender, EventArgs e)
        {
            this.Visible = false;
            category_form d = new category_form();
            d.Visible = true;
        }
        private void addCategoryEvent(object sender, EventArgs e)
        {
            string newCat = AddCategoryLBl.Text;
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into tblCategory(cCaption) values('" + newCat +"')";
            dr = cmd.ExecuteReader();
            MessageBox.Show("دسته بندی جدید ثبت شد");
            con.Close();
        }

        private void Category_Add_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
