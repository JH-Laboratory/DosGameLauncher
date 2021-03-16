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
            this.lblPlay = new System.Windows.Forms.PictureBox();
            this.lblMini = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.PictureBox();
            this.btndiscord = new System.Windows.Forms.PictureBox();
            this.btnForums = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblLauncherVer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndiscord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForums)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlay
            // 
            this.lblPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlay.Image = ((System.Drawing.Image)(resources.GetObject("lblPlay.Image")));
            this.lblPlay.Location = new System.Drawing.Point(827, 498);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(118, 34);
            this.lblPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblPlay.TabIndex = 0;
            this.lblPlay.TabStop = false;
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // lblMini
            // 
            this.lblMini.BackColor = System.Drawing.Color.Transparent;
            this.lblMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMini.Image = ((System.Drawing.Image)(resources.GetObject("lblMini.Image")));
            this.lblMini.Location = new System.Drawing.Point(861, 12);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(39, 38);
            this.lblMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblMini.TabIndex = 1;
            this.lblMini.TabStop = false;
            this.lblMini.Click += new System.EventHandler(this.lblMini_Click);
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Image = ((System.Drawing.Image)(resources.GetObject("lblClose.Image")));
            this.lblClose.Location = new System.Drawing.Point(906, 12);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(39, 38);
            this.lblClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lblClose.TabIndex = 2;
            this.lblClose.TabStop = false;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // btndiscord
            // 
            this.btndiscord.BackColor = System.Drawing.Color.Transparent;
            this.btndiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndiscord.Image = ((System.Drawing.Image)(resources.GetObject("btndiscord.Image")));
            this.btndiscord.Location = new System.Drawing.Point(152, 498);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 542);
            this.Controls.Add(this.lblLauncherVer);
            this.Controls.Add(this.btnForums);
            this.Controls.Add(this.btndiscord);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblMini);
            this.Controls.Add(this.lblPlay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelheimRP - Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.lblPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndiscord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForums)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lblPlay;
        private System.Windows.Forms.PictureBox lblMini;
        private System.Windows.Forms.PictureBox lblClose;
        private System.Windows.Forms.PictureBox btndiscord;
        private System.Windows.Forms.PictureBox btnForums;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblLauncherVer;
    }
}

