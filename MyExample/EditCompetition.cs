using System;
using System.Windows.Forms;

namespace MyExample
{
    public partial class EditCompetition : Form
    {
        private readonly FormSkiCompetition skierForm;
        private readonly DataProvider dataProvider;
        public EditCompetition(FormSkiCompetition skierForm, string connection)
        {
            InitializeComponent();
            this.skierForm = skierForm;

            this.dataProvider = new DataProvider(connection);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            var id = int.Parse(skierForm.listBoxCompetitions.SelectedValue.ToString());
            var competitionName = textBoxEditCompetitionName.Text;
            var location = comboBoxEditLocation.SelectedValue.ToString();
            var dateStart = DateTime.Parse(monthCalendarEdit.SelectionRange.Start.ToShortDateString());
            var dateEnd = DateTime.Parse(monthCalendarEdit.SelectionRange.End.ToShortDateString());

            dataProvider.EditCompetition(id, competitionName,location,dateStart,dateEnd,trackBarEditNumberOfCompetitors.Value);
            skierForm.RefreshGrid();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditCompetition_Load(object sender, EventArgs e)
        {
            comboBoxEditLocation.ValueMember = "CompetitionLocation";
            comboBoxEditLocation.DisplayMember = "CompetitionLocation";

            comboBoxEditLocation.DataSource = dataProvider.Locations();
            comboBoxEditLocation.Text = ((Competition)skierForm.listBoxCompetitions.SelectedItem).Location;
            var dataset = dataProvider.TrackBar();
            trackBarEditNumberOfCompetitors.Maximum = BindingContext[dataset].Count;
            trackBarEditNumberOfCompetitors.Value = ((Competition)skierForm.listBoxCompetitions.SelectedItem).Competitors;
        }

        private void TrackBarEditNumberOfCompetitors_Scroll(object sender, EventArgs e)
        {
            var dataset = dataProvider.TrackBar();
            trackBarEditNumberOfCompetitors.Maximum = BindingContext[dataset].Count;
            toolTipEditCompetition.SetToolTip(trackBarEditNumberOfCompetitors, trackBarEditNumberOfCompetitors.Value.ToString());
        }

    }
}
