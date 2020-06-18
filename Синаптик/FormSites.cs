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
    public partial class FormSites : Form
    {
        public FormSites()
        {
            InitializeComponent();
            ShowSites();
            comboBoxType.SelectedIndex = 0;
        }

        void ShowSites()
        {
            listViewMultipage.Items.Clear();
            listViewLend.Items.Clear();

            foreach (Sites sites in Program.Sinaptik.Sites)
            {
                if (sites.Type == 0.ToString())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        sites.Id.ToString(), sites.Name, "Многостраничный", sites.Pages.ToString()
                    });

                    item.Tag = sites;

                    listViewMultipage.Items.Add(item);
                }
                else if (sites.Type == 1.ToString())
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        sites.Id.ToString(), sites.Name, "Лендинг", sites.Units.ToString()
                    });

                    item.Tag = sites;

                    listViewLend.Items.Add(item);
                }
            }

            listViewMultipage.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewLend.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Sites sites = new Sites();
            sites.Name = textBoxName.Text;

            if (comboBoxType.SelectedIndex == 0)
            {
                sites.Type = 0.ToString();
                if (textBoxMulti.Text != " ") { sites.Pages = Convert.ToString(textBoxMulti.Text); }
                sites.Pages = Convert.ToString(textBoxMulti.Text);
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                sites.Type = 1.ToString();
                if (textBoxLend.Text != " ") { sites.Units = Convert.ToString(textBoxLend.Text); }
            }
            Program.Sinaptik.Sites.Add(sites);
            Program.Sinaptik.SaveChanges();
            ShowSites();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                if (listViewMultipage.SelectedItems.Count == 1)
                {
                    Sites sites = listViewMultipage.SelectedItems[0].Tag as Sites;
                    sites.Name = textBoxName.Text;
                    sites.Pages = Convert.ToString(textBoxMulti.Text);   

                    Program.Sinaptik.SaveChanges();
                    ShowSites();
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                if (listViewLend.SelectedItems.Count == 1)
                {
                    Sites sites = listViewLend.SelectedItems[0].Tag as Sites;
                    sites.Name = textBoxName.Text;
                    sites.Units = Convert.ToString(textBoxLend.Text);

                    Program.Sinaptik.SaveChanges();
                    ShowSites();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewMultipage.SelectedItems.Count == 1)
                    {
                        Sites sites = listViewMultipage.SelectedItems[0].Tag as Sites;
                        Program.Sinaptik.Sites.Remove(sites);
                        Program.Sinaptik.SaveChanges();
                        ShowSites();
                    }
                    textBoxName.Text = " ";
                    textBoxMulti.Text = " ";
                    textBoxLend.Text = " ";
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewLend.SelectedItems.Count == 1)
                    {
                        Sites sites = listViewLend.SelectedItems[0].Tag as Sites;
                        Program.Sinaptik.Sites.Remove(sites);
                        Program.Sinaptik.SaveChanges();
                        ShowSites();
                    }

                    textBoxName.Text = " ";
                    textBoxMulti.Text = " ";
                    textBoxLend.Text = " ";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewMultipage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMultipage.SelectedItems.Count == 1)
            {
                Sites sites = listViewMultipage.SelectedItems[0].Tag as Sites;
                textBoxName.Text = sites.Name;
                textBoxMulti.Text = sites.Pages.ToString();
            }
            else
            {
                textBoxName.Text = " ";
                textBoxMulti.Text = " ";
            }
        }

        private void listViewLend_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLend.SelectedItems.Count == 1)
            {
                Sites sites = listViewLend.SelectedItems[0].Tag as Sites;
                textBoxName.Text = sites.Name;
                textBoxLend.Text = sites.Units.ToString();
            }
            else
            {
                textBoxName.Text = " ";
                textBoxLend.Text = " ";
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewMultipage.Visible = true;
                labelName.Visible = true;
                textBoxName.Visible = true;
                labelType.Visible = true;
                comboBoxType.Visible = true;
                labelMulti.Visible = true;
                textBoxMulti.Visible = true;

                listViewLend.Visible = false;
                labelLend.Visible = false;
                textBoxLend.Visible = false;

                
                textBoxName.Text = " ";
                comboBoxType.Text = " ";
                textBoxMulti.Text = " ";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewLend.Visible = true;
                labelName.Visible = true;
                textBoxName.Visible = true;
                labelType.Visible = true;
                comboBoxType.Visible = true;
                labelLend.Visible = true;
                textBoxLend.Visible = true;

                listViewMultipage.Visible = false;
                labelMulti.Visible = false;
                textBoxMulti.Visible = false;

                
                textBoxName.Text = " ";
                comboBoxType.Text = " ";
                textBoxLend.Text = " ";
            }
        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelMulti_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
