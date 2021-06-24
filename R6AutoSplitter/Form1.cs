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

        private int _timeToStart = 10;
        private SplitType _type = SplitType.Situations;
        public Form1()
        {
            InitializeComponent();
            Countdown.Text = _timeToStart.ToString();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Countdown.Text == "0")
            {
                timer.Stop();
                runningText.Text = "currently running " + _type.ToString();
                runningText.Visible = true;
                int returnCode = ScreenScrapper.Split(_type);
                runningText.Visible = false;
                runningText.Text = "currently running";
                Countdown.Text = _timeToStart.ToString();
            }
            else
            {
                Countdown.Text = (Int32.Parse(Countdown.Text) - 1).ToString();
            }
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
    }
}
