namespace verdensur_med_threads
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelKBH = new System.Windows.Forms.Label();
            this.labelNY = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.labelTK = new System.Windows.Forms.Label();
            this.labelKBHtext = new System.Windows.Forms.Label();
            this.labelNewYorktext = new System.Windows.Forms.Label();
            this.labelLondontext = new System.Windows.Forms.Label();
            this.labelTokyotext = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Startbutton = new System.Windows.Forms.Button();
            this.buttonUr2 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.buttonStopUr1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKBH
            // 
            this.labelKBH.AutoSize = true;
            this.labelKBH.Location = new System.Drawing.Point(69, 25);
            this.labelKBH.Name = "labelKBH";
            this.labelKBH.Size = new System.Drawing.Size(30, 15);
            this.labelKBH.TabIndex = 0;
            this.labelKBH.Text = "KBH";
            // 
            // labelNY
            // 
            this.labelNY.AutoSize = true;
            this.labelNY.Location = new System.Drawing.Point(69, 75);
            this.labelNY.Name = "labelNY";
            this.labelNY.Size = new System.Drawing.Size(57, 15);
            this.labelNY.TabIndex = 1;
            this.labelNY.Text = "New York";
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Location = new System.Drawing.Point(69, 121);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(48, 15);
            this.labelLN.TabIndex = 2;
            this.labelLN.Text = "London";
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(69, 175);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(38, 15);
            this.labelTK.TabIndex = 3;
            this.labelTK.Text = "Tokyo";
            // 
            // labelKBHtext
            // 
            this.labelKBHtext.AutoSize = true;
            this.labelKBHtext.Location = new System.Drawing.Point(219, 30);
            this.labelKBHtext.Name = "labelKBHtext";
            this.labelKBHtext.Size = new System.Drawing.Size(38, 15);
            this.labelKBHtext.TabIndex = 4;
            this.labelKBHtext.Text = "label1";
            this.labelKBHtext.Click += new System.EventHandler(this.labelKBHtext_Click);
            // 
            // labelNewYorktext
            // 
            this.labelNewYorktext.AutoSize = true;
            this.labelNewYorktext.Location = new System.Drawing.Point(219, 75);
            this.labelNewYorktext.Name = "labelNewYorktext";
            this.labelNewYorktext.Size = new System.Drawing.Size(38, 15);
            this.labelNewYorktext.TabIndex = 5;
            this.labelNewYorktext.Text = "label1";
            // 
            // labelLondontext
            // 
            this.labelLondontext.AutoSize = true;
            this.labelLondontext.Location = new System.Drawing.Point(219, 121);
            this.labelLondontext.Name = "labelLondontext";
            this.labelLondontext.Size = new System.Drawing.Size(38, 15);
            this.labelLondontext.TabIndex = 6;
            this.labelLondontext.Text = "label1";
            // 
            // labelTokyotext
            // 
            this.labelTokyotext.AutoSize = true;
            this.labelTokyotext.Location = new System.Drawing.Point(219, 175);
            this.labelTokyotext.Name = "labelTokyotext";
            this.labelTokyotext.Size = new System.Drawing.Size(38, 15);
            this.labelTokyotext.TabIndex = 7;
            this.labelTokyotext.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(310, 276);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(75, 23);
            this.Startbutton.TabIndex = 8;
            this.Startbutton.Text = "Start ur";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // buttonUr2
            // 
            this.buttonUr2.Location = new System.Drawing.Point(310, 305);
            this.buttonUr2.Name = "buttonUr2";
            this.buttonUr2.Size = new System.Drawing.Size(75, 23);
            this.buttonUr2.TabIndex = 9;
            this.buttonUr2.Text = "Start ur 2";
            this.buttonUr2.UseVisualStyleBackColor = true;
            this.buttonUr2.Click += new System.EventHandler(this.buttonUr2_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // buttonStopUr1
            // 
            this.buttonStopUr1.Location = new System.Drawing.Point(406, 276);
            this.buttonStopUr1.Name = "buttonStopUr1";
            this.buttonStopUr1.Size = new System.Drawing.Size(75, 23);
            this.buttonStopUr1.TabIndex = 10;
            this.buttonStopUr1.Text = "Stop ur 1";
            this.buttonStopUr1.UseVisualStyleBackColor = true;
            this.buttonStopUr1.Click += new System.EventHandler(this.buttonStopUr1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonStopUr1);
            this.Controls.Add(this.buttonUr2);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.labelTokyotext);
            this.Controls.Add(this.labelLondontext);
            this.Controls.Add(this.labelNewYorktext);
            this.Controls.Add(this.labelKBHtext);
            this.Controls.Add(this.labelTK);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.labelNY);
            this.Controls.Add(this.labelKBH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKBH;
        private System.Windows.Forms.Label labelNY;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Label labelTK;
        private System.Windows.Forms.Label labelKBHtext;
        private System.Windows.Forms.Label labelNewYorktext;
        private System.Windows.Forms.Label labelLondontext;
        private System.Windows.Forms.Label labelTokyotext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button buttonUr2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button buttonStopUr1;
        private System.Windows.Forms.Button button2;
    }
}
