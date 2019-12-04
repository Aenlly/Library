namespace Library.admin
{
    partial class admin_BookPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_BookPage));
            this.Dgv_adminBook = new System.Windows.Forms.DataGridView();
            this.b_isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_press = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cl_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindNavig = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstext_book = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtn_select = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_whole = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_bookadd = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_type = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_edit = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_adminBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindNavig)).BeginInit();
            this.bindNavig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_adminBook
            // 
            this.Dgv_adminBook.AllowUserToAddRows = false;
            this.Dgv_adminBook.AllowUserToDeleteRows = false;
            this.Dgv_adminBook.AllowUserToResizeColumns = false;
            this.Dgv_adminBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_adminBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_adminBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_adminBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_adminBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.b_isbn,
            this.b_name,
            this.t_name,
            this.b_author,
            this.b_press,
            this.b_time,
            this.b_price,
            this.b_stocks,
            this.Cl_delete,
            this.Cl_edit});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_adminBook.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_adminBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_adminBook.Location = new System.Drawing.Point(0, 28);
            this.Dgv_adminBook.MultiSelect = false;
            this.Dgv_adminBook.Name = "Dgv_adminBook";
            this.Dgv_adminBook.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_adminBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_adminBook.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_adminBook.RowTemplate.Height = 23;
            this.Dgv_adminBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_adminBook.Size = new System.Drawing.Size(1159, 497);
            this.Dgv_adminBook.TabIndex = 1;
            this.Dgv_adminBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_adminBook_CellClick);
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
            this.b_stocks.HeaderText = "库存";
            this.b_stocks.Name = "b_stocks";
            this.b_stocks.ReadOnly = true;
            // 
            // Cl_delete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.Cl_delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cl_delete.HeaderText = "操作";
            this.Cl_delete.Name = "Cl_delete";
            this.Cl_delete.ReadOnly = true;
            this.Cl_delete.Text = "删除";
            this.Cl_delete.UseColumnTextForButtonValue = true;
            // 
            // Cl_edit
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.Cl_edit.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cl_edit.HeaderText = "操作";
            this.Cl_edit.Name = "Cl_edit";
            this.Cl_edit.ReadOnly = true;
            this.Cl_edit.Text = "修改信息";
            this.Cl_edit.UseColumnTextForButtonValue = true;
            // 
            // bindNavig
            // 
            this.bindNavig.AddNewItem = null;
            this.bindNavig.CountItem = this.bindingNavigatorCountItem;
            this.bindNavig.DeleteItem = null;
            this.bindNavig.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bindNavig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripSeparator1,
            this.tsbtn_bookadd,
            this.tsbtn_type,
            this.tsbtn_edit});
            this.bindNavig.Location = new System.Drawing.Point(0, 0);
            this.bindNavig.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindNavig.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindNavig.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindNavig.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindNavig.Name = "bindNavig";
            this.bindNavig.PositionItem = this.bindingNavigatorPositionItem;
            this.bindNavig.Size = new System.Drawing.Size(1159, 28);
            this.bindNavig.TabIndex = 0;
            this.bindNavig.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(41, 25);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
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
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(90, 25);
            this.toolStripLabel1.Text = "查询书名：";
            // 
            // tstext_book
            // 
            this.tstext_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstext_book.Name = "tstext_book";
            this.tstext_book.Size = new System.Drawing.Size(121, 28);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbtn_bookadd
            // 
            this.tsbtn_bookadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_bookadd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_bookadd.Image")));
            this.tsbtn_bookadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_bookadd.Name = "tsbtn_bookadd";
            this.tsbtn_bookadd.Size = new System.Drawing.Size(78, 25);
            this.tsbtn_bookadd.Text = "添加图书";
            this.tsbtn_bookadd.Click += new System.EventHandler(this.tsbtn_bookadd_Click);
            // 
            // tsbtn_type
            // 
            this.tsbtn_type.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_type.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_type.Image")));
            this.tsbtn_type.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_type.Name = "tsbtn_type";
            this.tsbtn_type.Size = new System.Drawing.Size(94, 25);
            this.tsbtn_type.Text = "添加新类别";
            this.tsbtn_type.Click += new System.EventHandler(this.tsbtn_type_Click);
            // 
            // tsbtn_edit
            // 
            this.tsbtn_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_edit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_edit.Image")));
            this.tsbtn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_edit.Name = "tsbtn_edit";
            this.tsbtn_edit.Size = new System.Drawing.Size(78, 25);
            this.tsbtn_edit.Text = "更改类别";
            this.tsbtn_edit.Click += new System.EventHandler(this.tsbtn_del_Click);
            // 
            // admin_BookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1159, 525);
            this.Controls.Add(this.Dgv_adminBook);
            this.Controls.Add(this.bindNavig);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin_BookPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图书管理";
            this.Activated += new System.EventHandler(this.admin_BookPage_Activated);
            this.Load += new System.EventHandler(this.admin_BookPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_adminBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindNavig)).EndInit();
            this.bindNavig.ResumeLayout(false);
            this.bindNavig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_adminBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_press;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_stocks;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_delete;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_edit;
        private System.Windows.Forms.BindingNavigator bindNavig;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstext_book;
        private System.Windows.Forms.ToolStripButton tsbtn_select;
        private System.Windows.Forms.ToolStripButton tsbtn_whole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtn_bookadd;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripButton tsbtn_type;
        private System.Windows.Forms.ToolStripButton tsbtn_edit;
    }
}