using _06_坦克大战正式.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_坦克大战正式
{
    internal class Player:MoveThing
    {
        public Player(int x,int y,int speed) 
        {
            this.X = x;
            this.Y = y; 
            this.Speed = speed;
            this.Direction = Direction.Up;
            BitmapUp = Resources.MyTankUp;
            BitmapDown = Resources.MyTankDown;
            BitmapLeft = Resources.MyTankLeft;
            BitmapRight = Resources.MyTankRight;
        }
    }
}
