
namespace OS_Lab_4001
{
    partial class Books_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Books_form));
            this.remove_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.eddit_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.back_dashboard_button = new System.Windows.Forms.Button();
            this.lend_button = new System.Windows.Forms.Button();
            this.scale_button = new System.Windows.Forms.Button();
            this.membership_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tags_books = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.category_books = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.year_books = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.location_books = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.author_books = new System.Windows.Forms.TextBox();
            this.publisher_books = new System.Windows.Forms.TextBox();
            this.translator_books = new System.Windows.Forms.TextBox();
            this.book_name_search = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.book_dataGridView = new System.Windows.Forms.DataGridView();
            this.books_name_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Athour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // remove_button
            // 
            this.remove_button.BackColor = System.Drawing.Color.Red;
            this.remove_button.Location = new System.Drawing.Point(114, 359);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(75, 31);
            this.remove_button.TabIndex = 0;
            this.remove_button.Text = "حذف";
            this.remove_button.UseVisualStyleBackColor = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_button.Location = new System.Drawing.Point(195, 359);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 32);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "اضافه";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // eddit_button
            // 
            this.eddit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.eddit_button.Location = new System.Drawing.Point(195, 397);
            this.eddit_button.Name = "eddit_button";
            this.eddit_button.Size = new System.Drawing.Size(75, 32);
            this.eddit_button.TabIndex = 3;
            this.eddit_button.Text = "ویرایش";
            this.eddit_button.UseVisualStyleBackColor = false;
            this.eddit_button.Click += new System.EventHandler(this.eddit_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.search_button.Location = new System.Drawing.Point(114, 396);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 32);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "جستجو";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // back_dashboard_button
            // 
            this.back_dashboard_button.BackColor = System.Drawing.Color.Aqua;
            this.back_dashboard_button.Location = new System.Drawing.Point(1029, 381);
            this.back_dashboard_button.Name = "back_dashboard_button";
            this.back_dashboard_button.Size = new System.Drawing.Size(75, 34);
            this.back_dashboard_button.TabIndex = 5;
            this.back_dashboard_button.Text = "بازگشت";
            this.back_dashboard_button.UseVisualStyleBackColor = false;
            this.back_dashboard_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // lend_button
            // 
            this.lend_button.BackColor = System.Drawing.Color.Aqua;
            this.lend_button.Location = new System.Drawing.Point(948, 421);
            this.lend_button.Name = "lend_button";
            this.lend_button.Size = new System.Drawing.Size(75, 35);
            this.lend_button.TabIndex = 6;
            this.lend_button.Text = "امانات";
            this.lend_button.UseVisualStyleBackColor = false;
            this.lend_button.Click += new System.EventHandler(this.button6_Click);
            // 
            // scale_button
            // 
            this.scale_button.BackColor = System.Drawing.Color.Aqua;
            this.scale_button.Location = new System.Drawing.Point(1029, 421);
            this.scale_button.Name = "scale_button";
            this.scale_button.Size = new System.Drawing.Size(75, 35);
            this.scale_button.TabIndex = 7;
            this.scale_button.Text = "دسته بندی";
            this.scale_button.UseVisualStyleBackColor = false;
            this.scale_button.Click += new System.EventHandler(this.scale_button_Click);
            // 
            // membership_button
            // 
            this.membership_button.BackColor = System.Drawing.Color.Aqua;
            this.membership_button.Location = new System.Drawing.Point(948, 381);
            this.membership_button.Name = "membership_button";
            this.membership_button.Size = new System.Drawing.Size(75, 34);
            this.membership_button.TabIndex = 8;
            this.membership_button.Text = "اعضا";
            this.membership_button.UseVisualStyleBackColor = false;
            this.membership_button.Click += new System.EventHandler(this.button8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(369, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 90;
            this.label11.Text = "برچسب";
            // 
            // tags_books
            // 
            this.tags_books.Location = new System.Drawing.Point(200, 128);
            this.tags_books.Name = "tags_books";
            this.tags_books.Size = new System.Drawing.Size(158, 22);
            this.tags_books.TabIndex = 89;
            this.tags_books.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(464, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 88;
            this.label10.Text = "دسته بندی";
            // 
            // category_books
            // 
            this.category_books.Location = new System.Drawing.Point(295, 84);
            this.category_books.Name = "category_books";
            this.category_books.Size = new System.Drawing.Size(158, 22);
            this.category_books.TabIndex = 87;
            this.category_books.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(464, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 86;
            this.label12.Text = "سال چاپ";
            // 
            // year_books
            // 
            this.year_books.Location = new System.Drawing.Point(295, 56);
            this.year_books.Name = "year_books";
            this.year_books.Size = new System.Drawing.Size(158, 22);
            this.year_books.TabIndex = 85;
            this.year_books.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(253, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 16);
            this.label14.TabIndex = 82;
            this.label14.Text = "مکان";
            // 
            // location_books
            // 
            this.location_books.Location = new System.Drawing.Point(84, 28);
            this.location_books.Name = "location_books";
            this.location_books.Size = new System.Drawing.Size(158, 22);
            this.location_books.TabIndex = 81;
            this.location_books.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.location_books.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(253, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 16);
            this.label15.TabIndex = 80;
            this.label15.Text = "ناشر";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(253, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 16);
            this.label16.TabIndex = 79;
            this.label16.Text = "مترجم";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(464, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 16);
            this.label18.TabIndex = 77;
            this.label18.Text = "نویسنده";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(165, 436);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 16);
            this.label19.TabIndex = 76;
            this.label19.Text = "نام کتاب";
            // 
            // author_books
            // 
            this.author_books.Location = new System.Drawing.Point(295, 28);
            this.author_books.Name = "author_books";
            this.author_books.Size = new System.Drawing.Size(158, 22);
            this.author_books.TabIndex = 75;
            this.author_books.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.author_books.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // publisher_books
            // 
            this.publisher_books.Location = new System.Drawing.Point(84, 84);
            this.publisher_books.Name = "publisher_books";
            this.publisher_books.Size = new System.Drawing.Size(158, 22);
            this.publisher_books.TabIndex = 74;
            this.publisher_books.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // translator_books
            // 
            this.translator_books.Location = new System.Drawing.Point(84, 56);
            this.translator_books.Name = "translator_books";
            this.translator_books.Size = new System.Drawing.Size(158, 22);
            this.translator_books.TabIndex = 73;
            this.translator_books.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // book_name_search
            // 
            this.book_name_search.Location = new System.Drawing.Point(114, 462);
            this.book_name_search.Name = "book_name_search";
            this.book_name_search.Size = new System.Drawing.Size(158, 22);
            this.book_name_search.TabIndex = 71;
            this.book_name_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_name_search.TextChanged += new System.EventHandler(this.book_name_search_TextChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.label11);
            this.panel.Controls.Add(this.tags_books);
            this.panel.Controls.Add(this.translator_books);
            this.panel.Controls.Add(this.label10);
            this.panel.Controls.Add(this.publisher_books);
            this.panel.Controls.Add(this.category_books);
            this.panel.Controls.Add(this.author_books);
            this.panel.Controls.Add(this.label12);
            this.panel.Controls.Add(this.label18);
            this.panel.Controls.Add(this.year_books);
            this.panel.Controls.Add(this.label16);
            this.panel.Controls.Add(this.label15);
            this.panel.Controls.Add(this.label14);
            this.panel.Controls.Add(this.location_books);
            this.panel.Location = new System.Drawing.Point(310, 334);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(605, 200);
            this.panel.TabIndex = 91;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(369, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "برای ویرایش بر روی بارکد کتاب مورد نظر کلیک کنید سپس یه کمک فیلد ها ویرایش خود را" +
    " انجام دهید";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // book_dataGridView
            // 
            this.book_dataGridView.AllowUserToAddRows = false;
            this.book_dataGridView.AllowUserToDeleteRows = false;
            this.book_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.book_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.book_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.books_name_data,
            this.barcode,
            this.Athour,
            this.year,
            this.location,
            this.translator,
            this.publisher,
            this.category,
            this.tags,
            this.brrowed});
            this.book_dataGridView.Location = new System.Drawing.Point(72, 41);
            this.book_dataGridView.Name = "book_dataGridView";
            this.book_dataGridView.ReadOnly = true;
            this.book_dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.book_dataGridView.RowHeadersWidth = 25;
            this.book_dataGridView.RowTemplate.Height = 24;
            this.book_dataGridView.Size = new System.Drawing.Size(1052, 298);
            this.book_dataGridView.TabIndex = 92;
            this.book_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.book_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // books_name_data
            // 
            this.books_name_data.DataPropertyName = "bName";
            this.books_name_data.HeaderText = "نام کتاب";
            this.books_name_data.MinimumWidth = 6;
            this.books_name_data.Name = "books_name_data";
            this.books_name_data.ReadOnly = true;
            // 
            // barcode
            // 
            this.barcode.DataPropertyName = "bID";
            this.barcode.HeaderText = "بارکد";
            this.barcode.MinimumWidth = 6;
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            // 
            // Athour
            // 
            this.Athour.DataPropertyName = "bAuthor";
            this.Athour.HeaderText = "نویسنده";
            this.Athour.MinimumWidth = 6;
            this.Athour.Name = "Athour";
            this.Athour.ReadOnly = true;
            // 
            // year
            // 
            this.year.DataPropertyName = "bYear";
            this.year.HeaderText = "سال چاپ";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // location
            // 
            this.location.DataPropertyName = "bLocation";
            this.location.HeaderText = "مکان";
            this.location.MinimumWidth = 6;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // translator
            // 
            this.translator.DataPropertyName = "bTranslator";
            this.translator.HeaderText = "مترجم";
            this.translator.MinimumWidth = 6;
            this.translator.Name = "translator";
            this.translator.ReadOnly = true;
            // 
            // publisher
            // 
            this.publisher.DataPropertyName = "bPublisher";
            this.publisher.HeaderText = "ناشر";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            // 
            // category
            // 
            this.category.DataPropertyName = "bCategory";
            this.category.HeaderText = "دسته بندی";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // tags
            // 
            this.tags.DataPropertyName = "bTags";
            this.tags.HeaderText = "برچسب";
            this.tags.MinimumWidth = 6;
            this.tags.Name = "tags";
            this.tags.ReadOnly = true;
            // 
            // brrowed
            // 
            this.brrowed.DataPropertyName = "bBorrowd";
            this.brrowed.HeaderText = "امانت داده شده";
            this.brrowed.MinimumWidth = 6;
            this.brrowed.Name = "brrowed";
            this.brrowed.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(149, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 94;
            this.button1.Text = "تازه";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Books_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.book_dataGridView);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.book_name_search);
            this.Controls.Add(this.membership_button);
            this.Controls.Add(this.scale_button);
            this.Controls.Add(this.lend_button);
            this.Controls.Add(this.back_dashboard_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.eddit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.remove_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Books_form";
            this.Text = "کتاب ها";
            this.Load += new System.EventHandler(this.Books_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button eddit_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button back_dashboard_button;
        private System.Windows.Forms.Button lend_button;
        private System.Windows.Forms.Button scale_button;
        private System.Windows.Forms.Button membership_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tags_books;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox category_books;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox year_books;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox location_books;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox author_books;
        private System.Windows.Forms.TextBox publisher_books;
        private System.Windows.Forms.TextBox translator_books;
        private System.Windows.Forms.TextBox book_name_search;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView book_dataGridView;
        private System.Windows.Forms.BindingSource libraryDBDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn books_name_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Athour;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn translator;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn brrowed;
    }
}