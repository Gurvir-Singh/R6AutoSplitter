using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6AutoSplitter
{
    public partial class DebuggerWindow : Form
    {
        private Thread _renderThread;
        private bool _running;
        private object lockObject = new object();
        public DebuggerWindow()
        {
            InitializeComponent();
            _running = true;
            _renderThread = new Thread(render);
            CheckForIllegalCrossThreadCalls = false;
            _renderThread.Start();
            //render();
        }

        private void render()
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap debugSS = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
            Graphics debugGFX = Graphics.FromImage(debugSS);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            long timeRunning = 0;
            while (_running)
            {

                if (timeRunning != 0)
                {
                    fpsLabel.Text = "FPS: " + (1 / (stopWatch.ElapsedMilliseconds - timeRunning)).ToString();
                }
                timeRunning = stopWatch.ElapsedMilliseconds;
                if (!stopWatch.IsRunning)
                {
                    stopWatch.Start();
                }
                debugGFX.CopyFromScreen(0, 0, 0, 0, new Size(1920, 1080), CopyPixelOperation.SourceCopy);
                
                Invoke((MethodInvoker)(delegate ()
                {
                    pictureBox1.Image = debugSS;
                }));
            }
            stopWatch.Stop();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            _running = false;
            
        }
    }
}
