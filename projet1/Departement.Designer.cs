namespace projet1
{
    partial class Departement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnmat = new Button();
            btnEns = new Button();
            panel2 = new Panel();
            btnR = new Button();
            btnexit = new Button();
            button3 = new Button();
            cmbMaterielL = new ComboBox();
            cmbEnseignants = new ComboBox();
            cmbMateriel = new ComboBox();
            btnAffecter = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            button2 = new Button();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            groupBox2 = new GroupBox();
            comboBox3 = new ComboBox();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 119, 18);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 50);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(929, 15);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 3;
            label1.Text = "Admin";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_user_48;
            pictureBox3.Location = new Point(867, 2);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_grid_40;
            pictureBox2.Location = new Point(1004, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.téléchargement__1_;
            pictureBox1.Location = new Point(23, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 119, 18);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.icons8_home_48;
            button1.Location = new Point(-110, 175);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(400, 47);
            button1.TabIndex = 6;
            button1.Text = "                                    Département";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnmat
            // 
            btnmat.BackColor = SystemColors.ControlLightLight;
            btnmat.Cursor = Cursors.Hand;
            btnmat.FlatAppearance.BorderSize = 0;
            btnmat.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnmat.FlatStyle = FlatStyle.Flat;
            btnmat.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmat.ForeColor = SystemColors.GrayText;
            btnmat.Image = Properties.Resources.icons8_teacher_64;
            btnmat.Location = new Point(-92, 22);
            btnmat.Margin = new Padding(3, 2, 3, 2);
            btnmat.Name = "btnmat";
            btnmat.Size = new Size(382, 47);
            btnmat.TabIndex = 5;
            btnmat.Text = "                                    Technicien";
            btnmat.UseVisualStyleBackColor = false;
            btnmat.Click += btnmat_Click;
            // 
            // btnEns
            // 
            btnEns.BackColor = SystemColors.ControlLightLight;
            btnEns.Cursor = Cursors.Hand;
            btnEns.FlatAppearance.BorderSize = 0;
            btnEns.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnEns.FlatStyle = FlatStyle.Flat;
            btnEns.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEns.ForeColor = SystemColors.GrayText;
            btnEns.Image = Properties.Resources.icons8_servers_group_50;
            btnEns.Location = new Point(-110, 99);
            btnEns.Margin = new Padding(3, 2, 3, 2);
            btnEns.Name = "btnEns";
            btnEns.Size = new Size(400, 47);
            btnEns.TabIndex = 3;
            btnEns.Text = "                                    Materiel";
            btnEns.UseVisualStyleBackColor = false;
            btnEns.Click += btnEns_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnR);
            panel2.Controls.Add(btnexit);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnmat);
            panel2.Controls.Add(btnEns);
            panel2.Location = new Point(0, 32);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 472);
            panel2.TabIndex = 5;
            // 
            // btnR
            // 
            btnR.BackColor = SystemColors.ControlLightLight;
            btnR.Cursor = Cursors.Hand;
            btnR.FlatAppearance.BorderSize = 0;
            btnR.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnR.FlatStyle = FlatStyle.Flat;
            btnR.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnR.ForeColor = SystemColors.GrayText;
            btnR.Image = Properties.Resources.icons8_return_24;
            btnR.ImageAlign = ContentAlignment.MiddleLeft;
            btnR.Location = new Point(19, 413);
            btnR.Margin = new Padding(3, 2, 3, 2);
            btnR.Name = "btnR";
            btnR.Size = new Size(95, 30);
            btnR.TabIndex = 9;
            btnR.Text = "    Retour";
            btnR.UseVisualStyleBackColor = false;
            btnR.Click += btnR_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = SystemColors.ControlLightLight;
            btnexit.Cursor = Cursors.Hand;
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnexit.ForeColor = SystemColors.GrayText;
            btnexit.Image = Properties.Resources.icons8_exit_48;
            btnexit.ImageAlign = ContentAlignment.MiddleLeft;
            btnexit.Location = new Point(164, 413);
            btnexit.Margin = new Padding(3, 2, 3, 2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(95, 30);
            btnexit.TabIndex = 8;
            btnexit.Text = "      Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(67, 116);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(132, 32);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // cmbMaterielL
            // 
            cmbMaterielL.FormattingEnabled = true;
            cmbMaterielL.Location = new Point(67, 32);
            cmbMaterielL.Margin = new Padding(3, 2, 3, 2);
            cmbMaterielL.Name = "cmbMaterielL";
            cmbMaterielL.Size = new Size(133, 23);
            cmbMaterielL.TabIndex = 4;
            // 
            // cmbEnseignants
            // 
            cmbEnseignants.FormattingEnabled = true;
            cmbEnseignants.Location = new Point(67, 68);
            cmbEnseignants.Margin = new Padding(3, 2, 3, 2);
            cmbEnseignants.Name = "cmbEnseignants";
            cmbEnseignants.Size = new Size(133, 23);
            cmbEnseignants.TabIndex = 2;
            // 
            // cmbMateriel
            // 
            cmbMateriel.FormattingEnabled = true;
            cmbMateriel.Location = new Point(67, 29);
            cmbMateriel.Margin = new Padding(3, 2, 3, 2);
            cmbMateriel.Name = "cmbMateriel";
            cmbMateriel.Size = new Size(133, 23);
            cmbMateriel.TabIndex = 1;
            // 
            // btnAffecter
            // 
            btnAffecter.Location = new Point(67, 110);
            btnAffecter.Margin = new Padding(3, 2, 3, 2);
            btnAffecter.Name = "btnAffecter";
            btnAffecter.Size = new Size(132, 35);
            btnAffecter.TabIndex = 3;
            btnAffecter.Text = "button1";
            btnAffecter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Location = new Point(750, 82);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(256, 142);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Affecter un matériel";
            // 
            // button4
            // 
            button4.Location = new Point(68, 96);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(132, 35);
            button4.TabIndex = 3;
            button4.Text = "Affecter";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(67, 29);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(67, 60);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(315, 72);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(412, 384);
            dataGridView1.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(comboBox5);
            groupBox3.Location = new Point(750, 228);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(256, 126);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Affecter un technicien";
            // 
            // button2
            // 
            button2.Location = new Point(68, 74);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(132, 35);
            button2.TabIndex = 3;
            button2.Text = "Affecter";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(67, 20);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(133, 23);
            comboBox4.TabIndex = 1;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(67, 47);
            comboBox5.Margin = new Padding(3, 2, 3, 2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(133, 23);
            comboBox5.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(button5);
            groupBox2.Location = new Point(750, 358);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(256, 96);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Liberer un materiél";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(67, 32);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(133, 23);
            comboBox3.TabIndex = 4;
            // 
            // button5
            // 
            button5.Location = new Point(68, 59);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(132, 32);
            button5.TabIndex = 6;
            button5.Text = "Liberer";
            button5.UseVisualStyleBackColor = true;
            // 
            // Departement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 486);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Departement";
            Text = "Demande";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btnmat;
        private Button btnEns;
        private Panel panel2;
        private Button btnR;
        private Button btnexit;
        private Button button3;
        private ComboBox cmbMaterielL;
        private ComboBox cmbEnseignants;
        private ComboBox cmbMateriel;
        private Button btnAffecter;
        private GroupBox groupBox1;
        private Button button4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button button2;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private GroupBox groupBox2;
        private ComboBox comboBox3;
        private Button button5;
    }
}