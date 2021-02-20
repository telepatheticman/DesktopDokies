using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDokies
{
    enum Who
    {
        wSayori = 0,
        wNatsuki = 1,
        wYuri = 2,
        wMonika =3
    }
    public partial class DokiManager : Form
    {
        //Dictionary<Doki, > dokies;
        //List<Doki> testList;
        List<Bitmap> Monika_Res;
        List<Bitmap> Yuri_Res;
        List<Bitmap> Natsuki_Res;
        List<Bitmap> Sayori_Res;
        int size;
        Random Rand;
        Screen myScreen;
        Rectangle area;
        public DokiManager()
        {
            myScreen = Screen.FromControl(this);
            area = myScreen.WorkingArea;
            Rand = new Random();
            bool CloseButton = false;
            bool Told = false;
            InitializeComponent();

            loadRes();
            //testList = new List<Doki>();
            //testList.Add(new Doki());
            //testList[0].Show();
            //Thread.Sleep(5000);
            //testList[0].Close();
            this.bSpawn.Click += spawn_Click;
            this.bAbout.Click += (ss, ee) =>
            {
                About about = new About();
                about.ShowDialog();
            };
            this.FormClosing += (ss, ee) =>
            {
                
                if (ee.CloseReason == CloseReason.UserClosing && !CloseButton)
                {
                    ee.Cancel = true;
                    notifyIcon1.Visible = true;
                    this.Hide();
                    if(!Told)
                    {
                        notifyIcon1.ShowBalloonTip(500);
                        Told = true;
                    }
                }
            };

            this.bClose.Click += (ss, ee) =>
            {
                CloseButton = true;
                this.Close();
            };
            this.notifyIcon1.MouseDoubleClick += (ss, ee) =>
            {
                this.Show();
                notifyIcon1.Visible = false;
            };

            addDoki(Who.wSayori, 1);
            addDoki(Who.wNatsuki, 1);
            addDoki(Who.wYuri, 1);
            addDoki(Who.wMonika, 1);
        }

        private void addDokiControlls(Doki doki)
        {
            //Doki doki;//= new Doki();
            Label t = new Label();
            t.Text = getText();
            //getSize();
            //doki = GetDoki();
            //doki.StartPosition = FormStartPosition.Manual;
            doki.Location = new Point(Rand.Next(0, doki.rWall), Rand.Next(0, doki.floor / 2));
            doki.Show();
            FlowLayoutPanel p = new FlowLayoutPanel();
            p.Name = "test";
            p.FlowDirection = FlowDirection.LeftToRight;
            p.Size = new Size(this.fpAlive.ClientSize.Width - 25, 25);
            p.Controls.Add(t);

            Button b = new Button();
            b.Text = "Kill";
            p.Controls.Add(b);

            b.Click += (ss, ee) =>
            {
                this.fpAlive.Controls.Remove(p);
                p.Dispose();
                t.Dispose();
                b.Dispose();
            };

            b.Click += doki.DokiCloseHandle;

            this.fpAlive.Controls.Add(p);
        }

        private void addDoki()
        {
            getSize();
            Doki doki = GetDoki();
            addDokiControlls(doki);
        }

        private void addDoki(Who who, int sSize)
        {
            Doki doki = null;
            switch (who)
            {
                case Who.wSayori:
                    doki = GetSayori(sSize);
                    break;
                case Who.wNatsuki:
                    doki = GetNatsuki(sSize);
                    break;
                case Who.wYuri:
                    doki = GetYuri(sSize);
                    break;
                case Who.wMonika:
                    doki = GetMonika(sSize);
                    break;
            }
            addDokiControlls(doki);
        }

        private void spawn_Click(object sender, EventArgs e)
        {
            addDoki();
        }

        private void loadRes()
        {
            Monika_Res = new List<Bitmap>();
            Monika_Res.Add(Properties.Resources.MonikaLargeStanding);
            Monika_Res.Add(Properties.Resources.MonikaLargeHappy);
            Monika_Res.Add(Properties.Resources.MonikaLargeDead);
            Monika_Res.Add(Properties.Resources.MonikaMediumStanding);
            Monika_Res.Add(Properties.Resources.MonikaMediumHappy);
            Monika_Res.Add(Properties.Resources.MonikaMediumDead);
            Monika_Res.Add(Properties.Resources.MonikaSmallStanding);
            Monika_Res.Add(Properties.Resources.MonikaSmallHappy);
            Monika_Res.Add(Properties.Resources.MonikaSmallDead);

            Sayori_Res = new List<Bitmap>();
            Sayori_Res.Add(Properties.Resources.SayoriStandingLarge);
            Sayori_Res.Add(Properties.Resources.SayoriHappyLarge);
            Sayori_Res.Add(Properties.Resources.SayoriDeadLarge);
            Sayori_Res.Add(Properties.Resources.SayoriStandingMedium);
            Sayori_Res.Add(Properties.Resources.SayoriHappyMedium);
            Sayori_Res.Add(Properties.Resources.SayoriDeadMedium);
            Sayori_Res.Add(Properties.Resources.SayoriStandingSmall);
            Sayori_Res.Add(Properties.Resources.SayoriHappySmall);
            Sayori_Res.Add(Properties.Resources.SayoriDeadSmall);

            Natsuki_Res = new List<Bitmap>();
            Natsuki_Res.Add(Properties.Resources.NatsukiStandingLarge);
            Natsuki_Res.Add(Properties.Resources.NatsukiHappyLarge);
            Natsuki_Res.Add(Properties.Resources.NatsukiDeadLarge);
            Natsuki_Res.Add(Properties.Resources.NatsukiStandingMedium);
            Natsuki_Res.Add(Properties.Resources.NatsukiHappyMedium);
            Natsuki_Res.Add(Properties.Resources.NatsukiDeadMedium);
            Natsuki_Res.Add(Properties.Resources.NatsukiStandingSmall);
            Natsuki_Res.Add(Properties.Resources.NatsukiHappySmall);
            Natsuki_Res.Add(Properties.Resources.NatsukiDeadSmall);

            Yuri_Res = new List<Bitmap>();
            Yuri_Res.Add(Properties.Resources.YuriStandingLarge);
            Yuri_Res.Add(Properties.Resources.YuriHappyLarge);
            Yuri_Res.Add(Properties.Resources.YuriDeadLarge);
            Yuri_Res.Add(Properties.Resources.YuriStandingMedium);
            Yuri_Res.Add(Properties.Resources.YuriHappyMedium);
            Yuri_Res.Add(Properties.Resources.YuriDeadMedium);
            Yuri_Res.Add(Properties.Resources.YuriStandingSmall);
            Yuri_Res.Add(Properties.Resources.YuriHappySmall);
            Yuri_Res.Add(Properties.Resources.YuriDeadSmall);
        }

        private Doki GetDoki()
        {
            if (this.rSayori.Checked)
            {
                return GetSayori(size);
            }
            else if (this.rNatsuki.Checked)
            {
                return GetNatsuki(size);
            }
            else if (this.rYuri.Checked)
            {
                return GetYuri(size);
            }
            else
            {
                return GetMonika(size);
            }
        }

        private Doki GetSayori(int sSize)
        {
            return new Doki(Sayori_Res[0 + sSize * 3], Sayori_Res[1 + sSize * 3], Sayori_Res[2 + sSize * 3], sSize);
        }
        private Doki GetNatsuki(int sSize)
        {
            return new Doki(Natsuki_Res[0 + sSize * 3], Natsuki_Res[1 + sSize * 3], Natsuki_Res[2 + sSize * 3], sSize);
        }
        private Doki GetYuri(int sSize)
        {
            return new Doki(Yuri_Res[0 + sSize * 3], Yuri_Res[1 + sSize * 3], Yuri_Res[2 + sSize * 3], sSize);
        }
        private Doki GetMonika(int sSize)
        {
            return new Doki(Monika_Res[0 + sSize * 3], Monika_Res[1 + sSize * 3], Monika_Res[2 + sSize * 3], sSize);
        }

        private void getSize()
        {
            if (this.rLarge.Checked)
            {
                size = 0;
            }
            else if (this.rMedium.Checked)
            {
                size = 1;
            }
            else
            {
                size = 2;
            }
        }

        private String getText()
        {
            String text = "";

            if(this.rLarge.Checked)
            {
                text += "Large ";
            }
            else if (this.rMedium.Checked)
            {
                text += "Medium ";
            }
            else
            {
                text += "Small ";
            }

            if (this.rSayori.Checked)
            {
                text += "Sayori";
            }
            else if (this.rNatsuki.Checked)
            {
                text += "Natsuki";
            }
            else if (this.rYuri.Checked)
            {
                text += "Yuri";
            }
            else
            {
                text += "Monika";
            }

            return text;
        }
    }
}
