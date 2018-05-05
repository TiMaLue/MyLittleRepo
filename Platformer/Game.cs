using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Platformer
{
    class Game
    {
        private Boolean paused = false;
        private PictureBox canvas;

        public Game(PictureBox picBox)
        {
            canvas = picBox;
        }

        public void runGame()
        {
            this.loadWorld();
            //while (!paused)
            //{

            //}
        }

        private void loadWorld()
        {
            canvas.Image = Image.FromFile("../../resources/Green.png");
        }
    }
}
