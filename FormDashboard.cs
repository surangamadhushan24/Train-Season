using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainSeason
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        public string NicValue
        { get; set; }

        public void loadForm(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void buttonGetSeason_Click(object sender, EventArgs e)
        {

            string nic = NicValue.ToString();
            FormGetSeason getseason = new FormGetSeason();
            getseason.NicValue = nic;

            loadForm(getseason);

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            string nic = NicValue.ToString();
            FormProfile profile = new FormProfile();
            profile.NicValue = nic;
            loadForm(profile);
        }

        private void buttonTimeTable_Click(object sender, EventArgs e)
        {
            loadForm(new FormTimeTable());
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
