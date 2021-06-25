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
        private DebuggerWindow debugViewer;
        private Thread _splitterThread;
        private int _timeToStart = 3;
        private SplitType _type = SplitType.Situations;
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
                runningText.Text = "currently running " + _type.ToString();
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
            ScreenScrapper.Split(_type);
            runningText.Visible = false;
            Countdown.Text = _timeToStart.ToString();
            StopButton.Visible = false;
            StartButton.Visible = true;
        }

        

        private void SituationsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SituationsButton.Checked)
            {
                _type = SplitType.Situations;
            }
        }

        private void AllSituationsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AllSituationsButton.Checked)
            {
                _type = SplitType.AllSituations;
            }
        }

        private void TerroristHuntButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TerroristHuntButton.Checked)
            {
                _type = SplitType.TerroristHunt;
            }
        }

        private void AllTerroristHuntsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AllTerroristHuntsButton.Checked)
            {
                _type = SplitType.AllTerroristHunts;
            }
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

        private void debugButton_Click(object sender, EventArgs e)
        {
            debugViewer = new DebuggerWindow();
            debugViewer.Show();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Countdown.Text = _timeToStart.ToString();
            if (_splitterThread.IsAlive)
            {
                //_splitterThread.Abort();
            }
            runningText.Visible = false;
            StopButton.Visible = false;
            StartButton.Visible = true;
        }
    }
}
