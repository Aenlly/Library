namespace Library.admin
{
    partial class admin_userEdit
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.text_college = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.mtext_card = new System.Windows.Forms.MaskedTextBox();
            this.mtext_tel = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(95, 308);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 34);
            this.btn_edit.TabIndex = 37;
            this.btn_edit.Text = "确认修改";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // text_college
            // 
            this.text_college.Location = new System.Drawing.Point(131, 205);
            this.text_college.Name = "text_college";
            this.text_college.Size = new System.Drawing.Size(151, 23);
            this.text_college.TabIndex = 32;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(131, 51);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(107, 23);
            this.text_name.TabIndex = 27;
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(131, 14);
            this.text_id.Name = "text_id";
            this.text_id.ReadOnly = true;
            this.text_id.Size = new System.Drawing.Size(151, 23);
            this.text_id.TabIndex = 26;
            // 
            // cmb_position
            // 
            this.cmb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Location = new System.Drawing.Point(131, 248);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(68, 22);
            this.cmb_position.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "身份证：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "用户组：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "学院：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "手机号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 273);
            this.panel1.TabIndex = 25;
            // 
            // cmb_sex
            // 
            this.cmb_sex.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Location = new System.Drawing.Point(131, 94);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(68, 22);
            this.cmb_sex.TabIndex = 39;
            // 
            // mtext_card
            // 
            this.mtext_card.Location = new System.Drawing.Point(131, 169);
            this.mtext_card.Mask = "000000-00000000-000A";
            this.mtext_card.Name = "mtext_card";
            this.mtext_card.Size = new System.Drawing.Size(151, 23);
            this.mtext_card.TabIndex = 40;
            // 
            // mtext_tel
            // 
            this.mtext_tel.Location = new System.Drawing.Point(131, 131);
            this.mtext_tel.Mask = "000-0000-0000";
            this.mtext_tel.Name = "mtext_tel";
            this.mtext_tel.Size = new System.Drawing.Size(107, 23);
            this.mtext_tel.TabIndex = 41;
            // 
            // admin_userEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 357);
            this.Controls.Add(this.mtext_tel);
            this.Controls.Add(this.mtext_card);
            this.Controls.Add(this.cmb_sex);
            this.Controls.Add(this.cmb_position);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.text_college);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 10.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin_userEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户信息编辑";
            this.Load += new System.EventHandler(this.admin_userEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox text_college;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.MaskedTextBox mtext_card;
        private System.Windows.Forms.MaskedTextBox mtext_tel;
    }
}