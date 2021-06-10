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
    public partial class Register : Form
    {
        private FormSkiCompetition skierForm = null;
        private Skier skier = null;
        public Register(FormSkiCompetition skierForm)
        {
            InitializeComponent();
            this.skierForm = skierForm;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string sex = comboBoxSex.Text;
            if (sex.Equals("male"))
            {
                skier = new Boy(textBoxName.Text);
                skier.Team = comboBoxTeam.Text;
                skierForm.GetBoys().Add((Boy)skier);

            }
            else if(sex.Equals("female"))
            {
                skier = new Girl(textBoxName.Text);
                skier.Team = comboBoxTeam.Text;
                skierForm.GetGirls().Add((Girl)skier);

            }
            else
                return;
            
            List<Skier> skiers = skierForm.GetSkiersByTeam(((Team)comboBoxTeam.SelectedItem));

            skiers.Add(skier);

            DialogResult = DialogResult.OK;
        }
    }
}
