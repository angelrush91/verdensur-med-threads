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
        public void StartUr3()
        {

            timer3.Start();
        }
        public void StartUr4()
        {

            timer4.Start();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            labelKBHtext.Text = DateTime.Now.AddHours(0).ToString();

            //labelNewYorktext.Text = DateTime.Now.AddHours(-6).ToString();
            //
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelNewYorktext.Text = DateTime.Now.AddHours(-6).ToString();
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            labelLondontext.Text = DateTime.Now.AddHours(1).ToString();
        
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            labelTokyotext.Text = DateTime.Now.AddHours(7).ToString();
        }

        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var targetMethod1 = new Action(StartUr1);
            this.Invoke(targetMethod1);
            
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            var targetMethod2 = new Action(StartUr2);
            this.Invoke(targetMethod2);
        }
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            var targetMethod3 = new Action(StartUr3);
            this.Invoke(targetMethod3);
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            var targetMethod4 = new Action(StartUr4);
            this.Invoke(targetMethod4);
        }
        private void Startbutton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void buttonUr2_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
        }


        private void ButtonUr3_Click(object sender, EventArgs e)
        {
            backgroundWorker3.RunWorkerAsync();
        }

        private void buttonUr4_Click(object sender, EventArgs e)
        {
            backgroundWorker4.RunWorkerAsync();
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void labelLondontext_Click(object sender, EventArgs e)
        {

        }
    }
}
