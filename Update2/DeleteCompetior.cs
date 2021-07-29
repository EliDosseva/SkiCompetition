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
    
    public partial class DeleteCompetior : Form
    {
        
        private DataProvider dataProvider;
        public DeleteCompetior()
        {
            InitializeComponent();
            var connection = @"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True";
            this.dataProvider = new DataProvider(connection);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int ID = 0;
            if(!int.TryParse(textBoxID.Text, out ID))
            {
                dataProvider.Delete(ID, textBoxName.Text, textBoxLastname.Text);
            }
            else
            {
                ID = Convert.ToInt32(textBoxID.Text);
                dataProvider.Delete(ID, textBoxName.Text, textBoxLastname.Text);
            }
            
            DialogResult = DialogResult.OK;
        }
    }
}
