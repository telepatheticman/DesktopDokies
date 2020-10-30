using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopDokies
{
    static class Program
    {

        static Doki monika;
        static System.Timers.Timer Fall = new System.Timers.Timer();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            monika = new Doki();
            Application.Run(monika);

            Fall.Elapsed += Fall_Elapsed;
            Fall.Interval = 50;
            Fall.Start();

        }

        private static void Fall_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            while (monika.Location.Y < monika.floor)
            {
                monika.Location = new Point(monika.Location.X, monika.Location.Y + 3);
                monika.Update();
            }
            if (monika.Location.Y >= monika.floor)
            {
                monika.Location = new Point(monika.Location.X, monika.floor);
                monika.Update();
            }
            monika.falling = false;
            Fall.Enabled = false;
        }
    }
}
