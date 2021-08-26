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
    public partial class CompetitionRegister : Form
    {
        private FormSkiCompetition skierForm = null;
        private DataProvider dataProvider;
        public CompetitionRegister(FormSkiCompetition skierForm, string connection)
        {
            InitializeComponent();
            this.skierForm = skierForm;
            this.dataProvider = new DataProvider(connection);
        }

        private void CreateCompetition(object sender, EventArgs e)
        {
            

        }
        private void ButtonRegisterCompetition_Click(object sender, EventArgs e)
        {
            //WaitForm wf = new WaitForm();
            //wf.FormClosed += new FormClosedEventHandler(CreateCompetition);
            //wf.Show();
            Guid guid = Guid.NewGuid();

            if (textBoxCompetitionName.Text == "" || comboBoxLocation.Text == "" 
                || monthCalendar1.SelectionRange == null || trackBarNumberOfCompetitors.Value == 0)
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
