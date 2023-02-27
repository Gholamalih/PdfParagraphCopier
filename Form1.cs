using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GTrans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Source_TextBox_TextChanged(object sender, EventArgs e)
        {
            Destination_TextBox.Text = Source_TextBox.Text.Replace("\r\n", " ");

            string nullTerminatedStr = Destination_TextBox.Text + "\0";
            byte[] strBytes = Encoding.Unicode.GetBytes(nullTerminatedStr);
            IntPtr hglobal = Marshal.AllocHGlobal(strBytes.Length);
            Marshal.Copy(strBytes, 0, hglobal, strBytes.Length);
            Program.OpenClipboard(IntPtr.Zero);
            Program.EmptyClipboard();
            Program.SetClipboardData(13, hglobal);
            Program.CloseClipboard();
            Marshal.FreeHGlobal(hglobal);

        }

        private void sharpClipboard1_ClipboardChanged(object sender, WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs e)
        {
            if (e.ContentType == WK.Libraries.SharpClipboardNS.SharpClipboard.ContentTypes.Text)
            {
                Source_TextBox.Text = (string)e.Content;
            }
        }
    }
}
