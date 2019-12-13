namespace Library.admin
{
    partial class admin_Backups
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
            this.Btn_ok = new System.Windows.Forms.Button();
            this.Btn_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_path = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_ok
            // 
            this.Btn_ok.Location = new System.Drawing.Point(49, 183);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(86, 25);
            this.Btn_ok.TabIndex = 2;
            this.Btn_ok.Text = "确定";
            this.Btn_ok.UseVisualStyleBackColor = true;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // Btn_browse
            // 
            this.Btn_browse.Location = new System.Drawing.Point(310, 36);
            this.Btn_browse.Name = "Btn_browse";
            this.Btn_browse.Size = new System.Drawing.Size(86, 25);
            this.Btn_browse.TabIndex = 0;
            this.Btn_browse.Text = "浏览..";
            this.Btn_browse.UseVisualStyleBackColor = true;
            this.Btn_browse.Click += new System.EventHandler(this.Btn_browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "备份文件：";
            // 
            // text_path
            // 
            this.text_path.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.text_path.Enabled = false;
            this.text_path.Font = new System.Drawing.Font("宋体", 10.5F);
            this.text_path.Location = new System.Drawing.Point(106, 36);
            this.text_path.Name = "text_path";
            this.text_path.ReadOnly = true;
            this.text_path.ShortcutsEnabled = false;
            this.text_path.Size = new System.Drawing.Size(179, 23);
            this.text_path.TabIndex = 3;
            this.text_path.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 77);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "    为了使系统更安全正常的工作，请管理员定时对系\r\n\r\n统进行备份工作，以便发生意外时进行恢复。\r\n";
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Location = new System.Drawing.Point(248, 183);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(86, 25);
            this.Btn_cancel.TabIndex = 3;
            this.Btn_cancel.Text = "取消";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "bak";
            this.saveFileDialog1.Filter = "备份文件(*.bak)|*.bak";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "数据库备份";
            // 
            // admin_Backups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(408, 230);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.text_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_browse);
            this.Controls.Add(this.Btn_ok);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "admin_Backups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统备份";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.Button Btn_browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_path;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}