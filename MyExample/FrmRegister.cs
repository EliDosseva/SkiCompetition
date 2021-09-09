using System;
using System.Windows.Forms;

namespace MyExample
{
    internal partial class FrmRegister : Form
    {

        private readonly FrmSkiCompetition skierForm;
        private readonly DataProvider dataProvider;

        internal FrmRegister(FrmSkiCompetition skierForm, string connection)
        {
            InitializeComponent();
            this.skierForm = skierForm;
            
            dataProvider = new DataProvider(connection);
        }

        private void Register_Load(object sender, EventArgs e)
        {
            comboBoxTeam.ValueMember = "TeamID";
            comboBoxTeam.DisplayMember = "TeamName";
            comboBoxTeam.DataSource = dataProvider.TeamSelection();
            comboBoxTeam.SelectedIndex = -1;
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
          var ifExist = dataProvider.IfExist(textBoxName.Text,textBoxLastName.Text);

          if (textBoxName.Text == "" || textBoxLastName.Text == "" || comboBoxSex.Text == "" || comboBoxTeam.Text == "")
          {
                MyMessages.DisplayWarning("Please fill in all fields");
                return;
          }
          var sex = comboBoxSex.GetItemText(comboBoxSex.SelectedItem);

          int team = int.Parse(comboBoxTeam.SelectedValue.ToString());

          if (ifExist)
          {
              {
                  DialogResult dialogResult = MyMessages.Warning(string.Format(
                      "Competitor {0} {1} already exist! Do you want to register new competitor with these names?", textBoxName.Text, textBoxLastName.Text));
                  if (dialogResult == DialogResult.Yes)
                  {
                      Close();
                  }
                  else if (dialogResult == DialogResult.No)
                  {
                      return;
                  }
              }
          }

          dataProvider.CreateCompetitor(textBoxName.Text, textBoxLastName.Text, sex, team, 0);
            
            skierForm.RefreshGrid();
          DialogResult = DialogResult.OK;
        }

    }
}

