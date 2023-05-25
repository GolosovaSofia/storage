using System;
using System.Windows.Forms;

namespace storage
{
    public partial class Start : Form
    {
        private System.Windows.Forms.Timer timer;

        public Start()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += delegate
            {
                this.Close();
            };
            timer.Interval = (int)TimeSpan.FromSeconds(2).TotalMilliseconds;
            timer.Start();
        }
    }
}
