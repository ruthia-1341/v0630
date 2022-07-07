using System;
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

        static int ChrMax => 100;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        Label[] labels = new Label[ChrMax];

        static Random rand = new Random();
            
       
        //静的（最初に決めておく）　static　↔動的（実行時に変更可能）
       


        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < ChrMax; i++)
            {
                vx[i] = rand.Next(-10, 11);
                vy[i] = rand.Next(-10, 11);

                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Text = "★";
                Controls.Add(labels[i]);

                labels[i].Left = rand.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = rand.Next(ClientSize.Height - labels[i].Height);
            }

          
            /*
            //ラベル1
            label1.Left = rand.Next(ClientSize.Width- label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            //ラベル２
            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
            //ラベル３
            label4.Left = rand.Next(ClientSize.Width - label4.Width);
            label4.Top = rand.Next(ClientSize.Height - label4.Height);*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label2.Left = fpos.X - label2.Width / 2; 
            label2.Top = fpos.Y - label2.Height / 2;

            for (int i = 0; i < ChrMax; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];
            
                if (labels[i].Top < i ){
                    vx[i] = Math.Abs(vx[i]);
                }
                if (labels[i].Top > ClientSize.Height) {
                    vx[i] = -vx[i];
                }
                if (labels[i].Left < i ) {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (labels[i].Left > ClientSize.Width) {
                    vx[i] = -vx[i];
                }

                if (fpos.X <= labels[i].Right && fpos.Y <= labels[i].Bottom && fpos.X > labels[i].Left && fpos.Y > labels[i].Top)
                {
                    labels[i].Visible = false;
                }

                if (label2.Left <= labels[i].Right && label2.Top <= labels[i].Bottom && label2.Right > labels[i].Left && label2.Bottom > labels[i].Top)
                {
                    labels[i].Visible = false;
                }

            }
            
            /*  //ラベル1
              label1.Left += vx[0];
              label1.Top += vy[0];
              //ラベル２
              label3.Left += vx[1];
              label3.Top += vy[1];
              //ラベル３
              label4.Left += vx[2];
              label4.Top += vy[2];*/


            //ラベル1

            /*

            //ラベル２
            if (label3.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            if (label3.Top > ClientSize.Height)
            {
                vy[1] = -vy[1];
            }

            if (label3.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);

            }
            if (label3.Left > ClientSize.Width)
            {
                vx[1] = -vx[1];
            }


            //ラベル３
            if (label4.Top < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            if (label4.Top > ClientSize.Height)
            {
                vx[2] = -vx[2];
            }

            if (label4.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);

            }
            if (label4.Left > ClientSize.Width)
            {
                vx[2] = -vx[2];
            }
            */
            /*
              
             
            ＿人人人 人人人＿
            ＞  圧倒的力技 ＜
            ￣^y^y^y^y^y^y^￣


            */




            //vx=math.abs(vx);正の値を返す



            /*
            if (fpos.X <= label1.Right && fpos.Y <= label1.Bottom && fpos.X > label1.Left && fpos.Y > label1.Top)
            {
                timer1.Enabled = false;
            }
            if (fpos.X <= label3.Right && fpos.Y <= label3.Bottom && fpos.X > label3.Left && fpos.Y > label3.Top)
            {
                timer1.Enabled = false;
            }
            if (fpos.X <= label4.Right && fpos.Y <= label4.Bottom && fpos.X > label4.Left && fpos.Y > label4.Top)
            {
                timer1.Enabled = false;
            }

            */
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
