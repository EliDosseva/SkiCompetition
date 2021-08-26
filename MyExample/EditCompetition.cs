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
    public partial class EditCompetition : Form
    {
        private FormSkiCompetition skierForm = null;
        private DataProvider dataProvider;
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
            this.trackBarEditNumberOfCompetitors.Maximum = this.BindingContext[dataset].Count;
        }

        private void TrackBarEditNumberOfCompetitors_Scroll(object sender, EventArgs e)
        {
            var dataset = dataProvider.TrackBar();
            this.trackBarEditNumberOfCompetitors.Maximum = this.BindingContext[dataset].Count;
            toolTipEditCompetition.SetToolTip(trackBarEditNumberOfCompetitors, trackBarEditNumberOfCompetitors.Value.ToString());
        }

    }
}
