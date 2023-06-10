
namespace OS_Lab_4001
{
    partial class lend_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lend_dg = new System.Windows.Forms.DataGridView();
            this.lLend_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lBook_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDaycount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.library_DBDataSet = new OS_Lab_4001.Library_DBDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lend_dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(409, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "جست و جو";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Location = new System.Drawing.Point(408, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "جست و جو";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Location = new System.Drawing.Point(25, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 72);
            this.button3.TabIndex = 2;
            this.button3.Text = "ثبت امانت جدید";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lend_dg
            // 
            this.lend_dg.AutoGenerateColumns = false;
            this.lend_dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lend_dg.BackgroundColor = System.Drawing.Color.MintCream;
            this.lend_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lend_dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lLend_id,
            this.lBook_id,
            this.lUser,
            this.lDate,
            this.lDaycount,
            this.lReturned});
            this.lend_dg.DataSource = this.libraryDBDataSetBindingSource;
            this.lend_dg.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lend_dg.Location = new System.Drawing.Point(25, 196);
            this.lend_dg.Name = "lend_dg";
            this.lend_dg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lend_dg.RowHeadersWidth = 51;
            this.lend_dg.RowTemplate.Height = 24;
            this.lend_dg.Size = new System.Drawing.Size(738, 195);
            this.lend_dg.TabIndex = 3;
            this.lend_dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lend_dg_CellContentClick);
            // 
            // lLend_id
            // 
            this.lLend_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.lLend_id.DataPropertyName = "lId";
            this.lLend_id.HeaderText = "کد امانت";
            this.lLend_id.MinimumWidth = 6;
            this.lLend_id.Name = "lLend_id";
            this.lLend_id.Width = 76;
            // 
            // lBook_id
            // 
            this.lBook_id.DataPropertyName = "lBook";
            this.lBook_id.HeaderText = "کد کتاب";
            this.lBook_id.MinimumWidth = 6;
            this.lBook_id.Name = "lBook_id";
            // 
            // lUser
            // 
            this.lUser.DataPropertyName = "lUser";
            this.lUser.HeaderText = "کد کاربر";
            this.lUser.MinimumWidth = 6;
            this.lUser.Name = "lUser";
            // 
            // lDate
            // 
            this.lDate.DataPropertyName = "lDate";
            this.lDate.HeaderText = "تاریخ ثبت";
            this.lDate.MinimumWidth = 6;
            this.lDate.Name = "lDate";
            // 
            // lDaycount
            // 
            this.lDaycount.DataPropertyName = "lDaycount";
            this.lDaycount.HeaderText = "مدت";
            this.lDaycount.MinimumWidth = 6;
            this.lDaycount.Name = "lDaycount";
            // 
            // lReturned
            // 
            this.lReturned.DataPropertyName = "lReturned";
            this.lReturned.HeaderText = "پس داده شده";
            this.lReturned.MinimumWidth = 6;
            this.lReturned.Name = "lReturned";
            // 
            // libraryDBDataSetBindingSource
            // 
            this.libraryDBDataSetBindingSource.DataSource = this.library_DBDataSet;
            this.libraryDBDataSetBindingSource.Position = 0;
            // 
            // library_DBDataSet
            // 
            this.library_DBDataSet.DataSetName = "Library_DBDataSet";
            this.library_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MintCream;
            this.textBox1.Location = new System.Drawing.Point(528, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.MintCream;
            this.textBox2.Location = new System.Drawing.Point(528, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 22);
            this.textBox2.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CadetBlue;
            this.button4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Location = new System.Drawing.Point(25, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "ثبت بازگشت کتاب";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button5.Location = new System.Drawing.Point(528, 411);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 41);
            this.button5.TabIndex = 7;
            this.button5.Text = "بازگشت به داشبورد";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(700, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "جستجو";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(691, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "شماره امانت";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(709, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "کد کتاب";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(692, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "کد عضویت";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.MintCream;
            this.textBox3.Location = new System.Drawing.Point(528, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 22);
            this.textBox3.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CadetBlue;
            this.button6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button6.Location = new System.Drawing.Point(409, 127);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 32);
            this.button6.TabIndex = 13;
            this.button6.Text = "جست و جو";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lend_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::OS_Lab_4001.Properties.Resources._39_Create_a_Login_Form_in_Adobe_Photoshop_From_Scratch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lend_dg);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "lend_form";
            this.Text = "مدیریت امانات";
            this.Load += new System.EventHandler(this.lend_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lend_dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.library_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView lend_dg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource libraryDBDataSetBindingSource;
        private Library_DBDataSet library_DBDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn lLend_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lBook_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDaycount;
        private System.Windows.Forms.DataGridViewTextBoxColumn lReturned;
    }
}