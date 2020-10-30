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
        Bitmap happy = Properties.Resources.M_Happy;
        Bitmap standing = Properties.Resources.M_Standing;

        int floor;
        public Doki()
        {

            InitializeComponent();
            this.image.MouseDown += image_MouseDown;
            this.image.MouseMove += image_MouseMove;
            this.image.MouseUp += image_MouseUp;
            this.image.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            this.image.Image = Properties.Resources.M_Happy;
            this.image.Image = standing;
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            floor = area.Height - this.image.Height;
        }

        private bool mouseDown;
        private Point lastLocation;

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            this.image.Image = happy;
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
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            floor = area.Height - this.image.Height;
            //Console.WriteLine($"Floor: {floor}, Height: {area.Height}, Corner: {area.X}, {area.Y}");
            this.Location = new Point(this.Location.X, area.Height - this.image.Height + area.Y);
            this.image.Image = standing;
            mouseDown = false;
        }
    }
}
