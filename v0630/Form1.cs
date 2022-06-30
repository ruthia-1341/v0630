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
        int vx1= rand.Next(-10, 11), vy1= rand.Next(-10, 11);
        int vx2 = rand.Next(-10, 11), vy2 = rand.Next(-10, 11);
        int vx3 = rand.Next(-10, 11), vy3 = rand.Next(-10, 11);
        //静的（最初に決めておく）　static　↔動的（実行時に変更可能）
        static Random rand = new Random();


        public Form1()
        {
            InitializeComponent();
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
            label1.Left += vx1;
            label1.Top += vy1;
            //ラベル２
            label3.Left += vx2;
            label3.Top += vy2;
            //ラベル３
            label4.Left += vx3;
            label4.Top += vy3;


            //ラベル1
            if (label1.Top < 0 ){
                vy1 = Math.Abs(vy1);
            }
            if (label1.Top > ClientSize.Height) {
                vy1 = -vy1;
            }
            
            if (label1.Left < 0 ) {
                vx1 = Math.Abs(vx1);
              
            }
            if (label1.Left > ClientSize.Width) {
                vx1 = -vx1;
            }


            //ラベル２
            if (label3.Top < 0)
            {
                vy2 = Math.Abs(vy2);
            }
            if (label3.Top > ClientSize.Height)
            {
                vy2 = -vy2;
            }

            if (label3.Left < 0)
            {
                vx2 = Math.Abs(vx2);

            }
            if (label3.Left > ClientSize.Width)
            {
                vx2 = -vx2;
            }


            //ラベル３
            if (label4.Top < 0)
            {
                vy3 = Math.Abs(vy3);
            }
            if (label4.Top > ClientSize.Height)
            {
                vy3 = -vy3;
            }

            if (label4.Left < 0)
            {
                vx3 = Math.Abs(vx3);

            }
            if (label4.Left > ClientSize.Width)
            {
                vx3 = -vx3;
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
