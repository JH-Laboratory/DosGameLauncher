namespace DosGameLauncher
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btndiscord = new System.Windows.Forms.PictureBox();
            this.btnForums = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLauncherVer = new System.Windows.Forms.Label();
            this.jhlLogo = new System.Windows.Forms.PictureBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.glistHunterFaves = new System.Windows.Forms.ComboBox();
            this.lbl_gamelist1 = new System.Windows.Forms.Label();
            this.glistOther = new System.Windows.Forms.ComboBox();
            this.lbl_gamelist2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jhlLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(827, 498);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(118, 34);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.Location = new System.Drawing.Point(861, 12);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(39, 38);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMini.TabIndex = 1;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(906, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 38);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btndiscord
            // 
            this.btndiscord.BackColor = System.Drawing.Color.Transparent;
            this.btndiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndiscord.Image = ((System.Drawing.Image)(resources.GetObject("btndiscord.Image")));
            this.btndiscord.Location = new System.Drawing.Point(162, 498);
            this.btndiscord.Name = "btndiscord";
            this.btndiscord.Size = new System.Drawing.Size(33, 32);
            this.btndiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btndiscord.TabIndex = 4;
            this.btndiscord.TabStop = false;
            this.btndiscord.Click += new System.EventHandler(this.btndiscord_Click);
            // 
            // btnForums
            // 
            this.btnForums.BackColor = System.Drawing.Color.Transparent;
            this.btnForums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForums.Image = ((System.Drawing.Image)(resources.GetObject("btnForums.Image")));
            this.btnForums.Location = new System.Drawing.Point(15, 498);
            this.btnForums.Name = "btnForums";
            this.btnForums.Size = new System.Drawing.Size(118, 34);
            this.btnForums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnForums.TabIndex = 14;
            this.btnForums.TabStop = false;
            this.btnForums.Click += new System.EventHandler(this.btnForums_Click);
            // 
            // lblLauncherVer
            // 
            this.lblLauncherVer.AutoSize = true;
            this.lblLauncherVer.BackColor = System.Drawing.Color.Transparent;
            this.lblLauncherVer.Font = new System.Drawing.Font("Glass Gauge", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLauncherVer.ForeColor = System.Drawing.Color.Black;
            this.lblLauncherVer.Location = new System.Drawing.Point(665, 505);
            this.lblLauncherVer.Name = "lblLauncherVer";
            this.lblLauncherVer.Size = new System.Drawing.Size(156, 25);
            this.lblLauncherVer.TabIndex = 17;
            this.lblLauncherVer.Text = "Launcher v.0.0.0";
            // 
            // jhlLogo
            // 
            this.jhlLogo.BackColor = System.Drawing.Color.Transparent;
            this.jhlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jhlLogo.BackgroundImage")));
            this.jhlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.jhlLogo.Location = new System.Drawing.Point(-19, 12);
            this.jhlLogo.Name = "jhlLogo";
            this.jhlLogo.Size = new System.Drawing.Size(100, 50);
            this.jhlLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.jhlLogo.TabIndex = 18;
            this.jhlLogo.TabStop = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Glass Gauge", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(12, 466);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(183, 20);
            this.lblCopyright.TabIndex = 19;
            this.lblCopyright.Text = "Copyright JHLabs, 2021";
            // 
            // glistHunterFaves
            // 
            this.glistHunterFaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(158)))), ((int)(((byte)(12)))));
            this.glistHunterFaves.Font = new System.Drawing.Font("Glass Gauge", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glistHunterFaves.FormattingEnabled = true;
            this.glistHunterFaves.Items.AddRange(new object[] {
            "⠀",
            "Wolfenstein3D",
            "DOOM",
            "Transport Tycoon Deluxe",
            "SimCity",
            "Oregon Trail",
            "The Elder Scrolls: Arena",
            "Civilization",
            "Tetris",
            "Quake",
            "C&C Red Alert"});
            this.glistHunterFaves.Location = new System.Drawing.Point(47, 240);
            this.glistHunterFaves.Name = "glistHunterFaves";
            this.glistHunterFaves.Size = new System.Drawing.Size(157, 24);
            this.glistHunterFaves.TabIndex = 20;
            // 
            // lbl_gamelist1
            // 
            this.lbl_gamelist1.AutoSize = true;
            this.lbl_gamelist1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gamelist1.Font = new System.Drawing.Font("Glass Gauge", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamelist1.Location = new System.Drawing.Point(43, 199);
            this.lbl_gamelist1.Name = "lbl_gamelist1";
            this.lbl_gamelist1.Size = new System.Drawing.Size(161, 24);
            this.lbl_gamelist1.TabIndex = 21;
            this.lbl_gamelist1.Text = "Hunter\'s Favorites";
            // 
            // glistOther
            // 
            this.glistOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(158)))), ((int)(((byte)(12)))));
            this.glistOther.Font = new System.Drawing.Font("Glass Gauge", 9.75F, System.Drawing.FontStyle.Bold);
            this.glistOther.FormattingEnabled = true;
            this.glistOther.Items.AddRange(new object[] {
            "⠀",
            "Battlechess",
            "The Incredible Machine",
            "SimFarm",
            "SimAnt",
            "Warcraft",
            "Oregon Trail: Deluxe",
            "Daggerfall"});
            this.glistOther.Location = new System.Drawing.Point(741, 240);
            this.glistOther.Name = "glistOther";
            this.glistOther.Size = new System.Drawing.Size(187, 24);
            this.glistOther.TabIndex = 22;
            // 
            // lbl_gamelist2
            // 
            this.lbl_gamelist2.AutoSize = true;
            this.lbl_gamelist2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gamelist2.Font = new System.Drawing.Font("Glass Gauge", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamelist2.Location = new System.Drawing.Point(737, 199);
            this.lbl_gamelist2.Name = "lbl_gamelist2";
            this.lbl_gamelist2.Size = new System.Drawing.Size(191, 24);
            this.lbl_gamelist2.TabIndex = 23;
            this.lbl_gamelist2.Text = "All the other goodies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 542);
            this.Controls.Add(this.lbl_gamelist2);
            this.Controls.Add(this.glistOther);
            this.Controls.Add(this.lbl_gamelist1);
            this.Controls.Add(this.glistHunterFaves);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.jhlLogo);
            this.Controls.Add(this.lblLauncherVer);
            this.Controls.Add(this.btnForums);
            this.Controls.Add(this.btndiscord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnPlay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOS Game Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jhlLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnPlay;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btndiscord;
        private System.Windows.Forms.PictureBox btnForums;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblLauncherVer;
        private System.Windows.Forms.PictureBox jhlLogo;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.ComboBox glistHunterFaves;
        private System.Windows.Forms.Label lbl_gamelist1;
        private System.Windows.Forms.ComboBox glistOther;
        private System.Windows.Forms.Label lbl_gamelist2;
    }
}

