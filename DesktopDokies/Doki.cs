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
        Random rand = new Random();

        Bitmap happy = Properties.Resources.M_Happy;
        Bitmap standing = Properties.Resources.M_Standing;
        Bitmap happy_Flip = Properties.Resources.M_Happy;
        Bitmap standing_Flip = Properties.Resources.M_Standing;

        public bool falling = true;
        private Timer Fall = new Timer();

        float jumpReduction = 5.0f;

        float jumpSpeedMax = -20.0f;
        float jumpSpeed = -20.0f;
        int maxJumps = 4;
        int jumps = 0;
        private Timer Jump = new Timer();

        private float walkHopMax = -10.0f;
        private float walkHop = -10.0f;
        private int walkDist = 42;
        private Timer Walk = new Timer();

        private Timer Move = new Timer();

        public int floor;

        public int rWall;
        public int lWall;

        bool Flipped = false; //False if fasing left
        bool fromFall = true;

        float speed = 0.0f;
        float acc = 0.5f;

        int dir = 0;

        public Doki()
        {
            //this.image.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            InitializeComponent();

            happy_Flip.RotateFlip(RotateFlipType.RotateNoneFlipX);
            standing_Flip.RotateFlip(RotateFlipType.RotateNoneFlipX);

            this.Disposed += (ss, ee) =>
            {
                Fall.Dispose();
                Jump.Dispose();
                Move.Dispose();
                Walk.Dispose();
                happy.Dispose();
                standing.Dispose();
                happy_Flip.Dispose();
                standing_Flip.Dispose();
            };

            falling = true;
            this.image.MouseDown += image_MouseDown;
            this.image.MouseMove += image_MouseMove;
            this.image.MouseUp += image_MouseUp;
            Fall.Tick += new EventHandler(Fall_Elapsed);
            Fall.Interval = 15;

            Jump.Tick += new EventHandler(Jump_Elapsed);
            Jump.Interval = 10;

            Walk.Tick += new EventHandler(Walk_Elapsed);
            Walk.Interval = 10;

            Move.Tick += new EventHandler(Move_Elapsed);
            Move.Interval = 2000;
            
            this.image.Image = happy;
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            floor = area.Height - this.image.Height + area.Y;
            rWall = area.Width - this.image.Width + area.X;
            lWall = area.X;

            //Flip();

            //dir = rand.Next(2);

            Fall.Start();

        }

        private bool mouseDown;
        private Point lastLocation;
        private int lastX;

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
                //changeImage(standing);
                Fall.Enabled = false;
                Jump.Enabled = true;
                fromFall = true;
            }
        }

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            speed = 0;
            falling = false;
            Fall.Stop();
            Jump.Stop();
            Walk.Stop();
            walkHop = walkHopMax;
            Move.Stop();
            resetJump();
            setHappy();
            mouseDown = true;
            lastLocation = e.Location;
            lastX = Cursor.Position.X;
        }

        private void image_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                //Console.WriteLine(lastLocation.X);
                if (lastX - Cursor.Position.X > 0 && Flipped) Flip();
                if (lastX - Cursor.Position.X < 0 && !Flipped) Flip();
                //Console.WriteLine($"lastX: {lastX}, eX: {Cursor.Position.X}");
                //Console.WriteLine(Cursor.Position.X);
                lastX = Cursor.Position.X;
                this.Update();
            }
        }

        private void image_MouseUp(object sender, MouseEventArgs e)
        {
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            floor = area.Height - this.image.Height + area.Y;
            rWall = area.Width - this.image.Width + area.X;
            lWall = area.X;
            if (this.Location.X > rWall) this.Location = new Point(rWall, this.Location.Y);
            if (this.Location.X < lWall) this.Location = new Point(lWall, this.Location.Y);
            falling = true;
            //Console.WriteLine($"Floor: {floor}, Height: {area.Height}, Corner: {area.X}, {area.Y}");
            Fall.Start();
            setHappy();
            mouseDown = false;
        }


        private void Flip()
        {
            Flipped = !Flipped;
        }

        private void setStanding()
        {
            if (Flipped)
            {
                changeImage(standing_Flip);
            }
            else
            {
                changeImage(standing);
            }
        }

        private void setHappy()
        {
            if(Flipped)
            {
                changeImage(happy_Flip);
            }
            else
            {
                changeImage(happy);
            }
        }

        private void changeImage(Bitmap newImg)
        {
            this.image.Image = newImg;
        }

        private void resetJump()
        {
            jumpSpeed = jumpSpeedMax;
            jumps = 0;
        }

        private void Jump_Elapsed(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y + (int)Math.Floor(jumpSpeed));
            jumpSpeed += acc * 2;
            if (this.Location.Y >= floor && jumpSpeed > 0 && jumps == maxJumps - 1)
            {
                this.Location = new Point(this.Location.X, floor);
                resetJump();
                this.Update();
                setStanding();
                Jump.Enabled = false;
                if (fromFall)
                {
                    Move.Enabled = true;
                    fromFall = false;
                }
            }
            if (this.Location.Y >= floor && jumpSpeed > 0 && jumps < maxJumps)
            {
                this.Location = new Point(this.Location.X, floor);
                jumpSpeed = jumpSpeedMax + (jumps + 1) * jumpReduction;
                jumps++;
                this.Update();
            }
        }
        int track = 0;
        private void Walk_Elapsed(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + dir * 2, this.Location.Y + (int)Math.Floor(walkHop));
            walkHop += acc * 2;
            track++;
            if (this.Location.Y >= floor && walkHop > 0)
            {
                this.Location = new Point(this.Location.X, floor);
                walkHop = walkHopMax;
                this.Update();
                //Console.WriteLine(track);
                Walk.Enabled = false;
                Move.Enabled = true;
            }
        }

        private void Move_Elapsed(object sender, EventArgs e)
        {
            dir = rand.Next(2);
            if (dir == 0) dir = -1;
            if ((dir < 0 && Flipped) || (dir > 0 && !Flipped)) Flip();
            setStanding();
            //Flip();
            //this.image.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            //this.image.Image = happy;
            
            this.Update();
            Walk.Enabled = true;
            Move.Enabled = false;
        }
    }
}
