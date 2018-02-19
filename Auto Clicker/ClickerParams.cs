using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Clicker
{
    public partial class ClickerParams : Form
    {
        private int _startCode = 0;
        private Boolean _isRecording = false;
        private Boolean _isClicking = false;
        private KeyPressEventArgs _commandKey = new KeyPressEventArgs('1');
        private Clicker c = new Clicker();
        private System.Windows.Forms.Timer timerCountDown, clickCount;
        private int counter = 5;

        private void setStartCode(int value)
        {
            if (value < 0 || value > 2)
            {
                throw new Exception("Invalid Start Code.");
            }
            else
            {
                _startCode = value;
            }
        }

        private int checkMode()
        {
            int startCode = 0;

            if (untilStoppedToolStripMenuItem.Checked)
            {
                startCode = 0;
            }
            else if (whilePressedToolStripMenuItem.Checked)
            {
                startCode = 1;
            }
            else if (setAmountToolStripMenuItem.Checked)
            {
                startCode = 2;
            }

            try
            {
                setStartCode(startCode);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _startCode;
        }

        private void Exit(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void startClicking()
        {
            int code = checkMode();

            switch (code)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                default:
                    MessageBox.Show("Mode not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }

        private void recordCmdBtn(object sender, KeyPressEventArgs e)
        {
            _isRecording = false;

            _commandKey = new KeyPressEventArgs(e.KeyChar);
            
            CommandKeyLbl.Text = _commandKey.KeyChar.ToString() + " selected.";
        }

        private void stopClicking(object sender, KeyPressEventArgs e)
        {
            _isClicking = false;
        }

        public int validate()
        {
            if (ClickNumberTxt.Enabled == true)
            {
                if (ClickNumberTxt.Text.Trim() != "")
                {
                    int x = -1;

                    try
                    {
                        x = int.Parse(ClickNumberTxt.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid value entered for number of clicks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 1;
                    }

                    if (x == 0)
                    {
                        MessageBox.Show("Invalid value entered for number of clicks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 1;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a value for number of clicks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 2;
                }
            }

            if (ClickTimeTxt.Text.Trim() != "")
            {
                int x = -1;

                try
                {
                    x = int.Parse(ClickTimeTxt.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("invalid value entered for click interval.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }

                if (x == 0)
                {
                    MessageBox.Show("Invalid value entered for click interval.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 1;
                }
                else
                {
                    try
                    {
                        c.setInterval(int.Parse(ClickTimeTxt.Text));
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a value for click interval.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }

            return 0;
        }

        public ClickerParams()
        {
            InitializeComponent();
        }

        private void ClickerParams_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            checkMode();

            Thread click = new Thread(() => c.loopMouseClick(ref _isClicking));
            click.Start();

            CommandKeyLbl.Text = _commandKey.KeyChar.ToString() + " selected.";
            ClickNumberTxt.Enabled = false;
            ClickTimeTxt.Text = "1000";

            whilePressedToolStripMenuItem.Enabled = false;
            setAmountToolStripMenuItem.Enabled = false;
        }

        void ClickerParams_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_isRecording)
            {
                recordCmdBtn(sender, e);
            }

            if (_isClicking)
            {
                stopClicking(sender, e);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Exit(sender, e);
        }

        private void RecordCmdBtn_Click(object sender, EventArgs e)
        {
            _isRecording = true;
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit(sender, e);
        }
        
        private void untilStoppedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            untilStoppedToolStripMenuItem.Checked = true;
            whilePressedToolStripMenuItem.Checked = false;
            setAmountToolStripMenuItem.Checked = false;

            ClickNumberTxt.Enabled = false;
            checkMode();
        }
        
        private void whilePressedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            untilStoppedToolStripMenuItem.Checked = false;
            whilePressedToolStripMenuItem.Checked = true;
            setAmountToolStripMenuItem.Checked = false;

            ClickNumberTxt.Enabled = false;
            checkMode();
        }

        private void setAmountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            untilStoppedToolStripMenuItem.Checked = false;
            whilePressedToolStripMenuItem.Checked = false;
            setAmountToolStripMenuItem.Checked = true;

            ClickNumberTxt.Enabled = true;
            checkMode();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            _isClicking = false;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (_isClicking)
            {
                return;
            }

            int y = validate();

            if (y != 0)
            {
                return;
            }
            
            setTimers();
        }

        private void setTimers()
        {
            counter = 5;
            timerCountDown = new System.Windows.Forms.Timer();
            timerCountDown.Tick += new EventHandler(timerCountDown_Tick);
            timerCountDown.Interval = 1000; // 1 second
            timerCountDown.Start();
            timerLbl.Text = counter.ToString();

            clickCount = new System.Windows.Forms.Timer();
            clickCount.Tick += new EventHandler(clickCount_Tick);
            clickCount.Interval = 25; // 1 second
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter <= 0)
            {
                timerCountDown.Stop();
                clickCount.Start();
                _isClicking = true;
            }
            timerLbl.Text = counter.ToString();
        }

        private void clickCount_Tick(object sender, EventArgs e)
        {
            timesClickedLbl.Text = c.getClicks().ToString();
        }
    }
}
