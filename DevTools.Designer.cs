namespace DosGameLauncher
{
    partial class DevToolsForm
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
            this.devbtnDobox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.devbtnWindows = new System.Windows.Forms.Button();
            this.devbtnRepo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // devbtnDobox
            // 
            this.devbtnDobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.devbtnDobox.Font = new System.Drawing.Font("Glass Gauge", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devbtnDobox.Location = new System.Drawing.Point(69, 47);
            this.devbtnDobox.Name = "devbtnDobox";
            this.devbtnDobox.Size = new System.Drawing.Size(160, 32);
            this.devbtnDobox.TabIndex = 0;
            this.devbtnDobox.Text = "Launch Dosbox";
            this.devbtnDobox.UseVisualStyleBackColor = false;
            this.devbtnDobox.Click += new System.EventHandler(this.devbtnDobox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Glass Gauge", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "DGL Dev Toolbox";
            // 
            // devbtnWindows
            // 
            this.devbtnWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.devbtnWindows.Font = new System.Drawing.Font("Glass Gauge", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devbtnWindows.Location = new System.Drawing.Point(69, 85);
            this.devbtnWindows.Name = "devbtnWindows";
            this.devbtnWindows.Size = new System.Drawing.Size(160, 32);
            this.devbtnWindows.TabIndex = 2;
            this.devbtnWindows.Text = "Open Windows";
            this.devbtnWindows.UseVisualStyleBackColor = false;
            this.devbtnWindows.Click += new System.EventHandler(this.devbtnWindows_Click);
            // 
            // devbtnRepo
            // 
            this.devbtnRepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.devbtnRepo.Font = new System.Drawing.Font("Glass Gauge", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devbtnRepo.Location = new System.Drawing.Point(69, 123);
            this.devbtnRepo.Name = "devbtnRepo";
            this.devbtnRepo.Size = new System.Drawing.Size(160, 32);
            this.devbtnRepo.TabIndex = 3;
            this.devbtnRepo.Text = "Go to Repo";
            this.devbtnRepo.UseVisualStyleBackColor = false;
            this.devbtnRepo.Click += new System.EventHandler(this.devbtnRepo_Click);
            // 
            // DevToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.devbtnRepo);
            this.Controls.Add(this.devbtnWindows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.devbtnDobox);
            this.Name = "DevToolsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DGL Dev Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button devbtnDobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button devbtnWindows;
        private System.Windows.Forms.Button devbtnRepo;
    }
}