﻿namespace gestor_de_rh01
{
    partial class Lista_de_compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_de_compra));
            label1 = new Label();
            textnombart = new TextBox();
            txtcateg = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textnomact = new TextBox();
            label4 = new Label();
            guar = new Button();
            borr = new Button();
            button3 = new Button();
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
            dateTimePicker1 = new DateTimePicker();
            panel6 = new Panel();
            Textcantidad1 = new TextBox();
            impr = new Button();
            label5 = new Label();
            textlugd = new TextBox();
            label6 = new Label();
            dgvGestor = new DataGridView();
            gpanel1 = new Class.gpanel();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.Location = new Point(13, 215);
            label1.Name = "label1";
            label1.Size = new Size(170, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Articulo";
            // 
            // textnombart
            // 
            textnombart.Location = new Point(13, 252);
            textnombart.Name = "textnombart";
            textnombart.Size = new Size(178, 27);
            textnombart.TabIndex = 1;
            // 
            // txtcateg
            // 
            txtcateg.FormattingEnabled = true;
            txtcateg.Items.AddRange(new object[] { "FDA", "UND", "LB" });
            txtcateg.Location = new Point(328, 252);
            txtcateg.Name = "txtcateg";
            txtcateg.Size = new Size(151, 28);
            txtcateg.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(203, 215);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 4;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(328, 215);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 6;
            label3.Text = "Categoria";
            // 
            // textnomact
            // 
            textnomact.Location = new Point(15, 94);
            textnomact.Name = "textnomact";
            textnomact.Size = new Size(416, 27);
            textnomact.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(15, 62);
            label4.Name = "label4";
            label4.Size = new Size(199, 23);
            label4.TabIndex = 8;
            label4.Text = "Nombre de la actividad";
            // 
            // guar
            // 
            guar.Location = new Point(13, 302);
            guar.Name = "guar";
            guar.Size = new Size(111, 55);
            guar.TabIndex = 10;
            guar.Text = "Guardar";
            guar.UseVisualStyleBackColor = true;
            guar.Click += guar_Click;
            // 
            // borr
            // 
            borr.Location = new Point(364, 302);
            borr.Name = "borr";
            borr.Size = new Size(111, 55);
            borr.TabIndex = 11;
            borr.Text = "Borrar";
            borr.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(247, 302);
            button3.Name = "button3";
            button3.Size = new Size(111, 55);
            button3.TabIndex = 12;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
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
            MenuVertical.Size = new Size(70, 712);
            MenuVertical.TabIndex = 13;
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
            button7.Size = new Size(60, 49);
            button7.TabIndex = 23;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
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
            button4.Size = new Size(59, 49);
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
            button5.Location = new Point(4, 206);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(61, 49);
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
            button6.Size = new Size(61, 49);
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
            button8.Size = new Size(61, 49);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(378, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(Textcantidad1);
            panel6.Controls.Add(impr);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(textlugd);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(dateTimePicker1);
            panel6.Controls.Add(guar);
            panel6.Controls.Add(borr);
            panel6.Controls.Add(textnomact);
            panel6.Controls.Add(txtcateg);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(textnombart);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(91, 32);
            panel6.Name = "panel6";
            panel6.Size = new Size(691, 377);
            panel6.TabIndex = 15;
            // 
            // Textcantidad1
            // 
            Textcantidad1.Location = new Point(203, 252);
            Textcantidad1.Name = "Textcantidad1";
            Textcantidad1.Size = new Size(102, 27);
            Textcantidad1.TabIndex = 19;
            // 
            // impr
            // 
            impr.Location = new Point(130, 302);
            impr.Name = "impr";
            impr.Size = new Size(111, 55);
            impr.TabIndex = 18;
            impr.Text = "Imprimir";
            impr.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(13, 146);
            label5.Name = "label5";
            label5.Size = new Size(199, 23);
            label5.TabIndex = 16;
            label5.Text = "Lugar donde se compra";
            // 
            // textlugd
            // 
            textlugd.Location = new Point(13, 174);
            textlugd.Name = "textlugd";
            textlugd.Size = new Size(305, 27);
            textlugd.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 11);
            label6.Name = "label6";
            label6.Size = new Size(315, 37);
            label6.TabIndex = 15;
            label6.Text = "Listado de compra";
            // 
            // dgvGestor
            // 
            dgvGestor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestor.Location = new Point(91, 415);
            dgvGestor.Name = "dgvGestor";
            dgvGestor.RowHeadersWidth = 51;
            dgvGestor.Size = new Size(691, 260);
            dgvGestor.TabIndex = 16;
            // 
            // gpanel1
            // 
            gpanel1.ColorBottom = Color.Cornsilk;
            gpanel1.ColorTop = Color.LightGreen;
            gpanel1.Location = new Point(0, 0);
            gpanel1.Name = "gpanel1";
            gpanel1.Size = new Size(833, 709);
            gpanel1.TabIndex = 20;
            // 
            // Lista_de_compra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 712);
            Controls.Add(dgvGestor);
            Controls.Add(panel6);
            Controls.Add(MenuVertical);
            Controls.Add(gpanel1);
            Name = "Lista_de_compra";
            Text = "Lista_de_compra";
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textnombart;
        private ComboBox txtcateg;
        private Label label2;
        private Label label3;
        private TextBox textnomact;
        private Label label4;
        private Button guar;
        private Button borr;
        private Button button3;
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
        private DateTimePicker dateTimePicker1;
        private Panel panel6;
        private Label label6;
        private Button impr;
        private Label label5;
        private TextBox textlugd;
        private DataGridView dgvGestor;
        private TextBox Textcantidad1;
        private Class.gpanel gpanel1;
    }
}