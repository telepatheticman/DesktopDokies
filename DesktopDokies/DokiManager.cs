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

    public partial class DokiManager : Form
    {
        //Dictionary<Doki, > dokies;
        //List<Doki> testList;
        List<Bitmap> Monika_Res;
        List<Bitmap> Yuri_Res;
        List<Bitmap> Natsuki_Res;
        List<Bitmap> Sayori_Res;
        List<Doki> Dokies;
        Random Rand;
        Screen myScreen;
        Rectangle area;

        System.Windows.Forms.Timer rain = new System.Windows.Forms.Timer();
        bool isRaining = false;
        bool justMonika = false;
        int lowerRainInterval = 500;
        int higherRainInterval = 700;

        int rainDokiesSelected = 4;
        int rainSayoriSelected = 1;
        int rainNatsukiSelected = 1;
        int rainYuriSelected = 1;
        int rainMonikaSelected = 1;




        public DokiManager()
        {
            myScreen = Screen.FromControl(this);
            area = myScreen.WorkingArea;
            Rand = new Random();
            bool CloseButton = false;
            bool Told = false;
            InitializeComponent();

            loadRes();

            Dokies = new List<Doki>();

            initCheck(this.cSayori, this.cNatsuki, this.cYuri, this.cMonika);
            initCheck(this.cNatsuki, this.cYuri, this.cMonika, this.cSayori);
            initCheck(this.cYuri, this.cMonika,this.cSayori, this.cNatsuki);
            initCheck(this.cMonika, this.cSayori, this.cNatsuki, this.cYuri);

            initCheck(this.cSmall, this.cMedium, this.cLarge);
            initCheck(this.cMedium, this.cLarge, this.cSmall);
            initCheck(this.cLarge, this.cSmall, this.cMedium);


            /*this.cSayori.Click += (ss, ee) =>
            {
                if(this.cSayori.Enabled)
                {
                    rainSayoriSelected *= -1;
                    rainDokiesSelected += rainSayoriSelected;
                }
                if(rainDokiesSelected == 1)
                {
                    if (this.cNatsuki.Checked) { this.cNatsuki.Enabled = false; };
                }
            };*/

            this.bSpawn.Click += spawn_Click;
            this.bRain.Click += rain_Click;
            rain.Tick += new EventHandler(rain_Tick);
            rain.Interval = Rand.Next(lowerRainInterval, higherRainInterval + 1);
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
            this.bKillAll.Click += (ss, ee) =>
            {
                removeAll();
            };

            this.bMonika.Click += (ss, ee) =>
            {
                justMonika = true;
            };

            this.tFreq.ValueChanged += (ss, ee) =>
            {
                this.nFreq.Value = this.tFreq.Value;
            };

            this.nFreq.ValueChanged += (ss, ee) =>
            {
                this.tFreq.Value = (int)this.nFreq.Value;
            };

            this.tAmount.ValueChanged += (ss, ee) =>
            {
                this.nAmount.Value = this.tAmount.Value;
            };

            this.nAmount.ValueChanged += (ss, ee) =>
            {
                this.tAmount.Value = (int)this.nAmount.Value;
            };

            addDoki(Who.wSayori, (int)DokiSize.Medium, "Medium Sayori");
            addDoki(Who.wNatsuki, (int)DokiSize.Medium, "Medium Natsuki");
            addDoki(Who.wYuri, (int)DokiSize.Medium, "Medium Yuri");
            addDoki(Who.wMonika, (int)DokiSize.Medium, "Medium Monika");
        }

        private void initCheck(CheckBox main, params CheckBox[] group)
        {
            main.Click += (ss, ee) =>
            {
                int total = 0;
                if (main.Checked) total++;
                foreach (CheckBox checkBox in group)
                {
                    if (checkBox.Checked) total++;
                }
                if (total == 1)
                {
                    if (main.Checked)
                    {
                        main.Enabled = false;
                    }
                    else
                    {
                        foreach (CheckBox checkBox in group)
                        {
                            if (checkBox.Checked) checkBox.Enabled = false;
                        }
                    }
                }
                else
                {
                    main.Enabled = true;
                    foreach (CheckBox checkBox in group)
                    {
                        checkBox.Enabled = true;
                    }
                }
            };
        }

        private void removeAll()
        {
            //Likly unsafe. Not necisarily garentied to be a FlowLayoutPanel. But it is for now. 
            foreach(FlowLayoutPanel cont in this.fpAlive.Controls)
            {
                cont.Dispose();
            }
            this.fpAlive.Controls.Clear();
            foreach(Doki doki in Dokies)
            {
                BeginInvoke(new MethodInvoker(delegate { doki.DokiClose(); }));
            }
            Dokies.Clear();
        }

        private void addDokiControlls(Doki doki, string tText = "")
        {
            //Doki doki;//= new Doki();
            Label t = new Label();
            if(string.IsNullOrEmpty(tText))
            { 
                t.Text = getText();
            }
            else
            {
                t.Text = tText;
            }
            //getSize();
            //doki = GetDoki();
            //doki.StartPosition = FormStartPosition.Manual;
            doki.Location = new Point(Rand.Next(0, doki.rWall), Rand.Next(0, doki.floor / 2));
            Dokies.Add(doki);
            doki.Show();
            FlowLayoutPanel p = new FlowLayoutPanel();
            p.Name = "test";
            p.FlowDirection = FlowDirection.LeftToRight;
            p.Size = new Size(this.fpAlive.ClientSize.Width - 25, 25);
            p.Controls.Add(t);

            Button b = new Button();
            b.Text = "Kill";
            p.Controls.Add(b);

            p.Disposed += (ss, ee) =>
            {
                this.fpAlive.Controls.Remove(p);
                t.Dispose();
                b.Dispose();
            };

            b.Click += (ss, ee) =>
            {
                p.Dispose();
            };

            b.Click += doki.DokiCloseHandle;
            //Doesnt work twice
            //this.bKillAll.Click += doki.DokiCloseHandle;
            //this.bKillAll.Click += (ss, ee) => { p.Dispose(); };

            this.fpAlive.Controls.Add(p);
        }

        private void addDoki()
        {
            getSize();
            Doki doki = GetDoki();
            addDokiControlls(doki);
        }

        private void addDoki(Who who, int size, string tText)
        {
            Doki doki = null;
            switch (who)
            {
                case Who.wSayori:
                    doki = GetSayori(size);
                    break;
                case Who.wNatsuki:
                    doki = GetNatsuki(size);
                    break;
                case Who.wYuri:
                    doki = GetYuri(size);
                    break;
                case Who.wMonika:
                    doki = GetMonika(size);
                    break;
            }
            addDokiControlls(doki, tText);
        }

        private void rain_Click(object sender, EventArgs e)
        {
            if(!isRaining)
            {
                rain.Start();
                isRaining = true;
                this.bRain.Text = "Stop Rain";
            }
            else
            {
                rain.Stop();
                isRaining = false;
                this.bRain.Text = "Start Rain";
            }
        }

        private void rain_Tick(object sender, EventArgs e)
        {
            Who next = (Who)Rand.Next(0, 4);
            Doki doki = null;
            switch (next)
             {
                case Who.wSayori:
                    doki = GetSayori((int)DokiSize.Small, true);
                    break;
                case Who.wNatsuki:
                    doki = GetNatsuki((int)DokiSize.Small, true);
                    break;
                case Who.wYuri:
                    doki = GetYuri((int)DokiSize.Small, true);
                    break;
                case Who.wMonika:
                    doki = GetMonika((int)DokiSize.Small, true);
                    break;
            }
            doki.Location = new Point(Rand.Next(0, doki.rWall), -doki.Height - 5);
            doki.Show();
            rain.Interval = Rand.Next(lowerRainInterval, higherRainInterval + 1);
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
                return GetSayori(getSize());
            }
            else if (this.rNatsuki.Checked)
            {
                return GetNatsuki(getSize());
            }
            else if (this.rYuri.Checked)
            {
                return GetYuri(getSize());
            }
            else
            {
                return GetMonika(getSize());
            }
        }

        private Doki GetSayori(int size, bool isRain = false)
        {
            return new Doki(Sayori_Res[0 + size * 3], Sayori_Res[1 + size * 3], Sayori_Res[2 + size * 3], (DokiSize)size, Who.wSayori, isRain);
        }
        private Doki GetNatsuki(int size, bool isRain = false)
        {
            return new Doki(Natsuki_Res[0 + size * 3], Natsuki_Res[1 + size * 3], Natsuki_Res[2 + size * 3], (DokiSize)size, Who.wNatsuki, isRain);
        }
        private Doki GetYuri(int size, bool isRain = false)
        {
            return new Doki(Yuri_Res[0 + size * 3], Yuri_Res[1 + size * 3], Yuri_Res[2 + size * 3], (DokiSize)size, Who.wYuri, isRain);
        }
        private Doki GetMonika(int size, bool isRain = false)
        {
            return new Doki(Monika_Res[0 + size * 3], Monika_Res[1 + size * 3], Monika_Res[2 + size * 3], (DokiSize)size, Who.wMonika, isRain);
        }

        private int getSize()
        {
            if (this.rLarge.Checked)
            {
                return (int)DokiSize.Large;
            }
            else if (this.rMedium.Checked)
            {
                return (int)DokiSize.Medium;
            }
            else
            {
                return (int)DokiSize.Small;
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
