namespace FORMSNMP
{
    partial class Properties_Dialog
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
            this.groupBox_usm = new System.Windows.Forms.GroupBox();
            this.button_del_user = new System.Windows.Forms.Button();
            this.button_add_user = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.comboBox_priv_prot = new System.Windows.Forms.ComboBox();
            this.comboBox_auth_prot = new System.Windows.Forms.ComboBox();
            this.comboBox_sec_name = new System.Windows.Forms.ComboBox();
            this.textBox_priv_pass = new System.Windows.Forms.TextBox();
            this.textBox_auth_pass = new System.Windows.Forms.TextBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.label_priv_pass = new System.Windows.Forms.Label();
            this.label_priv_prot = new System.Windows.Forms.Label();
            this.label_auth_pass = new System.Windows.Forms.Label();
            this.label_auth_prot = new System.Windows.Forms.Label();
            this.label_sec_name = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox_usm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_usm
            // 
            this.groupBox_usm.Controls.Add(this.button_del_user);
            this.groupBox_usm.Controls.Add(this.button_add_user);
            this.groupBox_usm.Controls.Add(this.button_reset);
            this.groupBox_usm.Controls.Add(this.comboBox_priv_prot);
            this.groupBox_usm.Controls.Add(this.comboBox_auth_prot);
            this.groupBox_usm.Controls.Add(this.comboBox_sec_name);
            this.groupBox_usm.Controls.Add(this.textBox_priv_pass);
            this.groupBox_usm.Controls.Add(this.textBox_auth_pass);
            this.groupBox_usm.Controls.Add(this.button_apply);
            this.groupBox_usm.Controls.Add(this.label_priv_pass);
            this.groupBox_usm.Controls.Add(this.label_priv_prot);
            this.groupBox_usm.Controls.Add(this.label_auth_pass);
            this.groupBox_usm.Controls.Add(this.label_auth_prot);
            this.groupBox_usm.Controls.Add(this.label_sec_name);
            this.groupBox_usm.Location = new System.Drawing.Point(12, 12);
            this.groupBox_usm.Name = "groupBox_usm";
            this.groupBox_usm.Size = new System.Drawing.Size(570, 214);
            this.groupBox_usm.TabIndex = 0;
            this.groupBox_usm.TabStop = false;
            this.groupBox_usm.Text = "USM";
            // 
            // button_del_user
            // 
            this.button_del_user.Location = new System.Drawing.Point(112, 173);
            this.button_del_user.Name = "button_del_user";
            this.button_del_user.Size = new System.Drawing.Size(75, 23);
            this.button_del_user.TabIndex = 13;
            this.button_del_user.Text = "Delete User";
            this.button_del_user.UseVisualStyleBackColor = true;
            // 
            // button_add_user
            // 
            this.button_add_user.Location = new System.Drawing.Point(10, 173);
            this.button_add_user.Name = "button_add_user";
            this.button_add_user.Size = new System.Drawing.Size(96, 23);
            this.button_add_user.TabIndex = 12;
            this.button_add_user.Text = "Add New User";
            this.button_add_user.UseVisualStyleBackColor = true;
            this.button_add_user.Click += new System.EventHandler(this.button_add_user_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(402, 173);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 11;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            // 
            // comboBox_priv_prot
            // 
            this.comboBox_priv_prot.FormattingEnabled = true;
            this.comboBox_priv_prot.Items.AddRange(new object[] {
            "None",
            "DES",
            "DEA",
            "AES128",
            "AES196",
            "AES256"});
            this.comboBox_priv_prot.Location = new System.Drawing.Point(109, 97);
            this.comboBox_priv_prot.Name = "comboBox_priv_prot";
            this.comboBox_priv_prot.Size = new System.Drawing.Size(450, 21);
            this.comboBox_priv_prot.TabIndex = 10;
            this.comboBox_priv_prot.Text = "None";
            // 
            // comboBox_auth_prot
            // 
            this.comboBox_auth_prot.FormattingEnabled = true;
            this.comboBox_auth_prot.Items.AddRange(new object[] {
            "None",
            "HMAC-MD5",
            "HMAC-SHA"});
            this.comboBox_auth_prot.Location = new System.Drawing.Point(109, 40);
            this.comboBox_auth_prot.Name = "comboBox_auth_prot";
            this.comboBox_auth_prot.Size = new System.Drawing.Size(450, 21);
            this.comboBox_auth_prot.TabIndex = 9;
            this.comboBox_auth_prot.Text = "None";
            this.comboBox_auth_prot.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox_sec_name
            // 
            this.comboBox_sec_name.FormattingEnabled = true;
            this.comboBox_sec_name.Location = new System.Drawing.Point(109, 11);
            this.comboBox_sec_name.Name = "comboBox_sec_name";
            this.comboBox_sec_name.Size = new System.Drawing.Size(450, 21);
            this.comboBox_sec_name.TabIndex = 8;
            // 
            // textBox_priv_pass
            // 
            this.textBox_priv_pass.Location = new System.Drawing.Point(109, 126);
            this.textBox_priv_pass.Name = "textBox_priv_pass";
            this.textBox_priv_pass.Size = new System.Drawing.Size(450, 20);
            this.textBox_priv_pass.TabIndex = 7;
            // 
            // textBox_auth_pass
            // 
            this.textBox_auth_pass.Location = new System.Drawing.Point(109, 69);
            this.textBox_auth_pass.Name = "textBox_auth_pass";
            this.textBox_auth_pass.Size = new System.Drawing.Size(450, 20);
            this.textBox_auth_pass.TabIndex = 6;
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(484, 174);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 5;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            // 
            // label_priv_pass
            // 
            this.label_priv_pass.AutoSize = true;
            this.label_priv_pass.Location = new System.Drawing.Point(7, 128);
            this.label_priv_pass.Name = "label_priv_pass";
            this.label_priv_pass.Size = new System.Drawing.Size(71, 13);
            this.label_priv_pass.TabIndex = 4;
            this.label_priv_pass.Text = "PrivPassword";
            // 
            // label_priv_prot
            // 
            this.label_priv_prot.AutoSize = true;
            this.label_priv_prot.Location = new System.Drawing.Point(7, 101);
            this.label_priv_prot.Name = "label_priv_prot";
            this.label_priv_prot.Size = new System.Drawing.Size(64, 13);
            this.label_priv_prot.TabIndex = 3;
            this.label_priv_prot.Text = "PrivProtocol";
            // 
            // label_auth_pass
            // 
            this.label_auth_pass.AutoSize = true;
            this.label_auth_pass.Location = new System.Drawing.Point(7, 74);
            this.label_auth_pass.Name = "label_auth_pass";
            this.label_auth_pass.Size = new System.Drawing.Size(75, 13);
            this.label_auth_pass.TabIndex = 2;
            this.label_auth_pass.Text = "AuthPassword";
            // 
            // label_auth_prot
            // 
            this.label_auth_prot.AutoSize = true;
            this.label_auth_prot.Location = new System.Drawing.Point(7, 47);
            this.label_auth_prot.Name = "label_auth_prot";
            this.label_auth_prot.Size = new System.Drawing.Size(68, 13);
            this.label_auth_prot.TabIndex = 1;
            this.label_auth_prot.Text = "AuthProtocol";
            // 
            // label_sec_name
            // 
            this.label_sec_name.AutoSize = true;
            this.label_sec_name.Location = new System.Drawing.Point(7, 20);
            this.label_sec_name.Name = "label_sec_name";
            this.label_sec_name.Size = new System.Drawing.Size(73, 13);
            this.label_sec_name.TabIndex = 0;
            this.label_sec_name.Text = "SecurityName";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(496, 235);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Properties_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 270);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.groupBox_usm);
            this.Name = "Properties_Dialog";
            this.Text = "Properties";
            this.groupBox_usm.ResumeLayout(false);
            this.groupBox_usm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_usm;
        private System.Windows.Forms.ComboBox comboBox_priv_prot;
        private System.Windows.Forms.ComboBox comboBox_auth_prot;
        private System.Windows.Forms.ComboBox comboBox_sec_name;
        private System.Windows.Forms.TextBox textBox_priv_pass;
        private System.Windows.Forms.TextBox textBox_auth_pass;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Label label_priv_pass;
        private System.Windows.Forms.Label label_priv_prot;
        private System.Windows.Forms.Label label_auth_pass;
        private System.Windows.Forms.Label label_auth_prot;
        private System.Windows.Forms.Label label_sec_name;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_del_user;
        private System.Windows.Forms.Button button_add_user;
        private System.Windows.Forms.Button button_reset;
    }
}