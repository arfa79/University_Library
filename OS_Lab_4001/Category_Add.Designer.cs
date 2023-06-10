
namespace OS_Lab_4001
{
    partial class Category_Add
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
            this.backToCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddCategoryLBl = new System.Windows.Forms.TextBox();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToCategory
            // 
            this.backToCategory.BackColor = System.Drawing.Color.IndianRed;
            this.backToCategory.ForeColor = System.Drawing.Color.White;
            this.backToCategory.Location = new System.Drawing.Point(231, 124);
            this.backToCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backToCategory.Name = "backToCategory";
            this.backToCategory.Size = new System.Drawing.Size(160, 48);
            this.backToCategory.TabIndex = 25;
            this.backToCategory.Text = "بازگشت به لیست";
            this.backToCategory.UseVisualStyleBackColor = false;
            this.backToCategory.Click += new System.EventHandler(this.backToCategoryEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(297, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "نام دسته بندی کتاب";
            // 
            // AddCategoryLBl
            // 
            this.AddCategoryLBl.Location = new System.Drawing.Point(12, 84);
            this.AddCategoryLBl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCategoryLBl.Name = "AddCategoryLBl";
            this.AddCategoryLBl.Size = new System.Drawing.Size(379, 22);
            this.AddCategoryLBl.TabIndex = 27;
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.addCategoryBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.addCategoryBtn.Location = new System.Drawing.Point(12, 124);
            this.addCategoryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(213, 48);
            this.addCategoryBtn.TabIndex = 26;
            this.addCategoryBtn.Text = "ثبت دسته بندی جدید";
            this.addCategoryBtn.UseVisualStyleBackColor = false;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryEvent);
            // 
            // Category_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OS_Lab_4001.Properties.Resources._39_Create_a_Login_Form_in_Adobe_Photoshop_From_Scratch;
            this.ClientSize = new System.Drawing.Size(436, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddCategoryLBl);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.backToCategory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Category_Add";
            this.Text = "افزودن دسته بندی";
            this.Load += new System.EventHandler(this.Category_Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddCategoryLBl;
        private System.Windows.Forms.Button addCategoryBtn;
    }
}