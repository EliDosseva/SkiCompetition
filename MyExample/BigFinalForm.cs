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
    public partial class BigFinalForm : Form
    {
        private DataProvider dataProvider;
        public BigFinalForm(string connection)
        {
            InitializeComponent();
            this.dataProvider = new DataProvider(connection);
        }

        private void BigFinalForm_Load(object sender, EventArgs e)
        {
            dataGridViewFemaleResults.DataSource = dataProvider.TimesFemaleBigFinal();
            dataGridViewMaleResults.DataSource = dataProvider.TimesMaleBigFinal();
        }
    }
}
