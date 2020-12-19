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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_login = new System.Windows.Forms.DataGridView();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_whole = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_end = new System.Windows.Forms.Button();
            this.mcd_start = new System.Windows.Forms.MonthCalendar();
            this.mcd_end = new System.Windows.Forms.MonthCalendar();
            this.Cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_login.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_login.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_login.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_login.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cl_id,
            this.Cl_uid,
            this.Cl_time});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_login.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_login.Location = new System.Drawing.Point(0, 103);
            this.Dgv_login.Name = "Dgv_login";
            this.Dgv_login.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_login.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_login.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_login.RowTemplate.Height = 23;
            this.Dgv_login.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_login.Size = new System.Drawing.Size(570, 422);
            this.Dgv_login.TabIndex = 4;
            // 
            // btn_select
            // 
            this.btn_select.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_select.Location = new System.Drawing.Point(314, 51);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(120, 30);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "立刻查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_whole
            // 
            this.btn_whole.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_whole.Location = new System.Drawing.Point(91, 52);
            this.btn_whole.Name = "btn_whole";
            this.btn_whole.Size = new System.Drawing.Size(120, 30);
            this.btn_whole.TabIndex = 3;
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
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "点击选择";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(239, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "结束时间：";
            // 
            // btn_end
            // 
            this.btn_end.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_end.Location = new System.Drawing.Point(314, 7);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(120, 30);
            this.btn_end.TabIndex = 1;
            this.btn_end.Text = "点击选择";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // mcd_start
            // 
            this.mcd_start.Location = new System.Drawing.Point(91, 39);
            this.mcd_start.Name = "mcd_start";
            this.mcd_start.TabIndex = 10;
            this.mcd_start.TabStop = false;
            this.mcd_start.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcd_start_DateChanged);
            this.mcd_start.MouseLeave += new System.EventHandler(this.mcd_start_MouseLeave);
            // 
            // mcd_end
            // 
            this.mcd_end.Location = new System.Drawing.Point(314, 39);
            this.mcd_end.Name = "mcd_end";
            this.mcd_end.TabIndex = 11;
            this.mcd_end.TabStop = false;
            this.mcd_end.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcd_end_DateChanged);
            this.mcd_end.MouseLeave += new System.EventHandler(this.mcd_end_MouseLeave);
            // 
            // Cl_id
            // 
            this.Cl_id.HeaderText = "记录编号";
            this.Cl_id.Name = "Cl_id";
            this.Cl_id.ReadOnly = true;
            // 
            // Cl_uid
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cl_uid.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cl_uid.HeaderText = "用户编号";
            this.Cl_uid.Name = "Cl_uid";
            this.Cl_uid.ReadOnly = true;
            // 
            // Cl_time
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cl_time.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cl_time.HeaderText = "登录时间";
            this.Cl_time.Name = "Cl_time";
            this.Cl_time.ReadOnly = true;
            this.Cl_time.Width = 300;
            // 
            // admin_loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(570, 525);
            this.Controls.Add(this.mcd_end);
            this.Controls.Add(this.mcd_start);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_whole);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_login);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "admin_loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户登录记录";
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
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.MonthCalendar mcd_start;
        private System.Windows.Forms.MonthCalendar mcd_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_time;
    }
}