using _05_坦克大战.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_坦克大战
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            //GDI绘制
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            graphics.DrawLine(pen, new Point(0,0),new Point(100,100));

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            //graphics.DrawLine(pen, new Point(0, 0), new Point(100, 100));


            //graphics.DrawString("tank", new Font("宋体", 80), new SolidBrush(Color.Black), new Point(200, 200));
            Image image=Properties.Resources.Boss;
            graphics.DrawImage(image, new Point(200, 200));
        }
    }
}
