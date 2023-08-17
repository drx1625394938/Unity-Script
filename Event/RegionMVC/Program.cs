using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RegionMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();//事件拥有者
            Controller controller = new Controller(form);//事件响应者
            form.ShowDialog();//显示窗口
        }
    }

    class Controller 
    {
        private Form form;//字段
        public Controller(Form form) //构造方法
        {
            if (form != null) 
            {
                this.form = form;
                this.form.Click += FormClicked;//事件&事件订阅
            }
        }

        private void FormClicked(object sender, EventArgs e)//事件处理器
        {
            //窗体标题显示为当前时间
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
