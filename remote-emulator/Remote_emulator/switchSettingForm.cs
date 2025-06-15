using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remote_emulator
{
    public partial class switchSettingForm : Form
    {

        string sw;

        public switchSettingForm(string selElement)
        {
            sw = selElement;
            InitializeComponent();
            modeCB.SelectedIndex = 0;
        }
        private void switchSettingForm_Load(object sender, EventArgs e)
        {
            this.Text = "Edit " + sw;
            modeCB.SelectedIndex = 0;
            valueCB.SelectedIndex = 0;
        }

        private void modeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modeCB.SelectedIndex)
            {
                case 0:
                    minHotkeyTB.Enabled = false;
                    midHotkeyTB.Enabled = false;
                    maxHotkeyTB.Enabled = false;

                    minHotkeyTB.BackColor = Color.Gray;
                    midHotkeyTB.BackColor = Color.Gray;
                    maxHotkeyTB.BackColor = Color.Gray;

                    if (valueCB.SelectedIndex == 1)
                    {
                        minValTB.BackColor = Color.LightBlue;
                        midValTB.BackColor = Color.Gray;
                        maxValTB.BackColor = Color.LightBlue;
                    }

                    break;
                case 1:
                    minHotkeyTB.Enabled = true;
                    midHotkeyTB.Enabled = false;
                    maxHotkeyTB.Enabled = true;

                    minHotkeyTB.BackColor = Color.LightBlue;
                    midHotkeyTB.BackColor = Color.Gray;
                    maxHotkeyTB.BackColor = Color.LightBlue;

                    if (valueCB.SelectedIndex == 1)
                    {
                        minValTB.BackColor = Color.LightBlue;
                        midValTB.BackColor = Color.Gray;
                        maxValTB.BackColor = Color.LightBlue;
                    }

                    break;
                case 2:
                    minHotkeyTB.Enabled = true;
                    midHotkeyTB.Enabled = true;
                    maxHotkeyTB.Enabled = true;

                    minHotkeyTB.BackColor = Color.LightBlue;
                    midHotkeyTB.BackColor = Color.LightBlue;
                    maxHotkeyTB.BackColor = Color.LightBlue;

                    if (valueCB.SelectedIndex == 1)
                    {
                        minValTB.BackColor = Color.LightBlue;
                        midValTB.BackColor = Color.LightBlue;
                        maxValTB.BackColor = Color.LightBlue;
                    }
                    break;
                default:
                    break;
            }
        }

        private void valueCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (valueCB.SelectedIndex)
            {
                case 0:
                    minValTB.Enabled = false;
                    midValTB.Enabled = false;
                    maxValTB.Enabled = false;

                    minValTB.BackColor = Color.Gray;
                    midValTB.BackColor = Color.Gray;
                    maxValTB.BackColor = Color.Gray;
                    break;
                case 1:
                    switch (modeCB.SelectedIndex)
                    {
                        case 0:
                        case 1:
                            minValTB.Enabled = true;
                            midValTB.Enabled = false;
                            maxValTB.Enabled = true;

                            minValTB.BackColor = Color.LightBlue;
                            midValTB.BackColor = Color.Gray;
                            maxValTB.BackColor = Color.LightBlue;
                            break;
                        case 2:
                            minValTB.Enabled = true;
                            midValTB.Enabled = true;
                            maxValTB.Enabled = true;

                            minValTB.BackColor = Color.LightBlue;
                            midValTB.BackColor = Color.LightBlue;
                            maxValTB.BackColor = Color.LightBlue;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void hotkey_Set(object sender, EventArgs e)
        {
            var key = KeyCaptureForm.ShowAndCaptureKey(this);
            if (key.HasValue && sender is Control control)
            {
                control.Text = key.Value.ToString();
                Console.WriteLine($"Key set for {control.Name}: {key.Value}");
            }
        }

        private void minValTB_Click(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                int.TryParse(control.Text, out int currentValue);
                var number = NumberInputForm.ShowAndGetNumber(this, currentValue);
                if (number.HasValue)
                {
                    control.Text = number.Value.ToString();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class KeyCaptureForm : Form
    {
        public Keys PressedKey { get; private set; }

        public KeyCaptureForm()
        {
            this.Text = "Press key";
            this.Width = 300;
            this.Height = 100;
            this.StartPosition = FormStartPosition.CenterParent;
            this.KeyPreview = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
            Label label = new Label()
            {
                Text = "Press any key...",
                AutoSize = true,
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };
            this.Controls.Add(label);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            PressedKey = keyData;
            this.DialogResult = DialogResult.OK;
            this.Close();
            return true;
        }

        public static Keys? ShowAndCaptureKey(IWin32Window parent = null)
        {
            using (var form = new KeyCaptureForm())
            {
                return form.ShowDialog(parent) == DialogResult.OK ? form.PressedKey : (Keys?)null;
            }
        }
    }

    public class NumberInputForm : Form
    {
        public int SelectedNumber { get; private set; }

        private NumericUpDown numericUpDown;

        public NumberInputForm(int initialValue = 0)
        {
            this.Text = "Enter number [-100; 100]";
            this.Width = 300;
            this.Height = 120;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            numericUpDown = new NumericUpDown()
            {
                Minimum = -100,
                Maximum = 100,
                Value = initialValue,
                Dock = DockStyle.Top,
                TextAlign = HorizontalAlignment.Center
            };

            var okButton = new Button()
            {
                Text = "Confirm",
                Dock = DockStyle.Bottom,
                DialogResult = DialogResult.OK
            };

            this.Controls.Add(numericUpDown);
            this.Controls.Add(okButton);

            this.AcceptButton = okButton;
        }

        public static int? ShowAndGetNumber(IWin32Window parent = null, int initialValue = 0)
        {
            using (var form = new NumberInputForm(initialValue))
            {
                return form.ShowDialog(parent) == DialogResult.OK ? (int?)form.numericUpDown.Value : null;
            }
        }
    }


}
