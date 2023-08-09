using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_坦克大战正式
{
    //不可移动的物体
    internal class CantMoveThing : GameObject
    {
        public Image Image { get; set; }
        //不可移动物体获取自身图片方法重写
        public override Image GetSeftImage()
        {
            return Image;
        }
        
        //不可移动物体的构造方法
        public CantMoveThing(Image Image,int X,int Y) 
        {
            this.Image = Image;
            this.X = X;
            this.Y = Y;
        }
    }
}
