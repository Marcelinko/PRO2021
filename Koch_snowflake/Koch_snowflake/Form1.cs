using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koch_snowflake
{
    public partial class Form1 : Form
    {
        private double x;//pozicija želve
        private double y;
        private double alfa;//kot glede na os x
        Pen pen = new Pen(Color.Black, 2);
        public Form1()
        {
            InitializeComponent();
        }
        private int risaniX(double xr)
        {
            return (int)Math.Round(this.Width * xr);
        }
        private int risaniY(double yr)
        {
            return (int)Math.Round(this.Height - this.Height * yr);
        }
        public void ObratLevo(double kot)
        {
            alfa = alfa + kot;
        }
        public void Premik(double d, Graphics g)
        {
            double stariX = x;
            double stariY = y;
            x = x + d*Math.Cos(alfa * Math.PI / 180);
            y = y + d*Math.Sin(alfa * Math.PI / 180);
            int x1 = risaniX(stariX);
            int y1 = risaniY(stariY);
            int x2 = risaniX(x);
            int y2 = risaniY(y);
            g.DrawLine(pen, x1, y1, x2, y2);
        }
        public void Koch(int n, double korak,Graphics g)
        {
            if(n == 0)
            {
                Premik(korak, g);
                return;
            }
            Koch(n - 1, korak, g);
            ObratLevo(60);
            Koch(n - 1,korak,g);
            ObratLevo(-120);
            Koch(n - 1, korak, g);
            ObratLevo(60);
            Koch(n - 1, korak, g);
        }
        public void Drevo(int n, double x, double y,double a,double dolzina,Graphics g)
        {
            int kot = 60;
            double cx = x + dolzina * Math.Cos(a * Math.PI / 180);
            double cy = y + dolzina * Math.Sin(a * Math.PI / 180);
            int x1 = risaniX(cx);
            int y1 = risaniY(cy);
            int x2 = risaniX(x);
            int y2 = risaniY(y);
            Random r = new Random();
            Color c = Color.FromArgb(0, r.Next(255), 100);
            pen = new Pen(c);
            g.DrawLine(pen, x1, y1, x2, y2);
            if (n == 0) return;
            Drevo(n-1, cx, cy, a - kot, dolzina*0.65, g);
            Drevo(n - 1, cx, cy, a + kot, dolzina * 0.65, g);
            Drevo(n - 1, cx, cy, a, dolzina*(1 - 0.65), g);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //x = 0.5;
            //y = 0.5;
            //alfa = 0;
            //for(int k = 0; k < 6; k++)
            //{
            //    double korak = 0.2;
            //    Premik(korak, g);
            //    ObratLevo(360 / 6);
            //}
            //Random r = new Random();
            //x = 0.5;
            //y = 0.5;
            //alfa = 0;
            x = 0.0;
            y = 0.0;
            int n = 8;
            //Koch(2, 1 / Math.Pow(3, n), g);
            //for(int k = 0; k < 6; k++)
            //{
            //    Koch(n, 1 / Math.Pow(3, n)*0.35, g);
            //    ObratLevo(360 / 6);
            //}
                Drevo(n, 0.5, 0, 90, 0.3, g);
        }
    }
}
