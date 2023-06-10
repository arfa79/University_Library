using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Lab_4001
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            category_form cf = new category_form();
            cf.Visible=true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            lend_form l = new lend_form();
            l.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Books_form cf = new Books_form();
            cf.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login_form cf = new login_form();
            cf.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            user_form uf = new user_form();
            uf.Visible = true;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
