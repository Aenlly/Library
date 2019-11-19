namespace Library.admin
{
    partial class admin_FeedBackPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_FeedBackPage));
            this.Dgv_fbk = new System.Windows.Forms.DataGridView();
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
            this.tstext_time = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtn_select = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_no = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_yes = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_whole = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mcd_time = new System.Windows.Forms.MonthCalendar();
            this.Cl_Reply = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cl_see = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cl_solve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_asrtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_smntime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_fbk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_fbk
            // 
            this.Dgv_fbk.AllowUserToAddRows = false;
            this.Dgv_fbk.AllowUserToDeleteRows = false;
            this.Dgv_fbk.AllowUserToResizeColumns = false;
            this.Dgv_fbk.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_fbk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_fbk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_fbk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cl_id,
            this.Cl_uid,
            this.Cl_title,
            this.Cl_smntime,
            this.Cl_asrtime,
            this.Cl_solve,
            this.Cl_see,
            this.Cl_Reply});
            this.Dgv_fbk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_fbk.Location = new System.Drawing.Point(0, 28);
            this.Dgv_fbk.MultiSelect = false;
            this.Dgv_fbk.Name = "Dgv_fbk";
            this.Dgv_fbk.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_fbk.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_fbk.RowTemplate.Height = 23;
            this.Dgv_fbk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_fbk.Size = new System.Drawing.Size(865, 497);
            this.Dgv_fbk.TabIndex = 0;
            this.Dgv_fbk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_fbk_CellClick);
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
            this.tstext_time,
            this.tsbtn_select,
            this.tsbtn_no,
            this.tsbtn_yes,
            this.tsbtn_whole});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(865, 28);
            this.bindingNavigator1.TabIndex = 1;
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
            this.toolStripLabel1.Size = new System.Drawing.Size(122, 25);
            this.toolStripLabel1.Text = "提交时间查询：";
            // 
            // tstext_time
            // 
            this.tstext_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstext_time.Name = "tstext_time";
            this.tstext_time.ReadOnly = true;
            this.tstext_time.Size = new System.Drawing.Size(100, 28);
            this.tstext_time.Click += new System.EventHandler(this.tstext_time_Click);
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
            // tsbtn_no
            // 
            this.tsbtn_no.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_no.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_no.Image")));
            this.tsbtn_no.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_no.Name = "tsbtn_no";
            this.tsbtn_no.Size = new System.Drawing.Size(94, 25);
            this.tsbtn_no.Text = "显示未解决";
            this.tsbtn_no.ToolTipText = "显示未回复";
            this.tsbtn_no.Click += new System.EventHandler(this.tsbtn_no_Click);
            // 
            // tsbtn_yes
            // 
            this.tsbtn_yes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_yes.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_yes.Image")));
            this.tsbtn_yes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_yes.Name = "tsbtn_yes";
            this.tsbtn_yes.Size = new System.Drawing.Size(94, 25);
            this.tsbtn_yes.Text = "显示已解决";
            this.tsbtn_yes.ToolTipText = "显示已回复";
            this.tsbtn_yes.Click += new System.EventHandler(this.tsbtn_yes_Click);
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
            // mcd_time
            // 
            this.mcd_time.Location = new System.Drawing.Point(295, 25);
            this.mcd_time.Name = "mcd_time";
            this.mcd_time.TabIndex = 2;
            this.mcd_time.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcd_time_DateChanged);
            this.mcd_time.MouseLeave += new System.EventHandler(this.mcd_time_MouseLeave);
            // 
            // Cl_Reply
            // 
            this.Cl_Reply.HeaderText = "操作";
            this.Cl_Reply.Name = "Cl_Reply";
            this.Cl_Reply.ReadOnly = true;
            this.Cl_Reply.Text = "回复";
            this.Cl_Reply.UseColumnTextForButtonValue = true;
            // 
            // Cl_see
            // 
            this.Cl_see.HeaderText = "操作";
            this.Cl_see.Name = "Cl_see";
            this.Cl_see.ReadOnly = true;
            this.Cl_see.Text = "查看";
            this.Cl_see.UseColumnTextForButtonValue = true;
            // 
            // Cl_solve
            // 
            this.Cl_solve.HeaderText = "是否已回复";
            this.Cl_solve.Name = "Cl_solve";
            this.Cl_solve.ReadOnly = true;
            // 
            // Cl_asrtime
            // 
            this.Cl_asrtime.HeaderText = "回复时间";
            this.Cl_asrtime.Name = "Cl_asrtime";
            this.Cl_asrtime.ReadOnly = true;
            // 
            // Cl_smntime
            // 
            this.Cl_smntime.HeaderText = "提交时间";
            this.Cl_smntime.Name = "Cl_smntime";
            this.Cl_smntime.ReadOnly = true;
            // 
            // Cl_title
            // 
            this.Cl_title.HeaderText = "反馈标题";
            this.Cl_title.Name = "Cl_title";
            this.Cl_title.ReadOnly = true;
            // 
            // Cl_uid
            // 
            this.Cl_uid.HeaderText = "用户ID";
            this.Cl_uid.Name = "Cl_uid";
            this.Cl_uid.ReadOnly = true;
            // 
            // Cl_id
            // 
            this.Cl_id.HeaderText = "反馈编号";
            this.Cl_id.Name = "Cl_id";
            this.Cl_id.ReadOnly = true;
            // 
            // admin_FeedBackPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 525);
            this.Controls.Add(this.mcd_time);
            this.Controls.Add(this.Dgv_fbk);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.Name = "admin_FeedBackPage";
            this.Text = "反馈记录";
            this.Load += new System.EventHandler(this.admin_FeedBackPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_fbk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_fbk;
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
        private System.Windows.Forms.ToolStripTextBox tstext_time;
        private System.Windows.Forms.ToolStripButton tsbtn_select;
        private System.Windows.Forms.ToolStripButton tsbtn_no;
        private System.Windows.Forms.ToolStripButton tsbtn_yes;
        private System.Windows.Forms.ToolStripButton tsbtn_whole;
        private System.Windows.Forms.MonthCalendar mcd_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_smntime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_asrtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_solve;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_see;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_Reply;
    }
}