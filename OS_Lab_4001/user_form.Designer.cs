namespace OS_Lab_4001
{
    partial class user_form
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.user_familyname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.user_dataGridView = new System.Windows.Forms.DataGridView();
            this.Users_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regesterdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteuserbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(939, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 41);
            this.button6.TabIndex = 37;
            this.button6.Text = "بازگشت به داشبورد";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(919, 302);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(248, 47);
            this.button5.TabIndex = 36;
            this.button5.Text = "حذف عضویت";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(919, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 34);
            this.button3.TabIndex = 35;
            this.button3.Text = "جست و جو";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // user_familyname
            // 
            this.user_familyname.Location = new System.Drawing.Point(906, 109);
            this.user_familyname.Name = "user_familyname";
            this.user_familyname.Size = new System.Drawing.Size(190, 22);
            this.user_familyname.TabIndex = 34;
            this.user_familyname.TextChanged += new System.EventHandler(this.user_familyname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1102, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "نام خانوادگی";
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(906, 27);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(190, 22);
            this.user_id.TabIndex = 32;
            this.user_id.TextChanged += new System.EventHandler(this.user_id_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1105, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "کد عضویت";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "جستجو";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(919, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 34);
            this.button2.TabIndex = 29;
            this.button2.Text = "جست و جو";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Location = new System.Drawing.Point(919, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 47);
            this.button1.TabIndex = 28;
            this.button1.Text = "فرم عضویت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_dataGridView
            // 
            this.user_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.user_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Users_Id,
            this.fname,
            this.lname,
            this.gender,
            this.birthdate,
            this.phonenumber,
            this.adress,
            this.regesterdate});
            this.user_dataGridView.Location = new System.Drawing.Point(28, 27);
            this.user_dataGridView.Name = "user_dataGridView";
            this.user_dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.user_dataGridView.RowHeadersWidth = 51;
            this.user_dataGridView.RowTemplate.Height = 24;
            this.user_dataGridView.Size = new System.Drawing.Size(872, 398);
            this.user_dataGridView.TabIndex = 27;
            this.user_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Users_Id
            // 
            this.Users_Id.DataPropertyName = "uId";
            this.Users_Id.HeaderText = "کد عضویت";
            this.Users_Id.MinimumWidth = 6;
            this.Users_Id.Name = "Users_Id";
            this.Users_Id.Width = 125;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "uFirstname";
            this.fname.HeaderText = "نام";
            this.fname.MinimumWidth = 6;
            this.fname.Name = "fname";
            this.fname.Width = 125;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "uLastname";
            this.lname.HeaderText = "نام خانوادگی";
            this.lname.MinimumWidth = 6;
            this.lname.Name = "lname";
            this.lname.Width = 125;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "uGender";
            this.gender.HeaderText = "جنسیت";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.Width = 125;
            // 
            // birthdate
            // 
            this.birthdate.DataPropertyName = "uBirthday";
            this.birthdate.HeaderText = "تاریخ تولد";
            this.birthdate.MinimumWidth = 6;
            this.birthdate.Name = "birthdate";
            this.birthdate.Width = 125;
            // 
            // phonenumber
            // 
            this.phonenumber.DataPropertyName = "uPhonenumber";
            this.phonenumber.HeaderText = "شماره تلفن";
            this.phonenumber.MinimumWidth = 6;
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Width = 125;
            // 
            // adress
            // 
            this.adress.DataPropertyName = "uAddress";
            this.adress.HeaderText = "آدرس";
            this.adress.MinimumWidth = 6;
            this.adress.Name = "adress";
            this.adress.Width = 125;
            // 
            // regesterdate
            // 
            this.regesterdate.DataPropertyName = "uRegisteratiodate";
            this.regesterdate.HeaderText = "تاریخ عضویت";
            this.regesterdate.MinimumWidth = 6;
            this.regesterdate.Name = "regesterdate";
            this.regesterdate.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(1107, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "کد عضویت ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // deleteuserbox
            // 
            this.deleteuserbox.Location = new System.Drawing.Point(906, 264);
            this.deleteuserbox.Name = "deleteuserbox";
            this.deleteuserbox.Size = new System.Drawing.Size(190, 22);
            this.deleteuserbox.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1105, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "برای حذف";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button4.Location = new System.Drawing.Point(1053, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 47);
            this.button4.TabIndex = 41;
            this.button4.Text = "اصلاح مشخصات";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // user_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::OS_Lab_4001.Properties.Resources._39_Create_a_Login_Form_in_Adobe_Photoshop_From_Scratch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 449);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteuserbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.user_familyname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_dataGridView);
            this.Name = "user_form";
            this.Text = "user_form";
            this.Load += new System.EventHandler(this.user_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox user_familyname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView user_dataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deleteuserbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Users_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn regesterdate;
        private System.Windows.Forms.Button button4;
    }
}