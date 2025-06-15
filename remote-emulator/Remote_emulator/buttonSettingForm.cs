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
    public partial class buttonSettingForm : Form
    {
        public buttonSettingForm()
        {
            InitializeComponent();
        }

        private void buttonSettingForm_Load(object sender, EventArgs e)
        {
            this.Text = "Edit Buttons";
            modeCB.SelectedIndex = 0;        
        }

        private void modeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modeCB.SelectedIndex)
            {
                case 0:
                    value1.Enabled = false;
                    value2.Enabled = false;
                    value3.Enabled = false;
                    value4.Enabled = false;
                    value5.Enabled = false;
                    value6.Enabled = false;

                    value1.BackColor = Color.Gray;
                    value2.BackColor = Color.Gray;
                    value3.BackColor = Color.Gray;
                    value4.BackColor = Color.Gray;
                    value5.BackColor = Color.Gray;
                    value6.BackColor = Color.Gray;

                    break;
                case 1:
                    value1.Enabled = true;
                    value2.Enabled = true;
                    value3.Enabled = true;
                    value4.Enabled = true;
                    value5.Enabled = true;
                    value6.Enabled = true;

                    value1.BackColor = Color.LightBlue; 
                    value2.BackColor = Color.LightBlue;
                    value3.BackColor = Color.LightBlue;
                    value4.BackColor = Color.LightBlue;
                    value5.BackColor = Color.LightBlue;
                    value6.BackColor = Color.LightBlue;

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

        private void value_Set(object sender, EventArgs e)
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
    }
}
