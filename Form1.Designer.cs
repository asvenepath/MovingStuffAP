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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCompScore = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCPUScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.pcbSplit = new System.Windows.Forms.PictureBox();
            this.pcbCompPaddle = new System.Windows.Forms.PictureBox();
            this.pcbPaddle = new System.Windows.Forms.PictureBox();
            this.pcbBall = new System.Windows.Forms.PictureBox();
            this.pcbBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbExtra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(305, 418);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(268, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(305, 454);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(268, 28);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlow.ForeColor = System.Drawing.Color.Black;
            this.btnSlow.Location = new System.Drawing.Point(23, 415);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(110, 66);
            this.btnSlow.TabIndex = 3;
            this.btnSlow.Text = "SLOW";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // btnFast
            // 
            this.btnFast.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFast.Location = new System.Drawing.Point(139, 414);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(114, 67);
            this.btnFast.TabIndex = 4;
            this.btnFast.Text = "FAST";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(624, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 64);
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(222, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(413, 44);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "SINGLE PLAYER PONG";
            // 
            // lblCompScore
            // 
            this.lblCompScore.AutoSize = true;
            this.lblCompScore.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompScore.ForeColor = System.Drawing.Color.Maroon;
            this.lblCompScore.Location = new System.Drawing.Point(816, 100);
            this.lblCompScore.Name = "lblCompScore";
            this.lblCompScore.Size = new System.Drawing.Size(53, 30);
            this.lblCompScore.TabIndex = 23;
            this.lblCompScore.Text = "CPU";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Green;
            this.lblPlayer.Location = new System.Drawing.Point(816, 258);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(84, 30);
            this.lblPlayer.TabIndex = 24;
            this.lblPlayer.Text = "PLAYER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "FIRST TO 10 POINTS WINs";
            // 
            // lblCPUScore
            // 
            this.lblCPUScore.AutoSize = true;
            this.lblCPUScore.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPUScore.Location = new System.Drawing.Point(816, 130);
            this.lblCPUScore.Name = "lblCPUScore";
            this.lblCPUScore.Size = new System.Drawing.Size(25, 30);
            this.lblCPUScore.TabIndex = 26;
            this.lblCPUScore.Text = "0";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(816, 288);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(25, 30);
            this.lblPlayerScore.TabIndex = 27;
            this.lblPlayerScore.Text = "0";
            // 
            // pcbSplit
            // 
            this.pcbSplit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pcbSplit.Location = new System.Drawing.Point(12, 239);
            this.pcbSplit.Name = "pcbSplit";
            this.pcbSplit.Size = new System.Drawing.Size(798, 15);
            this.pcbSplit.TabIndex = 22;
            this.pcbSplit.TabStop = false;
            // 
            // pcbCompPaddle
            // 
            this.pcbCompPaddle.BackColor = System.Drawing.Color.Maroon;
            this.pcbCompPaddle.Location = new System.Drawing.Point(12, 76);
            this.pcbCompPaddle.Name = "pcbCompPaddle";
            this.pcbCompPaddle.Size = new System.Drawing.Size(138, 18);
            this.pcbCompPaddle.TabIndex = 21;
            this.pcbCompPaddle.TabStop = false;
            this.pcbCompPaddle.Click += new System.EventHandler(this.pcbCompPaddle_Click);
            // 
            // pcbPaddle
            // 
            this.pcbPaddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pcbPaddle.Location = new System.Drawing.Point(12, 383);
            this.pcbPaddle.Name = "pcbPaddle";
            this.pcbPaddle.Size = new System.Drawing.Size(138, 18);
            this.pcbPaddle.TabIndex = 18;
            this.pcbPaddle.TabStop = false;
            // 
            // pcbBall
            // 
            this.pcbBall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pcbBall.Location = new System.Drawing.Point(396, 230);
            this.pcbBall.Name = "pcbBall";
            this.pcbBall.Size = new System.Drawing.Size(22, 24);
            this.pcbBall.TabIndex = 0;
            this.pcbBall.TabStop = false;
            this.pcbBall.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbBackground
            // 
            this.pcbBackground.BackColor = System.Drawing.Color.Teal;
            this.pcbBackground.Location = new System.Drawing.Point(12, 76);
            this.pcbBackground.Name = "pcbBackground";
            this.pcbBackground.Size = new System.Drawing.Size(785, 325);
            this.pcbBackground.TabIndex = 19;
            this.pcbBackground.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 85);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pcbExtra
            // 
            this.pcbExtra.BackColor = System.Drawing.Color.Teal;
            this.pcbExtra.Location = new System.Drawing.Point(781, 76);
            this.pcbExtra.Name = "pcbExtra";
            this.pcbExtra.Size = new System.Drawing.Size(29, 325);
            this.pcbExtra.TabIndex = 29;
            this.pcbExtra.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 575);
            this.Controls.Add(this.pcbCompPaddle);
            this.Controls.Add(this.pcbPaddle);
            this.Controls.Add(this.pcbBall);
            this.Controls.Add(this.pcbSplit);
            this.Controls.Add(this.pcbExtra);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblCPUScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblCompScore);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFast);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbBackground);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSplit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBall;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.PictureBox pcbPaddle;
        private System.Windows.Forms.PictureBox pcbBackground;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pcbCompPaddle;
        private System.Windows.Forms.PictureBox pcbSplit;
        private System.Windows.Forms.Label lblCompScore;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCPUScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbExtra;
    }
}

