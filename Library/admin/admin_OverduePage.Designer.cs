namespace Library.admin
{
    partial class admin_OverduePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_OverduePage));
            this.Dgv_overdue = new System.Windows.Forms.DataGridView();
            this.Cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_borrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_dayover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_examine = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cl_examineNo = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.tstext_name = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtn_select = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_whole = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_no = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_examine = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_yes = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_nopass = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_overdue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_overdue
            // 
            this.Dgv_overdue.AllowUserToAddRows = false;
            this.Dgv_overdue.AllowUserToDeleteRows = false;
            this.Dgv_overdue.AllowUserToResizeColumns = false;
            this.Dgv_overdue.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_overdue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_overdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_overdue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cl_id,
            this.Cl_name,
            this.Cl_book,
            this.Cl_borrow,
            this.Cl_return,
            this.Cl_dayover,
            this.Cl_money,
            this.Cl_state,
            this.Cl_examine,
            this.Cl_examineNo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_overdue.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_overdue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_overdue.Location = new System.Drawing.Point(0, 28);
            this.Dgv_overdue.MultiSelect = false;
            this.Dgv_overdue.Name = "Dgv_overdue";
            this.Dgv_overdue.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_overdue.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_overdue.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_overdue.RowTemplate.Height = 23;
            this.Dgv_overdue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_overdue.Size = new System.Drawing.Size(1075, 497);
            this.Dgv_overdue.TabIndex = 1;
            this.Dgv_overdue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_overdue_CellClick);
            // 
            // Cl_id
            // 
            this.Cl_id.HeaderText = "借书编号";
            this.Cl_id.Name = "Cl_id";
            this.Cl_id.ReadOnly = true;
            // 
            // Cl_name
            // 
            this.Cl_name.HeaderText = "借书人";
            this.Cl_name.Name = "Cl_name";
            this.Cl_name.ReadOnly = true;
            // 
            // Cl_book
            // 
            this.Cl_book.HeaderText = "图书名称";
            this.Cl_book.Name = "Cl_book";
            this.Cl_book.ReadOnly = true;
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
            // Cl_dayover
            // 
            this.Cl_dayover.HeaderText = "逾期天数";
            this.Cl_dayover.Name = "Cl_dayover";
            this.Cl_dayover.ReadOnly = true;
            // 
            // Cl_money
            // 
            this.Cl_money.HeaderText = "逾期金额";
            this.Cl_money.Name = "Cl_money";
            this.Cl_money.ReadOnly = true;
            // 
            // Cl_state
            // 
            this.Cl_state.HeaderText = "逾期状态";
            this.Cl_state.Name = "Cl_state";
            this.Cl_state.ReadOnly = true;
            // 
            // Cl_examine
            // 
            this.Cl_examine.HeaderText = "操作";
            this.Cl_examine.Name = "Cl_examine";
            this.Cl_examine.ReadOnly = true;
            this.Cl_examine.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cl_examine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cl_examine.Text = "审核通过";
            this.Cl_examine.UseColumnTextForButtonValue = true;
            // 
            // Cl_examineNo
            // 
            this.Cl_examineNo.HeaderText = "操作";
            this.Cl_examineNo.Name = "Cl_examineNo";
            this.Cl_examineNo.ReadOnly = true;
            this.Cl_examineNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cl_examineNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cl_examineNo.Text = "审核不通过";
            this.Cl_examineNo.UseColumnTextForButtonValue = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
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
            this.tstext_name,
            this.tsbtn_select,
            this.tsbtn_whole,
            this.toolStripSeparator1,
            this.tsbtn_no,
            this.tsbtn_examine,
            this.tsbtn_yes,
            this.tsbtn_nopass});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1075, 28);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(106, 25);
            this.toolStripLabel1.Text = "查询借书人：";
            // 
            // tstext_name
            // 
            this.tstext_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstext_name.Name = "tstext_name";
            this.tstext_name.Size = new System.Drawing.Size(100, 28);
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
            // tsbtn_no
            // 
            this.tsbtn_no.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_no.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_no.Image")));
            this.tsbtn_no.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_no.Name = "tsbtn_no";
            this.tsbtn_no.Size = new System.Drawing.Size(126, 25);
            this.tsbtn_no.Text = "显示未缴费用户";
            this.tsbtn_no.Click += new System.EventHandler(this.tsbtn_no_Click);
            // 
            // tsbtn_examine
            // 
            this.tsbtn_examine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_examine.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_examine.Image")));
            this.tsbtn_examine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_examine.Name = "tsbtn_examine";
            this.tsbtn_examine.Size = new System.Drawing.Size(126, 25);
            this.tsbtn_examine.Text = "显示审核中用户";
            this.tsbtn_examine.Click += new System.EventHandler(this.tsbtn_examine_Click);
            // 
            // tsbtn_yes
            // 
            this.tsbtn_yes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_yes.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_yes.Image")));
            this.tsbtn_yes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_yes.Name = "tsbtn_yes";
            this.tsbtn_yes.Size = new System.Drawing.Size(126, 25);
            this.tsbtn_yes.Text = "显示已缴费用户";
            this.tsbtn_yes.Click += new System.EventHandler(this.tsbtn_yes_Click);
            // 
            // tsbtn_nopass
            // 
            this.tsbtn_nopass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_nopass.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_nopass.Image")));
            this.tsbtn_nopass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_nopass.Name = "tsbtn_nopass";
            this.tsbtn_nopass.Size = new System.Drawing.Size(126, 25);
            this.tsbtn_nopass.Text = "显示未通过用户";
            this.tsbtn_nopass.Click += new System.EventHandler(this.tsbtn_nopass_Click);
            // 
            // admin_OverduePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1075, 525);
            this.Controls.Add(this.Dgv_overdue);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin_OverduePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "逾期管理";
            this.Load += new System.EventHandler(this.admin_OverduePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_overdue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_overdue;
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstext_name;
        private System.Windows.Forms.ToolStripButton tsbtn_select;
        private System.Windows.Forms.ToolStripButton tsbtn_whole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtn_no;
        private System.Windows.Forms.ToolStripButton tsbtn_yes;
        private System.Windows.Forms.ToolStripButton tsbtn_examine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_borrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_dayover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_money;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_state;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_examine;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_examineNo;
        private System.Windows.Forms.ToolStripButton tsbtn_nopass;
    }
}