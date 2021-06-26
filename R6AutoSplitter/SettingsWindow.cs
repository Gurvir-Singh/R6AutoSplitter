using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6AutoSplitter
{
    public partial class SettingsWindow : Form
    {
        Form1 _mainWindow;
        DebuggerWindow debugView;
        public SettingsWindow(Form1 mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {

        }

        private void SettingsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainWindow.Show();
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            debugView = new DebuggerWindow();
            debugView.Show();
        }
    }
}
