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
            Guid guid = Guid.NewGuid();
            var competitionName = textBoxCompetitionName.Text;
            var location = textBoxLocation.Text;
            var date = monthCalendar1.SelectionRange;
            dataProvider.CreateCompetition(guid, competitionName, location, date);
            skierForm.RefreshGrid();

        }
        private void ButtonRegisterCompetition_Click(object sender, EventArgs e)
        {
            //WaitForm wf = new WaitForm();
            //wf.FormClosed += new FormClosedEventHandler(CreateCompetition);
            //wf.Show();
            CreateCompetition(sender,e);
            DialogResult = DialogResult.OK;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            var dataset = dataProvider.TrackBar();
            this.trackBar1.Maximum = this.BindingContext[dataset].Count;
        }

        private void CompetitionRegister_Load(object sender, EventArgs e)
        {
            var dataset = dataProvider.TrackBar();
            this.trackBar1.Maximum = this.BindingContext[dataset].Count;
        }
    }
}
