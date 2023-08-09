using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_坦克大战正式
{
    //可移动对象朝向有四种
    enum Direction 
    {
        Up,
        Down,
        Left,
        Right
    }
    internal class MoveThing : GameObject
    {
        //可移动对象有上下左右四种状态的图片
        public Bitmap BitmapUp { get; set; }
        public Bitmap BitmapDown { get; set; }
        public Bitmap BitmapLeft { get; set; }
        public Bitmap BitmapRight { get; set; }

        //朝向
        public Direction Direction { get; set; }

        //速度
        public int Speed { get; set; }

        //可移动物体获取自身图片重写
        public override Image GetSeftImage()
        {
            Bitmap bitmap;
            switch (Direction) 
            {
                case Direction.Up:
                    bitmap = BitmapUp;
                    break;
                case Direction.Down:
                    bitmap = BitmapDown;
                    break;
                case Direction.Left:
                    bitmap = BitmapLeft;
                    break;
                case Direction.Right:
                    bitmap = BitmapRight;
                    break;
                default:
                    bitmap=BitmapUp;
                    break;
            }
            //将背景的黑色设置为透明的
            bitmap.MakeTransparent(Color.Black);
             
            return bitmap;
        }
        
    }
}
