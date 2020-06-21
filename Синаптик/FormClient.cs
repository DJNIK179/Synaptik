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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (Client client in Program.Sinaptik.Client)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    client.Id.ToString() , client.FirstName, client.MiddleName, client.LastName, client.Phone, client.Email
                });
                item.Tag = client;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.FirstName = textBoxFirstName.Text;
            client.MiddleName = textBoxMiddleName.Text;
            client.LastName = textBoxLastName.Text;
            client.Phone = textBoxPhone.Text;
            client.Email = textBoxEmail.Text;
            Program.Sinaptik.Client.Add(client);
            Program.Sinaptik.SaveChanges();
            ShowClient();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Client client = listViewClient.SelectedItems[0].Tag as Client;
                client.FirstName = textBoxFirstName.Text;
                client.MiddleName = textBoxMiddleName.Text;
                client.LastName = textBoxLastName.Text;
                client.Phone = textBoxPhone.Text;
                client.Email = textBoxEmail.Text;
                Program.Sinaptik.SaveChanges();
                ShowClient();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClient.SelectedItems.Count == 1)
                {
                    Client client = listViewClient.SelectedItems[0].Tag as Client;
                    Program.Sinaptik.Client.Remove(client);
                    Program.Sinaptik.SaveChanges();
                    ShowClient();
                }

                textBoxFirstName.Text = " ";
                textBoxMiddleName.Text = " ";
                textBoxLastName.Text = " ";
                textBoxPhone.Text = " ";
                textBoxEmail.Text = " ";
            }
            catch
            {
                textBoxFirstName.Text = " ";
                textBoxMiddleName.Text = " ";
                textBoxLastName.Text = " ";
                textBoxPhone.Text = " ";
                textBoxEmail.Text = " ";
            }
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 1)
            {
                Client client = listViewClient.SelectedItems[0].Tag as Client;
                textBoxFirstName.Text = client.FirstName;
                textBoxMiddleName.Text = client.MiddleName;
                textBoxLastName.Text = client.LastName;
                textBoxPhone.Text = client.Phone;
                textBoxEmail.Text = client.Email;
            }
            else
            {
                textBoxFirstName.Text = " ";
                textBoxMiddleName.Text = " ";
                textBoxLastName.Text = " ";
                textBoxPhone.Text = " ";
                textBoxEmail.Text = " ";
            }
        }
    }
}
