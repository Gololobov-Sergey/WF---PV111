using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF___PV111
{
    public partial class GDI : Form
    {
        public GDI()
        {
            InitializeComponent();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            //Graphics g = e.Graphics;
            Graphics g = this.CreateGraphics();


            g.TranslateTransform(100, 100);
            Pen p = new Pen(Brushes.Blue, 5);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            g.DrawEllipse(p, 50, 50, 200, 100);
        }


        private void GDI_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;


            //g.TranslateTransform(100, 100);
            //Pen p = new Pen(Brushes.Blue, 5);
            //p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            //g.DrawEllipse(p, 50, 50, 200, 100);

            //Rectangle r = new Rectangle(0, 0, 685, 50);
            //LinearGradientBrush lg = new LinearGradientBrush(r, Color.Aqua, Color.Red, LinearGradientMode.Horizontal);
            //g.FillRectangle(lg, r);

            //Rectangle r1 = new Rectangle(0, 60, 685, 50);
            //HatchBrush hb = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.Green);
            //g.FillRectangle(hb, r1);

            //Rectangle r2 = new Rectangle(0, 120, 685, 50);
            //TextureBrush tb = new TextureBrush(new Bitmap("C:\\Users\\golol\\Downloads\\Logo\\Cpp.png"));
            //g.FillRectangle(tb, r2);

            //Font f = new Font("Impact", 30, FontStyle.Italic);
            //g.DrawString("Hello Win Form!", f, Brushes.Tomato, 20, 200);


            //Rectangle r1 = new Rectangle(40,40,150,150);
            //Rectangle r2 = new Rectangle(100,100,150,150);

            //Region reg1 = new Region(r1);
            //Region reg2 = new Region(r2);

            //g.DrawRectangle(Pens.Tomato, r1);
            //g.DrawRectangle(Pens.Blue, r2);

            ////reg1.Intersect(reg2);
            ////reg1.Exclude(reg2);
            ////reg1.Union(reg2);
            ////reg1.Xor(reg2);
            //reg1.Complement(reg2);
            //g.FillRegion(Brushes.Green, reg1);




            //g.Dispose();
        }
    }
}
