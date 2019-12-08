namespace Library.admin
{
    partial class admin_userAdd
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
            this.btn_add = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_user = new System.Windows.Forms.ComboBox();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.mtext_card = new System.Windows.Forms.MaskedTextBox();
            this.cmb_college = new System.Windows.Forms.ComboBox();
            this.link_college = new System.Windows.Forms.LinkLabel();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("宋体", 12F);
            this.btn_add.Location = new System.Drawing.Point(52, 241);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 33);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "添加用户";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(116, 17);
            this.text_name.MaxLength = 10;
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(107, 23);
            this.text_name.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 194);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "学院：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 9;
            this.label7.Text = "身份证：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "用户组：";
            // 
            // cmb_user
            // 
            this.cmb_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_user.FormattingEnabled = true;
            this.cmb_user.Location = new System.Drawing.Point(116, 168);
            this.cmb_user.Name = "cmb_user";
            this.cmb_user.Size = new System.Drawing.Size(87, 22);
            this.cmb_user.TabIndex = 5;
            // 
            // cmb_sex
            // 
            this.cmb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Location = new System.Drawing.Point(116, 52);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(87, 22);
            this.cmb_sex.TabIndex = 1;
            // 
            // mtext_card
            // 
            this.mtext_card.Location = new System.Drawing.Point(116, 85);
            this.mtext_card.Mask = "000000-00000000-000A";
            this.mtext_card.Name = "mtext_card";
            this.mtext_card.Size = new System.Drawing.Size(151, 23);
            this.mtext_card.TabIndex = 2;
            // 
            // cmb_college
            // 
            this.cmb_college.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_college.FormattingEnabled = true;
            this.cmb_college.Location = new System.Drawing.Point(116, 128);
            this.cmb_college.Name = "cmb_college";
            this.cmb_college.Size = new System.Drawing.Size(170, 22);
            this.cmb_college.TabIndex = 3;
            // 
            // link_college
            // 
            this.link_college.AutoSize = true;
            this.link_college.Location = new System.Drawing.Point(311, 136);
            this.link_college.Name = "link_college";
            this.link_college.Size = new System.Drawing.Size(63, 14);
            this.link_college.TabIndex = 4;
            this.link_college.TabStop = true;
            this.link_college.Text = "添加学院";
            this.link_college.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_college_LinkClicked);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(223, 241);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(96, 32);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "返回";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // admin_userAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(409, 309);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.link_college);
            this.Controls.Add(this.cmb_college);
            this.Controls.Add(this.mtext_card);
            this.Controls.Add(this.cmb_sex);
            this.Controls.Add(this.cmb_user);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin_userAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.admin_userAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_user;
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.MaskedTextBox mtext_card;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_college;
        private System.Windows.Forms.LinkLabel link_college;
        private System.Windows.Forms.Button btn_close;
    }
}