namespace MovingStuffAP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.pcbBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(353, 565);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(246, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(353, 601);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(246, 28);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.ForeColor = System.Drawing.Color.Black;
            this.btnSlow.Location = new System.Drawing.Point(12, 565);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(91, 67);
            this.btnSlow.TabIndex = 3;
            this.btnSlow.Text = "SLOW";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(109, 565);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(91, 67);
            this.btnFast.TabIndex = 4;
            this.btnFast.Text = "FAST";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(605, 566);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 64);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 1;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // pcbBall
            // 
            this.pcbBall.BackColor = System.Drawing.Color.Fuchsia;
            this.pcbBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbBall.BackgroundImage")));
            this.pcbBall.Location = new System.Drawing.Point(96, 187);
            this.pcbBall.Name = "pcbBall";
            this.pcbBall.Size = new System.Drawing.Size(73, 78);
            this.pcbBall.TabIndex = 0;
            this.pcbBall.TabStop = false;
            this.pcbBall.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 644);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFast);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pcbBall);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.PictureBox pcbBall;
    }
}

