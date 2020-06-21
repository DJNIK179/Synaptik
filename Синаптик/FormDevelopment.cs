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
            comboBoxSites.SelectedItem = 0;
        }
        void ShowClient()
        {
            comboBoxClient.Items.Clear();
            foreach (Client client in Program.Sinaptik.Client)
            {
                string[] item = { client.Id + ". " + client.FirstName +" " + client.LastName + " " + client.MiddleName };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSites()
        {
            comboBoxSites.Items.Clear();
            foreach (Sites sites in Program.Sinaptik.Sites)
            {
                string[] item = { sites.Id + ". " + sites.Name +" "+ sites.Type };
                comboBoxSites.Items.Add(string.Join(" ", item));
            }
        }
        void ShowEmployees()
        {
            comboBoxEmployees.Items.Clear();
            foreach(Employees employees in Program.Sinaptik.Employees)
            {
                string[] item = { employees.Id + ". " + employees.FirstName + " " + employees.LastName + " " + employees.MiddleName};
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
                    development.Client.FirstName +" "+ development.Client.LastName +" "+ development.Client.MiddleName,
                    development.IdSites.ToString(),
                    development.Sites.Name,
                    development.IdEmployees.ToString(),
                    development.Employees.FirstName+" "+ development.Employees.LastName+" "+ development.Employees.MiddleName,
                    development.Prise.ToString()
                });
                item.Tag = development;
                listViewDevelop.Items.Add(item);
            }
            listViewDevelop.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null && comboBoxSites.SelectedItem != null && comboBoxEmployees.SelectedItem != null && textBoxPrise.Text != " ")
            {
                Development development = new Development();
                development.IdClent = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                development.IdSites = Convert.ToInt32(comboBoxSites.SelectedItem.ToString().Split('.')[0]);
                development.IdEmployees = Convert.ToInt32(comboBoxEmployees.SelectedItem.ToString().Split('.')[0]);
                development.Prise = Convert.ToInt32(textBoxPrise.Text);
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
                development.IdClent = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                development.IdSites = Convert.ToInt32(comboBoxSites.SelectedItem.ToString().Split('.')[0]);
                development.IdEmployees = Convert.ToInt32(comboBoxEmployees.SelectedItem.ToString().Split('.')[0]);
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
                    Program.Sinaptik.Development.Remove(development);
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
                comboBoxClient.SelectedItem = null;
                comboBoxSites.SelectedItem = null;
                comboBoxEmployees.SelectedItem = null;
                textBoxPrise.Text = " ";
            }
        }

        private void listViewDevelopment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDevelop.SelectedItems.Count == 1)
            {
                Development development = listViewDevelop.SelectedItems[0].Tag as Development;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(development.IdClent.ToString());
                comboBoxSites.SelectedIndex = comboBoxSites.FindString(development.IdSites.ToString());
                comboBoxEmployees.SelectedIndex = comboBoxEmployees.FindString(development.IdEmployees.ToString());
                textBoxPrise.Text = development.Prise.ToString();
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
            textBoxPrise.Text = Convert.ToString(Deductions());
        }
        int Deductions()
        { 
            int prise = 0;
            foreach (Sites sites in Program.Sinaptik.Sites)
            {
              if (sites.Id == Convert.ToInt32(comboBoxSites.SelectedItem.ToString().Split('.')[0]))
              { 
                int c = Convert.ToInt32(sites.Type);
                if (c != 0) { int b = Convert.ToInt32(sites.Units); prise = 500 * b; }
                else if (c != 1) { int a = Convert.ToInt32(sites.Pages); prise = 1500 * a; }
              }
                
            }
            return prise;
        }
    }
}
