using System;
using System.Windows.Forms;

namespace MyExample
{
    internal partial class FrmEditCompetition : Form
    {
        private readonly FrmSkiCompetition skierForm;
        private readonly DataProvider dataProvider;

        internal FrmEditCompetition(FrmSkiCompetition skierForm, string connection)
        {
            InitializeComponent();
            this.skierForm = skierForm;

            this.dataProvider = new DataProvider(connection);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            var competitionName = textBoxEditCompetitionName.Text;
            var location = comboBoxEditLocation.SelectedValue.ToString();
            var dateStart = DateTime.Parse(monthCalendarEdit.SelectionRange.Start.ToShortDateString());
            var dateEnd = DateTime.Parse(monthCalendarEdit.SelectionRange.End.ToShortDateString());

            dataProvider.EditCompetition(skierForm.competitionId, competitionName,location,dateStart,dateEnd,trackBarEditNumberOfCompetitors.Value);
            skierForm.RefreshGrid();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TrackBarEditNumberOfCompetitors_Scroll(object sender, EventArgs e)
        {
            var dataset = dataProvider.TrackBar();
            trackBarEditNumberOfCompetitors.Maximum = BindingContext[dataset].Count;
            toolTipEditCompetition.SetToolTip(trackBarEditNumberOfCompetitors, trackBarEditNumberOfCompetitors.Value.ToString());
        }

        internal void CompetitionInfo(ListBox listBox)
        {
            comboBoxEditLocation.ValueMember = "CompetitionLocation";
            comboBoxEditLocation.DisplayMember = "CompetitionLocation";

            comboBoxEditLocation.DataSource = dataProvider.Locations();
            textBoxEditCompetitionName.Text = ((Competition)listBox.SelectedItem).CompetitionName;
            comboBoxEditLocation.Text = ((Competition)listBox.SelectedItem).Location;
            var dataset = dataProvider.TrackBar();
            trackBarEditNumberOfCompetitors.Maximum = BindingContext[dataset].Count;
            trackBarEditNumberOfCompetitors.Value = ((Competition)listBox.SelectedItem).Competitors;
            monthCalendarEdit.SelectionStart = ((Competition)listBox.SelectedItem).DateStart;
            monthCalendarEdit.SelectionEnd = ((Competition)listBox.SelectedItem).DateEnd;
        }
    }
}
