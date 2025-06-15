using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json.Linq;


namespace remote_emulator
{
    public partial class mainForm : Form
    {
        bool isDraggedR = false;
        bool isDraggedL = false;
        Point mousePos;

        uint[] serialOut;
        byte[] sbus_out = new byte[25+1];
        byte mode;

        bool serialConnedted = false;

        UInt16[] CH = new UInt16[16];
        UInt16 selCH = (UInt16)172;
        private int switch0Pos = 0;
        private int switch1Pos = 0;
        private int switch2Pos = 0;
        private int switch3Pos = 0;

        public mainForm()
        {
            InitializeComponent();

            ConfigManager.Load();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string[] av_ports = SerialPort.GetPortNames();

            COMBox.Items.AddRange(av_ports);
            COMBox.SelectedIndex = 0;

            leftStick.Location = new Point(100, 100);
            leftX_trim.Value = 100;
            leftY_trim.Value = -100;
            rightStick.Location = new Point(100, 100);
            rightX_trim.Value = 100;
            rightY_trim.Value = -100;
            rightStickPosLabel.Text = rightStick.Location.ToString();
            leftStickPosLabel.Text = leftStick.Location.ToString();

            for (int i = 0; i < 16; i++)
            {
                CH[i] = 172;
            }

            mode = 1;

            TIM1.Start();
            TIM3.Start();
        }

        private void ReScanBtn_Click(object sender, EventArgs e)
        {
            string[] av_ports = SerialPort.GetPortNames();
            COMBox.Items.Clear();
            COMBox.Items.AddRange(av_ports);
            COMBox.SelectedIndex = 0;
        }

        private void rightX_trim_Scroll(object sender, EventArgs e)
        {
            rightStick.Location = new Point(rightX_trim.Value, rightY_trim.Value * (-1));
        }
        private void rightY_trim_Scroll(object sender, EventArgs e)
        {
            rightStick.Location = new Point(rightX_trim.Value, rightY_trim.Value * (-1));
        }
        private void leftX_trim_Scroll(object sender, EventArgs e)
        {
            leftStick.Location = new Point(leftX_trim.Value, leftY_trim.Value * (-1));
        }
        private void leftY_trim_Scroll(object sender, EventArgs e)
        {
            leftStick.Location = new Point(leftX_trim.Value, leftY_trim.Value * (-1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rightStick.Location = new Point(100, 100);
            rightX_trim.Value = 100;
            rightY_trim.Value = -100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            leftStick.Location = new Point(100, 100);
            leftX_trim.Value = 100;
            leftY_trim.Value = -100;
        }

        //---------------- RIGHT STICK --------------------------
        private void rightStick_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDraggedR = true;
                mousePos = new Point(e.X, e.Y);
            }
        }

