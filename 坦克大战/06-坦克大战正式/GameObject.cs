using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_坦克大战正式
{
    internal abstract class GameObject
    {
        //所有物体都有一个自己所在的位置
        public int X { get; set; }
        public int Y { get; set; } 

        //所有游戏对象都有获取自身图片和在画板上画出自己图片的方法
        //获取自己的图片方法
        public abstract Image GetSeftImage();

        //在画板上画出图片方法
        public void DrawSeltImage() 
        {
            Graphics g = GameFramework.g;
            g.DrawImage(GetSeftImage(), X, Y);
        }
	}
}
