using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Newtonsoft.Json;

namespace remote_emulator
{
    public static class ConfigManager
    {
        private static readonly string ConfigPath =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ControllerSettings.json");

        public static AppSettings Settings { get; private set; }

        public static void Load()
        {
            if (File.Exists(ConfigPath))
            {
                try
                {
                    string json = File.ReadAllText(ConfigPath);
                    Settings = JsonConvert.DeserializeObject<AppSettings>(json) ?? GetDefaultSettings();
                }
                catch
                {
                    Settings = GetDefaultSettings();
                }
            }
            else
            {
                Settings = GetDefaultSettings();
                Save();
            }
        }

        public static void Save()
        {
            string json = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            File.WriteAllText(ConfigPath, json);
        }

        private static AppSettings GetDefaultSettings()
        {
            return new AppSettings
            {
                LeftStick = new StickSettings
                {
                    HotkeyUp = "W",
                    HotkeyDown = "S",
                    HotkeyLeft = "A",
                    HotkeyRight = "D",
                    ChannelX = 1,
                    ChannelY = 2,
                    XRange = new AxisRange { Min = -100, Max = 100 },
                    YRange = new AxisRange { Min = -100, Max = 100 },
                    UseCustomValues = false
                },
                RightStick = new StickSettings
                {
                    HotkeyUp = "Up",
                    HotkeyDown = "Down",
                    HotkeyLeft = "Left",
                    HotkeyRight = "Right",
                    ChannelX = 3,
                    ChannelY = 4,
                    XRange = new AxisRange { Min = -100, Max = 100 },
                    YRange = new AxisRange { Min = -100, Max = 100 },
                    UseCustomValues = false
                },
                Switches = new List<SwitchSettings>
                {
                    new SwitchSettings
                    {
                        Name = "SW0",
                        HotkeyMain = "Q",
                        HotkeyMin = "M",
                        HotkeyMid = "",
                        HotkeyMax = "U",
                        Mode = SwitchMode.Double,
                        ValueMin = -100,
                        ValueMid = 0,
                        ValueMax = 100,
                        Channel = 5,
                        UseCustomValues = false
                    },
                    new SwitchSettings
                    {
                        Name = "SW1",
                        HotkeyMain = "E",
                        HotkeyMin = "",
                        HotkeyMid = "",
                        HotkeyMax = "",
                        Mode = SwitchMode.Triple,
                        ValueMin = -100,
                        ValueMid = 0,
                        ValueMax = 100,
                        Channel = 6,
                        UseCustomValues = false
                    },
                    new SwitchSettings
                    {
                        Name = "SW2",
                        HotkeyMain = "R",
                        HotkeyMin = "",
                        HotkeyMid = "",
                        HotkeyMax = "",
                        Mode = SwitchMode.Single,
                        ValueMin = -100,
                        ValueMid = 0,
                        ValueMax = 100,
                        Channel = 7,
                        UseCustomValues = false
                    },
                    new SwitchSettings
                    {
                        Name = "SW3",
                        HotkeyMain = "T",
                        HotkeyMin = "",
                        HotkeyMid = "",
                        HotkeyMax = "",
                        Mode = SwitchMode.Triple,
                        ValueMin = -100,
                        ValueMid = 0,
                        ValueMax = 100,
                        Channel = 8,
                        UseCustomValues = false
                    }


                },
                RadioButtons = new ButtonGroupSettings
                {
                    UseCustomValues = false,
                    Channel = 9,
                    Buttons = new List<ButtonOption>
                    {
                        new ButtonOption { Name = "selBtn0", Hotkey = "1", Value = -100 },
                        new ButtonOption { Name = "selBtn1", Hotkey = "2", Value = -60 },
                        new ButtonOption { Name = "selBtn2", Hotkey = "3", Value = -20 },
                        new ButtonOption { Name = "selBtn3", Hotkey = "4", Value = 20 },
                        new ButtonOption { Name = "selBtn4", Hotkey = "5", Value = 60 },
                        new ButtonOption { Name = "selBtn5", Hotkey = "6", Value = 100 },
                    }
                }
            };
        }

        public static bool[] GetAvailableChannels()
        {
            // Ініціалізуємо всі 16 каналів як вільні
            bool[] channels = Enumerable.Repeat(true, 16).ToArray();

            void MarkUsed(int channel)
            {
                if (channel >= 1 && channel <= 16)
                {
                    channels[channel - 1] = false;
                }
            }

            var s = ConfigManager.Settings;

            // Стік: по 2 канали на кожен
            MarkUsed(s.LeftStick.ChannelX);
            MarkUsed(s.LeftStick.ChannelY);
            MarkUsed(s.RightStick.ChannelX);
            MarkUsed(s.RightStick.ChannelY);

            // Свічі
            foreach (var sw in s.Switches)
                MarkUsed(sw.Channel);

            // Кнопки
            MarkUsed(s.RadioButtons.Channel);

            return channels;
        }
    }

    public class AppSettings
    {
        public StickSettings LeftStick { get; set; }
        public StickSettings RightStick { get; set; }
        public List<SwitchSettings> Switches { get; set; }
        public ButtonGroupSettings RadioButtons { get; set; }
    }

    public class StickSettings
    {
        public string HotkeyUp { get; set; }
        public string HotkeyDown { get; set; }
        public string HotkeyLeft { get; set; }
        public string HotkeyRight { get; set; }

        public int ChannelX { get; set; }
        public int ChannelY { get; set; }

        public AxisRange XRange { get; set; }
        public AxisRange YRange { get; set; }

        public bool UseCustomValues { get; set; }
    }

    public class AxisRange
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class SwitchSettings
    {
        public string Name { get; set; }

        public string HotkeyMain { get; set; }
        public string HotkeyMin { get; set; }
        public string HotkeyMid { get; set; }
        public string HotkeyMax { get; set; }

        public SwitchMode Mode { get; set; }

        public int ValueMin { get; set; }
        public int ValueMid { get; set; }
        public int ValueMax { get; set; }

        public int Channel { get; set; }

        public bool UseCustomValues { get; set; }
    }

    public enum SwitchMode
    {
        Single,
        Double,
        Triple
    }

    public class ButtonGroupSettings
    {
        public bool UseCustomValues { get; set; }
        public int Channel { get; set; }
        public List<ButtonOption> Buttons { get; set; }
    }

    public class ButtonOption
    {
        public string Name { get; set; }
        public string Hotkey { get; set; }
        public int Value { get; set; }
    }


}
