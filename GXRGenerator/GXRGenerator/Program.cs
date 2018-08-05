using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GXRGenerator
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        { 
            gen = new GenCSharp.GenCSharp();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static GenCSharp.GenCSharp gen = null;
    }
}
