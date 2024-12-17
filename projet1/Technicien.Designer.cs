namespace projet1
{
    partial class Technicien
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            btnEns = new Button();
            panel2 = new Panel();
            btnR = new Button();
            btnexit = new Button();
            btnDEm = new Button();
            delete = new Button();
            Edit = new Button();
            Add = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(1063, 50);
            panel1.TabIndex = 2;
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
            // button4
            // 
            button4.BackColor = Color.FromArgb(227, 119, 18);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.icons8_teacher_64;
            button4.Location = new Point(-92, 22);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(382, 47);
            button4.TabIndex = 5;
            button4.Text = "                                       Technicien";
            button4.UseVisualStyleBackColor = false;
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
            panel2.Controls.Add(btnDEm);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnEns);
            panel2.Location = new Point(0, 50);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 472);
            panel2.TabIndex = 3;
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
            btnR.Location = new Point(23, 428);
            btnR.Margin = new Padding(3, 2, 3, 2);
            btnR.Name = "btnR";
            btnR.Size = new Size(95, 32);
            btnR.TabIndex = 7;
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
            btnexit.Location = new Point(167, 428);
            btnexit.Margin = new Padding(3, 2, 3, 2);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(95, 32);
            btnexit.TabIndex = 4;
            btnexit.Text = "      Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // btnDEm
            // 
            btnDEm.BackColor = SystemColors.ControlLightLight;
            btnDEm.Cursor = Cursors.Hand;
            btnDEm.FlatAppearance.BorderSize = 0;
            btnDEm.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnDEm.FlatStyle = FlatStyle.Flat;
            btnDEm.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDEm.ForeColor = SystemColors.GrayText;
            btnDEm.Image = Properties.Resources.icons8_home_48;
            btnDEm.Location = new Point(-110, 175);
            btnDEm.Margin = new Padding(3, 2, 3, 2);
            btnDEm.Name = "btnDEm";
            btnDEm.Size = new Size(400, 47);
            btnDEm.TabIndex = 6;
            btnDEm.Text = "                                     Departement";
            btnDEm.UseVisualStyleBackColor = false;
            btnDEm.Click += btnDEm_Click;
            // 
            // delete
            // 
            delete.Location = new Point(910, 442);
            delete.Name = "delete";
            delete.Size = new Size(126, 29);
            delete.TabIndex = 5;
            delete.Text = "Supprimer";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(778, 442);
            Edit.Name = "Edit";
            Edit.Size = new Size(126, 29);
            Edit.TabIndex = 6;
            Edit.Text = "Modifier";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Add
            // 
            Add.Location = new Point(646, 442);
            Add.Name = "Add";
            Add.Size = new Size(126, 29);
            Add.TabIndex = 7;
            Add.Text = "Ajouter";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(305, 67);
            listView1.Name = "listView1";
            listView1.Size = new Size(735, 369);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Technicien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 521);
            Controls.Add(listView1);
            Controls.Add(Add);
            Controls.Add(Edit);
            Controls.Add(delete);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Technicien";
            Text = "Materiel";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button4;
        private Button btnEns;
        private Panel panel2;
        private Button btnDEm;
        private Button btnexit;
        private Button btnR;
        private Button delete;
        private Button Edit;
        private Button Add;
        private ListView listView1;
    }
}