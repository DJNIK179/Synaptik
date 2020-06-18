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
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
        }

        void ShowEmployees()
        {
            listViewEmployees.Items.Clear();
            foreach (Employees employees in Program.Sinaptik.Employees)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    employees.Id.ToString() , employees.FirstName, employees.MiddleName, employees.LastName, employees.Phone, employees.Post
                });
                item.Tag = employees;
                listViewEmployees.Items.Add(item);
            }
            listViewEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            employees.FirstName = textBoxFirstName.Text;
            employees.MiddleName = textBoxMiddleName.Text;
            employees.LastName = textBoxLastName.Text;
            employees.Phone = textBoxPhone.Text;
            employees.Post = textBoxPost.Text;
            Program.Sinaptik.Employees.Add(employees);
            Program.Sinaptik.SaveChanges();
            ShowEmployees();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count == 1)
            {
                Employees employees = listViewEmployees.SelectedItems[0].Tag as Employees;
                employees.FirstName = textBoxFirstName.Text;
                employees.MiddleName = textBoxMiddleName.Text;
                employees.LastName = textBoxLastName.Text;
                employees.Phone = textBoxPhone.Text;
                employees.Post = textBoxPost.Text;
                Program.Sinaptik.SaveChanges();
                ShowEmployees();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewEmployees.SelectedItems.Count == 1)
                {
                    Employees employees = listViewEmployees.SelectedItems[0].Tag as Employees;
                    Program.Sinaptik.Employees.Remove(employees);
                    Program.Sinaptik.SaveChanges();
                    ShowEmployees();
                }

                textBoxFirstName.Text = " ";
                textBoxMiddleName.Text = " ";
                textBoxLastName.Text = " ";
                textBoxPhone.Text = " ";
                textBoxPost.Text = " ";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эту запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count == 1)
            {
                Employees employees = listViewEmployees.SelectedItems[0].Tag as Employees;
                textBoxFirstName.Text = employees.FirstName;
                textBoxMiddleName.Text = employees.MiddleName;
                textBoxLastName.Text = employees.LastName;
                textBoxPhone.Text = employees.Phone;
                textBoxPost.Text = employees.Post;
            }
            else
            {
                textBoxFirstName.Text = " ";
                textBoxMiddleName.Text = " ";
                textBoxLastName.Text = " ";
                textBoxPhone.Text = " ";
                textBoxPost.Text = " ";
            }
        }
    }
}
