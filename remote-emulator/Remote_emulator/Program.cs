﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace remote_emulator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary> 
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
