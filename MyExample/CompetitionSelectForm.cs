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
    public partial class CompetitionSelectForm : Form
    {
        private DataProvider dataProvider;
        public CompetitionSelectForm(string connection)
        {
            InitializeComponent();
            this.dataProvider = new DataProvider(connection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> values = new List<int>();

            foreach (var item in listBox1.SelectedItems)
            {
                values.Add(int.Parse(((DataRowView)item).Row["ID"].ToString()));
            }
            
        }

        private void CompetitionSelectForm_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = dataProvider.CompetitionTable();
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "CompetitionName";
        }
    }
}
