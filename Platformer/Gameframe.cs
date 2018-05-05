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
    public partial class Gameframe : Form
    {
        public Gameframe(Boolean fullscreen)
        {
            InitializeComponent();
            if (fullscreen)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
            Game game = new Game(GameBox);
            game.runGame();
        }

        private void Gameframe_Load(object sender, EventArgs e)
        {

        }
    }
}
