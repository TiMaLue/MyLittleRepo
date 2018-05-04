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
                int width, height;
                width = (int) System.Windows.SystemParameters.FullPrimaryScreenWidth;
                height = (int) System.Windows.SystemParameters.FullPrimaryScreenHeight;
                UpdateBounds(0, 0, width, height);

                FormBorderStyle = FormBorderStyle.None;
                MessageBox.Show("Width:" + width + " Height:" + height);
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
    }
}
