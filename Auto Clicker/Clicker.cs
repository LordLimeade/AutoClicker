using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Clicker
{
    class Clicker
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        private int _interval = 100;
        private int _timesClicked = 0;

        public void setInterval(int value)
        {
            if (value < 10)
            {
                throw new Exception("Click interval must be greater than or equal to 1 ms.");
            }
            else
            {
                _interval = value;
            }
        }

        public int getInterval()
        {
            return _interval;
        }

        private void setClicks(int value)
        {
            _timesClicked = value;
        }

        public int getClicks()
        {
            return _timesClicked;
        }

        public Clicker()
        {

        }

        public Clicker(int interval)
        {
            setInterval(interval);
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

            setClicks(getClicks() + 1);
        }

        public void loopMouseClick(ref Boolean doLoop)
        {
            setClicks(0);

            while (true)
            {
                if (doLoop)
                {
                    uint X = (uint)Cursor.Position.X;
                    uint Y = (uint)Cursor.Position.Y;
                    mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
                    System.Threading.Thread.Sleep(_interval);

                    setClicks(getClicks() + 1);
                }
            }
        }
    }
}
