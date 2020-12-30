namespace Library.admin
{
    partial class admin_Type
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
            this.lbl = new System.Windows.Forms.Label();
            this.text_type = new System.Windows.Forms.TextBox();
            this.btn_type = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(38, 21);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(104, 16);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "书籍类型名：";
            // 
            // text_type
            // 
            this.text_type.Location = new System.Drawing.Point(143, 16);
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(177, 26);
            this.text_type.TabIndex = 1;
            // 
            // btn_type
            // 
            this.btn_type.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_type.Location = new System.Drawing.Point(41, 68);
            this.btn_type.Name = "btn_type";
            this.btn_type.Size = new System.Drawing.Size(88, 40);
            this.btn_type.TabIndex = 2;
            this.btn_type.Text = "添加";
            this.btn_type.UseVisualStyleBackColor = true;
            this.btn_type.Click += new System.EventHandler(this.btn_type_Click);
            // 
            // btn_no
            // 
            this.btn_no.Font = new System.Drawing.Font("宋体", 13F);
            this.btn_no.Location = new System.Drawing.Point(226, 68);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(85, 40);
            this.btn_no.TabIndex = 3;
            this.btn_no.Text = "取消";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // admin_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(366, 120);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_type);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.lbl);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin_Type";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加新书籍类型";
            this.Load += new System.EventHandler(this.admin_BookType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox text_type;
        private System.Windows.Forms.Button btn_type;
        private System.Windows.Forms.Button btn_no;
    }
}