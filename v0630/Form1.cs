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
        

        int[] vx = new int[3];
        int[] vy = new int[3];

        static Random rand = new Random();
            
       
        //静的（最初に決めておく）　static　↔動的（実行時に変更可能）
       


        public Form1()
        {
            InitializeComponent();

            vx[0] = rand.Next(-10, 11);
            vy[0] = rand.Next(-10, 11);
            vx[1] = rand.Next(-10, 11);
            vy[1] = rand.Next(-10, 11);
            vx[2] = rand.Next(-10, 11);
            vy[2] = rand.Next(-10, 11);

            //ラベル1
            label1.Left = rand.Next(ClientSize.Width- label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);
            //ラベル２
            label3.Left = rand.Next(ClientSize.Width - label3.Width);
            label3.Top = rand.Next(ClientSize.Height - label3.Height);
            //ラベル３
            label4.Left = rand.Next(ClientSize.Width - label4.Width);
            label4.Top = rand.Next(ClientSize.Height - label4.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label2.Left = fpos.X - label2.Width / 2; 
            label2.Top = fpos.Y - label2.Height / 2;
            //ラベル1
            label1.Left += vx[0];
            label1.Top += vy[0];
            //ラベル２
            label3.Left += vx[1];
            label3.Top += vy[1];
            //ラベル３
            label4.Left += vx[2];
            label4.Top += vy[2];


            //ラベル1
            if (label1.Top < 0 ){
                vx[0] = Math.Abs(vx[0]);
            }
            if (label1.Top > ClientSize.Height) {
                vx[0] = -vx[0];
            }
            
            if (label1.Left < 0 ) {
                vx[0] = Math.Abs(vx[0]);
              
            }
            if (label1.Left > ClientSize.Width) {
                vx[0] = -vx[0];
            }


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

            /*
              
             
            ＿人人人 人人人＿
            ＞  圧倒的力技 ＜
            ￣^y^y^y^y^y^y^￣


            */




            //vx=math.abs(vx);正の値を返す

            /* if (label2.Left <= label1.Right && label2.Top <= label1.Bottom && label2.Right > label1.Left && label2.Bottom > label1.Top)
             {
                 timer1.Enabled = false;
             }*/
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
