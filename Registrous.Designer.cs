﻿namespace gestor_de_rh01
{
    partial class Registrous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrous));
            label6 = new Label();
            panel6 = new Panel();
            comboBoxnvadm = new ComboBox();
            btnborrar = new Button();
            Btnguardar = new Button();
            label8 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            usuario = new TextBox();
            label1 = new Label();
            dgvGestor = new DataGridView();
            MenuVertical = new Panel();
            button7 = new Button();
            button4 = new Button();
            panel5 = new Panel();
            panel9 = new Panel();
            button5 = new Button();
            panel4 = new Panel();
            button6 = new Button();
            panel3 = new Panel();
            button8 = new Button();
            panel2 = new Panel();
            button9 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestor).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(113, 9);
            label6.Name = "label6";
            label6.Size = new Size(462, 59);
            label6.TabIndex = 12;
            label6.Text = "Registro Usuario";
            // 
            // panel6
            // 
            panel6.Controls.Add(comboBoxnvadm);
            panel6.Controls.Add(btnborrar);
            panel6.Controls.Add(Btnguardar);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(textBox2);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(usuario);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(113, 94);
            panel6.Name = "panel6";
            panel6.Size = new Size(714, 252);
            panel6.TabIndex = 11;
            // 
            // comboBoxnvadm
            // 
            comboBoxnvadm.FormattingEnabled = true;
            comboBoxnvadm.Items.AddRange(new object[] { "ANALISTA RRHH", "ENCARGADO EV DESEMPE;O", "SECRETARIA EJECUTIVA", "DIGITADOR" });
            comboBoxnvadm.Location = new Point(324, 66);
            comboBoxnvadm.Name = "comboBoxnvadm";
            comboBoxnvadm.Size = new Size(197, 28);
            comboBoxnvadm.TabIndex = 25;
            // 
            // btnborrar
            // 
            btnborrar.Location = new Point(324, 140);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(117, 49);
            btnborrar.TabIndex = 8;
            btnborrar.Text = "Cancelar";
            btnborrar.UseVisualStyleBackColor = true;
            btnborrar.Click += btnborrar_Click;
            // 
            // Btnguardar
            // 
            Btnguardar.Location = new Point(461, 140);
            Btnguardar.Name = "Btnguardar";
            Btnguardar.Size = new Size(117, 49);
            Btnguardar.TabIndex = 5;
            Btnguardar.Text = "Guardar";
            Btnguardar.UseVisualStyleBackColor = true;
            Btnguardar.Click += Btnguardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.Location = new Point(326, 40);
            label8.Name = "label8";
            label8.Size = new Size(195, 23);
            label8.TabIndex = 14;
            label8.Text = "Nivel de administrador";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 27);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(41, 125);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // usuario
            // 
            usuario.Location = new Point(41, 66);
            usuario.Name = "usuario";
            usuario.Size = new Size(202, 27);
            usuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(41, 40);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Usuario";
            // 
            // dgvGestor
            // 
            dgvGestor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestor.Location = new Point(113, 365);
            dgvGestor.Name = "dgvGestor";
            dgvGestor.RowHeadersWidth = 51;
            dgvGestor.Size = new Size(714, 250);
            dgvGestor.TabIndex = 13;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(139, 195, 140);
            MenuVertical.Controls.Add(button7);
            MenuVertical.Controls.Add(button4);
            MenuVertical.Controls.Add(panel5);
            MenuVertical.Controls.Add(panel9);
            MenuVertical.Controls.Add(button5);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(button6);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(button8);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(button9);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4, 5, 4, 5);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(70, 610);
            MenuVertical.TabIndex = 19;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(0, 64, 0);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(6, 438);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(64, 49);
            button7.TabIndex = 23;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 64, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(6, 382);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(64, 49);
            button4.TabIndex = 21;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.GreenYellow;
            panel5.Location = new Point(0, 385);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(7, 43);
            panel5.TabIndex = 20;
            // 
            // panel9
            // 
            panel9.BackColor = Color.GreenYellow;
            panel9.Location = new Point(0, 438);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 51);
            panel9.TabIndex = 18;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 64, 0);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(5, 206);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(66, 49);
            button5.TabIndex = 9;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.GreenYellow;
            panel4.Location = new Point(0, 323);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(7, 49);
            panel4.TabIndex = 8;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(0, 64, 0);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(5, 324);
            button6.Margin = new Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new Size(65, 49);
            button6.TabIndex = 7;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.GreenYellow;
            panel3.Location = new Point(0, 265);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(7, 49);
            panel3.TabIndex = 6;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(0, 64, 0);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(5, 139);
            button8.Margin = new Padding(4, 5, 4, 5);
            button8.Name = "button8";
            button8.Size = new Size(65, 49);
            button8.TabIndex = 5;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.GreenYellow;
            panel2.Location = new Point(0, 139);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(7, 49);
            panel2.TabIndex = 4;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(0, 64, 0);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(5, 265);
            button9.Margin = new Padding(4, 5, 4, 5);
            button9.Name = "button9";
            button9.Size = new Size(61, 49);
            button9.TabIndex = 3;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GreenYellow;
            panel1.Location = new Point(0, 206);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 49);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 32);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Registrous
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 610);
            Controls.Add(MenuVertical);
            Controls.Add(dgvGestor);
            Controls.Add(label6);
            Controls.Add(panel6);
            Name = "Registrous";
            Text = "Registrous";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestor).EndInit();
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Panel panel6;
        private Button btnborrar;
        private Button Btnguardar;
        private TextBox textBox2;
        private Label label2;
        private TextBox usuario;
        private Label label1;
        private DataGridView dgvGestor;
        private Panel MenuVertical;
        private Button button7;
        private Button button4;
        private Panel panel5;
        private Panel panel9;
        private Button button5;
        private Panel panel4;
        private Button button6;
        private Panel panel3;
        private Button button8;
        private Panel panel2;
        private Button button9;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox comboBoxnvadm;
        private Label label8;
    }
}