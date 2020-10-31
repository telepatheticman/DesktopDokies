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
        int size;
        public DokiManager()
        {
            InitializeComponent();

            loadRes();
            //testList = new List<Doki>();
            //testList.Add(new Doki());
            //testList[0].Show();
            //Thread.Sleep(5000);
            //testList[0].Close();
            this.bSpawn.Click += spawn_Click;
        }


        private void spawn_Click(object sender, EventArgs e)
        {
            Doki doki;//= new Doki();
            Label t = new Label();
            t.Text = getText();
            doki = GetDoki();
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
                doki.Close();
                doki.Dispose();
                this.fpAlive.Controls.Remove(p);
                p.Dispose();
                t.Dispose();
                b.Dispose();
            };

            this.fpAlive.Controls.Add(p);
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
                return new Doki(Sayori_Res[0 + size*3], Sayori_Res[1 + size*3], Sayori_Res[2 + size*3], size);
            }
            else if (this.rNatsuki.Checked)
            {
                return new Doki(Natsuki_Res[0 + size*3], Natsuki_Res[1 + size*3], Natsuki_Res[2 + size*3], size);
            }
            else if (this.rYuri.Checked)
            {
                return new Doki(Yuri_Res[0 + size*3], Yuri_Res[1 + size*3], Yuri_Res[2 + size*3], size);
            }
            else
            {
                return new Doki(Monika_Res[0 + size*3], Monika_Res[1 + size*3], Monika_Res[2 + size*3], size);
            }
        }

        private String getText()
        {
            String text = "";

            if(this.rLarge.Checked)
            {
                text += "Large ";
                size = 0;
            }
            else if (this.rMedium.Checked)
            {
                text += "Medium ";
                size = 1;
            }
            else
            {
                text += "Small ";
                size = 2;
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
