namespace Library.admin
{
    partial class admin_OperationPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_ort = new System.Windows.Forms.DataGridView();
            this.Cl_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cl_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_time = new System.Windows.Forms.Button();
            this.mcd_time = new System.Windows.Forms.MonthCalendar();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_whole = new System.Windows.Forms.Button();
            this.mcd_end = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_end = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "开始日期：";
            // 
            // Dgv_ort
            // 
            this.Dgv_ort.AllowUserToAddRows = false;
            this.Dgv_ort.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_ort.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_ort.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_ort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ort.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cl_id,
            this.Cl_ort,
            this.Cl_time});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_ort.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_ort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_ort.Location = new System.Drawing.Point(0, 65);
            this.Dgv_ort.Name = "Dgv_ort";
            this.Dgv_ort.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_ort.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_ort.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_ort.RowTemplate.Height = 23;
            this.Dgv_ort.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_ort.Size = new System.Drawing.Size(727, 497);
            this.Dgv_ort.TabIndex = 3;
            // 
            // Cl_id
            // 
            this.Cl_id.HeaderText = "操作编号";
            this.Cl_id.Name = "Cl_id";
            this.Cl_id.ReadOnly = true;
            // 
            // Cl_ort
            // 
            this.Cl_ort.HeaderText = "执行操作";
            this.Cl_ort.Name = "Cl_ort";
            this.Cl_ort.ReadOnly = true;
            this.Cl_ort.Width = 400;
            // 
            // Cl_time
            // 
            this.Cl_time.HeaderText = "操作时间";
            this.Cl_time.Name = "Cl_time";
            this.Cl_time.ReadOnly = true;
            this.Cl_time.Width = 150;
            // 
            // btn_time
            // 
            this.btn_time.Font = new System.Drawing.Font("宋体", 11F);
            this.btn_time.Location = new System.Drawing.Point(113, 18);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(96, 25);
            this.btn_time.TabIndex = 0;
            this.btn_time.Text = "选择时间";
            this.btn_time.UseVisualStyleBackColor = true;
            this.btn_time.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // mcd_time
            // 
            this.mcd_time.Location = new System.Drawing.Point(113, 42);
            this.mcd_time.Margin = new System.Windows.Forms.Padding(10);
            this.mcd_time.Name = "mcd_time";
            this.mcd_time.TabIndex = 7;
            this.mcd_time.TabStop = false;
            this.mcd_time.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcd_time_DateChanged);
            this.mcd_time.MouseLeave += new System.EventHandler(this.mcd_time_MouseLeave);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(529, 21);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_whole
            // 
            this.btn_whole.Location = new System.Drawing.Point(631, 22);
            this.btn_whole.Name = "btn_whole";
            this.btn_whole.Size = new System.Drawing.Size(75, 23);
            this.btn_whole.TabIndex = 3;
            this.btn_whole.Text = "显示全部";
            this.btn_whole.UseVisualStyleBackColor = true;
            this.btn_whole.Click += new System.EventHandler(this.btn_whole_Click);
            // 
            // mcd_end
            // 
            this.mcd_end.Location = new System.Drawing.Point(336, 42);
            this.mcd_end.Margin = new System.Windows.Forms.Padding(10);
            this.mcd_end.Name = "mcd_end";
            this.mcd_end.TabIndex = 10;
            this.mcd_end.TabStop = false;
            this.mcd_end.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcd_end_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "结束日期：";
            // 
            // btn_end
            // 
            this.btn_end.Font = new System.Drawing.Font("宋体", 11F);
            this.btn_end.Location = new System.Drawing.Point(336, 18);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(96, 25);
            this.btn_end.TabIndex = 1;
            this.btn_end.Text = "选择时间";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // admin_OperationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(727, 562);
            this.Controls.Add(this.mcd_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_whole);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.mcd_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_time);
            this.Controls.Add(this.Dgv_ort);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "admin_OperationPage";
            this.Text = "操作记录";
            this.Load += new System.EventHandler(this.admin_OperationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_ort;
        private System.Windows.Forms.Button btn_time;
        private System.Windows.Forms.MonthCalendar mcd_time;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_whole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_ort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cl_time;
        private System.Windows.Forms.MonthCalendar mcd_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_end;
    }
}