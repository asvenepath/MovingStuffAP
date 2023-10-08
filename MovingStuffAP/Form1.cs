using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingStuffAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variable Declaration
        static int intSpeed = 1;
        static int intDirection = 1;
        static int intHMove = intSpeed;
        static int intVMove = intSpeed;
        static int intBottom = 260;
        static int intPcbLength = 75;

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.tmrGame.Enabled = true;
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            intHMove = intSpeed;
            intVMove = intSpeed;

            if (intDirection == 1)
            {
                intHMove = Math.Abs(intHMove);
                intVMove = Math.Abs(intVMove) * -1;
            }
            else if (intDirection == 2)
            {
                intHMove = Math.Abs(intHMove) * -1;
                intVMove = Math.Abs(intVMove) * -1;
            }
            else if (intDirection == 3)
            {
                intHMove = Math.Abs(intHMove) * -1;
                intVMove = Math.Abs(intVMove);
            }
            else if (intDirection == 4)
            {
                intHMove = Math.Abs(intHMove);
                intVMove = Math.Abs(intVMove);
            }
            this.pcbBall.Left += intHMove;
            this.pcbBall.Top += intVMove;

            //Counter clockwise
            if (intDirection == 1 && pcbBall.Left > this.Width - intPcbLength)
            {
                intDirection = 2;
            }
            else if (intDirection == 2 && pcbBall.Top < 0)
            {
                intDirection = 3;
            }
            else if (intDirection == 3 && pcbBall.Left < 0)
            {
                intDirection = 4;
            }
            else if (intDirection == 4 && pcbBall.Top > intBottom)
            {
                intDirection = 1;
            }

            //Clockwise
            if (intDirection == 2 && pcbBall.Left < 0)
            {
                intDirection = 1;
            }
            else if (intDirection == 1 && pcbBall.Top < 0)
            {
                intDirection = 4;
            }
            else if (intDirection == 4 && pcbBall.Left > this.Width - intPcbLength)
            {
                intDirection = 3;
            }
            else if (intDirection == 3 && pcbBall.Top > intBottom)
            {
                intDirection = 2;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.tmrGame.Enabled = false;

        }
        //pcbBall
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            intSpeed += 1;
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            if (intSpeed < 5)
            {
                intSpeed += 0;
            }
            else
            {
                intSpeed -= 1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            intDirection = 1;
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            intDirection = 2;
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            intDirection = 3;
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            intDirection = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}