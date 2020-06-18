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
    public partial class FormDevelopment : Form
    {
        public FormDevelopment()
        {
            InitializeComponent();
            ShowClient();
            ShowDewelopment();
            ShowEmployees();
            ShowSites();
        }
        void ShowClient()
        {
            comboBoxClient.Items.Clear();
            foreach (Client client in Program.Sinaptik.Client)
            {
                string[] item = { client.Id + " " + client.FirstName +" " + client.LastName + " " + client.MiddleName };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSites()
        {
            comboBoxSites.Items.Clear();
            foreach (Sites sites in Program.Sinaptik.Sites)
            {
                string[] item = { sites.Id + " " + sites.Name };
                comboBoxSites.Items.Add(string.Join(" ", item));
            }
        }
        void ShowEmployees()
        {
            comboBoxEmployees.Items.Clear();
            foreach(Employees employees in Program.Sinaptik.Employees)
            {
                string[] item = { employees.Id + " " + employees.FirstName + " " + employees.LastName + " " + employees.MiddleName};
                comboBoxEmployees.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDewelopment()
        {
            listViewDevelop.Items.Clear();
            foreach(Development development in Program.Sinaptik.Development)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    development.IdClent.ToString(),
                    development.Client.FirstName, development.Client.LastName, development.Client.MiddleName,
                    development.IdSites.ToString(),
                    development.Sites.Name,
                    development.IdEmployees.ToString(),
                    development.Employees.FirstName, development.Employees.LastName, development.Employees.MiddleName,
                    development.Prise.ToString(),
                });
                item.Tag = development;
                listViewDevelop.Items.Add(item);
            }
            listViewDevelop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null && comboBoxSites.SelectedItem != null && comboBoxEmployees.SelectedItem != null)
            {
                Development development = new Development();
                development.IdClent = Convert.ToInt32(comboBoxClient.SelectedIndex.ToString());
                development.IdSites = Convert.ToInt32(comboBoxSites.SelectedIndex.ToString());
                development.IdEmployees = Convert.ToInt32(comboBoxEmployees.SelectedIndex.ToString());
                development.Prise = Convert.ToInt32(textBoxPrise.Text.ToString());
                Program.Sinaptik.Development.Add(development);
                Program.Sinaptik.SaveChanges();
                ShowDewelopment();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDevelop.SelectedItems.Count == 1)
            {
                Development development = listViewDevelop.SelectedItems[0].Tag as Development;
                development.IdClent = Convert.ToInt32(comboBoxClient.SelectedItem.ToString());
                development.IdSites = Convert.ToInt32(comboBoxSites.SelectedItem.ToString());
                development.IdEmployees = Convert.ToInt32(comboBoxEmployees.SelectedItem.ToString());
                development.Prise = Convert.ToInt32(textBoxPrise.Text);
                Program.Sinaptik.SaveChanges();
                ShowDewelopment();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDevelop.SelectedItems.Count == 1)
                {
                    Development development = listViewDevelop.SelectedItems[0].Tag as Development;
                    Program.Sinaptik.SaveChanges();
                    ShowDewelopment();
                }
                comboBoxClient.SelectedItem = null;
                comboBoxSites.SelectedItem = null;
                comboBoxEmployees.SelectedItem = null;
                textBoxPrise.Text = " ";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эту запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewDevelopment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDevelop.SelectedItems.Count == 1)
            {
                Development development = listViewDevelop.SelectedItems[0].Tag as Development;
                development.IdClent = comboBoxClient.FindString(development.IdClent.ToString());
                development.IdSites = comboBoxSites.FindString(development.IdSites.ToString());
                development.IdEmployees = comboBoxEmployees.FindString(development.IdEmployees.ToString());
            }
            else
            {
                comboBoxClient.SelectedItem = null;
                comboBoxSites.SelectedItem = null;
                comboBoxEmployees.SelectedItem = null;
                textBoxPrise.Text = " ";
            }
        }

        private void comboBoxSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            Deductions();
        }
        void Deductions()
        {
            try
            {
                Sites sites = Program.Sinaptik.Sites.Find(Convert.ToInt32(comboBoxSites.SelectedItem.ToString().Split('.')[0]));
                int prise = 0;
                int a = Convert.ToInt32(sites.Pages);
                int b = Convert.ToInt32(sites.Units);
                int c = Convert.ToInt32(sites.Type);
                if (c != 0) { prise = 500 * b; }
                else if (c != 1) { prise = 1500 * a; }
                textBoxPrise.Text = prise.ToString();
            }
            catch
            {
                textBoxPrise.Text = " ";
            }
        }
    }
}
