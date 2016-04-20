namespace FORMSNMP
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_obj_id = new System.Windows.Forms.Label();
            this.label_value = new System.Windows.Forms.Label();
            this.label_target = new System.Windows.Forms.Label();
            this.textBox_obj_id = new System.Windows.Forms.TextBox();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.textBox_target = new System.Windows.Forms.TextBox();
            this.groupBox_snmp = new System.Windows.Forms.GroupBox();
            this.radioButton_snmpv1 = new System.Windows.Forms.RadioButton();
            this.radioButton_snmpv2c = new System.Windows.Forms.RadioButton();
            this.radioButton_snmpv3 = new System.Windows.Forms.RadioButton();
            this.groupBox_v1 = new System.Windows.Forms.GroupBox();
            this.label_community = new System.Windows.Forms.Label();
            this.textBox_community = new System.Windows.Forms.TextBox();
            this.groupBox_gen_opts = new System.Windows.Forms.GroupBox();
            this.label_retries = new System.Windows.Forms.Label();
            this.label_timeout = new System.Windows.Forms.Label();
            this.numericUpDown_retries = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_timeout = new System.Windows.Forms.NumericUpDown();
            this.groupBox_v3 = new System.Windows.Forms.GroupBox();
            this.label_sec_name = new System.Windows.Forms.Label();
            this.label_sec_level = new System.Windows.Forms.Label();
            this.label_context_name = new System.Windows.Forms.Label();
            this.label_context_eng_id = new System.Windows.Forms.Label();
            this.comboBox_sec_name = new System.Windows.Forms.ComboBox();
            this.comboBox_sec_level = new System.Windows.Forms.ComboBox();
            this.textBox_context_name = new System.Windows.Forms.TextBox();
            this.textBox_context_eng_id = new System.Windows.Forms.TextBox();
            this.groupBox_traps = new System.Windows.Forms.GroupBox();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_trap_port = new System.Windows.Forms.TextBox();
            this.button_traps = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_get_next = new System.Windows.Forms.Button();
            this.button_broadcast = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox_snmp.SuspendLayout();
            this.groupBox_v1.SuspendLayout();
            this.groupBox_gen_opts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_retries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timeout)).BeginInit();
            this.groupBox_v3.SuspendLayout();
            this.groupBox_traps.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label_obj_id
            // 
            this.label_obj_id.AutoSize = true;
            this.label_obj_id.Location = new System.Drawing.Point(13, 40);
            this.label_obj_id.Name = "label_obj_id";
            this.label_obj_id.Size = new System.Drawing.Size(52, 13);
            this.label_obj_id.TabIndex = 1;
            this.label_obj_id.Text = "Object-ID";
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(13, 71);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(34, 13);
            this.label_value.TabIndex = 2;
            this.label_value.Text = "Value";
            // 
            // label_target
            // 
            this.label_target.AutoSize = true;
            this.label_target.Location = new System.Drawing.Point(13, 102);
            this.label_target.Name = "label_target";
            this.label_target.Size = new System.Drawing.Size(38, 13);
            this.label_target.TabIndex = 3;
            this.label_target.Text = "Target";
            // 
            // textBox_obj_id
            // 
            this.textBox_obj_id.Location = new System.Drawing.Point(84, 36);
            this.textBox_obj_id.Name = "textBox_obj_id";
            this.textBox_obj_id.Size = new System.Drawing.Size(621, 20);
            this.textBox_obj_id.TabIndex = 4;
            // 
            // textBox_value
            // 
            this.textBox_value.Location = new System.Drawing.Point(84, 67);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(621, 20);
            this.textBox_value.TabIndex = 4;
            // 
            // textBox_target
            // 
            this.textBox_target.Location = new System.Drawing.Point(84, 98);
            this.textBox_target.Name = "textBox_target";
            this.textBox_target.Size = new System.Drawing.Size(621, 20);
            this.textBox_target.TabIndex = 4;
            // 
            // groupBox_snmp
            // 
            this.groupBox_snmp.Controls.Add(this.radioButton_snmpv3);
            this.groupBox_snmp.Controls.Add(this.radioButton_snmpv2c);
            this.groupBox_snmp.Controls.Add(this.radioButton_snmpv1);
            this.groupBox_snmp.Location = new System.Drawing.Point(16, 130);
            this.groupBox_snmp.Name = "groupBox_snmp";
            this.groupBox_snmp.Size = new System.Drawing.Size(689, 51);
            this.groupBox_snmp.TabIndex = 5;
            this.groupBox_snmp.TabStop = false;
            this.groupBox_snmp.Text = "SNMP Version";
            // 
            // radioButton_snmpv1
            // 
            this.radioButton_snmpv1.AutoSize = true;
            this.radioButton_snmpv1.Location = new System.Drawing.Point(19, 20);
            this.radioButton_snmpv1.Name = "radioButton_snmpv1";
            this.radioButton_snmpv1.Size = new System.Drawing.Size(68, 17);
            this.radioButton_snmpv1.TabIndex = 0;
            this.radioButton_snmpv1.TabStop = true;
            this.radioButton_snmpv1.Text = "SNMPv1";
            this.radioButton_snmpv1.UseVisualStyleBackColor = true;
            // 
            // radioButton_snmpv2c
            // 
            this.radioButton_snmpv2c.AutoSize = true;
            this.radioButton_snmpv2c.Location = new System.Drawing.Point(310, 17);
            this.radioButton_snmpv2c.Name = "radioButton_snmpv2c";
            this.radioButton_snmpv2c.Size = new System.Drawing.Size(74, 17);
            this.radioButton_snmpv2c.TabIndex = 1;
            this.radioButton_snmpv2c.TabStop = true;
            this.radioButton_snmpv2c.Text = "SNMPv2c";
            this.radioButton_snmpv2c.UseVisualStyleBackColor = true;
            // 
            // radioButton_snmpv3
            // 
            this.radioButton_snmpv3.AutoSize = true;
            this.radioButton_snmpv3.Location = new System.Drawing.Point(615, 20);
            this.radioButton_snmpv3.Name = "radioButton_snmpv3";
            this.radioButton_snmpv3.Size = new System.Drawing.Size(68, 17);
            this.radioButton_snmpv3.TabIndex = 2;
            this.radioButton_snmpv3.TabStop = true;
            this.radioButton_snmpv3.Text = "SNMPv3";
            this.radioButton_snmpv3.UseVisualStyleBackColor = true;
            // 
            // groupBox_v1
            // 
            this.groupBox_v1.Controls.Add(this.textBox_community);
            this.groupBox_v1.Controls.Add(this.label_community);
            this.groupBox_v1.Location = new System.Drawing.Point(16, 196);
            this.groupBox_v1.Name = "groupBox_v1";
            this.groupBox_v1.Size = new System.Drawing.Size(262, 65);
            this.groupBox_v1.TabIndex = 6;
            this.groupBox_v1.TabStop = false;
            this.groupBox_v1.Text = "SNMPv1 / v2c Options";
            // 
            // label_community
            // 
            this.label_community.AutoSize = true;
            this.label_community.Location = new System.Drawing.Point(6, 26);
            this.label_community.Name = "label_community";
            this.label_community.Size = new System.Drawing.Size(58, 13);
            this.label_community.TabIndex = 0;
            this.label_community.Text = "Community";
            // 
            // textBox_community
            // 
            this.textBox_community.Location = new System.Drawing.Point(68, 22);
            this.textBox_community.Name = "textBox_community";
            this.textBox_community.Size = new System.Drawing.Size(180, 20);
            this.textBox_community.TabIndex = 1;
            // 
            // groupBox_gen_opts
            // 
            this.groupBox_gen_opts.Controls.Add(this.numericUpDown_timeout);
            this.groupBox_gen_opts.Controls.Add(this.numericUpDown_retries);
            this.groupBox_gen_opts.Controls.Add(this.label_timeout);
            this.groupBox_gen_opts.Controls.Add(this.label_retries);
            this.groupBox_gen_opts.Location = new System.Drawing.Point(16, 270);
            this.groupBox_gen_opts.Name = "groupBox_gen_opts";
            this.groupBox_gen_opts.Size = new System.Drawing.Size(262, 81);
            this.groupBox_gen_opts.TabIndex = 7;
            this.groupBox_gen_opts.TabStop = false;
            this.groupBox_gen_opts.Text = "General Options";
            // 
            // label_retries
            // 
            this.label_retries.AutoSize = true;
            this.label_retries.Location = new System.Drawing.Point(12, 20);
            this.label_retries.Name = "label_retries";
            this.label_retries.Size = new System.Drawing.Size(40, 13);
            this.label_retries.TabIndex = 0;
            this.label_retries.Text = "Retries";
            // 
            // label_timeout
            // 
            this.label_timeout.AutoSize = true;
            this.label_timeout.Location = new System.Drawing.Point(12, 46);
            this.label_timeout.Name = "label_timeout";
            this.label_timeout.Size = new System.Drawing.Size(73, 13);
            this.label_timeout.TabIndex = 1;
            this.label_timeout.Text = "Timeout (Sec)";
            // 
            // numericUpDown_retries
            // 
            this.numericUpDown_retries.Location = new System.Drawing.Point(97, 16);
            this.numericUpDown_retries.Name = "numericUpDown_retries";
            this.numericUpDown_retries.Size = new System.Drawing.Size(151, 20);
            this.numericUpDown_retries.TabIndex = 2;
            this.numericUpDown_retries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_retries.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_timeout
            // 
            this.numericUpDown_timeout.Location = new System.Drawing.Point(97, 42);
            this.numericUpDown_timeout.Name = "numericUpDown_timeout";
            this.numericUpDown_timeout.Size = new System.Drawing.Size(151, 20);
            this.numericUpDown_timeout.TabIndex = 2;
            this.numericUpDown_timeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_timeout.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupBox_v3
            // 
            this.groupBox_v3.Controls.Add(this.textBox_context_eng_id);
            this.groupBox_v3.Controls.Add(this.textBox_context_name);
            this.groupBox_v3.Controls.Add(this.comboBox_sec_level);
            this.groupBox_v3.Controls.Add(this.comboBox_sec_name);
            this.groupBox_v3.Controls.Add(this.label_context_eng_id);
            this.groupBox_v3.Controls.Add(this.label_context_name);
            this.groupBox_v3.Controls.Add(this.label_sec_level);
            this.groupBox_v3.Controls.Add(this.label_sec_name);
            this.groupBox_v3.Enabled = false;
            this.groupBox_v3.Location = new System.Drawing.Point(284, 196);
            this.groupBox_v3.Name = "groupBox_v3";
            this.groupBox_v3.Size = new System.Drawing.Size(421, 155);
            this.groupBox_v3.TabIndex = 8;
            this.groupBox_v3.TabStop = false;
            this.groupBox_v3.Text = "SNMPv3 Options";
            // 
            // label_sec_name
            // 
            this.label_sec_name.AutoSize = true;
            this.label_sec_name.Location = new System.Drawing.Point(17, 25);
            this.label_sec_name.Name = "label_sec_name";
            this.label_sec_name.Size = new System.Drawing.Size(73, 13);
            this.label_sec_name.TabIndex = 0;
            this.label_sec_name.Text = "SecurityName";
            // 
            // label_sec_level
            // 
            this.label_sec_level.AutoSize = true;
            this.label_sec_level.Location = new System.Drawing.Point(17, 55);
            this.label_sec_level.Name = "label_sec_level";
            this.label_sec_level.Size = new System.Drawing.Size(71, 13);
            this.label_sec_level.TabIndex = 1;
            this.label_sec_level.Text = "SecurityLevel";
            // 
            // label_context_name
            // 
            this.label_context_name.AutoSize = true;
            this.label_context_name.Location = new System.Drawing.Point(17, 85);
            this.label_context_name.Name = "label_context_name";
            this.label_context_name.Size = new System.Drawing.Size(71, 13);
            this.label_context_name.TabIndex = 2;
            this.label_context_name.Text = "ContextName";
            // 
            // label_context_eng_id
            // 
            this.label_context_eng_id.AutoSize = true;
            this.label_context_eng_id.Location = new System.Drawing.Point(17, 115);
            this.label_context_eng_id.Name = "label_context_eng_id";
            this.label_context_eng_id.Size = new System.Drawing.Size(87, 13);
            this.label_context_eng_id.TabIndex = 3;
            this.label_context_eng_id.Text = "ContextEngineID";
            // 
            // comboBox_sec_name
            // 
            this.comboBox_sec_name.FormattingEnabled = true;
            this.comboBox_sec_name.Location = new System.Drawing.Point(123, 21);
            this.comboBox_sec_name.Name = "comboBox_sec_name";
            this.comboBox_sec_name.Size = new System.Drawing.Size(292, 21);
            this.comboBox_sec_name.TabIndex = 4;
            // 
            // comboBox_sec_level
            // 
            this.comboBox_sec_level.FormattingEnabled = true;
            this.comboBox_sec_level.Items.AddRange(new object[] {
            "noAuthNoPriv",
            "authNoPriv",
            "authPriv"});
            this.comboBox_sec_level.Location = new System.Drawing.Point(123, 55);
            this.comboBox_sec_level.Name = "comboBox_sec_level";
            this.comboBox_sec_level.Size = new System.Drawing.Size(292, 21);
            this.comboBox_sec_level.TabIndex = 5;
            this.comboBox_sec_level.Text = "noAuthNoPriv";
            // 
            // textBox_context_name
            // 
            this.textBox_context_name.Location = new System.Drawing.Point(123, 85);
            this.textBox_context_name.Name = "textBox_context_name";
            this.textBox_context_name.Size = new System.Drawing.Size(292, 20);
            this.textBox_context_name.TabIndex = 6;
            // 
            // textBox_context_eng_id
            // 
            this.textBox_context_eng_id.Location = new System.Drawing.Point(123, 113);
            this.textBox_context_eng_id.Name = "textBox_context_eng_id";
            this.textBox_context_eng_id.Size = new System.Drawing.Size(292, 20);
            this.textBox_context_eng_id.TabIndex = 7;
            // 
            // groupBox_traps
            // 
            this.groupBox_traps.Controls.Add(this.button_traps);
            this.groupBox_traps.Controls.Add(this.textBox_trap_port);
            this.groupBox_traps.Controls.Add(this.label_port);
            this.groupBox_traps.Location = new System.Drawing.Point(16, 357);
            this.groupBox_traps.Name = "groupBox_traps";
            this.groupBox_traps.Size = new System.Drawing.Size(683, 54);
            this.groupBox_traps.TabIndex = 9;
            this.groupBox_traps.TabStop = false;
            this.groupBox_traps.Text = "Traps";
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(12, 24);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(26, 13);
            this.label_port.TabIndex = 0;
            this.label_port.Text = "Port";
            // 
            // textBox_trap_port
            // 
            this.textBox_trap_port.Location = new System.Drawing.Point(68, 20);
            this.textBox_trap_port.Name = "textBox_trap_port";
            this.textBox_trap_port.Size = new System.Drawing.Size(180, 20);
            this.textBox_trap_port.TabIndex = 1;
            this.textBox_trap_port.Text = "162";
            // 
            // button_traps
            // 
            this.button_traps.Location = new System.Drawing.Point(518, 19);
            this.button_traps.Name = "button_traps";
            this.button_traps.Size = new System.Drawing.Size(149, 23);
            this.button_traps.TabIndex = 2;
            this.button_traps.Text = "Start Receiving Traps";
            this.button_traps.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 421);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(689, 121);
            this.textBox1.TabIndex = 10;
            // 
            // button_get_next
            // 
            this.button_get_next.Location = new System.Drawing.Point(630, 557);
            this.button_get_next.Name = "button_get_next";
            this.button_get_next.Size = new System.Drawing.Size(75, 23);
            this.button_get_next.TabIndex = 11;
            this.button_get_next.Text = "GetNext";
            this.button_get_next.UseVisualStyleBackColor = true;
            // 
            // button_broadcast
            // 
            this.button_broadcast.Location = new System.Drawing.Point(16, 557);
            this.button_broadcast.Name = "button_broadcast";
            this.button_broadcast.Size = new System.Drawing.Size(75, 23);
            this.button_broadcast.TabIndex = 12;
            this.button_broadcast.Text = "Broadcast";
            this.button_broadcast.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 602);
            this.Controls.Add(this.button_broadcast);
            this.Controls.Add(this.button_get_next);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox_traps);
            this.Controls.Add(this.groupBox_v3);
            this.Controls.Add(this.groupBox_gen_opts);
            this.Controls.Add(this.groupBox_v1);
            this.Controls.Add(this.groupBox_snmp);
            this.Controls.Add(this.textBox_target);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.textBox_obj_id);
            this.Controls.Add(this.label_target);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.label_obj_id);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple Window Forms SNMP Example";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_snmp.ResumeLayout(false);
            this.groupBox_snmp.PerformLayout();
            this.groupBox_v1.ResumeLayout(false);
            this.groupBox_v1.PerformLayout();
            this.groupBox_gen_opts.ResumeLayout(false);
            this.groupBox_gen_opts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_retries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timeout)).EndInit();
            this.groupBox_v3.ResumeLayout(false);
            this.groupBox_v3.PerformLayout();
            this.groupBox_traps.ResumeLayout(false);
            this.groupBox_traps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label_obj_id;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Label label_target;
        private System.Windows.Forms.TextBox textBox_obj_id;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.TextBox textBox_target;
        private System.Windows.Forms.GroupBox groupBox_snmp;
        private System.Windows.Forms.RadioButton radioButton_snmpv3;
        private System.Windows.Forms.RadioButton radioButton_snmpv2c;
        private System.Windows.Forms.RadioButton radioButton_snmpv1;
        private System.Windows.Forms.GroupBox groupBox_v1;
        private System.Windows.Forms.TextBox textBox_community;
        private System.Windows.Forms.Label label_community;
        private System.Windows.Forms.GroupBox groupBox_gen_opts;
        private System.Windows.Forms.NumericUpDown numericUpDown_timeout;
        private System.Windows.Forms.NumericUpDown numericUpDown_retries;
        private System.Windows.Forms.Label label_timeout;
        private System.Windows.Forms.Label label_retries;
        private System.Windows.Forms.GroupBox groupBox_v3;
        private System.Windows.Forms.TextBox textBox_context_eng_id;
        private System.Windows.Forms.TextBox textBox_context_name;
        private System.Windows.Forms.ComboBox comboBox_sec_level;
        private System.Windows.Forms.ComboBox comboBox_sec_name;
        private System.Windows.Forms.Label label_context_eng_id;
        private System.Windows.Forms.Label label_context_name;
        private System.Windows.Forms.Label label_sec_level;
        private System.Windows.Forms.Label label_sec_name;
        private System.Windows.Forms.GroupBox groupBox_traps;
        private System.Windows.Forms.Button button_traps;
        private System.Windows.Forms.TextBox textBox_trap_port;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_get_next;
        private System.Windows.Forms.Button button_broadcast;
    }
}

