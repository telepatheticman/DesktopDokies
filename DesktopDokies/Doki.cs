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

        public bool falling = true;
        private Timer Fall = new Timer();

        public int floor;

        bool Flipped = false; //False if fasing left

        float speed = 0.0f;
        float acc = 0.5f;

        public Doki()
        {
            //this.image.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            InitializeComponent();
            falling = true;
            this.image.MouseDown += image_MouseDown;
            this.image.MouseMove += image_MouseMove;
            this.image.MouseUp += image_MouseUp;
            Fall.Tick += new EventHandler(Fall_Elapsed);
            Fall.Interval = 15;
            
            this.image.Image = happy;
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            floor = area.Height - this.image.Height + area.Y;

            Flip();

            Fall.Start();

        }

        private bool mouseDown;
        private Point lastLocation;

        //private delegate void Fall_Elapsed_Delligate(object sender, EventArgs e);
        private void Fall_Elapsed(object sender, EventArgs e)
        {
            if(this.Location.Y < floor)
            {
                    this.Location = new Point(this.Location.X, this.Location.Y + (int)Math.Floor(speed));
                speed += acc;
                    this.Update();

            }
            if(this.Location.Y >= floor)
            {
                this.Location = new Point(this.Location.X, floor);
                this.Update();
                falling = false;
                speed = 0;
            }
            if (!falling)
            {
                changeImage(standing);
                Fall.Enabled = false;
            }
        }

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            speed = 0;
            falling = false;
            Fall.Stop();
            changeImage(happy);
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
            floor = area.Height - this.image.Height + area.Y;
            falling = true;
            //Console.WriteLine($"Floor: {floor}, Height: {area.Height}, Corner: {area.X}, {area.Y}");
            Fall.Start();
            changeImage(happy);
            mouseDown = false;
        }


        private void Flip()
        {
            //this.image.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            //Tricky: The image in the control are refrenced from the 
            happy.RotateFlip(RotateFlipType.RotateNoneFlipX);
            standing.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Flipped = !Flipped;
        }

        private void changeImage(Bitmap newImg)
        {
            this.image.Image = newImg;
        }
    }
}
