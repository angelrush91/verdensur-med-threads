using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verdensur_med_threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void labelKBHtext_Click(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            labelKBHtext.Text = DateTime.Now.AddHours(0).ToString();

            //labelNewYorktext.Text = DateTime.Now.AddHours(-6).ToString();
            //labelTokyotext.Text = DateTime.Now.AddHours(7).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        public void StartUr1()
        {
            timer1.Start();
            
        }
        public void StartUr2()
        {
            
            timer2.Start();
        }


        private void Startbutton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelNewYorktext.Text = DateTime.Now.AddHours(1).ToString();
        }

        private void buttonUr2_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            var targetMethod = new Action(StartUr2);
            this.Invoke(targetMethod);
        }
        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var targetMethod = new Action(StartUr1);
            this.Invoke(targetMethod);
            
        }

        private void buttonStopUr1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
