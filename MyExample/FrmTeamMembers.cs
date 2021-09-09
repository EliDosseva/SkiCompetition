using System;
using System.Windows.Forms;

namespace MyExample
{
    internal partial class FrmTeamMembers : Form
    {
        private readonly DataProvider dataProvider;

        internal FrmTeamMembers(FrmSkiCompetition skierForm, string connection)
        {
            InitializeComponent();
            dataProvider = new DataProvider(connection);
        }

        internal void TeamMembersLoad(int id)
        {
            foreach (var item in dataProvider.GetTeamMembers(id))
            {
                ListBoxTeamMembers.Items.Add(item);
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
