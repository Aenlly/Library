namespace Library.user
{
    partial class user_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user_Return));
            this.dGv = new System.Windows.Forms.DataGridView();
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
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtn_book = new System.Windows.Forms.ToolStripTextBox();
            this.tsbtn_return = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_whole = new System.Windows.Forms.ToolStripButton();
            this.Cl_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_borrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_return = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_renew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_renewday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_eme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cl_name,
            this.Cl_admin,
            this.Cl_borrow,
            this.Cl_return,
            this.Cl_day,
            this.Cl_renew,
            this.Cl_renewday,
            this.Cl_eme});
            this.dGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGv.Location = new System.Drawing.Point(0, 32);
            this.dGv.Name = "dGv";
            this.dGv.RowTemplate.Height = 23;
            this.dGv.Size = new System.Drawing.Size(894, 491);
            this.dGv.TabIndex = 0;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.toolStripLabel2,
            this.tsbtn_book,
            this.tsbtn_return,
            this.tsbtn_whole});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(894, 32);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 29);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 29);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 29);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 29);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 29);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 29);
            this.toolStripLabel1.Text = "图书类别:";
            // 
            // tscmb_type
            // 
            this.tscmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmb_type.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscmb_type.Name = "tscmb_type";
            this.tscmb_type.Size = new System.Drawing.Size(75, 32);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(93, 29);
            this.toolStripLabel2.Text = "图书名称:";
            // 
            // tsbtn_book
            // 
            this.tsbtn_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsbtn_book.Name = "tsbtn_book";
            this.tsbtn_book.Size = new System.Drawing.Size(120, 32);
            // 
            // tsbtn_return
            // 
            this.tsbtn_return.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_return.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_return.Image")));
            this.tsbtn_return.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_return.Name = "tsbtn_return";
            this.tsbtn_return.Size = new System.Drawing.Size(54, 29);
            this.tsbtn_return.Text = "查询";
            // 
            // tsbtn_whole
            // 
            this.tsbtn_whole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtn_whole.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_whole.Image")));
            this.tsbtn_whole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_whole.Name = "tsbtn_whole";
            this.tsbtn_whole.Size = new System.Drawing.Size(92, 29);
            this.tsbtn_whole.Text = "显示全部";
            // 
            // Cl_name
            // 
            this.Cl_name.HeaderText = "图书名称";
            this.Cl_name.Name = "Cl_name";
            // 
            // Cl_admin
            // 
            this.Cl_admin.HeaderText = "操作员编号";
            this.Cl_admin.Name = "Cl_admin";
            this.Cl_admin.Width = 150;
            // 
            // Cl_borrow
            // 
            this.Cl_borrow.HeaderText = "借书日期";
            this.Cl_borrow.Name = "Cl_borrow";
            // 
            // Cl_return
            // 
            this.Cl_return.HeaderText = "还书日期";
            this.Cl_return.Name = "Cl_return";
            // 
            // Cl_day
            // 
            this.Cl_day.HeaderText = "所借天数";
            this.Cl_day.Name = "Cl_day";
            // 
            // Cl_renew
            // 
            this.Cl_renew.HeaderText = "是否续借";
            this.Cl_renew.Name = "Cl_renew";
            // 
            // Cl_renewday
            // 
            this.Cl_renewday.HeaderText = "续借天数";
            this.Cl_renewday.Name = "Cl_renewday";
            // 
            // Cl_eme
            // 
            this.Cl_eme.HeaderText = "还书成功";
            this.Cl_eme.Name = "Cl_eme";
            // 
            // user_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 523);
            this.Controls.Add(this.dGv);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "user_Return";
            this.Text = "还书记录";
            this.Load += new System.EventHandler(this.user_Return_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGv;
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tsbtn_book;
        private System.Windows.Forms.ToolStripButton tsbtn_return;
        private System.Windows.Forms.ToolStripButton tsbtn_whole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_borrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_return;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_renew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_renewday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_eme;
    }
}