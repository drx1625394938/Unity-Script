using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_坦克大战正式
{
    public partial class Form1 : Form
    {
        Thread t;
        static Graphics g;//窗体画布
        static Bitmap tempBmp;//临时图片
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            g = this.CreateGraphics();
            GameFramework.g = g;

            tempBmp = new Bitmap(450,450);//大小跟窗体一样的临时图片
            Graphics tempG=Graphics.FromImage(tempBmp);//根据图片，创建一个大小相同的画布
            GameFramework.g = tempG;


            

            t = new Thread(new ThreadStart(GameMainThread));
            t.Start();
        }

        //主线程方法
        private static void GameMainThread() 
        {
            //GameFrameWork;
            GameFramework.Start();

            int sleepTime = 1000 / 60;
            while (true) 
            {
                GameFramework.g.Clear(Color.Black);
                GameFramework.Update();
                g.DrawImage(tempBmp, 0, 0);
                Thread.Sleep(sleepTime);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Abort();
        }
    }
}
