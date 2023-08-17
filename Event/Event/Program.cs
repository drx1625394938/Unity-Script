using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();//事件拥有者
            Boy boy=new Boy();//事件响应者
            Girl girl = new Girl();
            timer.Interval = 1000;//事件成员 timer.Interval,设置Elapsed事件间隔
            timer.Elapsed += boy.Action;//事件订阅
            timer.Elapsed += girl.Action;
            timer.Start();//引发Elapsed事件的方法
            Console.ReadLine();

        }
        class Boy
        {
            //事件处理器
            internal void Action(object sender, ElapsedEventArgs e)
            {
                Console.WriteLine("jump!");
            }
        }
        class Girl
        {
            internal void Action(object sender, ElapsedEventArgs e)
            {
                Console.WriteLine("sing!");
            }
        }
    }
}
