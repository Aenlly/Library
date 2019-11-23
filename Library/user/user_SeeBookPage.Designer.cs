namespace Library.user
{
    partial class user_SeeBookPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_SeeBookPage));
            this.Dgv_SeeBook = new System.Windows.Forms.DataGridView();
            this.b_isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_press = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_borrow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstext_book = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtn_select = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_whole = new System.Windows.Forms.ToolStripButton();
            this.BindNavig = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tscmb_day = new System.Windows.Forms.ToolStripComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SeeBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindNavig)).BeginInit();
            this.BindNavig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_SeeBook
            // 
            this.Dgv_SeeBook.AllowUserToAddRows = false;
            this.Dgv_SeeBook.AllowUserToDeleteRows = false;
            this.Dgv_SeeBook.AllowUserToResizeColumns = false;
            this.Dgv_SeeBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_SeeBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_SeeBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_SeeBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_SeeBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.b_isbn,
            this.b_name,
            this.t_name,
            this.b_author,
            this.b_press,
            this.b_time,
            this.b_price,
            this.b_stocks,
            this.Cl_borrow});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_SeeBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_SeeBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_SeeBook.Location = new System.Drawing.Point(0, 28);
            this.Dgv_SeeBook.MultiSelect = false;
            this.Dgv_SeeBook.Name = "Dgv_SeeBook";
            this.Dgv_SeeBook.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_SeeBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_SeeBook.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_SeeBook.RowTemplate.Height = 23;
            this.Dgv_SeeBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_SeeBook.Size = new System.Drawing.Size(1067, 509);
            this.Dgv_SeeBook.TabIndex = 1;
            this.Dgv_SeeBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGv_CellClick_1);
            // 
            // b_isbn
            // 
            this.b_isbn.HeaderText = "ISBN编号";
            this.b_isbn.Name = "b_isbn";
            this.b_isbn.ReadOnly = true;
            this.b_isbn.Width = 150;
            // 
            // b_name
            // 
            this.b_name.HeaderText = "图书名称";
            this.b_name.Name = "b_name";
            this.b_name.ReadOnly = true;
            this.b_name.Width = 150;
            // 
            // t_name
            // 
            this.t_name.HeaderText = "图书类别";
            this.t_name.Name = "t_name";
            this.t_name.ReadOnly = true;
            // 
            // b_author
            // 
            this.b_author.HeaderText = "作者";
            this.b_author.Name = "b_author";
            this.b_author.ReadOnly = true;
            // 
            // b_press
            // 
            this.b_press.HeaderText = "出版社";
            this.b_press.Name = "b_press";
            this.b_press.ReadOnly = true;
            // 
            // b_time
            // 
            this.b_time.HeaderText = "出版年份";
            this.b_time.Name = "b_time";
            this.b_time.ReadOnly = true;
            // 
            // b_price
            // 
            this.b_price.HeaderText = "价格";
            this.b_price.Name = "b_price";
            this.b_price.ReadOnly = true;
            // 
            // b_stocks
            // 
            this.b_stocks.HeaderText = "是否可借";
            this.b_stocks.Name = "b_stocks";
            this.b_stocks.ReadOnly = true;
            // 
            // Cl_borrow
            // 
            this.Cl_borrow.HeaderText = "操作";
            this.Cl_borrow.Name = "Cl_borrow";
            this.Cl_borrow.ReadOnly = true;
            this.Cl_borrow.Text = "借书";
            this.Cl_borrow.UseColumnTextForButtonValue = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(41, 25);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(90, 25);
            this.toolStripLabel1.Text = "图书名称：";
            // 
            // tstext_book
            // 
            this.tstext_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstext_book.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tstext_book.Name = "tstext_book";
            this.tstext_book.Size = new System.Drawing.Size(100, 28);
            // 
            // tsbtn_select
            // 
            this.tsbtn_select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_select.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_select.Image")));
            this.tsbtn_select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_select.Name = "tsbtn_select";
            this.tsbtn_select.Size = new System.Drawing.Size(46, 25);
            this.tsbtn_select.Text = "查询";
            this.tsbtn_select.Click += new System.EventHandler(this.tsbtn_select_Click);
            // 
            // tsbtn_whole
            // 
            this.tsbtn_whole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_whole.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_whole.Image")));
            this.tsbtn_whole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_whole.Name = "tsbtn_whole";
            this.tsbtn_whole.Size = new System.Drawing.Size(78, 25);
            this.tsbtn_whole.Text = "显示全部";
            this.tsbtn_whole.Click += new System.EventHandler(this.tsbtn_whole_Click);
            // 
            // BindNavig
            // 
            this.BindNavig.AddNewItem = null;
            this.BindNavig.CountItem = this.bindingNavigatorCountItem;
            this.BindNavig.DeleteItem = null;
            this.BindNavig.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BindNavig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.tstext_book,
            this.tsbtn_select,
            this.tsbtn_whole,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.tscmb_day});
            this.BindNavig.Location = new System.Drawing.Point(0, 0);
            this.BindNavig.MoveFirstItem = this.bindingNavigatorMoveLastItem;
            this.BindNavig.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindNavig.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindNavig.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindNavig.Name = "BindNavig";
            this.BindNavig.PositionItem = this.bindingNavigatorPositionItem;
            this.BindNavig.Size = new System.Drawing.Size(1067, 28);
            this.BindNavig.TabIndex = 0;
            this.BindNavig.Text = "bindingNavigator1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(122, 25);
            this.toolStripLabel3.Text = "选择所借天数：";
            // 
            // tscmb_day
            // 
            this.tscmb_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmb_day.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscmb_day.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tscmb_day.Items.AddRange(new object[] {
            "7天",
            "15天",
            "30天"});
            this.tscmb_day.Name = "tscmb_day";
            this.tscmb_day.Size = new System.Drawing.Size(75, 28);
            // 
            // user_SeeBookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 537);
            this.Controls.Add(this.Dgv_SeeBook);
            this.Controls.Add(this.BindNavig);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "user_SeeBookPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询图书";
            this.Load += new System.EventHandler(this.user_SeeBookPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SeeBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindNavig)).EndInit();
            this.BindNavig.ResumeLayout(false);
            this.BindNavig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_SeeBook;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstext_book;
        private System.Windows.Forms.ToolStripButton tsbtn_select;
        private System.Windows.Forms.ToolStripButton tsbtn_whole;
        private System.Windows.Forms.BindingNavigator BindNavig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_press;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_stocks;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_borrow;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox tscmb_day;
    }
}