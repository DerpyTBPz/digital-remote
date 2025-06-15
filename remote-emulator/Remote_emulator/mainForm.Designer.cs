namespace remote_emulator
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            this.COMBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_CRSF_Rx = new System.Windows.Forms.RadioButton();
            this.radio_CRSF_Tx = new System.Windows.Forms.RadioButton();
            this.radio_SBUS = new System.Windows.Forms.RadioButton();
            this.ReScanBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.rightStick = new System.Windows.Forms.RadioButton();
            this.leftStick = new System.Windows.Forms.RadioButton();
            this.leftStickPanel = new System.Windows.Forms.Panel();
            this.elementMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightStickPanel = new System.Windows.Forms.Panel();
            this.leftX_trim = new System.Windows.Forms.TrackBar();
            this.rightY_trim = new System.Windows.Forms.TrackBar();
            this.leftY_trim = new System.Windows.Forms.TrackBar();
            this.rightX_trim = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rightStickPosLabel = new System.Windows.Forms.Label();
            this.leftStickPosLabel = new System.Windows.Forms.Label();
            this.TIM1 = new System.Windows.Forms.Timer(this.components);
            this.connectBtn = new System.Windows.Forms.Button();
            this.TIM2 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.TIM3 = new System.Windows.Forms.Timer(this.components);
            this.Buttons = new System.Windows.Forms.GroupBox();
            this.selBtn5 = new System.Windows.Forms.RadioButton();
            this.selBtn4 = new System.Windows.Forms.RadioButton();
            this.selBtn3 = new System.Windows.Forms.RadioButton();
            this.selBtn2 = new System.Windows.Forms.RadioButton();
            this.selBtn1 = new System.Windows.Forms.RadioButton();
            this.selBtn0 = new System.Windows.Forms.RadioButton();
            this.TIM4 = new System.Windows.Forms.Timer(this.components);
            this.SW0 = new System.Windows.Forms.TrackBar();
            this.SW1 = new System.Windows.Forms.TrackBar();
            this.SW2 = new System.Windows.Forms.TrackBar();
            this.SW3 = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.leftStickPanel.SuspendLayout();
            this.elementMenuStrip.SuspendLayout();
            this.rightStickPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftX_trim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightY_trim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftY_trim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightX_trim)).BeginInit();
            this.Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SW0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SW1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SW2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SW3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMBox
            // 
            this.COMBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBox.Location = new System.Drawing.Point(950, 25);
            this.COMBox.Name = "COMBox";
            this.COMBox.Size = new System.Drawing.Size(121, 21);
            this.COMBox.Sorted = true;
            this.COMBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_CRSF_Rx);
            this.groupBox1.Controls.Add(this.radio_CRSF_Tx);
            this.groupBox1.Controls.Add(this.radio_SBUS);
            this.groupBox1.Location = new System.Drawing.Point(871, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Protocol";
            // 
            // radio_CRSF_Rx
            // 
            this.radio_CRSF_Rx.AutoSize = true;
            this.radio_CRSF_Rx.Location = new System.Drawing.Point(16, 65);
            this.radio_CRSF_Rx.Name = "radio_CRSF_Rx";
            this.radio_CRSF_Rx.Size = new System.Drawing.Size(69, 17);
            this.radio_CRSF_Rx.TabIndex = 2;
            this.radio_CRSF_Rx.Text = "CRSF Rx";
            this.radio_CRSF_Rx.UseVisualStyleBackColor = true;
            this.radio_CRSF_Rx.CheckedChanged += new System.EventHandler(this.radio_Mode_CheckedChanged);
            // 
            // radio_CRSF_Tx
            // 
            this.radio_CRSF_Tx.AutoSize = true;
            this.radio_CRSF_Tx.Location = new System.Drawing.Point(16, 42);
            this.radio_CRSF_Tx.Name = "radio_CRSF_Tx";
            this.radio_CRSF_Tx.Size = new System.Drawing.Size(68, 17);
            this.radio_CRSF_Tx.TabIndex = 1;
            this.radio_CRSF_Tx.Text = "CRSF Tx";
            this.radio_CRSF_Tx.UseVisualStyleBackColor = true;
            this.radio_CRSF_Tx.CheckedChanged += new System.EventHandler(this.radio_Mode_CheckedChanged);
            // 
            // radio_SBUS
            // 
            this.radio_SBUS.AutoSize = true;
            this.radio_SBUS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radio_SBUS.Checked = true;
            this.radio_SBUS.Location = new System.Drawing.Point(16, 20);
            this.radio_SBUS.Name = "radio_SBUS";
            this.radio_SBUS.Size = new System.Drawing.Size(54, 17);
            this.radio_SBUS.TabIndex = 0;
            this.radio_SBUS.TabStop = true;
            this.radio_SBUS.Text = "SBUS";
            this.radio_SBUS.UseVisualStyleBackColor = true;
            this.radio_SBUS.CheckedChanged += new System.EventHandler(this.radio_Mode_CheckedChanged);
            // 
            // ReScanBtn
            // 
            this.ReScanBtn.Location = new System.Drawing.Point(996, 52);
            this.ReScanBtn.Name = "ReScanBtn";
            this.ReScanBtn.Size = new System.Drawing.Size(75, 23);
            this.ReScanBtn.TabIndex = 2;
            this.ReScanBtn.Text = "ReScan";
            this.ReScanBtn.UseVisualStyleBackColor = true;
            this.ReScanBtn.Click += new System.EventHandler(this.ReScanBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowDrop = true;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            this.contextMenuStrip1.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(947, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM:";
            // 
            // rightStick
            // 
            this.rightStick.AutoSize = true;
            this.rightStick.Checked = true;
            this.rightStick.Location = new System.Drawing.Point(100, 107);
            this.rightStick.Name = "rightStick";
            this.rightStick.Size = new System.Drawing.Size(14, 13);
            this.rightStick.TabIndex = 0;
            this.rightStick.TabStop = true;
            this.rightStick.UseVisualStyleBackColor = true;
            this.rightStick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightStick_MouseDown);
            this.rightStick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rightStick_MouseMove);
            this.rightStick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rightStick_MouseUp);
            // 
            // leftStick
            // 
            this.leftStick.AutoSize = true;
            this.leftStick.Checked = true;
            this.leftStick.Location = new System.Drawing.Point(103, 97);
            this.leftStick.Name = "leftStick";
            this.leftStick.Size = new System.Drawing.Size(14, 13);
            this.leftStick.TabIndex = 0;
            this.leftStick.TabStop = true;
            this.leftStick.UseVisualStyleBackColor = true;
            this.leftStick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.leftStick_MouseDown);
            this.leftStick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.leftStick_MouseMove);
            this.leftStick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.leftStick_MouseUp);
            // 
            // leftStickPanel
            // 
            this.leftStickPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftStickPanel.ContextMenuStrip = this.elementMenuStrip;
            this.leftStickPanel.Controls.Add(this.leftStick);
            this.leftStickPanel.Location = new System.Drawing.Point(70, 48);
            this.leftStickPanel.Name = "leftStickPanel";
            this.leftStickPanel.Size = new System.Drawing.Size(220, 220);
            this.leftStickPanel.TabIndex = 3;
            // 
            // elementMenuStrip
            // 
            this.elementMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.elementMenuStrip.Name = "elementMenuStrip";
            this.elementMenuStrip.Size = new System.Drawing.Size(104, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // rightStickPanel
            // 
            this.rightStickPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightStickPanel.ContextMenuStrip = this.elementMenuStrip;
            this.rightStickPanel.Controls.Add(this.rightStick);
            this.rightStickPanel.Location = new System.Drawing.Point(579, 48);
            this.rightStickPanel.Name = "rightStickPanel";
            this.rightStickPanel.Size = new System.Drawing.Size(215, 215);
            this.rightStickPanel.TabIndex = 4;
            // 
            // leftX_trim
            // 
            this.leftX_trim.ContextMenuStrip = this.elementMenuStrip;
            this.leftX_trim.Location = new System.Drawing.Point(58, 274);
            this.leftX_trim.Maximum = 200;
            this.leftX_trim.Name = "leftX_trim";
            this.leftX_trim.Size = new System.Drawing.Size(243, 45);
            this.leftX_trim.TabIndex = 6;
            this.leftX_trim.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.leftX_trim.Value = 100;
            this.leftX_trim.Scroll += new System.EventHandler(this.leftX_trim_Scroll);
            // 
            // rightY_trim
            // 
            this.rightY_trim.ContextMenuStrip = this.elementMenuStrip;
            this.rightY_trim.Location = new System.Drawing.Point(806, 40);
            this.rightY_trim.Maximum = 0;
            this.rightY_trim.Minimum = -200;
            this.rightY_trim.Name = "rightY_trim";
            this.rightY_trim.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.rightY_trim.Size = new System.Drawing.Size(45, 236);
            this.rightY_trim.TabIndex = 7;
            this.rightY_trim.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.rightY_trim.Value = -100;
            this.rightY_trim.Scroll += new System.EventHandler(this.rightY_trim_Scroll);
            // 
            // leftY_trim
            // 
            this.leftY_trim.ContextMenuStrip = this.elementMenuStrip;
            this.leftY_trim.Location = new System.Drawing.Point(19, 40);
            this.leftY_trim.Maximum = 0;
            this.leftY_trim.Minimum = -200;
            this.leftY_trim.Name = "leftY_trim";
            this.leftY_trim.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.leftY_trim.Size = new System.Drawing.Size(45, 236);
            this.leftY_trim.TabIndex = 8;
            this.leftY_trim.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.leftY_trim.Value = -100;
            this.leftY_trim.Scroll += new System.EventHandler(this.leftY_trim_Scroll);
            // 
            // rightX_trim
            // 
            this.rightX_trim.ContextMenuStrip = this.elementMenuStrip;
            this.rightX_trim.Location = new System.Drawing.Point(570, 269);
            this.rightX_trim.Maximum = 200;
            this.rightX_trim.Name = "rightX_trim";
            this.rightX_trim.Size = new System.Drawing.Size(240, 45);
            this.rightX_trim.TabIndex = 9;
            this.rightX_trim.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.rightX_trim.Value = 100;
            this.rightX_trim.Scroll += new System.EventHandler(this.rightX_trim_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(816, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rightStickPosLabel
            // 
            this.rightStickPosLabel.AutoSize = true;
            this.rightStickPosLabel.Location = new System.Drawing.Point(576, 28);
            this.rightStickPosLabel.Name = "rightStickPosLabel";
            this.rightStickPosLabel.Size = new System.Drawing.Size(69, 13);
            this.rightStickPosLabel.TabIndex = 12;
            this.rightStickPosLabel.Text = "rightStickPos";
            // 
            // leftStickPosLabel
            // 
            this.leftStickPosLabel.AutoSize = true;
            this.leftStickPosLabel.Location = new System.Drawing.Point(67, 28);
            this.leftStickPosLabel.Name = "leftStickPosLabel";
            this.leftStickPosLabel.Size = new System.Drawing.Size(63, 13);
            this.leftStickPosLabel.TabIndex = 13;
            this.leftStickPosLabel.Text = "leftStickPos";
            // 
            // TIM1
            // 
            this.TIM1.Interval = 17;
            this.TIM1.Tick += new System.EventHandler(this.TIM1_Tick);
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.Red;
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectBtn.ForeColor = System.Drawing.Color.White;
            this.connectBtn.Location = new System.Drawing.Point(967, 187);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(104, 42);
            this.connectBtn.TabIndex = 14;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // TIM2
            // 
            this.TIM2.Interval = 1;
            this.TIM2.Tick += new System.EventHandler(this.TIM2_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.Handshake = System.IO.Ports.Handshake.XOnXOff;
            this.serialPort1.PortName = "COM5";
            this.serialPort1.ReadTimeout = 5;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // TIM3
            // 
            this.TIM3.Interval = 1;
            this.TIM3.Tick += new System.EventHandler(this.TIM3_Tick);
            // 
            // Buttons
            // 
            this.Buttons.ContextMenuStrip = this.elementMenuStrip;
            this.Buttons.Controls.Add(this.selBtn5);
            this.Buttons.Controls.Add(this.selBtn4);
            this.Buttons.Controls.Add(this.selBtn3);
            this.Buttons.Controls.Add(this.selBtn2);
            this.Buttons.Controls.Add(this.selBtn1);
            this.Buttons.Controls.Add(this.selBtn0);
            this.Buttons.Location = new System.Drawing.Point(323, 28);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(225, 60);
            this.Buttons.TabIndex = 15;
            this.Buttons.TabStop = false;
            this.Buttons.Tag = "selBtns";
            this.Buttons.Text = "Buttons";
            // 
            // selBtn5
            // 
            this.selBtn5.Appearance = System.Windows.Forms.Appearance.Button;
            this.selBtn5.AutoSize = true;
            this.selBtn5.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selBtn5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn5.Location = new System.Drawing.Point(187, 20);
            this.selBtn5.Name = "selBtn5";
            this.selBtn5.Size = new System.Drawing.Size(23, 23);
            this.selBtn5.TabIndex = 5;
            this.selBtn5.Tag = "selBtns";
            this.selBtn5.Text = "6";
            this.selBtn5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn5.UseVisualStyleBackColor = true;
            this.selBtn5.CheckedChanged += new System.EventHandler(this.selBtn_CheckedChanged);
            // 
            // selBtn4
            // 
            this.selBtn4.Appearance = System.Windows.Forms.Appearance.Button;
            this.selBtn4.AutoSize = true;
            this.selBtn4.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selBtn4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn4.Location = new System.Drawing.Point(152, 19);
            this.selBtn4.Name = "selBtn4";
            this.selBtn4.Size = new System.Drawing.Size(23, 23);
            this.selBtn4.TabIndex = 4;
            this.selBtn4.Tag = "selBtns";
            this.selBtn4.Text = "5";
            this.selBtn4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn4.UseVisualStyleBackColor = true;
            this.selBtn4.CheckedChanged += new System.EventHandler(this.selBtn_CheckedChanged);
            // 
            // selBtn3
            // 
            this.selBtn3.Appearance = System.Windows.Forms.Appearance.Button;
            this.selBtn3.AutoSize = true;
            this.selBtn3.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selBtn3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn3.Location = new System.Drawing.Point(117, 19);
            this.selBtn3.Name = "selBtn3";
            this.selBtn3.Size = new System.Drawing.Size(23, 23);
            this.selBtn3.TabIndex = 3;
            this.selBtn3.Tag = "selBtns";
            this.selBtn3.Text = "4";
            this.selBtn3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn3.UseVisualStyleBackColor = true;
            this.selBtn3.CheckedChanged += new System.EventHandler(this.selBtn_CheckedChanged);
            // 
            // selBtn2
            // 
            this.selBtn2.Appearance = System.Windows.Forms.Appearance.Button;
            this.selBtn2.AutoSize = true;
            this.selBtn2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selBtn2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn2.Location = new System.Drawing.Point(82, 20);
            this.selBtn2.Name = "selBtn2";
            this.selBtn2.Size = new System.Drawing.Size(23, 23);
            this.selBtn2.TabIndex = 2;
            this.selBtn2.Tag = "selBtns";
            this.selBtn2.Text = "3";
            this.selBtn2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn2.UseVisualStyleBackColor = true;
            this.selBtn2.CheckedChanged += new System.EventHandler(this.selBtn_CheckedChanged);
            // 
            // selBtn1
            // 
            this.selBtn1.Appearance = System.Windows.Forms.Appearance.Button;
            this.selBtn1.AutoSize = true;
            this.selBtn1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selBtn1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn1.Location = new System.Drawing.Point(47, 20);
            this.selBtn1.Name = "selBtn1";
            this.selBtn1.Size = new System.Drawing.Size(23, 23);
            this.selBtn1.TabIndex = 1;
            this.selBtn1.Tag = "selBtns";
            this.selBtn1.Text = "2";
            this.selBtn1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn1.UseVisualStyleBackColor = true;
            this.selBtn1.CheckedChanged += new System.EventHandler(this.selBtn_CheckedChanged);
            // 
            // selBtn0
            // 
            this.selBtn0.Appearance = System.Windows.Forms.Appearance.Button;
            this.selBtn0.AutoSize = true;
            this.selBtn0.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selBtn0.Checked = true;
            this.selBtn0.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn0.Location = new System.Drawing.Point(12, 20);
            this.selBtn0.Name = "selBtn0";
            this.selBtn0.Size = new System.Drawing.Size(23, 23);
            this.selBtn0.TabIndex = 0;
            this.selBtn0.TabStop = true;
            this.selBtn0.Tag = "selBtns";
            this.selBtn0.Text = "1";
            this.selBtn0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.selBtn0.UseVisualStyleBackColor = true;
            this.selBtn0.CheckedChanged += new System.EventHandler(this.selBtn_CheckedChanged);
            // 
            // TIM4
            // 
            this.TIM4.Enabled = true;
            this.TIM4.Interval = 1;
            this.TIM4.Tick += new System.EventHandler(this.TIM4_Tick);
            // 
            // SW0
            // 
            this.SW0.ContextMenuStrip = this.elementMenuStrip;
            this.SW0.Location = new System.Drawing.Point(6, 19);
            this.SW0.Maximum = 2;
            this.SW0.Name = "SW0";
            this.SW0.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SW0.Size = new System.Drawing.Size(45, 62);
            this.SW0.TabIndex = 16;
            this.SW0.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SW0.Scroll += new System.EventHandler(this.SwitchTrackBar_ValueChanged);
            // 
            // SW1
            // 
            this.SW1.ContextMenuStrip = this.elementMenuStrip;
            this.SW1.Location = new System.Drawing.Point(57, 19);
            this.SW1.Maximum = 2;
            this.SW1.Name = "SW1";
            this.SW1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SW1.Size = new System.Drawing.Size(45, 62);
            this.SW1.TabIndex = 17;
            this.SW1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SW1.Scroll += new System.EventHandler(this.SwitchTrackBar_ValueChanged);
            // 
            // SW2
            // 
            this.SW2.ContextMenuStrip = this.elementMenuStrip;
            this.SW2.Location = new System.Drawing.Point(123, 19);
            this.SW2.Maximum = 2;
            this.SW2.Name = "SW2";
            this.SW2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SW2.Size = new System.Drawing.Size(45, 62);
            this.SW2.TabIndex = 18;
            this.SW2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SW2.Scroll += new System.EventHandler(this.SwitchTrackBar_ValueChanged);
            // 
            // SW3
            // 
            this.SW3.ContextMenuStrip = this.elementMenuStrip;
            this.SW3.Location = new System.Drawing.Point(174, 19);
            this.SW3.Maximum = 2;
            this.SW3.Name = "SW3";
            this.SW3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.SW3.Size = new System.Drawing.Size(45, 62);
            this.SW3.TabIndex = 19;
            this.SW3.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SW3.Scroll += new System.EventHandler(this.SwitchTrackBar_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SW3);
            this.groupBox2.Controls.Add(this.SW0);
            this.groupBox2.Controls.Add(this.SW2);
            this.groupBox2.Controls.Add(this.SW1);
            this.groupBox2.Location = new System.Drawing.Point(323, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Switches";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 625);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Buttons);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.leftStickPosLabel);
            this.Controls.Add(this.rightStickPosLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leftStickPanel);
            this.Controls.Add(this.rightX_trim);
            this.Controls.Add(this.leftY_trim);
            this.Controls.Add(this.rightY_trim);
            this.Controls.Add(this.leftX_trim);
            this.Controls.Add(this.rightStickPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReScanBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.COMBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.leftStickPanel.ResumeLayout(false);
            this.leftStickPanel.PerformLayout();
            this.elementMenuStrip.ResumeLayout(false);
            this.rightStickPanel.ResumeLayout(false);
            this.rightStickPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftX_trim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightY_trim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftY_trim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightX_trim)).EndInit();
            this.Buttons.ResumeLayout(false);
            this.Buttons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SW0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SW1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SW2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SW3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox COMBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_CRSF_Tx;
        private System.Windows.Forms.RadioButton radio_SBUS;
        private System.Windows.Forms.Button ReScanBtn;
        private System.Windows.Forms.RadioButton radio_CRSF_Rx;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rightStick;
        private System.Windows.Forms.RadioButton leftStick;
        private System.Windows.Forms.Panel leftStickPanel;
        private System.Windows.Forms.Panel rightStickPanel;
        private System.Windows.Forms.TrackBar leftX_trim;
        private System.Windows.Forms.TrackBar rightX_trim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar rightY_trim;
        private System.Windows.Forms.TrackBar leftY_trim;
        private System.Windows.Forms.Label rightStickPosLabel;
        private System.Windows.Forms.Label leftStickPosLabel;
        private System.Windows.Forms.Timer TIM1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Timer TIM2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer TIM3;
        private System.Windows.Forms.GroupBox Buttons;
        private System.Windows.Forms.RadioButton selBtn0;
        private System.Windows.Forms.RadioButton selBtn5;
        private System.Windows.Forms.RadioButton selBtn4;
        private System.Windows.Forms.RadioButton selBtn3;
        private System.Windows.Forms.RadioButton selBtn2;
        private System.Windows.Forms.RadioButton selBtn1;
        private System.Windows.Forms.Timer TIM4;
        private System.Windows.Forms.TrackBar SW0;
        private System.Windows.Forms.TrackBar SW1;
        private System.Windows.Forms.TrackBar SW2;
        private System.Windows.Forms.TrackBar SW3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip elementMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}

