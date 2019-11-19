namespace Library.user
{
    partial class user_Feedback
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
            this.text_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_conent = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "反馈标题：";
            // 
            // text_title
            // 
            this.text_title.Location = new System.Drawing.Point(105, 112);
            this.text_title.MaxLength = 10;
            this.text_title.Name = "text_title";
            this.text_title.Size = new System.Drawing.Size(175, 23);
            this.text_title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "反馈内容：";
            // 
            // text_conent
            // 
            this.text_conent.Font = new System.Drawing.Font("宋体", 12F);
            this.text_conent.Location = new System.Drawing.Point(105, 172);
            this.text_conent.MaxLength = 100;
            this.text_conent.Multiline = true;
            this.text_conent.Name = "text_conent";
            this.text_conent.Size = new System.Drawing.Size(175, 195);
            this.text_conent.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("宋体", 14F);
            this.btn_ok.Location = new System.Drawing.Point(84, 418);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(125, 39);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "提交反馈";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "用户ID：";
            // 
            // text_id
            // 
            this.text_id.Enabled = false;
            this.text_id.Location = new System.Drawing.Point(105, 36);
            this.text_id.Name = "text_id";
            this.text_id.ReadOnly = true;
            this.text_id.Size = new System.Drawing.Size(104, 23);
            this.text_id.TabIndex = 6;
            this.text_id.TabStop = false;
            // 
            // user_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 487);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.text_conent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_title);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "user_Feedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "提交反馈问题";
            this.Load += new System.EventHandler(this.user_Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_conent;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_id;
    }
}