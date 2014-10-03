using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace lights
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern short GetKeyState(int keyCode);

        [DllImport("user32.dll")]
        private static extern int GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll", EntryPoint = "keybd_event")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private const byte VK_NUMLOCK = 0x90;
        private const byte VK_CAPSLOCK = 0x14;
        private const int VK_SCROLL = 0x91;
        private const uint KEYEVENTF_EXTENDEDKEY = 1;
        private const int KEYEVENTF_KEYUP = 0x2;
        private const int KEYEVENTF_KEYDOWN = 0x0;

        public static bool GetScrollLock()
        {
            return (((ushort)GetKeyState(0x91)) & 0xffff) != 0;
        }

        public static bool GetNumLock()
        {
            return (((ushort)GetKeyState(0x90)) & 0xffff) != 0;
        }

        public static bool GetCapsLock()
        {
            return (((ushort)GetKeyState(0x14)) & 0xffff) != 0;
        }

        public static void SetScrollLock(bool bState)
        {
            if (GetScrollLock() != bState)
            {
                keybd_event(VK_SCROLL, 0x91, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYDOWN, 0);
                keybd_event(VK_SCROLL, 0x91, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
            }
        }

        public static void SetNumLock(bool bState)
        {
            if (GetNumLock() != bState)
            {
                keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYDOWN, 0);
                keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
            }
        }

        public static void SetCapsLock(bool bState)
        {
            if (GetCapsLock() != bState)
            {
                keybd_event(VK_CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYDOWN, 0);
                keybd_event(VK_CAPSLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
            }
        }

        public void SetLablesColor()
        {
            if (GetScrollLock())
            {
                scrollLockLbl.ForeColor = Color.Red;
            }
            else
            {
                scrollLockLbl.ForeColor = Color.Black;
            }

            if (GetCapsLock())
            {
                capsLockLbl.ForeColor = Color.Red;
            }
            else
            {
                capsLockLbl.ForeColor = Color.Black;
            }

            if (GetNumLock())
            {
                numLockLbl.ForeColor = Color.Red;
            }
            else
            {
                numLockLbl.ForeColor = Color.Black;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateTimer.Start();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            SetCapsLock(!GetCapsLock());
            SetNumLock(!GetNumLock());
            SetScrollLock(!GetScrollLock());
            SetLablesColor();
        }
    }
}
