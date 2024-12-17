namespace projet1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMateriel_Click(object sender, EventArgs e)
        {
            Technicien cl = new Technicien(); cl.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEns_Click(object sender, EventArgs e)
        {
            Materiel cl = new Materiel(); cl.Show();
            this.Hide();
        }

        private void btndem_Click(object sender, EventArgs e)
        {
            Departement cl = new Departement(); cl.Show();
            this.Hide();
        }
    }
}
