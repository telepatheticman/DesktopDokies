namespace DesktopDokies
{
    partial class DokiManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DokiManager));
            this.gCharacter = new System.Windows.Forms.GroupBox();
            this.rNatsuki = new System.Windows.Forms.RadioButton();
            this.rYuri = new System.Windows.Forms.RadioButton();
            this.rMonika = new System.Windows.Forms.RadioButton();
            this.rSayori = new System.Windows.Forms.RadioButton();
            this.gSize = new System.Windows.Forms.GroupBox();
            this.rLarge = new System.Windows.Forms.RadioButton();
            this.rMedium = new System.Windows.Forms.RadioButton();
            this.rSmall = new System.Windows.Forms.RadioButton();
            this.bSpawn = new System.Windows.Forms.Button();
            this.gAlive = new System.Windows.Forms.GroupBox();
            this.fpAlive = new System.Windows.Forms.FlowLayoutPanel();
            this.bAbout = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.bClose = new System.Windows.Forms.Button();
            this.bRain = new System.Windows.Forms.Button();
            this.gCharacter.SuspendLayout();
            this.gSize.SuspendLayout();
            this.gAlive.SuspendLayout();
            this.SuspendLayout();
            // 
            // gCharacter
            // 
            this.gCharacter.Controls.Add(this.rNatsuki);
            this.gCharacter.Controls.Add(this.rYuri);
            this.gCharacter.Controls.Add(this.rMonika);
            this.gCharacter.Controls.Add(this.rSayori);
            this.gCharacter.Location = new System.Drawing.Point(16, 15);
            this.gCharacter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gCharacter.Name = "gCharacter";
            this.gCharacter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gCharacter.Size = new System.Drawing.Size(289, 126);
            this.gCharacter.TabIndex = 0;
            this.gCharacter.TabStop = false;
            this.gCharacter.Text = "Character";
            // 
            // rNatsuki
            // 
            this.rNatsuki.AutoSize = true;
            this.rNatsuki.Location = new System.Drawing.Point(180, 86);
            this.rNatsuki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rNatsuki.Name = "rNatsuki";
            this.rNatsuki.Size = new System.Drawing.Size(76, 21);
            this.rNatsuki.TabIndex = 3;
            this.rNatsuki.Text = "Natsuki";
            this.rNatsuki.UseVisualStyleBackColor = true;
            // 
            // rYuri
            // 
            this.rYuri.AutoSize = true;
            this.rYuri.Location = new System.Drawing.Point(27, 86);
            this.rYuri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rYuri.Name = "rYuri";
            this.rYuri.Size = new System.Drawing.Size(54, 21);
            this.rYuri.TabIndex = 2;
            this.rYuri.Text = "Yuri";
            this.rYuri.UseVisualStyleBackColor = true;
            // 
            // rMonika
            // 
            this.rMonika.AutoSize = true;
            this.rMonika.Location = new System.Drawing.Point(180, 25);
            this.rMonika.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rMonika.Name = "rMonika";
            this.rMonika.Size = new System.Drawing.Size(74, 21);
            this.rMonika.TabIndex = 1;
            this.rMonika.Text = "Monika";
            this.rMonika.UseVisualStyleBackColor = true;
            // 
            // rSayori
            // 
            this.rSayori.AutoSize = true;
            this.rSayori.Checked = true;
            this.rSayori.Location = new System.Drawing.Point(27, 23);
            this.rSayori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rSayori.Name = "rSayori";
            this.rSayori.Size = new System.Drawing.Size(69, 21);
            this.rSayori.TabIndex = 0;
            this.rSayori.TabStop = true;
            this.rSayori.Text = "Sayori";
            this.rSayori.UseVisualStyleBackColor = true;
            // 
            // gSize
            // 
            this.gSize.Controls.Add(this.rLarge);
            this.gSize.Controls.Add(this.rMedium);
            this.gSize.Controls.Add(this.rSmall);
            this.gSize.Location = new System.Drawing.Point(313, 15);
            this.gSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gSize.Name = "gSize";
            this.gSize.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gSize.Size = new System.Drawing.Size(304, 126);
            this.gSize.TabIndex = 1;
            this.gSize.TabStop = false;
            this.gSize.Text = "Size";
            // 
            // rLarge
            // 
            this.rLarge.AutoSize = true;
            this.rLarge.Location = new System.Drawing.Point(219, 53);
            this.rLarge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rLarge.Name = "rLarge";
            this.rLarge.Size = new System.Drawing.Size(66, 21);
            this.rLarge.TabIndex = 2;
            this.rLarge.Text = "Large";
            this.rLarge.UseVisualStyleBackColor = true;
            // 
            // rMedium
            // 
            this.rMedium.AutoSize = true;
            this.rMedium.Checked = true;
            this.rMedium.Location = new System.Drawing.Point(104, 53);
            this.rMedium.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rMedium.Name = "rMedium";
            this.rMedium.Size = new System.Drawing.Size(78, 21);
            this.rMedium.TabIndex = 1;
            this.rMedium.TabStop = true;
            this.rMedium.Text = "Medium";
            this.rMedium.UseVisualStyleBackColor = true;
            // 
            // rSmall
            // 
            this.rSmall.AutoSize = true;
            this.rSmall.Location = new System.Drawing.Point(9, 53);
            this.rSmall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rSmall.Name = "rSmall";
            this.rSmall.Size = new System.Drawing.Size(63, 21);
            this.rSmall.TabIndex = 0;
            this.rSmall.Text = "Small";
            this.rSmall.UseVisualStyleBackColor = true;
            // 
            // bSpawn
            // 
            this.bSpawn.Location = new System.Drawing.Point(735, 38);
            this.bSpawn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSpawn.Name = "bSpawn";
            this.bSpawn.Size = new System.Drawing.Size(107, 33);
            this.bSpawn.TabIndex = 2;
            this.bSpawn.Text = "Spawn";
            this.bSpawn.UseVisualStyleBackColor = true;
            // 
            // gAlive
            // 
            this.gAlive.Controls.Add(this.fpAlive);
            this.gAlive.Location = new System.Drawing.Point(16, 197);
            this.gAlive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gAlive.Name = "gAlive";
            this.gAlive.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gAlive.Size = new System.Drawing.Size(601, 292);
            this.gAlive.TabIndex = 3;
            this.gAlive.TabStop = false;
            this.gAlive.Text = "Alive";
            // 
            // fpAlive
            // 
            this.fpAlive.AutoScroll = true;
            this.fpAlive.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpAlive.Location = new System.Drawing.Point(9, 25);
            this.fpAlive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fpAlive.Name = "fpAlive";
            this.fpAlive.Size = new System.Drawing.Size(584, 260);
            this.fpAlive.TabIndex = 0;
            this.fpAlive.WrapContents = false;
            // 
            // bAbout
            // 
            this.bAbout.Location = new System.Drawing.Point(800, 505);
            this.bAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAbout.Name = "bAbout";
            this.bAbout.Size = new System.Drawing.Size(127, 34);
            this.bAbout.TabIndex = 4;
            this.bAbout.Text = "About";
            this.bAbout.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "We are still running in the background. Use End Desktop Dokies to kill us for goo" +
    "d.";
            this.notifyIcon1.BalloonTipTitle = "Still Running";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Desktop Dokies";
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(624, 505);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(168, 34);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "End Desktop Dokies";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // bRain
            // 
            this.bRain.Location = new System.Drawing.Point(735, 89);
            this.bRain.Margin = new System.Windows.Forms.Padding(4);
            this.bRain.Name = "bRain";
            this.bRain.Size = new System.Drawing.Size(107, 33);
            this.bRain.TabIndex = 6;
            this.bRain.Text = "Start Rain";
            this.bRain.UseVisualStyleBackColor = true;
            // 
            // DokiManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 553);
            this.Controls.Add(this.bRain);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bAbout);
            this.Controls.Add(this.gAlive);
            this.Controls.Add(this.bSpawn);
            this.Controls.Add(this.gSize);
            this.Controls.Add(this.gCharacter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DokiManager";
            this.Text = "Doki Manager";
            this.gCharacter.ResumeLayout(false);
            this.gCharacter.PerformLayout();
            this.gSize.ResumeLayout(false);
            this.gSize.PerformLayout();
            this.gAlive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gCharacter;
        private System.Windows.Forms.RadioButton rNatsuki;
        private System.Windows.Forms.RadioButton rYuri;
        private System.Windows.Forms.RadioButton rMonika;
        private System.Windows.Forms.RadioButton rSayori;
        private System.Windows.Forms.GroupBox gSize;
        private System.Windows.Forms.Button bSpawn;
        private System.Windows.Forms.RadioButton rLarge;
        private System.Windows.Forms.RadioButton rMedium;
        private System.Windows.Forms.RadioButton rSmall;
        private System.Windows.Forms.GroupBox gAlive;
        private System.Windows.Forms.FlowLayoutPanel fpAlive;
        private System.Windows.Forms.Button bAbout;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bRain;
    }
}

