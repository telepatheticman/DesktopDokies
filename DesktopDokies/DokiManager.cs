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
        List<Bitmap> Monika_Res;
        List<Bitmap> Yuri_Res;
        List<Bitmap> Natsuki_Res;
        List<Bitmap> Sayori_Res;
        List<Doki> Dokies;
        Random Rand;

        System.Windows.Forms.Timer rain = new System.Windows.Forms.Timer();
        bool isRaining = false;
        bool justMonika = false;
        int lowerRainInterval;
        int higherRainInterval;

        int rainDokiesSelected = 4;
        bool rainSayori = true;
        bool rainNatsuki = true;
        bool rainYuri = true;
        bool rainMonika = true;

        int rainSizeCount = 1;
        bool rainSmall = true;
        bool rainMedium = false;
        bool rainLarge = false;

        int rainFreq = 7;
        int rainAmount = 1;

        public DokiManager()
        {
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

            this.bSpawn.Click += spawn_Click;

            this.bRain.Click += rain_Click;
            rain.Tick += new EventHandler(rain_Tick);
            lowerRainInterval = (16 - rainFreq) * 70;
            higherRainInterval = (16 - rainFreq) * 100;
            rain.Interval = Rand.Next(lowerRainInterval, higherRainInterval + 1);

            About about = new About();
            this.bAbout.Click += (ss, ee) =>
            {
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

            this.bApply.Click += (ss, ee) =>
            {
                applySettings();
            };

            this.bReset.Click += (ss, ee) =>
            {
                resetSettings();
                applySettings();
            };

            this.bMonika.Click += (ss, ee) =>
            {
                applyJustMonika();
            };

            addDoki(Who.wSayori, (int)DokiSize.Medium, "Medium Sayori");
            addDoki(Who.wNatsuki, (int)DokiSize.Medium, "Medium Natsuki");
            addDoki(Who.wYuri, (int)DokiSize.Medium, "Medium Yuri");
            addDoki(Who.wMonika, (int)DokiSize.Medium, "Medium Monika");
        }

        //Begins Just Monika
        private void applyJustMonika()
        {
            justMonika = true;
            this.bMonika.Enabled = false;
            this.bMonika.Visible = false;

            rain.Enabled = false;
            isRaining = false;
            this.bRain.Text = "Start Rain";

            this.bKillAll.Enabled = false;

            this.bSpawn.Text = "Monika";
            this.rSayori.Text = "Monika";
            this.cSayori.Text = "Monika";
            this.rNatsuki.Text = "Monika";
            this.cNatsuki.Text = "Monika";
            this.rYuri.Text = "Monika";
            this.cYuri.Text = "Monika";

            removeAll();
            addDoki(Who.wMonika, (int)DokiSize.Medium, "Just Monika");
        }

        //Restes settings to default and applys them
        private void resetSettings()
        {
            this.cSayori.Checked = true;
            this.cSayori.Enabled = true;
            this.cNatsuki.Checked = true;
            this.cNatsuki.Enabled = true;
            this.cYuri.Checked = true;
            this.cYuri.Enabled = true;
            this.cMonika.Checked = true;
            this.cMonika.Enabled = true;

            this.cSmall.Checked = true;
            this.cSmall.Enabled = false;
            this.cMedium.Checked = false;
            this.cMedium.Enabled = true;
            this.cLarge.Checked = false;
            this.cLarge.Enabled = true;

            this.tFreq.Value = 1;
            this.tAmount.Value = 1;
        }

        //Apply settings based on the controlls in the settings panel
        private void applySettings()
        {
            int dokiTotal = 0;
            rainSayori = this.cSayori.Checked;
            if (rainSayori) dokiTotal++;
            rainNatsuki = this.cNatsuki.Checked;
            if (rainNatsuki) dokiTotal++;
            rainYuri = this.cYuri.Checked;
            if (rainYuri) dokiTotal++;
            rainMonika = this.cMonika.Checked;
            if (rainMonika) dokiTotal++;
            rainDokiesSelected = dokiTotal;

            int sizeTotal = 0;
            rainSmall = this.cSmall.Checked;
            if (rainSmall) sizeTotal++;
            rainMedium = this.cMedium.Checked;
            if (rainMedium) sizeTotal++;
            rainLarge = this.cLarge.Checked;
            if (rainLarge) sizeTotal++;
            rainSizeCount = sizeTotal;

            rainFreq = (int)this.nFreq.Value;
            rainAmount = (int)this.nAmount.Value;
            lowerRainInterval = (16 - rainFreq) * 70;
            higherRainInterval = (16 - rainFreq) * 100;
        }

        //Initalize checkbox logic
        //If all group checkboxes are unchecked, main is disabled
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

        //Removes all dokies
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

        //Adds the kill button and name to the alive list
        private void addDokiControlls(Doki doki, string tText = "")
        {
            Label t = new Label();
            if(string.IsNullOrEmpty(tText))
            { 
                t.Text = getText();
            }
            else
            {
                t.Text = tText;
            }

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
            if (justMonika) b.Enabled = false;
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

            this.fpAlive.Controls.Add(p);
        }

        //Adds a doki based on current radio button settings
        private void addDoki()
        {
            getSize();
            Doki doki = GetDoki();
            addDokiControlls(doki);
        }

        //Adds a doki based on manual settings
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

        //Event handler for the start rain button
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

        //Event handler for every time the rain timer ticks
        private void rain_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < rainAmount; i++)
            {
                int nextInt = Rand.Next(0, rainDokiesSelected);
                int nextSizeInt = Rand.Next(0, rainSizeCount);
                if (!justMonika)
                {
                    if (nextInt == 0 && !rainSayori) nextInt++;
                    if (nextInt == 1 && !rainNatsuki) nextInt++;
                    if (nextInt == 2 && !rainYuri) nextInt++;
                }
                else
                {
                    nextInt = (int)Who.wMonika;
                }
                if (nextSizeInt == 0 && !rainLarge) nextSizeInt++;
                if (nextSizeInt == 1 && !rainMedium) nextSizeInt++;

                Who next = (Who)nextInt;
                DokiSize nextSize = (DokiSize)nextSizeInt;
                Doki doki = null;
                switch (next)
                {
                    case Who.wSayori:
                        doki = GetSayori((int)nextSize, true);
                        break;
                    case Who.wNatsuki:
                        doki = GetNatsuki((int)nextSize, true);
                        break;
                    case Who.wYuri:
                        doki = GetYuri((int)nextSize, true);
                        break;
                    case Who.wMonika:
                        doki = GetMonika((int)nextSize, true);
                        break;
                }
                doki.Location = new Point(Rand.Next(0, doki.rWall), -doki.Height - 5);
                doki.Show();
            }
            rain.Interval = Rand.Next(lowerRainInterval, higherRainInterval + 1);
        }

        //Event handler for the spaawn button
        private void spawn_Click(object sender, EventArgs e)
        {
            if(!justMonika) addDoki();
            if(justMonika) addDoki(Who.wMonika, getSize(), "Just Monika");
        }

        //Loads all the images from the resource file for use in the dokies
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

        //Returns a doki based on radio buttom settings
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

        //Gets a Sayori doki
        private Doki GetSayori(int size, bool isRain = false)
        {
            return new Doki(Sayori_Res[0 + size * 3], Sayori_Res[1 + size * 3], Sayori_Res[2 + size * 3], (DokiSize)size, Who.wSayori, isRain);
        }

        //Gets a Natsuki doki
        private Doki GetNatsuki(int size, bool isRain = false)
        {
            return new Doki(Natsuki_Res[0 + size * 3], Natsuki_Res[1 + size * 3], Natsuki_Res[2 + size * 3], (DokiSize)size, Who.wNatsuki, isRain);
        }

        //Gets a Yuri doki
        private Doki GetYuri(int size, bool isRain = false)
        {
            return new Doki(Yuri_Res[0 + size * 3], Yuri_Res[1 + size * 3], Yuri_Res[2 + size * 3], (DokiSize)size, Who.wYuri, isRain);
        }

        //Gets a Monika doki
        private Doki GetMonika(int size, bool isRain = false)
        {
            return new Doki(Monika_Res[0 + size * 3], Monika_Res[1 + size * 3], Monika_Res[2 + size * 3], (DokiSize)size, Who.wMonika, isRain);
        }

        //Returns a size int based on radio button settings
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

        //Sets the name text based on radio button settings
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
