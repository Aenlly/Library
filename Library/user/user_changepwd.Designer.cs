namespace Library.user
{
    partial class user_ChangePwd
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
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.btn_NetStep = new System.Windows.Forms.Button();
            this.text_card = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "学号/工号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "身份证：";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(110, 38);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(158, 23);
            this.text_name.TabIndex = 7;
            // 
            // btn_NetStep
            // 
            this.btn_NetStep.Location = new System.Drawing.Point(30, 119);
            this.btn_NetStep.Name = "btn_NetStep";
            this.btn_NetStep.Size = new System.Drawing.Size(99, 37);
            this.btn_NetStep.TabIndex = 12;
            this.btn_NetStep.Text = "重置密码";
            this.btn_NetStep.UseVisualStyleBackColor = true;
            this.btn_NetStep.Click += new System.EventHandler(this.btn_NetStep_Click);
            // 
            // text_card
            // 
            this.text_card.Location = new System.Drawing.Point(110, 74);
            this.text_card.Name = "text_card";
            this.text_card.Size = new System.Drawing.Size(158, 23);
            this.text_card.TabIndex = 13;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(169, 119);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(99, 37);
            this.btn_Login.TabIndex = 14;
            this.btn_Login.Text = "返回登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // user_ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 193);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.text_card);
            this.Controls.Add(this.btn_NetStep);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "user_ChangePwd";
            this.Text = "找回密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.user_ChangePwd_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Button btn_NetStep;
        private System.Windows.Forms.TextBox text_card;
        private System.Windows.Forms.Button btn_Login;
    }
}