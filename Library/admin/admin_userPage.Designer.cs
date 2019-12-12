namespace Library.admin
{
    partial class admin_userPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_userPage));
            this.Dgv_user = new System.Windows.Forms.DataGridView();
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
            this.tscmb_type = new System.Windows.Forms.ToolStripComboBox();
            this.tstext = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtn_select = new System.Windows.Forms.ToolStripButton();
            this.ts_whole = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_add = new System.Windows.Forms.ToolStripButton();
            this.tbtn_college = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_edit = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_college = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cl_edit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_user
            // 
            this.Dgv_user.AllowUserToAddRows = false;
            this.Dgv_user.AllowUserToDeleteRows = false;
            this.Dgv_user.AllowUserToResizeColumns = false;
            this.Dgv_user.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cl_id,
            this.Cl_name,
            this.Cl_sex,
            this.Cl_card,
            this.Cl_college,
            this.Cl_tel,
            this.Cl_position,
            this.Cl_book,
            this.Cl_delete,
            this.Cl_edit});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_user.DefaultCellStyle = dataGridViewCellStyle13;
            this.Dgv_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_user.Location = new System.Drawing.Point(0, 28);
            this.Dgv_user.MultiSelect = false;
            this.Dgv_user.Name = "Dgv_user";
            this.Dgv_user.ReadOnly = true;
            this.Dgv_user.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_user.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_user.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.Dgv_user.RowTemplate.Height = 23;
            this.Dgv_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_user.Size = new System.Drawing.Size(1050, 497);
            this.Dgv_user.TabIndex = 1;
            this.Dgv_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_user_CellClick);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
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
            this.tscmb_type,
            this.tstext,
            this.tsbtn_select,
            this.ts_whole,
            this.toolStripSeparator1,
            this.tsbtn_add,
            this.tbtn_college,
            this.tsbtn_edit});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1050, 28);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 25);
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
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 25);
            this.toolStripLabel1.Text = "查询类别:";
            // 
            // tscmb_type
            // 
            this.tscmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmb_type.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscmb_type.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.tscmb_type.Name = "tscmb_type";
            this.tscmb_type.Size = new System.Drawing.Size(90, 28);
            // 
            // tstext
            // 
            this.tstext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstext.Name = "tstext";
            this.tstext.Size = new System.Drawing.Size(100, 28);
            // 
            // tsbtn_select
            // 
            this.tsbtn_select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_select.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_select.Image")));
            this.tsbtn_select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_select.Name = "tsbtn_select";
            this.tsbtn_select.Size = new System.Drawing.Size(41, 25);
            this.tsbtn_select.Text = "查询";
            this.tsbtn_select.Click += new System.EventHandler(this.tsbtn_select_Click);
            // 
            // ts_whole
            // 
            this.ts_whole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ts_whole.Image = ((System.Drawing.Image)(resources.GetObject("ts_whole.Image")));
            this.ts_whole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_whole.Name = "ts_whole";
            this.ts_whole.Size = new System.Drawing.Size(69, 25);
            this.ts_whole.Text = "显示全部";
            this.ts_whole.Click += new System.EventHandler(this.ts_whole_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tsbtn_add
            // 
            this.tsbtn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_add.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_add.Image")));
            this.tsbtn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_add.Name = "tsbtn_add";
            this.tsbtn_add.Size = new System.Drawing.Size(69, 25);
            this.tsbtn_add.Text = "添加用户";
            this.tsbtn_add.Click += new System.EventHandler(this.tsbtn_add_Click);
            // 
            // tbtn_college
            // 
            this.tbtn_college.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbtn_college.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_college.Image")));
            this.tbtn_college.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtn_college.Name = "tbtn_college";
            this.tbtn_college.Size = new System.Drawing.Size(69, 25);
            this.tbtn_college.Text = "添加学院";
            this.tbtn_college.Click += new System.EventHandler(this.tbtn_college_Click);
            // 
            // tsbtn_edit
            // 
            this.tsbtn_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_edit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_edit.Image")));
            this.tsbtn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_edit.Name = "tsbtn_edit";
            this.tsbtn_edit.Size = new System.Drawing.Size(69, 25);
            this.tsbtn_edit.Text = "更改学院";
            this.tsbtn_edit.Click += new System.EventHandler(this.tsbtn_del_Click);
            // 
            // Cl_id
            // 
            this.Cl_id.HeaderText = "学号/工号";
            this.Cl_id.Name = "Cl_id";
            this.Cl_id.ReadOnly = true;
            // 
            // Cl_name
            // 
            this.Cl_name.HeaderText = "姓名";
            this.Cl_name.Name = "Cl_name";
            this.Cl_name.ReadOnly = true;
            this.Cl_name.Width = 90;
            // 
            // Cl_sex
            // 
            this.Cl_sex.HeaderText = "性别";
            this.Cl_sex.Name = "Cl_sex";
            this.Cl_sex.ReadOnly = true;
            this.Cl_sex.Width = 70;
            // 
            // Cl_card
            // 
            this.Cl_card.HeaderText = "身份证";
            this.Cl_card.Name = "Cl_card";
            this.Cl_card.ReadOnly = true;
            this.Cl_card.Width = 140;
            // 
            // Cl_college
            // 
            this.Cl_college.HeaderText = "学院";
            this.Cl_college.Name = "Cl_college";
            this.Cl_college.ReadOnly = true;
            this.Cl_college.Width = 150;
            // 
            // Cl_tel
            // 
            this.Cl_tel.HeaderText = "联系电话";
            this.Cl_tel.Name = "Cl_tel";
            this.Cl_tel.ReadOnly = true;
            this.Cl_tel.Width = 120;
            // 
            // Cl_position
            // 
            this.Cl_position.HeaderText = "用户组";
            this.Cl_position.Name = "Cl_position";
            this.Cl_position.ReadOnly = true;
            this.Cl_position.Width = 80;
            // 
            // Cl_book
            // 
            this.Cl_book.HeaderText = "累计借书";
            this.Cl_book.Name = "Cl_book";
            this.Cl_book.ReadOnly = true;
            this.Cl_book.Width = 90;
            // 
            // Cl_delete
            // 
            this.Cl_delete.HeaderText = "操作";
            this.Cl_delete.Name = "Cl_delete";
            this.Cl_delete.ReadOnly = true;
            this.Cl_delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cl_delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cl_delete.Text = "删除";
            this.Cl_delete.UseColumnTextForButtonValue = true;
            this.Cl_delete.Width = 70;
            // 
            // Cl_edit
            // 
            this.Cl_edit.HeaderText = "操作";
            this.Cl_edit.Name = "Cl_edit";
            this.Cl_edit.ReadOnly = true;
            this.Cl_edit.Text = "编辑";
            this.Cl_edit.UseColumnTextForButtonValue = true;
            this.Cl_edit.Width = 70;
            // 
            // admin_userPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1050, 525);
            this.Controls.Add(this.Dgv_user);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin_userPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.admin_userPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_user;
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
        private System.Windows.Forms.ToolStripComboBox tscmb_type;
        private System.Windows.Forms.ToolStripTextBox tstext;
        private System.Windows.Forms.ToolStripButton tsbtn_select;
        private System.Windows.Forms.ToolStripButton ts_whole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtn_add;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripButton tbtn_college;
        private System.Windows.Forms.ToolStripButton tsbtn_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_card;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_college;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_book;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_delete;
        private System.Windows.Forms.DataGridViewButtonColumn Cl_edit;
    }
}