namespace remote_emulator
{
    partial class switchSettingForm
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
            this.modeLabel = new System.Windows.Forms.Label();
            this.modeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minHotkeyTB = new System.Windows.Forms.TextBox();
            this.midHotkeyTB = new System.Windows.Forms.TextBox();
            this.maxHotkeyTB = new System.Windows.Forms.TextBox();
            this.hotkeyTB = new System.Windows.Forms.TextBox();
            this.valueCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxValTB = new System.Windows.Forms.TextBox();
            this.midValTB = new System.Windows.Forms.TextBox();
            this.minValTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.avChannelsCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeLabel.Location = new System.Drawing.Point(12, 14);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(48, 17);
            this.modeLabel.TabIndex = 0;
            this.modeLabel.Text = "Mode:";
            // 
            // modeCB
            // 
            this.modeCB.FormattingEnabled = true;
            this.modeCB.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple"});
            this.modeCB.Location = new System.Drawing.Point(82, 12);
            this.modeCB.Name = "modeCB";
            this.modeCB.Size = new System.Drawing.Size(121, 21);
            this.modeCB.TabIndex = 1;
            this.modeCB.SelectedIndexChanged += new System.EventHandler(this.modeCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hotkey:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mid:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Max:";
            // 
            // minHotkeyTB
            // 
            this.minHotkeyTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.minHotkeyTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.minHotkeyTB.Location = new System.Drawing.Point(82, 84);
            this.minHotkeyTB.Name = "minHotkeyTB";
            this.minHotkeyTB.ReadOnly = true;
            this.minHotkeyTB.Size = new System.Drawing.Size(50, 20);
            this.minHotkeyTB.TabIndex = 6;
            this.minHotkeyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minHotkeyTB.Click += new System.EventHandler(this.hotkey_Set);
            // 
            // midHotkeyTB
            // 
            this.midHotkeyTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.midHotkeyTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.midHotkeyTB.Location = new System.Drawing.Point(82, 116);
            this.midHotkeyTB.Name = "midHotkeyTB";
            this.midHotkeyTB.ReadOnly = true;
            this.midHotkeyTB.Size = new System.Drawing.Size(50, 20);
            this.midHotkeyTB.TabIndex = 7;
            this.midHotkeyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.midHotkeyTB.Click += new System.EventHandler(this.hotkey_Set);
            // 
            // maxHotkeyTB
            // 
            this.maxHotkeyTB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.maxHotkeyTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxHotkeyTB.Location = new System.Drawing.Point(82, 146);
            this.maxHotkeyTB.Name = "maxHotkeyTB";
            this.maxHotkeyTB.ReadOnly = true;
            this.maxHotkeyTB.Size = new System.Drawing.Size(50, 20);
            this.maxHotkeyTB.TabIndex = 8;
            this.maxHotkeyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maxHotkeyTB.Click += new System.EventHandler(this.hotkey_Set);
            // 
            // hotkeyTB
            // 
            this.hotkeyTB.BackColor = System.Drawing.Color.LightBlue;
            this.hotkeyTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.hotkeyTB.Location = new System.Drawing.Point(82, 57);
            this.hotkeyTB.Name = "hotkeyTB";
            this.hotkeyTB.ReadOnly = true;
            this.hotkeyTB.Size = new System.Drawing.Size(50, 20);
            this.hotkeyTB.TabIndex = 9;
            this.hotkeyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hotkeyTB.Click += new System.EventHandler(this.hotkey_Set);
            // 
            // valueCB
            // 
            this.valueCB.FormattingEnabled = true;
            this.valueCB.Items.AddRange(new object[] {
            "Standart",
            "Custom"});
            this.valueCB.Location = new System.Drawing.Point(216, 56);
            this.valueCB.Name = "valueCB";
            this.valueCB.Size = new System.Drawing.Size(83, 21);
            this.valueCB.TabIndex = 10;
            this.valueCB.SelectedIndexChanged += new System.EventHandler(this.valueCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(146, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Values:";
            // 
            // maxValTB
            // 
            this.maxValTB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.maxValTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxValTB.Location = new System.Drawing.Point(249, 145);
            this.maxValTB.Name = "maxValTB";
            this.maxValTB.Size = new System.Drawing.Size(50, 20);
            this.maxValTB.TabIndex = 14;
            this.maxValTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // midValTB
            // 
            this.midValTB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.midValTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.midValTB.Location = new System.Drawing.Point(249, 115);
            this.midValTB.Name = "midValTB";
            this.midValTB.Size = new System.Drawing.Size(50, 20);
            this.midValTB.TabIndex = 13;
            this.midValTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minValTB
            // 
            this.minValTB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.minValTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.minValTB.Location = new System.Drawing.Point(249, 83);
            this.minValTB.Name = "minValTB";
            this.minValTB.ReadOnly = true;
            this.minValTB.Size = new System.Drawing.Size(50, 20);
            this.minValTB.TabIndex = 12;
            this.minValTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minValTB.Click += new System.EventHandler(this.minValTB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Channel:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // avChannelsCB
            // 
            this.avChannelsCB.FormattingEnabled = true;
            this.avChannelsCB.Location = new System.Drawing.Point(82, 203);
            this.avChannelsCB.Name = "avChannelsCB";
            this.avChannelsCB.Size = new System.Drawing.Size(85, 21);
            this.avChannelsCB.TabIndex = 18;
            // 
            // switchSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 248);
            this.Controls.Add(this.avChannelsCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxValTB);
            this.Controls.Add(this.midValTB);
            this.Controls.Add(this.minValTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valueCB);
            this.Controls.Add(this.hotkeyTB);
            this.Controls.Add(this.maxHotkeyTB);
            this.Controls.Add(this.midHotkeyTB);
            this.Controls.Add(this.minHotkeyTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modeCB);
            this.Controls.Add(this.modeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "switchSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.switchSettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.ComboBox modeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox minHotkeyTB;
        private System.Windows.Forms.TextBox midHotkeyTB;
        private System.Windows.Forms.TextBox maxHotkeyTB;
        private System.Windows.Forms.TextBox hotkeyTB;
        private System.Windows.Forms.ComboBox valueCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxValTB;
        private System.Windows.Forms.TextBox midValTB;
        private System.Windows.Forms.TextBox minValTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox avChannelsCB;
    }
}