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
            this.bSpawn.Location = new System.Drawing.Point(551, 23);
            this.bSpawn.Name = "bSpawn";
            this.bSpawn.Size = new System.Drawing.Size(80, 80);
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
            // DokiManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.bAbout);
            this.Controls.Add(this.gAlive);
            this.Controls.Add(this.bSpawn);
            this.Controls.Add(this.gSize);
            this.Controls.Add(this.gCharacter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

