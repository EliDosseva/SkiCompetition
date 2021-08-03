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
        
        private string _connection;
        public WaitForm(string connection)
        {
            InitializeComponent();

            this._connection = connection;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = 20;
            progressBar1.PerformStep();
            if (progressBar1.Value == 20)
            {
                timer1.Enabled = false;
                var fr = new FormRank(_connection);
                fr.Show();
                this.Hide();
            }
        }

        private void WaitForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
