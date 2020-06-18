using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Синаптик
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            if (FormAvtoriz.avtoriz.Type == "agent") buttonEmployees.Enabled = false;

        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            Form formEmployees = new FormEmployees();
            formEmployees.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonSites_Click(object sender, EventArgs e)
        {
            Form formSites = new FormSites();
            formSites.Show();
        }

        private void buttonDevelopment_Click(object sender, EventArgs e)
        {
            Form formDevelopment = new FormDevelopment();
            formDevelopment.Show();
        }

        private void buttonWebsite_developmen_Click(object sender, EventArgs e)
        {
            Form formWebsite_developmen = new FormWebsite_Development();
            formWebsite_developmen.Show();
        }
    }
}
