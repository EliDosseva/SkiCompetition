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
    public partial class TeamMembers : Form
    {
        private FormSkiCompetition skierForm = null;
        private DataProvider dataProvider;
        public TeamMembers(FormSkiCompetition skierForm, string connection)
        {
            InitializeComponent();

            this.skierForm = skierForm;

            this.dataProvider = new DataProvider(connection);
        }

        private void TeamMembers_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(skierForm.dataGridViewTeamRank.SelectedRows[0].Cells[1].Value);
            foreach (var item in dataProvider.GetTeamMembers(id))
            {
                ListBoxTeamMembers.Items.Add(item);
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
