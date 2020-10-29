using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDokies
{
    public partial class Doki : Form
    {
        public Doki()
        {
            InitializeComponent();
            this.image.MouseDown += image_MouseDown;
            this.image.MouseMove += image_MouseMove;
            this.image.MouseUp += image_MouseUp;
            this.image.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private bool mouseDown;
        private Point lastLocation;

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void image_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void image_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
