using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Form1 : Form
    {
        private static Boolean fullscreen;

        public Form1()
        {
            InitializeComponent();
            fullscreen = false;
        }


        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            System.Threading.Thread gameThread = 
                new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            gameThread.Start();
            Close();
            
        }

        private static void ThreadProc()
        {
            Application.Run(new Gameframe(fullscreen));
        }

        private void FullscreenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            fullscreen = !fullscreen;
            FullscreenCheckBox.Checked = fullscreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
