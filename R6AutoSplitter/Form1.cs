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
using System.Windows.Input;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace R6AutoSplitter
{
    public partial class Form1 : Form
    {
        private AspectRatioDefinitions.AspectRatio AspectRatio;
        private DebuggerWindow debugViewer;
        private Thread _splitterThread = null;
        private int _timeToStart = 3;
        private SettingsWindow settingsWindow = null;
        private bool _running
        {
            get
            {
                if (runningText.Visible)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Form1()
        {
            _splitterThread = new Thread(StartSplitter);
            InitializeComponent();
            Countdown.Text = _timeToStart.ToString();
            Bitmap Logo = new Bitmap("C:\\Users\\chari\\Desktop\\R6ASLogo - Copy.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Logo;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Visible = false;
            StopButton.Visible = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Countdown.Text == "0" && !_running)
            {
                
                timer.Stop();
                runningText.Text = "currently running";
                runningText.Visible = true;
                CheckForIllegalCrossThreadCalls = false;
                _splitterThread = new Thread(StartSplitter);
                _splitterThread.Start();
                
            }
            else
            {
                Countdown.Text = (Int32.Parse(Countdown.Text) - 1).ToString();
            }
        }

        private void StartSplitter()
        {
            runningText.Text = "currently running";
            Splitter.Split(pauseAfterSplitCheckbox.Checked, AspectRatioDefinitions.AspectRatio.SixteenByNine);
            runningText.Visible = false;
            Countdown.Text = _timeToStart.ToString();
            StopButton.Visible = false;
            StartButton.Visible = true;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsWindow = new SettingsWindow(this);
            settingsWindow.Show();
            this.Hide();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Countdown.Text = _timeToStart.ToString();
            if (_splitterThread.IsAlive)
            {
                _splitterThread.Abort();
            }
            runningText.Visible = false;
            StopButton.Visible = false;
            StartButton.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_splitterThread != null && _splitterThread.IsAlive)
            {
                _splitterThread.Abort();
            }
        }
    }
}
