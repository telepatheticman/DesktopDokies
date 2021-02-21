﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDokies
{
    public enum Who
    {
        wSayori = 0,
        wNatsuki = 1,
        wYuri = 2,
        wMonika = 3
    }

    public enum DokiSize
    {
        Small = 2,
        Medium = 1,
        Large = 0
    }

    public partial class Doki : Form
    {
        Random rand = new Random();

        Bitmap happy;// = Properties.Resources.M_Happy;
        Bitmap standing;// = Properties.Resources.M_Standing;
        Bitmap happy_Flip;// = Properties.Resources.M_Happy;
        Bitmap standing_Flip;// = Properties.Resources.M_Standing;
        Bitmap dead;// = Properties.Resources.M_Dead;

        public Who who;
        public DokiSize dokiSize;

        public bool falling = true;
        private Timer Fall = new Timer();

        float jumpReduction = 5.0f;

        float jumpSpeedMax = -20.0f;
        float jumpSpeed;
        int maxJumps = 4;
        int jumps = 0;
        private Timer Jump = new Timer();

        private float walkHopMax = -10.0f;
        private float walkHop;
        //private int walkDist = 42;
        private Timer Walk = new Timer();

        private Timer Move = new Timer();

        private Timer Die = new Timer();

        private Timer Rain = new Timer();

        public int floor;
        public int rainFloor;

        public int rWall;
        public int lWall;

        bool Flipped = false; //False if fasing left

        float speed = 0.0f;
        float acc = 0.5f;

        int dir = 0;

        //Size ranges from 0(Large) to 2(small)
        public Doki(Bitmap S, Bitmap H, Bitmap D, DokiSize size, Who dokiWho, bool isRain = false)
        {
            //this.image.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);

            InitializeComponent();
            happy = (Bitmap)H.Clone();
            happy_Flip = (Bitmap)H.Clone();
            standing = (Bitmap)S.Clone();
            standing_Flip = (Bitmap)S.Clone();
            dead = (Bitmap)D.Clone();

            who = dokiWho;

            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            setHappy();
            floor = area.Height - this.image.Height + area.Y;
            rainFloor = area.Height + this.image.Height * 2 + 5;
            rWall = area.Width - this.image.Width + area.X;
            lWall = area.X;
            happy_Flip.RotateFlip(RotateFlipType.RotateNoneFlipX);
            standing_Flip.RotateFlip(RotateFlipType.RotateNoneFlipX);

            this.Disposed += (ss, ee) =>
            {
                Fall.Dispose();
                Jump.Dispose();
                Move.Dispose();
                Walk.Dispose();
                Die.Dispose();
                Rain.Dispose();
                happy.Dispose();
                standing.Dispose();
                happy_Flip.Dispose();
                standing_Flip.Dispose();
                dead.Dispose();
            };

            Die.Tick += new EventHandler(Die_Elapsed);
            Die.Interval = 10;
            if(!isRain)
            {
                walkHopMax += 2 * (int)size + 1;
                jumpSpeedMax += 2 * (int)size + 1;
                //jumpReduction 
               
                walkHop = walkHopMax;
                jumpSpeed = jumpSpeedMax;
               
               
               
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
                Move.Interval = rand.Next(750, 2751);
               
                
                //setHappy();
                Fall.Start();
            }
            else
            {
                acc /= 8;
                if (rand.Next(0, 2) == 0) Flip();
                setHappy();
                this.Update();
                Rain.Tick += new EventHandler(Rain_Elapsed);
                Rain.Interval = 15;
                Rain.Start();
            }

        }

        public void DokiCloseHandle(object sender, EventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(delegate {  DokiClose(); }));
        }

        public void DokiClose()
        {
            
            this.image.Image = dead;
            this.Update();
            Die.Start();
            Walk.Enabled = false;
            Fall.Enabled = false;
            Jump.Enabled = false;
            Move.Enabled = false;
            Rain.Enabled = false;


            /*for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(10);
                //var t = Task.Delay(5);
                this.Opacity -= .01;
                this.Update();
                //t.Wait();
            }
            this.Dispose();
            this.Close();*/
            //this.Dispose();
        }

        private bool mouseDown;
        private Point lastLocation;
        private int lastX;

        private void Rain_Elapsed(object sender, EventArgs e)
        {
            if (this.Location.Y < rainFloor)
            {
                this.Location = new Point(this.Location.X, this.Location.Y + (int)Math.Floor(speed));
                speed += acc;
                this.Update();
            }
            if (this.Location.Y >= rainFloor)
            {
                this.Location = new Point(this.Location.X, rainFloor);
                this.Update();
                falling = false;
                speed = 0;
                DokiClose();
            }
        }

        private void Die_Elapsed(object sender, EventArgs e)
        {
            if(this.Opacity > 0)
            {
                this.Opacity -= .01;
                this.Update();
            }
            else
            {
                Die.Enabled = false;
                this.Dispose();
                this.Close();
            }
        }

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
                Fall.Enabled = false;
                Jump.Enabled = true;
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
                if (lastX - Cursor.Position.X > 0 && Flipped) Flip();
                if (lastX - Cursor.Position.X < 0 && !Flipped) Flip();
                lastX = Cursor.Position.X;
                setHappy();
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
                Move.Enabled = true;
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
            if (this.Location.X > rWall || this.Location.X < lWall)
            {
                dir *= -1;
                Flip();
                setStanding();
            }
            this.Location = new Point(this.Location.X + dir * 2, this.Location.Y + (int)Math.Floor(walkHop));
            walkHop += acc * 2;
            track++;
            if (this.Location.Y >= floor && walkHop > 0)
            {
                this.Location = new Point(this.Location.X, floor);
                walkHop = walkHopMax;
                this.Update();
                Walk.Enabled = false;
                Move.Enabled = true;
            }
        }

        private void Move_Elapsed(object sender, EventArgs e)
        {
            int willMove = rand.Next(5); 

            if(willMove == 0)
            {
                int willJump = rand.Next(15);
                if(willJump == 0)
                {
                    setHappy();
                    this.Update();
                    Jump.Enabled = true;
                    Move.Enabled = false;
                }
                else
                {
                    dir = rand.Next(2);
                    if (dir == 0) dir = -1;
                    if ((dir < 0 && Flipped) || (dir > 0 && !Flipped)) Flip();
                    setStanding();
                    this.Update();
                    Walk.Enabled = true;
                    Move.Enabled = false;
                }
            }
            Move.Interval = rand.Next(750, 2751);
        }
    }
}
