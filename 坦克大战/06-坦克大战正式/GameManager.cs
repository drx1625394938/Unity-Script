using _06_坦克大战正式.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _06_坦克大战正式
{
    internal class GameManager
    {
        static CantMoveThing boss;
        static Player player;
        //包含所有墙物体的列表
        static List<CantMoveThing> wallList = new List<CantMoveThing>();
        static List<CantMoveThing> steelList = new List<CantMoveThing>();
        static List<CantMoveThing> BossList=new List<CantMoveThing>();
        //static List<Player> PlayerList = new List<Player>();

        //创建地图方法
        public static void  CreateMap() 
        {
            #region 绘制地图
            CreateWall(1, 1, 5,Resources.wall,wallList);
            CreateWall(3, 1, 5, Resources.wall, wallList);
            CreateWall(5, 1, 4, Resources.wall, wallList);
            CreateWall(7, 1, 3, Resources.wall, wallList);
            CreateWall(9, 1, 4, Resources.wall, wallList);
            CreateWall(11, 1, 5, Resources.wall, wallList);
            CreateWall(13, 1, 5, Resources.wall, wallList);

            CreateWall(7, 5, 1, Resources.steel,steelList);
            CreateWall(2, 7, 1, Resources.wall, wallList);
            CreateWall(3, 7, 1, Resources.wall, wallList);
            CreateWall(4, 7, 1, Resources.wall, wallList);
            CreateWall(6, 6, 1, Resources.wall, wallList);
            CreateWall(8, 6, 1, Resources.wall, wallList);

            CreateWall(10, 7, 1, Resources.wall, wallList);
            CreateWall(11, 7, 1, Resources.wall, wallList);
            CreateWall(12, 7, 1, Resources.wall, wallList);

            CreateWall(0, 7, 1, Resources.steel, steelList);
            CreateWall(14, 7, 1, Resources.steel, steelList);

            CreateWall(1, 9, 5, Resources.wall, wallList);
            CreateWall(3, 9, 5, Resources.wall, wallList);
            CreateWall(5, 9, 3, Resources.wall, wallList);

            CreateWall(9, 9, 3, Resources.wall, wallList);
            CreateWall(11, 9, 5, Resources.wall, wallList);
            CreateWall(13, 9, 5, Resources.wall, wallList);

            CreateWall(6, 10, 1, Resources.wall, wallList);
            CreateWall(7, 10, 1, Resources.wall, wallList);
            CreateWall(8, 10, 1, Resources.wall, wallList);
            CreateWall(9, 10, 1, Resources.wall, wallList);

            CreateWall(6, 13, 2, Resources.wall, wallList);
            CreateWall(8, 13, 2, Resources.wall, wallList);
            CreateWall(7, 13, 1, Resources.wall, wallList);
            #endregion 

            CreateBoss(7, 14,BossList);
            
        }

        //绘制地图方法
        public static void DrawMap() 
        {
            foreach (CantMoveThing wall in wallList)
            {
                wall.DrawSeltImage();
            }
            foreach (CantMoveThing wall in steelList) 
            {
                wall.DrawSeltImage();
            }
            boss.DrawSeltImage();
        }
        public static void DrawPlayer() 
        {
            player.DrawSeltImage();
        }

        //创建墙体并将其放入列表方法
        private static void CreateWall(int X,int Y,int count,Image wallImg,List<CantMoveThing> wallList)
        {
            int xPosition=X*30;
            int yPosition=Y*30;

            for (int Position = yPosition; Position < yPosition + count * 30; Position += 15) 
            {
                //xPosition position     xposition+15 position
                CantMoveThing wallLeft = new CantMoveThing(wallImg, xPosition, Position);
                CantMoveThing wallright= new CantMoveThing(wallImg, xPosition+15, Position);
                wallList.Add(wallLeft);
                wallList.Add(wallright);   
            }
        
        }
        private static void CreateBoss(int X, int Y, List<CantMoveThing> BossList)
        {
            int xPosition = X * 30;
            int yPosition = Y * 30;

            boss = new CantMoveThing(Resources.Boss,xPosition,yPosition);
            BossList.Add(boss);
        }

        public static void CreatePlayer()
        {
            int xPosition = 5 * 30;
            int yPosition = 14 * 30;

            player = new Player(xPosition, yPosition, 2);
        }

    }
}
