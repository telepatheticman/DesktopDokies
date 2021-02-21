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
            this.gSettings = new System.Windows.Forms.GroupBox();
            this.fpSettings = new System.Windows.Forms.FlowLayoutPanel();
            this.gDoki = new System.Windows.Forms.GroupBox();
            this.cNatsuki = new System.Windows.Forms.CheckBox();
            this.cYuri = new System.Windows.Forms.CheckBox();
            this.cMonika = new System.Windows.Forms.CheckBox();
            this.cSayori = new System.Windows.Forms.CheckBox();
            this.gDokiSize = new System.Windows.Forms.GroupBox();
            this.cLarge = new System.Windows.Forms.CheckBox();
            this.cMedium = new System.Windows.Forms.CheckBox();
            this.cSmall = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nFreq = new System.Windows.Forms.NumericUpDown();
            this.tFreq = new System.Windows.Forms.TrackBar();
            this.gAmount = new System.Windows.Forms.GroupBox();
            this.nAmount = new System.Windows.Forms.NumericUpDown();
            this.tAmount = new System.Windows.Forms.TrackBar();
            this.fpSettingButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.bApply = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.bMonika = new System.Windows.Forms.Button();
            this.bKillAll = new System.Windows.Forms.Button();
            this.gCharacter.SuspendLayout();
            this.gSize.SuspendLayout();
            this.gAlive.SuspendLayout();
            this.gSettings.SuspendLayout();
            this.fpSettings.SuspendLayout();
            this.gDoki.SuspendLayout();
            this.gDokiSize.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFreq)).BeginInit();
            this.gAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAmount)).BeginInit();
            this.fpSettingButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gCharacter
            // 
            this.gCharacter.Controls.Add(this.rNatsuki);
            this.gCharacter.Controls.Add(this.rYuri);
            this.gCharacter.Controls.Add(this.rMonika);
            this.gCharacter.Controls.Add(this.rSayori);
            this.gCharacter.Location = new System.Drawing.Point(12, 12);
            this.gCharacter.Name = "gCharacter";
            this.gCharacter.Size = new System.Drawing.Size(217, 102);
            this.gCharacter.TabIndex = 0;
            this.gCharacter.TabStop = false;
            this.gCharacter.Text = "Character";
            // 
            // rNatsuki
            // 
            this.rNatsuki.AutoSize = true;
            this.rNatsuki.Location = new System.Drawing.Point(135, 70);
            this.rNatsuki.Name = "rNatsuki";
            this.rNatsuki.Size = new System.Drawing.Size(61, 17);
            this.rNatsuki.TabIndex = 3;
            this.rNatsuki.Text = "Natsuki";
            this.rNatsuki.UseVisualStyleBackColor = true;
            // 
            // rYuri
            // 
            this.rYuri.AutoSize = true;
            this.rYuri.Location = new System.Drawing.Point(20, 70);
            this.rYuri.Name = "rYuri";
            this.rYuri.Size = new System.Drawing.Size(43, 17);
            this.rYuri.TabIndex = 2;
            this.rYuri.Text = "Yuri";
            this.rYuri.UseVisualStyleBackColor = true;
            // 
            // rMonika
            // 
            this.rMonika.AutoSize = true;
            this.rMonika.Location = new System.Drawing.Point(135, 20);
            this.rMonika.Name = "rMonika";
            this.rMonika.Size = new System.Drawing.Size(60, 17);
            this.rMonika.TabIndex = 1;
            this.rMonika.Text = "Monika";
            this.rMonika.UseVisualStyleBackColor = true;
            // 
            // rSayori
            // 
            this.rSayori.AutoSize = true;
            this.rSayori.Checked = true;
            this.rSayori.Location = new System.Drawing.Point(20, 19);
            this.rSayori.Name = "rSayori";
            this.rSayori.Size = new System.Drawing.Size(54, 17);
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
            this.gSize.Location = new System.Drawing.Point(235, 12);
            this.gSize.Name = "gSize";
            this.gSize.Size = new System.Drawing.Size(228, 102);
            this.gSize.TabIndex = 1;
            this.gSize.TabStop = false;
            this.gSize.Text = "Size";
            // 
            // rLarge
            // 
            this.rLarge.AutoSize = true;
            this.rLarge.Location = new System.Drawing.Point(164, 43);
            this.rLarge.Name = "rLarge";
            this.rLarge.Size = new System.Drawing.Size(52, 17);
            this.rLarge.TabIndex = 2;
            this.rLarge.Text = "Large";
            this.rLarge.UseVisualStyleBackColor = true;
            // 
            // rMedium
            // 
            this.rMedium.AutoSize = true;
            this.rMedium.Checked = true;
            this.rMedium.Location = new System.Drawing.Point(78, 43);
            this.rMedium.Name = "rMedium";
            this.rMedium.Size = new System.Drawing.Size(62, 17);
            this.rMedium.TabIndex = 1;
            this.rMedium.TabStop = true;
            this.rMedium.Text = "Medium";
            this.rMedium.UseVisualStyleBackColor = true;
            // 
            // rSmall
            // 
            this.rSmall.AutoSize = true;
            this.rSmall.Location = new System.Drawing.Point(7, 43);
            this.rSmall.Name = "rSmall";
            this.rSmall.Size = new System.Drawing.Size(50, 17);
            this.rSmall.TabIndex = 0;
            this.rSmall.Text = "Small";
            this.rSmall.UseVisualStyleBackColor = true;
            // 
            // bSpawn
            // 
            this.bSpawn.Location = new System.Drawing.Point(551, 12);
            this.bSpawn.Name = "bSpawn";
            this.bSpawn.Size = new System.Drawing.Size(80, 27);
            this.bSpawn.TabIndex = 2;
            this.bSpawn.Text = "Spawn";
            this.bSpawn.UseVisualStyleBackColor = true;
            // 
            // gAlive
            // 
            this.gAlive.Controls.Add(this.fpAlive);
            this.gAlive.Location = new System.Drawing.Point(12, 160);
            this.gAlive.Name = "gAlive";
            this.gAlive.Size = new System.Drawing.Size(451, 237);
            this.gAlive.TabIndex = 3;
            this.gAlive.TabStop = false;
            this.gAlive.Text = "Alive";
            // 
            // fpAlive
            // 
            this.fpAlive.AutoScroll = true;
            this.fpAlive.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpAlive.Location = new System.Drawing.Point(7, 20);
            this.fpAlive.Name = "fpAlive";
            this.fpAlive.Size = new System.Drawing.Size(438, 211);
            this.fpAlive.TabIndex = 0;
            this.fpAlive.WrapContents = false;
            // 
            // bAbout
            // 
            this.bAbout.Location = new System.Drawing.Point(600, 410);
            this.bAbout.Name = "bAbout";
            this.bAbout.Size = new System.Drawing.Size(95, 28);
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
            this.bClose.Location = new System.Drawing.Point(468, 410);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(126, 28);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "End Desktop Dokies";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // bRain
            // 
            this.bRain.Location = new System.Drawing.Point(551, 50);
            this.bRain.Name = "bRain";
            this.bRain.Size = new System.Drawing.Size(80, 27);
            this.bRain.TabIndex = 6;
            this.bRain.Text = "Start Rain";
            this.bRain.UseVisualStyleBackColor = true;
            // 
            // gSettings
            // 
            this.gSettings.Controls.Add(this.fpSettings);
            this.gSettings.Location = new System.Drawing.Point(494, 160);
            this.gSettings.Name = "gSettings";
            this.gSettings.Size = new System.Drawing.Size(200, 237);
            this.gSettings.TabIndex = 7;
            this.gSettings.TabStop = false;
            this.gSettings.Text = "settings";
            // 
            // fpSettings
            // 
            this.fpSettings.AutoScroll = true;
            this.fpSettings.Controls.Add(this.gDoki);
            this.fpSettings.Controls.Add(this.gDokiSize);
            this.fpSettings.Controls.Add(this.groupBox1);
            this.fpSettings.Controls.Add(this.gAmount);
            this.fpSettings.Controls.Add(this.fpSettingButtons);
            this.fpSettings.Location = new System.Drawing.Point(6, 20);
            this.fpSettings.Name = "fpSettings";
            this.fpSettings.Size = new System.Drawing.Size(188, 211);
            this.fpSettings.TabIndex = 0;
            // 
            // gDoki
            // 
            this.gDoki.Controls.Add(this.cNatsuki);
            this.gDoki.Controls.Add(this.cYuri);
            this.gDoki.Controls.Add(this.cMonika);
            this.gDoki.Controls.Add(this.cSayori);
            this.gDoki.Location = new System.Drawing.Point(3, 3);
            this.gDoki.Name = "gDoki";
            this.gDoki.Size = new System.Drawing.Size(163, 71);
            this.gDoki.TabIndex = 0;
            this.gDoki.TabStop = false;
            this.gDoki.Text = "Dokis To Rain";
            // 
            // cNatsuki
            // 
            this.cNatsuki.AutoSize = true;
            this.cNatsuki.Checked = true;
            this.cNatsuki.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cNatsuki.Location = new System.Drawing.Point(95, 48);
            this.cNatsuki.Name = "cNatsuki";
            this.cNatsuki.Size = new System.Drawing.Size(62, 17);
            this.cNatsuki.TabIndex = 3;
            this.cNatsuki.Text = "Natsuki";
            this.cNatsuki.UseVisualStyleBackColor = true;
            // 
            // cYuri
            // 
            this.cYuri.AutoSize = true;
            this.cYuri.Checked = true;
            this.cYuri.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cYuri.Location = new System.Drawing.Point(7, 48);
            this.cYuri.Name = "cYuri";
            this.cYuri.Size = new System.Drawing.Size(44, 17);
            this.cYuri.TabIndex = 2;
            this.cYuri.Text = "Yuri";
            this.cYuri.UseVisualStyleBackColor = true;
            // 
            // cMonika
            // 
            this.cMonika.AutoSize = true;
            this.cMonika.Checked = true;
            this.cMonika.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cMonika.Location = new System.Drawing.Point(96, 20);
            this.cMonika.Name = "cMonika";
            this.cMonika.Size = new System.Drawing.Size(61, 17);
            this.cMonika.TabIndex = 1;
            this.cMonika.Text = "Monika";
            this.cMonika.UseVisualStyleBackColor = true;
            // 
            // cSayori
            // 
            this.cSayori.AutoSize = true;
            this.cSayori.Checked = true;
            this.cSayori.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cSayori.Location = new System.Drawing.Point(7, 20);
            this.cSayori.Name = "cSayori";
            this.cSayori.Size = new System.Drawing.Size(55, 17);
            this.cSayori.TabIndex = 0;
            this.cSayori.Text = "Sayori";
            this.cSayori.UseVisualStyleBackColor = true;
            // 
            // gDokiSize
            // 
            this.gDokiSize.Controls.Add(this.cLarge);
            this.gDokiSize.Controls.Add(this.cMedium);
            this.gDokiSize.Controls.Add(this.cSmall);
            this.gDokiSize.Location = new System.Drawing.Point(3, 80);
            this.gDokiSize.Name = "gDokiSize";
            this.gDokiSize.Size = new System.Drawing.Size(163, 65);
            this.gDokiSize.TabIndex = 1;
            this.gDokiSize.TabStop = false;
            this.gDokiSize.Text = "Doki Size To Rain";
            // 
            // cLarge
            // 
            this.cLarge.AutoSize = true;
            this.cLarge.Location = new System.Drawing.Point(48, 43);
            this.cLarge.Name = "cLarge";
            this.cLarge.Size = new System.Drawing.Size(53, 17);
            this.cLarge.TabIndex = 2;
            this.cLarge.Text = "Large";
            this.cLarge.UseVisualStyleBackColor = true;
            // 
            // cMedium
            // 
            this.cMedium.AutoSize = true;
            this.cMedium.Location = new System.Drawing.Point(94, 20);
            this.cMedium.Name = "cMedium";
            this.cMedium.Size = new System.Drawing.Size(63, 17);
            this.cMedium.TabIndex = 1;
            this.cMedium.Text = "Medium";
            this.cMedium.UseVisualStyleBackColor = true;
            // 
            // cSmall
            // 
            this.cSmall.AutoSize = true;
            this.cSmall.Checked = true;
            this.cSmall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cSmall.Enabled = false;
            this.cSmall.Location = new System.Drawing.Point(7, 20);
            this.cSmall.Name = "cSmall";
            this.cSmall.Size = new System.Drawing.Size(51, 17);
            this.cSmall.TabIndex = 0;
            this.cSmall.Text = "Small";
            this.cSmall.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nFreq);
            this.groupBox1.Controls.Add(this.tFreq);
            this.groupBox1.Location = new System.Drawing.Point(3, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rain Frequency";
            // 
            // nFreq
            // 
            this.nFreq.Location = new System.Drawing.Point(116, 19);
            this.nFreq.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFreq.Name = "nFreq";
            this.nFreq.Size = new System.Drawing.Size(40, 20);
            this.nFreq.TabIndex = 1;
            this.nFreq.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // tFreq
            // 
            this.tFreq.Location = new System.Drawing.Point(6, 19);
            this.tFreq.Maximum = 15;
            this.tFreq.Minimum = 1;
            this.tFreq.Name = "tFreq";
            this.tFreq.Size = new System.Drawing.Size(104, 45);
            this.tFreq.TabIndex = 0;
            this.tFreq.Value = 7;
            // 
            // gAmount
            // 
            this.gAmount.Controls.Add(this.nAmount);
            this.gAmount.Controls.Add(this.tAmount);
            this.gAmount.Location = new System.Drawing.Point(3, 223);
            this.gAmount.Name = "gAmount";
            this.gAmount.Size = new System.Drawing.Size(163, 66);
            this.gAmount.TabIndex = 3;
            this.gAmount.TabStop = false;
            this.gAmount.Text = "Rain Amount";
            // 
            // nAmount
            // 
            this.nAmount.Location = new System.Drawing.Point(116, 19);
            this.nAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAmount.Name = "nAmount";
            this.nAmount.Size = new System.Drawing.Size(40, 20);
            this.nAmount.TabIndex = 2;
            this.nAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tAmount
            // 
            this.tAmount.Location = new System.Drawing.Point(7, 19);
            this.tAmount.Minimum = 1;
            this.tAmount.Name = "tAmount";
            this.tAmount.Size = new System.Drawing.Size(104, 45);
            this.tAmount.TabIndex = 1;
            this.tAmount.Value = 1;
            // 
            // fpSettingButtons
            // 
            this.fpSettingButtons.Controls.Add(this.bApply);
            this.fpSettingButtons.Controls.Add(this.bReset);
            this.fpSettingButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fpSettingButtons.Location = new System.Drawing.Point(3, 295);
            this.fpSettingButtons.Name = "fpSettingButtons";
            this.fpSettingButtons.Size = new System.Drawing.Size(163, 30);
            this.fpSettingButtons.TabIndex = 4;
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(85, 3);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 23);
            this.bApply.TabIndex = 0;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(4, 3);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 1;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            // 
            // bMonika
            // 
            this.bMonika.Location = new System.Drawing.Point(600, 457);
            this.bMonika.Name = "bMonika";
            this.bMonika.Size = new System.Drawing.Size(94, 28);
            this.bMonika.TabIndex = 8;
            this.bMonika.Text = "Just Monika";
            this.bMonika.UseVisualStyleBackColor = true;
            // 
            // bKillAll
            // 
            this.bKillAll.Location = new System.Drawing.Point(551, 87);
            this.bKillAll.Name = "bKillAll";
            this.bKillAll.Size = new System.Drawing.Size(80, 27);
            this.bKillAll.TabIndex = 9;
            this.bKillAll.Text = "Kill All";
            this.bKillAll.UseVisualStyleBackColor = true;
            // 
            // DokiManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 446);
            this.Controls.Add(this.bKillAll);
            this.Controls.Add(this.bMonika);
            this.Controls.Add(this.gSettings);
            this.Controls.Add(this.bRain);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bAbout);
            this.Controls.Add(this.gAlive);
            this.Controls.Add(this.bSpawn);
            this.Controls.Add(this.gSize);
            this.Controls.Add(this.gCharacter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(722, 530);
            this.MinimumSize = new System.Drawing.Size(722, 485);
            this.Name = "DokiManager";
            this.Text = "Doki Manager";
            this.gCharacter.ResumeLayout(false);
            this.gCharacter.PerformLayout();
            this.gSize.ResumeLayout(false);
            this.gSize.PerformLayout();
            this.gAlive.ResumeLayout(false);
            this.gSettings.ResumeLayout(false);
            this.fpSettings.ResumeLayout(false);
            this.gDoki.ResumeLayout(false);
            this.gDoki.PerformLayout();
            this.gDokiSize.ResumeLayout(false);
            this.gDokiSize.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFreq)).EndInit();
            this.gAmount.ResumeLayout(false);
            this.gAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAmount)).EndInit();
            this.fpSettingButtons.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox gSettings;
        private System.Windows.Forms.FlowLayoutPanel fpSettings;
        private System.Windows.Forms.GroupBox gDoki;
        private System.Windows.Forms.CheckBox cNatsuki;
        private System.Windows.Forms.CheckBox cYuri;
        private System.Windows.Forms.CheckBox cMonika;
        private System.Windows.Forms.CheckBox cSayori;
        private System.Windows.Forms.GroupBox gDokiSize;
        private System.Windows.Forms.CheckBox cLarge;
        private System.Windows.Forms.CheckBox cMedium;
        private System.Windows.Forms.CheckBox cSmall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nFreq;
        private System.Windows.Forms.TrackBar tFreq;
        private System.Windows.Forms.GroupBox gAmount;
        private System.Windows.Forms.NumericUpDown nAmount;
        private System.Windows.Forms.TrackBar tAmount;
        private System.Windows.Forms.Button bMonika;
        private System.Windows.Forms.FlowLayoutPanel fpSettingButtons;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bKillAll;
    }
}

