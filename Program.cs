using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GTrans
{
    static class Program
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SetClipboardData(uint uFormat, IntPtr hMem);
        [DllImport("user32.dll")]
        public static extern void OpenClipboard(IntPtr ptr);
        [DllImport("user32.dll")]
        public static extern void EmptyClipboard();
        [DllImport("user32.dll")]
        public static extern void CloseClipboard();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());
        }
    }
}
