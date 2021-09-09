using System;
using System.Windows.Forms;

namespace MyExample
{
    internal partial class FrmBigFinal : Form
    {
        private readonly DataProvider dataProvider;

        internal FrmBigFinal(string connection)
        {
            InitializeComponent();
            dataProvider = new DataProvider(connection);
        }

        private void BigFinalForm_Load(object sender, EventArgs e)
        {
            dataGridViewFemaleResults.DataSource = dataProvider.BigFinalResults("female");
            dataGridViewMaleResults.DataSource = dataProvider.BigFinalResults("male");
        }

    }
}
