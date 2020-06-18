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
    public partial class FormWebsite_Development : Form
    {
        public FormWebsite_Development()
        {
            InitializeComponent();
            ShowDevelopmet();
            ShowSites();
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

        void ShowDevelopmet()
        {
            listViewDevelopment.Items.Clear();
            foreach (Website_developmen website_Developmen in Program.Sinaptik.Website_developmen)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    website_Developmen.Id.ToString(), website_Developmen.IdSites.ToString(), website_Developmen.Prototip,
                    website_Developmen.Design, website_Developmen.Verstka, website_Developmen.Marceting,
                });
                item.Tag = website_Developmen;
                listViewDevelopment.Items.Add(item);
            }
            listViewDevelopment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxSites.SelectedItem != null)
            {
                Website_developmen website_Developmen = new Website_developmen();
                website_Developmen.IdSites = Convert.ToInt32(comboBoxSites.SelectedIndex.ToString());
                website_Developmen.Prototip = comboBoxPrototip.Text;
                website_Developmen.Design = comboBoxDesign.Text;
                website_Developmen.Verstka = comboBoxVerstka.Text;
                website_Developmen.Marceting = comboBoxMarketing.Text;
                Program.Sinaptik.Website_developmen.Add(website_Developmen);
                Program.Sinaptik.SaveChanges();
                ShowDevelopmet();
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDevelopment.SelectedItems.Count == 1)
            {
                Website_developmen website_Developmen = listViewDevelopment.SelectedItems[0].Tag as Website_developmen;
                website_Developmen.IdSites = Convert.ToInt32(comboBoxSites.SelectedIndex.ToString());
                website_Developmen.Prototip = comboBoxPrototip.Text;
                website_Developmen.Design = comboBoxDesign.Text;
                website_Developmen.Verstka = comboBoxVerstka.Text;
                website_Developmen.Marceting = comboBoxMarketing.Text;
                
                Program.Sinaptik.SaveChanges();
                ShowDevelopmet();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDevelopment.SelectedItems.Count == 1)
                {
                    Website_developmen website_Developmen = listViewDevelopment.SelectedItems[0].Tag as Website_developmen;
                    Program.Sinaptik.Website_developmen.Remove(website_Developmen);
                    Program.Sinaptik.SaveChanges();
                    ShowDevelopmet();
                }
                comboBoxSites.SelectedItem = null;
                comboBoxPrototip.SelectedItem = null;
                comboBoxDesign.SelectedItem = null;
                comboBoxVerstka.SelectedItem = null;
                comboBoxMarketing.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эту запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxSites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewDevelopment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDevelopment.SelectedItems.Count == 1)
            {
                Website_developmen website_Developmen = listViewDevelopment.SelectedItems[0].Tag as Website_developmen;
                comboBoxSites.SelectedIndex = comboBoxSites.FindString(website_Developmen.IdSites.ToString());
                comboBoxPrototip.SelectedIndex = comboBoxPrototip.FindString(website_Developmen.Prototip.ToString());
                comboBoxDesign.SelectedIndex = comboBoxDesign.FindString(website_Developmen.Design.ToString());
                comboBoxVerstka.SelectedIndex = comboBoxVerstka.FindString(website_Developmen.Verstka.ToString());
                comboBoxMarketing.SelectedIndex = comboBoxMarketing.FindString(website_Developmen.Marceting.ToString());
            }
            else
            {
                comboBoxSites.SelectedItem = null;
                comboBoxPrototip.SelectedItem = null;
                comboBoxDesign.SelectedItem = null;
                comboBoxVerstka.SelectedItem = null;
                comboBoxMarketing.SelectedItem = null;
            }
        }
    }
}
