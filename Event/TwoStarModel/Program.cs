using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace TwoStarModel
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Form1 form1 = new Form1();
            form1.Click += form1.Action;
        }
    }
    class Form1 : Form
    {
        internal void Action(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
