namespace Library.admin
{
    partial class admin_BookType
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
            this.text_type = new System.Windows.Forms.TextBox();
            this.btn_type = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书类别名：";
            // 
            // text_type
            // 
            this.text_type.Location = new System.Drawing.Point(118, 8);
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(81, 26);
            this.text_type.TabIndex = 1;
            // 
            // btn_type
            // 
            this.btn_type.Location = new System.Drawing.Point(65, 51);
            this.btn_type.Name = "btn_type";
            this.btn_type.Size = new System.Drawing.Size(76, 29);
            this.btn_type.TabIndex = 2;
            this.btn_type.Text = "添加";
            this.btn_type.UseVisualStyleBackColor = true;
            this.btn_type.Click += new System.EventHandler(this.btn_type_Click);
            // 
            // admin_BookType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 92);
            this.Controls.Add(this.btn_type);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin_BookType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加新类别";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_type;
        private System.Windows.Forms.Button btn_type;
    }
}