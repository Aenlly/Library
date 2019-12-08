namespace Library.admin
{
    partial class admin_BookAdd
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.text_price = new System.Windows.Forms.TextBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.text_press = new System.Windows.Forms.TextBox();
            this.text_author = new System.Windows.Forms.TextBox();
            this.text_book = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lkl_type = new System.Windows.Forms.LinkLabel();
            this.text_isbn = new System.Windows.Forms.TextBox();
            this.text_year = new System.Windows.Forms.TextBox();
            this.text_stocks = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(40, 341);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 34);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "立即添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(182, 341);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(96, 32);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "返回";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(131, 245);
            this.text_price.MaxLength = 10;
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(100, 23);
            this.text_price.TabIndex = 7;
            this.text_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_price_KeyPress);
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(131, 93);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(88, 22);
            this.cmb_type.TabIndex = 2;
            // 
            // text_press
            // 
            this.text_press.Location = new System.Drawing.Point(131, 168);
            this.text_press.Name = "text_press";
            this.text_press.Size = new System.Drawing.Size(137, 23);
            this.text_press.TabIndex = 5;
            // 
            // text_author
            // 
            this.text_author.Location = new System.Drawing.Point(131, 129);
            this.text_author.Name = "text_author";
            this.text_author.Size = new System.Drawing.Size(137, 23);
            this.text_author.TabIndex = 4;
            // 
            // text_book
            // 
            this.text_book.Location = new System.Drawing.Point(131, 12);
            this.text_book.Name = "text_book";
            this.text_book.Size = new System.Drawing.Size(210, 23);
            this.text_book.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 305);
            this.panel1.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "库存：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN编号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "图书价格：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "图书类别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "作者：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "出版年份：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "出版社：";
            // 
            // lkl_type
            // 
            this.lkl_type.AutoSize = true;
            this.lkl_type.Location = new System.Drawing.Point(236, 101);
            this.lkl_type.Name = "lkl_type";
            this.lkl_type.Size = new System.Drawing.Size(105, 14);
            this.lkl_type.TabIndex = 3;
            this.lkl_type.TabStop = true;
            this.lkl_type.Text = "点击添加新类别";
            this.lkl_type.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_type_LinkClicked);
            // 
            // text_isbn
            // 
            this.text_isbn.Location = new System.Drawing.Point(131, 56);
            this.text_isbn.MaxLength = 20;
            this.text_isbn.Name = "text_isbn";
            this.text_isbn.Size = new System.Drawing.Size(210, 23);
            this.text_isbn.TabIndex = 1;
            this.text_isbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_isbn_KeyPress);
            // 
            // text_year
            // 
            this.text_year.Location = new System.Drawing.Point(131, 204);
            this.text_year.MaxLength = 4;
            this.text_year.Name = "text_year";
            this.text_year.Size = new System.Drawing.Size(75, 23);
            this.text_year.TabIndex = 6;
            this.text_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_year_KeyPress);
            // 
            // text_stocks
            // 
            this.text_stocks.Location = new System.Drawing.Point(131, 285);
            this.text_stocks.MaxLength = 4;
            this.text_stocks.Name = "text_stocks";
            this.text_stocks.Size = new System.Drawing.Size(100, 23);
            this.text_stocks.TabIndex = 8;
            this.text_stocks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_stocks_KeyPress);
            // 
            // admin_BookAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(353, 410);
            this.Controls.Add(this.text_stocks);
            this.Controls.Add(this.text_year);
            this.Controls.Add(this.text_isbn);
            this.Controls.Add(this.lkl_type);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.text_press);
            this.Controls.Add(this.text_author);
            this.Controls.Add(this.text_book);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin_BookAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加图书";
            this.Load += new System.EventHandler(this.admin_BookAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.TextBox text_press;
        private System.Windows.Forms.TextBox text_author;
        private System.Windows.Forms.TextBox text_book;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lkl_type;
        private System.Windows.Forms.TextBox text_isbn;
        private System.Windows.Forms.TextBox text_year;
        private System.Windows.Forms.TextBox text_stocks;
    }
}