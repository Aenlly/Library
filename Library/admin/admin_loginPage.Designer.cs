namespace Library.admin
{
    partial class admin_loginPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_login = new System.Windows.Forms.DataGridView();
            this.Cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_whole = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_end = new System.Windows.Forms.Button();
            this.mcd_start = new System.Windows.Forms.MonthCalendar();
            this.mcd_end = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_login)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "开始时间：";
            // 
            // Dgv_login
            // 
            this.Dgv_login.AllowUserToAddRows = false;
            this.Dgv_login.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_login.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Dgv_login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_login.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cl_id,
            this.Cl_uid,
            this.Cl_time});
            this.Dgv_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_login.Location = new System.Drawing.Point(0, 103);
            this.Dgv_login.Name = "Dgv_login";
            this.Dgv_login.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_login.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.Dgv_login.RowTemplate.Height = 23;
            this.Dgv_login.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_login.Size = new System.Drawing.Size(349, 422);
            this.Dgv_login.TabIndex = 1;
            // 
            // Cl_id
            // 
            this.Cl_id.HeaderText = "记录编号";
            this.Cl_id.Name = "Cl_id";
            this.Cl_id.ReadOnly = true;
            // 
            // Cl_uid
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cl_uid.DefaultCellStyle = dataGridViewCellStyle14;
            this.Cl_uid.HeaderText = "学号/工号";
            this.Cl_uid.Name = "Cl_uid";
            this.Cl_uid.ReadOnly = true;
            // 
            // Cl_time
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cl_time.DefaultCellStyle = dataGridViewCellStyle15;
            this.Cl_time.HeaderText = "登录时间";
            this.Cl_time.Name = "Cl_time";
            this.Cl_time.ReadOnly = true;
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_select.Location = new System.Drawing.Point(232, 7);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(105, 30);
            this.btn_select.TabIndex = 3;
            this.btn_select.Text = "立刻查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_whole
            // 
            this.btn_whole.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_whole.Location = new System.Drawing.Point(232, 50);
            this.btn_whole.Name = "btn_whole";
            this.btn_whole.Size = new System.Drawing.Size(105, 28);
            this.btn_whole.TabIndex = 4;
            this.btn_whole.Text = "显示全部";
            this.btn_whole.UseVisualStyleBackColor = true;
            this.btn_whole.Click += new System.EventHandler(this.btn_whole_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.Location = new System.Drawing.Point(91, 7);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(120, 30);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "点击选择";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "结束时间：";
            // 
            // btn_end
            // 
            this.btn_end.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_end.Location = new System.Drawing.Point(91, 48);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(120, 30);
            this.btn_end.TabIndex = 9;
            this.btn_end.Text = "点击选择";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // mcd_start
            // 
            this.mcd_start.Location = new System.Drawing.Point(92, 36);
            this.mcd_start.Name = "mcd_start";
            this.mcd_start.TabIndex = 10;
            this.mcd_start.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcd_start_DateChanged);
            this.mcd_start.MouseLeave += new System.EventHandler(this.mcd_start_MouseLeave);
            // 
            // mcd_end
            // 
            this.mcd_end.Location = new System.Drawing.Point(92, 73);
            this.mcd_end.Name = "mcd_end";
            this.mcd_end.TabIndex = 11;
            this.mcd_end.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcd_end_DateChanged);
            this.mcd_end.MouseLeave += new System.EventHandler(this.mcd_end_MouseLeave);
            // 
            // admin_loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 525);
            this.Controls.Add(this.mcd_start);
            this.Controls.Add(this.mcd_end);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_whole);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.Dgv_login);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "admin_loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录记录";
            this.Load += new System.EventHandler(this.admin_loginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_login;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_whole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_time;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.MonthCalendar mcd_start;
        private System.Windows.Forms.MonthCalendar mcd_end;
    }
}