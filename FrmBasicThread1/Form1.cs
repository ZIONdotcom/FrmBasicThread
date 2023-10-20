using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicThread1
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread ThreadA, ThreadB;

            ThreadStart eme = new ThreadStart(MyThreadClass.Thread1);

            ThreadA = new Thread(eme);
            ThreadB = new Thread(eme);

            ThreadA.Name = "Thread A Process ";
            ThreadB.Name = "Thread B Process ";
            Console.WriteLine(label.Text.ToString());
           
            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();
            label.Text = "-End of Thread-";
            Console.WriteLine(label.Text.ToString());
          
        }
    }
}
