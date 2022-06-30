﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0630
{
    public partial class Form1 : Form
    {
        int vx= rand.Next(-10, 11), vy= rand.Next(-10, 11);
        //静的（最初に決めておく）　static　↔動的（実行時に変更可能）
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width- label2.Width);
            label1.Top = rand.Next(ClientSize.Height - label2.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label2.Left = fpos.X - label2.Width / 2; 
            label2.Top = fpos.Y - label2.Height / 2;

            label1.Left += vx;
            label1.Top += vy;

           

            if (label1.Top < 0 ){
                vy = Math.Abs(vy);
            }
            if (label1.Top > ClientSize.Height) {
                vy = -vy;
            }
            
            if (label1.Left < 0 ) {
                vx = Math.Abs(vx);
              
            }
            if (label1.Left > ClientSize.Width) {
                vx = -vx;
            }

            //vx=math.abs(vx);正の値を返す

            /* if (label2.Left <= label1.Right && label2.Top <= label1.Bottom && label2.Right > label1.Left && label2.Bottom > label1.Top)
             {
                 timer1.Enabled = false;
             }*/
            if (fpos.X <= label1.Right && fpos.Y <= label1.Bottom && fpos.X > label1.Left && fpos.Y > label1.Top)
            {
                timer1.Enabled = false;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
