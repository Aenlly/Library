﻿namespace Library.user
{
    partial class user_BorrowPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_BorrowPage));
            this.Dgv_borrow = new System.Windows.Forms.DataGridView();
            this.Cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_borrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_renew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_emeover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_eme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_Renewal = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cl_operation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ts_borrow = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_borrowNo = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_borrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_borrow
            // 
            this.Dgv_borrow.AllowUserToAddRows = false;
            this.Dgv_borrow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_borrow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_borrow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_borrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cl_id,
            this.Cl_name,
            this.Cl_borrow,
            this.Cl_return,
            this.Cl_day,
            this.Cl_renew,
            this.Cl_emeover,
            this.Cl_eme,
            this.Cl_Renewal,
            this.Cl_operation});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_borrow.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_borrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_borrow.Location = new System.Drawing.Point(0, 28);
            this.Dgv_borrow.Name = "Dgv_borrow";
            this.Dgv_borrow.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_borrow.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_borrow.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_borrow.RowTemplate.Height = 23;
            this.Dgv_borrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_borrow.Size = new System.Drawing.Size(969, 497);
            this.Dgv_borrow.TabIndex = 1;
            this.Dgv_borrow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_borrow_CellClick);
            // 
            // Cl_id
            // 
            this.Cl_id.HeaderText = "借书编号";
            this.Cl_id.Name = "Cl_id";
            this.Cl_id.ReadOnly = true;
            // 
            // Cl_name
            // 
            this.Cl_name.HeaderText = "图书名称";
            this.Cl_name.Name = "Cl_name";
            this.Cl_name.ReadOnly = true;
            // 
            // Cl_borrow
            // 
            this.Cl_borrow.HeaderText = "借书日期";
            this.Cl_borrow.Name = "Cl_borrow";
            this.Cl_borrow.ReadOnly = true;
            // 
            // Cl_return
            // 
            this.Cl_return.HeaderText = "应还日期";
            this.Cl_return.Name = "Cl_return";
            this.Cl_return.ReadOnly = true;
            // 
            // Cl_day
            // 
            this.Cl_day.HeaderText = "所借天数";
            this.Cl_day.Name = "Cl_day";
            this.Cl_day.ReadOnly = true;
            // 
            // Cl_renew
            // 
            this.Cl_renew.HeaderText = "续借资格";
            this.Cl_renew.Name = "Cl_renew";
            this.Cl_renew.ReadOnly = true;
            this.Cl_renew.Width = 90;
            // 
            // Cl_emeover
            // 
            this.Cl_emeover.HeaderText = "是否逾期";
            this.Cl_emeover.Name = "Cl_emeover";
            this.Cl_emeover.ReadOnly = true;
            this.Cl_emeover.Width = 90;
            // 
            // Cl_eme
            // 
            this.Cl_eme.HeaderText = "借书状态";
            this.Cl_eme.Name = "Cl_eme";
            this.Cl_eme.ReadOnly = true;
            // 
            // Cl_Renewal
            // 
            this.Cl_Renewal.HeaderText = "操作";
            this.Cl_Renewal.Name = "Cl_Renewal";
            this.Cl_Renewal.ReadOnly = true;
            this.Cl_Renewal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cl_Renewal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cl_Renewal.Text = "续借";
            this.Cl_Renewal.UseColumnTextForButtonValue = true;
            this.Cl_Renewal.Width = 60;
            // 
            // Cl_operation
            // 
            this.Cl_operation.HeaderText = "操作";
            this.Cl_operation.Name = "Cl_operation";
            this.Cl_operation.ReadOnly = true;
            this.Cl_operation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cl_operation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cl_operation.Text = "还书";
            this.Cl_operation.UseColumnTextForButtonValue = true;
            this.Cl_operation.Width = 60;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ts_borrow,
            this.tsbtn_borrowNo});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(969, 28);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            this.toolStripLabel1.Text = "图书名称：";
            // 
            // tstext_book
            // 
            this.tstext_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstext_book.Name = "tstext_book";
            this.tstext_book.Size = new System.Drawing.Size(100, 28);
            // 
            // tsbtn_select
            // 
            this.tsbtn_select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_select.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_select.Image")));
            this.tsbtn_select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_select.Name = "tsbtn_select";
            this.tsbtn_select.Size = new System.Drawing.Size(78, 25);
            this.tsbtn_select.Text = "点击查询";
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
            // ts_borrow
            // 
            this.ts_borrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_borrow.Image = ((System.Drawing.Image)(resources.GetObject("ts_borrow.Image")));
            this.ts_borrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_borrow.Name = "ts_borrow";
            this.ts_borrow.Size = new System.Drawing.Size(142, 25);
            this.ts_borrow.Text = "显示当前所借记录";
            this.ts_borrow.Click += new System.EventHandler(this.ts_borrow_Click);
            // 
            // tsbtn_borrowNo
            // 
            this.tsbtn_borrowNo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_borrowNo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_borrowNo.Image")));
            this.tsbtn_borrowNo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_borrowNo.Name = "tsbtn_borrowNo";
            this.tsbtn_borrowNo.Size = new System.Drawing.Size(174, 25);
            this.tsbtn_borrowNo.Text = "显示失败或审核中记录";
            this.tsbtn_borrowNo.Click += new System.EventHandler(this.tsbtn_borrowNo_Click);
            // 
            // user_BorrowPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(969, 525);
            this.Controls.Add(this.Dgv_borrow);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "user_BorrowPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "借书记录";
            this.Load += new System.EventHandler(this.user_BorrowPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_borrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_borrow;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_borrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_renew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_emeover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_eme;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_Renewal;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_operation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtn_borrowNo;
        private System.Windows.Forms.ToolStripButton ts_borrow;
    }
}