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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_time = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.mcd_time = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择日期：";
            // 
            // cmb_time
            // 
            this.cmb_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_time.FormattingEnabled = true;
            this.cmb_time.Location = new System.Drawing.Point(97, 14);
            this.cmb_time.MaxDropDownItems = 1;
            this.cmb_time.Name = "cmb_time";
            this.cmb_time.Size = new System.Drawing.Size(111, 22);
            this.cmb_time.TabIndex = 4;
            this.cmb_time.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmb_time_MouseDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(933, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "显示";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mcd_time
            // 
            this.mcd_time.Location = new System.Drawing.Point(97, 36);
            this.mcd_time.Name = "mcd_time";
            this.mcd_time.TabIndex = 5;
            this.mcd_time.Visible = false;
            this.mcd_time.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcd_time_DateChanged);
            // 
            // admin_OperationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.mcd_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_time);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.Name = "admin_OperationPage";
            this.Text = "操作记录";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_time;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar mcd_time;
    }
}