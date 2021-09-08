using System;
using System.Windows.Forms;

namespace MyExample
{
    public partial class BigFinalForm : Form
    {
        private readonly DataProvider dataProvider;
        public BigFinalForm(string connection)
        {
            InitializeComponent();
            this.dataProvider = new DataProvider(connection);
        }

        private void BigFinalForm_Load(object sender, EventArgs e)
        {
            dataGridViewFemaleResults.DataSource = dataProvider.BigFinalResults("female");
            dataGridViewMaleResults.DataSource = dataProvider.BigFinalResults("male");
        }

    }
}
