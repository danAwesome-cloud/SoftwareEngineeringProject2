using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringProject2
{
    public partial class CreateIdea : Form
    {
        public CreateIdea()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnectionClass.getInstanceOfDBConnection().CreateIdea(tbIdeaTitle.Text, tbAbstract.Text, tbCountryAva.Text, tbRegionalAvailability.Text, tbCurrencyType.Text, tbIdeaType.Text, tbPublishdate.Text, tbexpireDate.Text, rtbInsertIdea.Text, tbRiskRating.Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
