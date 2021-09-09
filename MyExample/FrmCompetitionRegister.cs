using System;
using System.Windows.Forms;

namespace MyExample
{
    public partial class FrmCompetitionRegister : Form
    {
        private readonly FrmSkiCompetition skierForm;
        private readonly DataProvider dataProvider;

        internal FrmCompetitionRegister(FrmSkiCompetition skierForm, string connection)
        {
            InitializeComponent();
            this.skierForm = skierForm;
            this.dataProvider = new DataProvider(connection);
        }

        private void ButtonRegisterCompetition_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();

            if (textBoxCompetitionName.Text == "" || comboBoxLocation.Text == "" || trackBarNumberOfCompetitors.Value == 0)
            {
                MyMessages.DisplayWarning("Please fill in all fields");
                return;
            }

            var competitionName = textBoxCompetitionName.Text;
            var location = comboBoxLocation.SelectedValue.ToString();

            var dateStart = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToShortDateString());
            var dateEnd = DateTime.Parse(monthCalendar1.SelectionRange.End.ToShortDateString());

            dataProvider.CreateCompetition(guid, competitionName, location, dateStart, dateEnd, trackBarNumberOfCompetitors.Value);
            skierForm.RefreshGrid();
            DialogResult = DialogResult.OK;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            var dataset = dataProvider.TrackBar();
            trackBarNumberOfCompetitors.Maximum = BindingContext[dataset].Count;
            toolTip1.SetToolTip(trackBarNumberOfCompetitors, trackBarNumberOfCompetitors.Value.ToString());

        }

        private void CompetitionRegister_Load(object sender, EventArgs e)
        {
            comboBoxLocation.ValueMember = "CompetitionLocation";
            comboBoxLocation.DisplayMember = "CompetitionLocation";
            
            comboBoxLocation.DataSource = dataProvider.Locations();
            comboBoxLocation.SelectedIndex = -1;
            var dataset = dataProvider.TrackBar();
            this.trackBarNumberOfCompetitors.Maximum = this.BindingContext[dataset].Count;
        }
    }
}