        private void rightStick_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggedR)
            {
                var newLocation = new Point(rightStick.Left + e.X - mousePos.X, rightStick.Top + e.Y - mousePos.Y);

                if (newLocation.X <= 0)
                {
                    newLocation.X = 0;
                }
                else if (newLocation.X >= 200)
                {
                    newLocation.X = 200;
                }

                if (newLocation.Y < 0)
                {
                    newLocation.Y = 0;
                }
                else if (newLocation.Y >= 200)
                {
                    newLocation.Y = 200;
                }

                rightStick.Location = newLocation;
            }
        }

        private void rightStick_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDraggedR = false;
                Console.WriteLine(rightStick.Location.ToString());
                rightStick.Location = new Point(rightX_trim.Value, rightY_trim.Value * (-1));
            }
        }

        //---------------- LEFT STICK --------------------------
        private void leftStick_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDraggedL = true;
                mousePos = new Point(e.X, e.Y);
            }
        }

        private void leftStick_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggedL)
            {
                var newLocation = new Point(leftStick.Left + e.X - mousePos.X, leftStick.Top + e.Y - mousePos.Y);

                if (newLocation.X <= 0)
                {
                    newLocation.X = 0;
                }
                else if (newLocation.X >= 200)
                {
                    newLocation.X = 200;
                }

                if (newLocation.Y < 0)
                {
                    newLocation.Y = 0;
                }
                else if (newLocation.Y >= 200)
                {
                    newLocation.Y = 200;
                }

                leftStick.Location = newLocation;
            }
        }

        private void leftStick_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDraggedL = false;
                Console.WriteLine(leftStick.Location.ToString());
                leftStick.Location = new Point(leftX_trim.Value, leftY_trim.Value * (-1));
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (!serialConnedted)
            {
                serialPort1.PortName = COMBox.Text;
                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                connectBtn.Text = "Disconnect";
                connectBtn.BackColor = Color.LimeGreen;
                TIM2.Start();
                serialConnedted = true;
            }
            else
            {
                TIM2.Stop();
                try 
                {
                    serialPort1.Close();
                }
                catch (Exception ex)
                {

                }
                
                connectBtn.Text = "Connect";
                connectBtn.BackColor = Color.Red;                
                serialConnedted = false;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }

        // ------------------------------ TIMER's ------------------------
        // -- TIM1 -- UPDATE PER FRAME (60 Hz) --
        private void TIM1_Tick(object sender, EventArgs e)
        {
            rightStickPosLabel.Text = rightStick.Location.ToString();
            leftStickPosLabel.Text = leftStick.Location.ToString();
        }

        // -- TIM2 -- SERIAL SEND (1 ms) --
        private void TIM2_Tick(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(sbus_out, 0, 26);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectBtn_Click(sender, e);
                ReScanBtn_Click(sender, e);
            }
        }

        // -- TIM3 -- CHANNEL UPDATE (1 ms) --
        private void TIM3_Tick(object sender, EventArgs e)
        {
            var left = ConfigManager.Settings.LeftStick;
            var right = ConfigManager.Settings.RightStick;
            var radio = ConfigManager.Settings.RadioButtons;
            var switches = ConfigManager.Settings.Switches;

            // Стіки
            CH[right.ChannelX - 1] = (UInt16)Math.Round((((double)(rightStick.Location.X + 1) / 201) * 1639) + 172);
            CH[right.ChannelY - 1] = (UInt16)Math.Round(1811 - ((double)rightStick.Location.Y / 201) * (1811 - 172));

            CH[left.ChannelX - 1] = (UInt16)Math.Round((((double)(leftStick.Location.X + 1) / 201) * 1639) + 172);
            CH[left.ChannelY - 1] = (UInt16)Math.Round(1811 - ((double)leftStick.Location.Y / 201) * (1811 - 172));

            // Радіо кнопки
            CH[radio.Channel - 1] = selCH;

            // Свічі (позиції мають бути: 0 = min, 1 = mid, 2 = max)
            CH[switches[0].Channel - 1] = ConvertSwitchValueToPwm(switches[0], switch0Pos);
            CH[switches[1].Channel - 1] = ConvertSwitchValueToPwm(switches[1], switch1Pos);
            CH[switches[2].Channel - 1] = ConvertSwitchValueToPwm(switches[2], switch2Pos);
            CH[switches[3].Channel - 1] = ConvertSwitchValueToPwm(switches[3], switch3Pos);

            for (int i = 0; i < 16; i++)
            {
                Console.Write(CH[i].ToString() + "\t");
            }
            Console.Write("\n");
        }

        private UInt16 ConvertSwitchValueToPwm(SwitchSettings sw, int pos)
        {
            int value = 0;
            if (pos == 0) value = sw.ValueMin;
            else if (pos == 1) value = sw.ValueMid;
            else if (pos == 2) value = sw.ValueMax;

            return (UInt16)Math.Round((value + 100.0) * (1639.0 / 200.0) + 172);
        }

        private void selBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selBtn = sender as RadioButton;

            if (selBtn != null && selBtn.Checked)
            {
                var buttons = ConfigManager.Settings.RadioButtons.Buttons;
                var btnSetting = buttons.Find(b => b.Name == selBtn.Name);

                if (btnSetting != null)
                {
                    int inputValue = Math.Max(-100, Math.Min(100, btnSetting.Value));
                    double normalized = (inputValue + 100) / 200.0;
                    selCH = (UInt16)(172 + normalized * (1811 - 172));
                }
                else
                {
                    Console.WriteLine($"Не знайдено налаштувань для {selBtn.Name}");
                }
            }
        }

        private void mainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            var settings = ConfigManager.Settings;
            char key = char.ToUpper(e.KeyChar); // для нечутливості до регістру

            // Radio buttons
            foreach (var btn in settings.RadioButtons.Buttons)
            {
                if (btn.Hotkey.Equals(key.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    // Викликаємо Select() через Name (наприклад: selBtn0)
                    Control foundBtn = this.Controls.Find(btn.Name, true).FirstOrDefault();
                    if (foundBtn is RadioButton rb)
                        rb.Select();
                }
            }

            // Switches (перевіряємо всі 4)
            foreach (var sw in settings.Switches)
            {
                if (sw.HotkeyMain.Equals(key.ToString(), StringComparison.OrdinalIgnoreCase))
                    CycleSwitch(sw.Name); // приклад: SW0 → перемкнути
                else if (sw.HotkeyMin.Equals(key.ToString(), StringComparison.OrdinalIgnoreCase))
                    SetSwitchPosition(sw.Name, 0);
                else if (sw.HotkeyMid.Equals(key.ToString(), StringComparison.OrdinalIgnoreCase))
                    SetSwitchPosition(sw.Name, 1);
                else if (sw.HotkeyMax.Equals(key.ToString(), StringComparison.OrdinalIgnoreCase))
                    SetSwitchPosition(sw.Name, 2);
            }
        }

        private void CycleSwitch(string switchName)
        {
            var trackBar = Controls.Find(switchName, true).FirstOrDefault() as TrackBar;
            if (trackBar != null)
            {
                int nextValue;
                var sw = ConfigManager.Settings.Switches.FirstOrDefault(s => s.Name == switchName);
                if (sw == null) return;

                switch (sw.Mode)
                {
                    case SwitchMode.Single:
                        nextValue = 2; // одразу на max
                        break;
                    case SwitchMode.Double:
                        nextValue = (trackBar.Value == 0) ? 2 : 0;
                        break;
                    case SwitchMode.Triple:
                    default:
                        nextValue = (trackBar.Value + 1) % 3;
                        break;
                }

                trackBar.Value = nextValue;
            }
        }

        private void SetSwitchPosition(string switchName, int position)
        {
            var trackBar = Controls.Find(switchName, true).FirstOrDefault() as TrackBar;
            if (trackBar != null && position >= 0 && position <= 2)
            {
                trackBar.Value = position;
            }
        }

        // 
        // TRANSFORM CHANNELS INTO 8BIT BUFFER FOR SEND
        //
        private void TIM4_Tick(object sender, EventArgs e)
        {
            sbus_out[0] = (byte)(0x0F);
            sbus_out[1] = (byte)(CH[0] & 0x07FF);
            sbus_out[2] = (byte)(((CH[0] & 0x07FF) >> 8) | ((CH[1] & 0x07FF) << 3));
            sbus_out[3] = (byte)(((CH[1] & 0x07FF) >> 5) | ((CH[2] & 0x07FF) << 6));
            sbus_out[4] = (byte)(((CH[2] & 0x07FF) >> 2));
            sbus_out[5] = (byte)(((CH[2] & 0x07FF) >> 10) | ((CH[3] & 0x07FF) << 1));
            sbus_out[6] = (byte)(((CH[3] & 0x07FF) >> 7) | ((CH[4] & 0x07FF) << 4));
            sbus_out[7] = (byte)(((CH[4] & 0x07FF) >> 4) | ((CH[5] & 0x07FF) << 7));
            sbus_out[8] = (byte)(((CH[5] & 0x07FF) >> 1));
            sbus_out[9] = (byte)(((CH[5] & 0x07FF) >> 9) | ((CH[6] & 0x07FF) << 2));
            sbus_out[10] = (byte)(((CH[6] & 0x07FF) >> 6) | ((CH[7] & 0x07FF) << 5));
            sbus_out[11] = (byte)(((CH[7] & 0x07FF) >> 3));
            sbus_out[12] = (byte)((CH[8] & 0x07FF));
            sbus_out[13] = (byte)(((CH[8] & 0x07FF) >> 8) | ((CH[9] & 0x07FF) << 3));
            sbus_out[14] = (byte)(((CH[9] & 0x07FF) >> 5) | ((CH[10] & 0x07FF) << 6));
            sbus_out[15] = (byte)(((CH[10] & 0x07FF) >> 2));
            sbus_out[16] = (byte)(((CH[10] & 0x07FF) >> 10) | ((CH[11] & 0x07FF) << 1));
            sbus_out[17] = (byte)(((CH[11] & 0x07FF) >> 7) | ((CH[12] & 0x07FF) << 4));
            sbus_out[18] = (byte)(((CH[12] & 0x07FF) >> 4) | ((CH[13] & 0x07FF) << 7));
            sbus_out[19] = (byte)(((CH[13] & 0x07FF) >> 1));
            sbus_out[20] = (byte)(((CH[13] & 0x07FF) >> 9) | ((CH[14] & 0x07FF) << 2));
            sbus_out[21] = (byte)(((CH[14] & 0x07FF) >> 6) | ((CH[15] & 0x07FF) << 5));
            sbus_out[22] = (byte)(((CH[15] & 0x07FF) >> 3));
            sbus_out[23] = (byte)(0x00 | (0x00 * 0x01) | (0x00 * 0x02) | (0x00 * 0x04) | (0x00 * 0x08));
            sbus_out[24] = (byte)mode;
            sbus_out[25] = (byte)(0x00);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control control = elementMenuStrip.SourceControl;
            //Application.Run(new switchSettingForm(control.Name));
            switch (control.Name)
            {
                case "SW0":
                case "SW1":
                case "SW2":
                case "SW3":
                    switchSettingForm ssf = new switchSettingForm(control.Name);
                    ssf.Show();
                    break;
                case "Buttons":
                    buttonSettingForm bsf = new buttonSettingForm();
                    bsf.Show();
                    break;
                default:
                    break;
            }

            //Program.ShowDialog(control.Name);        
        }

        private void radio_Mode_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            switch(rb.Name)
            {
                case "radio_SBUS":
                    mode = (byte)1;
                    break;
                case "radio_CRSF_Tx":
                    mode = (byte)2;
                    break;
                case "radio_CRSF_Rx":
                    mode = (byte)3;
                    break;
                default:
                    break;

            }
        }

        private void SwitchTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (sender is TrackBar tb)
            {
                switch (tb.Name)
                {
                    case "SW0":
                        switch0Pos = tb.Value;
                        break;
                    case "SW1":
                        switch1Pos = tb.Value;
                        break;
                    case "SW2":
                        switch2Pos = tb.Value;
                        break;
                    case "SW3":
                        switch3Pos = tb.Value;
                        break;
                }
            }
        }
    }
}


