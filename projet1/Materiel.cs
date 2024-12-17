using System;
using System.Windows.Forms;

namespace projet1
{
    public partial class Materiel : Form
    {
        public Materiel()
        {
            InitializeComponent();
        }

        private void Materiel_Load(object sender, EventArgs e)
        {
            // Configure the ListView to display Type, Reference, and Department
            listView1.View = View.Details;
            listView1.Columns.Add("Type", 150, HorizontalAlignment.Left);       // Type column
            listView1.Columns.Add("Reference", 150, HorizontalAlignment.Left);  // Reference column
            listView1.Columns.Add("Department", 150, HorizontalAlignment.Left); // Department column

            // Add some example items to the ListView
            listView1.Items.Add(new ListViewItem(new string[] { "Laptop", "L123", "IT" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Desktop", "D456", "Finance" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Printer", "P789", "HR" }));

            // Adding Labels outside ListView for descriptions (if needed)
            Label typeLabel = new Label() { Text = "Material Type", Location = new Point(20, 20), AutoSize = true };
            Label refLabel = new Label() { Text = "Reference", Location = new Point(170, 20), AutoSize = true };
            Label deptLabel = new Label() { Text = "Department", Location = new Point(270, 20), AutoSize = true };

            // Adding the labels to the form
            Controls.Add(typeLabel);
            Controls.Add(refLabel);
            Controls.Add(deptLabel);

            // Adjust ListView position to appear below the labels
            listView1.Location = new Point(20, 50);  // Positioning ListView below labels
            listView1.Size = new Size(460, 200);     // Adjust size as needed
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // Handle the button click event for exit (if any specific logic is needed)
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmat_Click(object sender, EventArgs e)
        {
            Technicien cl = new Technicien();
            cl.Show();
            this.Hide();
        }

        private void btndem_Click(object sender, EventArgs e)
        {
            Departement cl = new Departement();
            cl.Show();
            this.Hide();
        }

        private void btnRe_Click(object sender, EventArgs e)
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
                string selectedType = selectedItem.Text;
                string selectedReference = selectedItem.SubItems[1].Text;
                string selectedDepartment = selectedItem.SubItems[2].Text;

                // You can use this data to display in another area or modify as needed
                MessageBox.Show($"Selected Material: {selectedType}\nReference: {selectedReference}\nDepartment: {selectedDepartment}",
                                "Material Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Please select a material to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                string newType = InputPrompt.ShowDialog("Edit Type:", "Edit Material", selectedItem.Text);
                string newReference = InputPrompt.ShowDialog("Edit Reference:", "Edit Material", selectedItem.SubItems[1].Text);
                string newDepartment = InputPrompt.ShowDialog("Edit Department:", "Edit Material", selectedItem.SubItems[2].Text);

                if (!string.IsNullOrWhiteSpace(newType) && !string.IsNullOrWhiteSpace(newReference) && !string.IsNullOrWhiteSpace(newDepartment))
                {
                    selectedItem.Text = newType;
                    selectedItem.SubItems[1].Text = newReference;
                    selectedItem.SubItems[2].Text = newDepartment;
                }
                else
                {
                    MessageBox.Show("All fields (Type, Reference, Department) are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a material to edit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string type = InputPrompt.ShowDialog("Enter Type:", "Add Material");
            string reference = InputPrompt.ShowDialog("Enter Reference:", "Add Material");

            if (!string.IsNullOrWhiteSpace(type) && !string.IsNullOrWhiteSpace(reference))
            {
                // Create a new ListViewItem with placeholders for Department
                ListViewItem item = new ListViewItem(type);
                item.SubItems.Add(reference);
                item.SubItems.Add(""); // Blank for Department
                listView1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Both Type and Reference are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public static class InputPrompt
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
