namespace remote_emulator
{
    partial class buttonSettingForm
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
            this.modeCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hotkey1 = new System.Windows.Forms.TextBox();
            this.hotkey2 = new System.Windows.Forms.TextBox();
            this.hotkey3 = new System.Windows.Forms.TextBox();
            this.hotkey4 = new System.Windows.Forms.TextBox();
            this.hotkey5 = new System.Windows.Forms.TextBox();
            this.hotkey6 = new System.Windows.Forms.TextBox();
            this.value1 = new System.Windows.Forms.TextBox();
            this.value2 = new System.Windows.Forms.TextBox();
            this.value3 = new System.Windows.Forms.TextBox();
            this.value4 = new System.Windows.Forms.TextBox();
            this.value5 = new System.Windows.Forms.TextBox();
            this.value6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mode";
            // 
            // modeCB
            // 
            this.modeCB.FormattingEnabled = true;
            this.modeCB.Items.AddRange(new object[] {
            "Standart",
            "Custom"});
            this.modeCB.Location = new System.Drawing.Point(82, 12);
            this.modeCB.Name = "modeCB";
            this.modeCB.Size = new System.Drawing.Size(121, 21);
            this.modeCB.TabIndex = 1;
            this.modeCB.SelectedIndexChanged += new System.EventHandler(this.modeCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F);
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Button 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F);
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Button 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F);
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Button 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F);
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Button 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10F);
            this.label6.Location = new System.Drawing.Point(12, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Button 5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F);
            this.label7.Location = new System.Drawing.Point(12, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Button 6";
            // 
            // hotkey1
            // 
            this.hotkey1.Location = new System.Drawing.Point(108, 62);
            this.hotkey1.Name = "hotkey1";
            this.hotkey1.Size = new System.Drawing.Size(50, 20);
            this.hotkey1.TabIndex = 8;
            this.hotkey1.Click += new System.EventHandler(this.hotkey_Set);
            // 
            // hotkey2
            // 
            this.hotkey2.Location = new System.Drawing.Point(108, 88);
            this.hotkey2.Name = "hotkey2";
            this.hotkey2.Size = new System.Drawing.Size(50, 20);
            this.hotkey2.TabIndex = 9;
            this.hotkey2.Click += new System.EventHandler(this.hotkey_Set);
            // 
            // hotkey3
            // 
            this.hotkey3.Location = new System.Drawing.Point(108, 114);
            this.hotkey3.Name = "hotkey3";
            this.hotkey3.Size = new System.Drawing.Size(50, 20);
            this.hotkey3.TabIndex = 10;
            this.hotkey3.Click += new System.EventHandler(this.hotkey_Set);
            // 
            // hotkey4
            // 
            this.hotkey4.Location = new System.Drawing.Point(108, 140);
            this.hotkey4.Name = "hotkey4";
            this.hotkey4.Size = new System.Drawing.Size(50, 20);
            this.hotkey4.TabIndex = 11;
            this.hotkey4.Click += new System.EventHandler(this.hotkey_Set);
            // 
            // hotkey5
            // 
            this.hotkey5.Location = new System.Drawing.Point(108, 166);
            this.hotkey5.Name = "hotkey5";
            this.hotkey5.Size = new System.Drawing.Size(50, 20);
            this.hotkey5.TabIndex = 12;
            this.hotkey5.Click += new System.EventHandler(this.hotkey_Set);
            // 
            // hotkey6
            // 
            this.hotkey6.Location = new System.Drawing.Point(108, 192);
            this.hotkey6.Name = "hotkey6";
            this.hotkey6.Size = new System.Drawing.Size(50, 20);
            this.hotkey6.TabIndex = 13;
            this.hotkey6.Click += new System.EventHandler(this.hotkey_Set);
            // 
            // value1
            // 
            this.value1.Location = new System.Drawing.Point(227, 62);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(50, 20);
            this.value1.TabIndex = 14;
            this.value1.Click += new System.EventHandler(this.value_Set);
            // 
            // value2
            // 
            this.value2.Location = new System.Drawing.Point(227, 88);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(50, 20);
            this.value2.TabIndex = 15;
            this.value2.Click += new System.EventHandler(this.value_Set);
            // 
            // value3
            // 
            this.value3.Location = new System.Drawing.Point(227, 114);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(50, 20);
            this.value3.TabIndex = 16;
            this.value3.Click += new System.EventHandler(this.value_Set);
            // 
            // value4
            // 
            this.value4.Location = new System.Drawing.Point(227, 140);
            this.value4.Name = "value4";
            this.value4.Size = new System.Drawing.Size(50, 20);
            this.value4.TabIndex = 17;
            this.value4.Click += new System.EventHandler(this.value_Set);
            // 
            // value5
            // 
            this.value5.Location = new System.Drawing.Point(227, 166);
            this.value5.Name = "value5";
            this.value5.Size = new System.Drawing.Size(50, 20);
            this.value5.TabIndex = 18;
            this.value5.Click += new System.EventHandler(this.value_Set);
            // 
            // value6
            // 
            this.value6.Location = new System.Drawing.Point(227, 192);
            this.value6.Name = "value6";
            this.value6.Size = new System.Drawing.Size(50, 20);
            this.value6.TabIndex = 19;
            this.value6.Click += new System.EventHandler(this.value_Set);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10F);
            this.label8.Location = new System.Drawing.Point(105, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Hotkey";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10F);
            this.label9.Location = new System.Drawing.Point(229, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Value";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(238, 218);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 22;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // buttonSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 248);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.value6);
            this.Controls.Add(this.value5);
            this.Controls.Add(this.value4);
            this.Controls.Add(this.value3);
            this.Controls.Add(this.value2);
            this.Controls.Add(this.value1);
            this.Controls.Add(this.hotkey6);
            this.Controls.Add(this.hotkey5);
            this.Controls.Add(this.hotkey4);
            this.Controls.Add(this.hotkey3);
            this.Controls.Add(this.hotkey2);
            this.Controls.Add(this.hotkey1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modeCB);
            this.Controls.Add(this.label1);
            this.Name = "buttonSettingForm";
            this.Text = "buttonSettingForm";
            this.Load += new System.EventHandler(this.buttonSettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox modeCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hotkey1;
        private System.Windows.Forms.TextBox hotkey2;
        private System.Windows.Forms.TextBox hotkey3;
        private System.Windows.Forms.TextBox hotkey4;
        private System.Windows.Forms.TextBox hotkey5;
        private System.Windows.Forms.TextBox hotkey6;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.TextBox value3;
        private System.Windows.Forms.TextBox value4;
        private System.Windows.Forms.TextBox value5;
        private System.Windows.Forms.TextBox value6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button confirmBtn;
    }
}