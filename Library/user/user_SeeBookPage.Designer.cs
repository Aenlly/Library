﻿namespace Library.user
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
            this.dGv = new System.Windows.Forms.DataGridView();
            this.b_isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_press = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindSoure = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tscmb_type = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstext_book = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtn_select = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_whole = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_borrow = new System.Windows.Forms.ToolStripButton();
            this.BindNavig = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tstext_bookname = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSoure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindNavig)).BeginInit();
            this.BindNavig.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGv
            // 
            this.dGv.AllowUserToAddRows = false;
            this.dGv.AllowUserToDeleteRows = false;
            this.dGv.AllowUserToOrderColumns = true;
            this.dGv.AllowUserToResizeColumns = false;
            this.dGv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.b_isbn,
            this.b_name,
            this.t_type,
            this.b_author,
            this.b_press,
            this.b_time,
            this.b_price,
            this.b_stocks});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGv.Location = new System.Drawing.Point(0, 28);
            this.dGv.Name = "dGv";
            this.dGv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dGv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dGv.RowTemplate.Height = 23;
            this.dGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGv.Size = new System.Drawing.Size(944, 509);
            this.dGv.TabIndex = 0;
            this.dGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGv_CellClick_1);
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
            // t_type
            // 
            this.t_type.HeaderText = "图书类别";
            this.t_type.Name = "t_type";
            this.t_type.ReadOnly = true;
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 25);
            this.toolStripLabel2.Text = "类别:";
            // 
            // tscmb_type
            // 
            this.tscmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmb_type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tscmb_type.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.tscmb_type.Name = "tscmb_type";
            this.tscmb_type.Size = new System.Drawing.Size(75, 28);
            this.tscmb_type.Tag = "选择类别";
            this.tscmb_type.SelectedIndexChanged += new System.EventHandler(this.tscmb_type_SelectedIndexChanged);
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
            // tsbtn_borrow
            // 
            this.tsbtn_borrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_borrow.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_borrow.Image")));
            this.tsbtn_borrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_borrow.Name = "tsbtn_borrow";
            this.tsbtn_borrow.Size = new System.Drawing.Size(78, 25);
            this.tsbtn_borrow.Text = "点击借书";
            this.tsbtn_borrow.Click += new System.EventHandler(this.tsbtn_borrow_Click);
            // 
            // BindNavig
            // 
            this.BindNavig.AddNewItem = null;
            this.BindNavig.BindingSource = this.BindSoure;
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
            this.toolStripLabel2,
            this.tscmb_type,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tstext_book,
            this.tsbtn_select,
            this.tsbtn_whole,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.tstext_bookname,
            this.tsbtn_borrow});
            this.BindNavig.Location = new System.Drawing.Point(0, 0);
            this.BindNavig.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindNavig.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindNavig.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindNavig.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindNavig.Name = "BindNavig";
            this.BindNavig.PositionItem = this.bindingNavigatorPositionItem;
            this.BindNavig.Size = new System.Drawing.Size(944, 28);
            this.BindNavig.TabIndex = 8;
            this.BindNavig.Text = "bindingNavigator1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(78, 25);
            this.toolStripLabel3.Text = "当前选中:";
            // 
            // tstext_bookname
            // 
            this.tstext_bookname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstext_bookname.Enabled = false;
            this.tstext_bookname.Name = "tstext_bookname";
            this.tstext_bookname.Size = new System.Drawing.Size(100, 28);
            this.tstext_bookname.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user_SeeBookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 537);
            this.Controls.Add(this.dGv);
            this.Controls.Add(this.BindNavig);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "user_SeeBookPage";
            this.Text = "查询图书";
            this.Load += new System.EventHandler(this.user_SeeBookPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindSoure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindNavig)).EndInit();
            this.BindNavig.ResumeLayout(false);
            this.BindNavig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGv;
        private System.Windows.Forms.BindingSource BindSoure;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tscmb_type;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstext_book;
        private System.Windows.Forms.ToolStripButton tsbtn_select;
        private System.Windows.Forms.ToolStripButton tsbtn_whole;
        private System.Windows.Forms.ToolStripButton tsbtn_borrow;
        private System.Windows.Forms.BindingNavigator BindNavig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_author;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_press;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_stocks;
        private System.Windows.Forms.ToolStripTextBox tstext_bookname;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}