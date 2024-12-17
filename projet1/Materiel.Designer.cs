namespace projet1
{
    partial class Materiel
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
            btndem = new Button();
            btnmat = new Button();
            button2 = new Button();
            panel2 = new Panel();
            btnRe = new Button();
            btnexit = new Button();
            listView1 = new ListView();
            Add = new Button();
            Edit = new Button();
            delete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.ForeColor = Color.FromArgb(227, 119, 18);
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
            pictureBox2.Location = new Point(998, 2);
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
            // btndem
            // 
            btndem.BackColor = SystemColors.ControlLightLight;
            btndem.Cursor = Cursors.Hand;
            btndem.FlatAppearance.BorderSize = 0;
            btndem.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btndem.FlatStyle = FlatStyle.Flat;
            btndem.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndem.ForeColor = SystemColors.GrayText;
            btndem.Image = Properties.Resources.icons8_home_48;
            btndem.Location = new Point(-110, 175);
            btndem.Margin = new Padding(3, 2, 3, 2);
            btndem.Name = "btndem";
            btndem.Size = new Size(400, 47);
            btndem.TabIndex = 6;
            btndem.Text = "                                      Département";
            btndem.UseVisualStyleBackColor = false;
            btndem.Click += btndem_Click;
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
            btnmat.Text = "                                        Technicien";
            btnmat.UseVisualStyleBackColor = false;
            btnmat.Click += btnmat_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(227, 119, 18);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.icons8_servers_group_50;
            button2.Location = new Point(-110, 99);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(400, 47);
            button2.TabIndex = 3;
            button2.Text = "                                    Materiel";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnRe);
            panel2.Controls.Add(btnexit);
            panel2.Controls.Add(btndem);
            panel2.Controls.Add(btnmat);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(0, 32);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 472);
            panel2.TabIndex = 5;
            // 
            // btnRe
            // 
            btnRe.BackColor = SystemColors.ControlLightLight;
            btnRe.Cursor = Cursors.Hand;
            btnRe.FlatAppearance.BorderSize = 0;
            btnRe.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnRe.FlatStyle = FlatStyle.Flat;
            btnRe.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRe.ForeColor = SystemColors.GrayText;
            btnRe.Image = Properties.Resources.icons8_return_24;
            btnRe.ImageAlign = ContentAlignment.MiddleLeft;
            btnRe.Location = new Point(23, 408);
            btnRe.Margin = new Padding(3, 2, 3, 2);
            btnRe.Name = "btnRe";
            btnRe.Size = new Size(95, 35);
            btnRe.TabIndex = 9;
            btnRe.Text = "    Retour";
            btnRe.UseVisualStyleBackColor = false;
            btnRe.Click += btnRe_Click;
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
            btnexit.Location = new Point(167, 408);
            btnexit.Margin = new Padding(3, 2, 3, 2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(95, 35);
            btnexit.TabIndex = 8;
            btnexit.Text = "       Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click_1;
            // 
            // listView1
            // 
            listView1.Location = new Point(300, 55);
            listView1.Name = "listView1";
            listView1.Size = new Size(735, 369);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Add
            // 
            Add.ForeColor = Color.Black;
            Add.Location = new Point(641, 430);
            Add.Name = "Add";
            Add.Size = new Size(126, 29);
            Add.TabIndex = 11;
            Add.Text = "Ajouter";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Edit
            // 
            Edit.ForeColor = Color.Black;
            Edit.Location = new Point(773, 430);
            Edit.Name = "Edit";
            Edit.Size = new Size(126, 29);
            Edit.TabIndex = 10;
            Edit.Text = "Modifier";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // delete
            // 
            delete.ForeColor = Color.Black;
            delete.Location = new Point(905, 430);
            delete.Name = "delete";
            delete.Size = new Size(126, 29);
            delete.TabIndex = 9;
            delete.Text = "Supprimer";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Materiel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 486);
            Controls.Add(listView1);
            Controls.Add(Add);
            Controls.Add(Edit);
            Controls.Add(delete);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.Crimson;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Materiel";
            Text = "Enseignant";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btndem;
        private Button btnmat;
        private Button button2;
        private Panel panel2;
        private Button btnRe;
        private Button btnexit;
        private ListView listView1;
        private Button Add;
        private Button Edit;
        private Button delete;
    }
}