using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExample
{
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();
        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 8)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void WaitForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 800;
            progressBar1.Maximum = 8;
            timer1.Tick += new EventHandler(Timer1_Tick);
        }

    }
}
