namespace Library.admin
{
    partial class admin_Recovery
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
            this.text_path = new System.Windows.Forms.TextBox();
            this.Btn_browse = new System.Windows.Forms.Button();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择文件：";
            // 
            // text_path
            // 
            this.text_path.Cursor = System.Windows.Forms.Cursors.Default;
            this.text_path.Location = new System.Drawing.Point(99, 31);
            this.text_path.Name = "text_path";
            this.text_path.ReadOnly = true;
            this.text_path.Size = new System.Drawing.Size(190, 26);
            this.text_path.TabIndex = 1;
            this.text_path.TabStop = false;
            // 
            // Btn_browse
            // 
            this.Btn_browse.Location = new System.Drawing.Point(314, 33);
            this.Btn_browse.Name = "Btn_browse";
            this.Btn_browse.Size = new System.Drawing.Size(75, 23);
            this.Btn_browse.TabIndex = 0;
            this.Btn_browse.Text = "浏览...";
            this.Btn_browse.UseVisualStyleBackColor = true;
            this.Btn_browse.Click += new System.EventHandler(this.Btn_browse_Click);
            // 
            // Btn_ok
            // 
            this.Btn_ok.Font = new System.Drawing.Font("宋体", 14F);
            this.Btn_ok.Location = new System.Drawing.Point(69, 180);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(101, 37);
            this.Btn_ok.TabIndex = 1;
            this.Btn_ok.Text = "确定";
            this.Btn_ok.UseVisualStyleBackColor = true;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Font = new System.Drawing.Font("宋体", 14F);
            this.Btn_cancel.Location = new System.Drawing.Point(270, 180);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(104, 37);
            this.Btn_cancel.TabIndex = 2;
            this.Btn_cancel.Text = "取消";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "备份文件(*.bak)|*.bak";
            this.openFileDialog1.InitialDirectory = "C";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "数据库恢复";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 77);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "    数据库还原文件为.bak格式，请勿选错格式进行还\r\n\r\n原，否则会造成异常错误。\r\n";
            // 
            // admin_Recovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(407, 240);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_ok);
            this.Controls.Add(this.Btn_browse);
            this.Controls.Add(this.text_path);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin_Recovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据恢复";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_path;
        private System.Windows.Forms.Button Btn_browse;
        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}