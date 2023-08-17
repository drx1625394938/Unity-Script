using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.ShowDialog();
        }
    }
    class MyForm : Form 
    {
        TextBox text;
        Button button;
        public MyForm() 
        {
            this.text = new TextBox();
            this.button = new Button();

            this.Controls.Add(this.button);
            this.Controls.Add(this.text);

            button.Text = "请点击";
            button.Click += ButtonClicked;//订阅
            
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.text.Text = DateTime.Now.ToString();
        }
    }


}
