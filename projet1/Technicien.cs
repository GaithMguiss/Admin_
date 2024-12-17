using System;
using System.Windows.Forms;

namespace projet1
{
    public partial class Technicien : Form
    {
        public Technicien()
        {
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEns_Click(object sender, EventArgs e)
        {
            Materiel cl = new Materiel();
            cl.Show();
            this.Hide();
        }

        private void btnDEm_Click(object sender, EventArgs e)
        {
            Departement cl = new Departement();
            cl.Show();
            this.Hide();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            Form1 cl = new Form1();
            cl.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder for future functionality when a list item is selected
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string selectedName = selectedItem.Text;
                string selectedId = selectedItem.SubItems[1].Text;
                string selectedDepartment = selectedItem.SubItems[2].Text;

                // You can use this data to display in another area or modify as needed
                MessageBox.Show($"Selected Technician: {selectedName}\nID: {selectedId}\nDepartment: {selectedDepartment}",
                                "Technician Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = Prompt.ShowDialog("Enter Name:", "Add Technicien");
            string id = Prompt.ShowDialog("Enter ID:", "Add Technicien");

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(id))
            {
                // Create a new ListViewItem with placeholders for Department
                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add(id);
                item.SubItems.Add(""); // Blank for Department
                listView1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Both Name and ID are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string newName = Prompt.ShowDialog("Edit Name:", "Edit Technicien", selectedItem.Text);
                string newId = Prompt.ShowDialog("Edit ID:", "Edit Technicien", selectedItem.SubItems[1].Text);
                string newDepartment = Prompt.ShowDialog("Edit Department:", "Edit Technicien", selectedItem.SubItems[2].Text);

                if (!string.IsNullOrWhiteSpace(newName) && !string.IsNullOrWhiteSpace(newId) && !string.IsNullOrWhiteSpace(newDepartment))
                {
                    selectedItem.Text = newName;
                    selectedItem.SubItems[1].Text = newId;
                    selectedItem.SubItems[2].Text = newDepartment;
                }
                else
                {
                    MessageBox.Show("All fields (Name, ID, Department) are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a technicien to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Please select a technicien to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption, string defaultValue = "")
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 350, Text = defaultValue };
            Button confirmation = new Button() { Text = "OK", Left = 250, Width = 100, Top = 100, DialogResult = DialogResult.OK };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
        }
    }
}
