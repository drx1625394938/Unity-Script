using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_坦克大战正式
{
    internal class GameFramework
    {
        public static Graphics g;
        public static void Start() 
        {
            GameManager.CreateMap();
            GameManager.CreatePlayer();
        }
        public static void Update() 
        {
            //FPS
            GameManager.DrawMap();
            GameManager.DrawPlayer();
        }
    }
}
