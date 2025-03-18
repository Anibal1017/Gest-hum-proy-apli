namespace gestor_de_rh01
{
    partial class Certificado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Certificado));
            panel6 = new Panel();
            FechatextBox = new MaskedTextBox();
            label9 = new Label();
            aserv = new TextBox();
            cedulatextBox = new MaskedTextBox();
            btnguardardoc = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label8 = new Label();
            SubtextBox = new TextBox();
            label7 = new Label();
            ltrabtextBox = new TextBox();
            label5 = new Label();
            CargotextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnimprimir = new Button();
            button3 = new Button();
            btnborrar = new Button();
            nombretextBox = new TextBox();
            label4 = new Label();
            label6 = new Label();
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
            gpanel1 = new Class.gpanel();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestor).BeginInit();
            MenuVertical.SuspendLayout();
            gpanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGreen;
            panel6.Controls.Add(FechatextBox);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(aserv);
            panel6.Controls.Add(cedulatextBox);
            panel6.Controls.Add(btnguardardoc);
            panel6.Controls.Add(maskedTextBox1);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(SubtextBox);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(ltrabtextBox);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(CargotextBox);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(btnimprimir);
            panel6.Controls.Add(button3);
            panel6.Controls.Add(btnborrar);
            panel6.Controls.Add(nombretextBox);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(87, 72);
            panel6.Name = "panel6";
            panel6.Size = new Size(936, 392);
            panel6.TabIndex = 16;
            // 
            // FechatextBox
            // 
            FechatextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FechatextBox.Location = new Point(283, 82);
            FechatextBox.Mask = "00/00/0000";
            FechatextBox.Name = "FechatextBox";
            FechatextBox.Size = new Size(222, 34);
            FechatextBox.TabIndex = 36;
            FechatextBox.ValidatingType = typeof(DateTime);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            label9.Location = new Point(564, 134);
            label9.Name = "label9";
            label9.Size = new Size(212, 26);
            label9.TabIndex = 35;
            label9.Text = "Años de Servicios";
            // 
            // aserv
            // 
            aserv.Font = new Font("Segoe UI", 12F);
            aserv.Location = new Point(583, 165);
            aserv.Name = "aserv";
            aserv.Size = new Size(101, 34);
            aserv.TabIndex = 34;
            // 
            // cedulatextBox
            // 
            cedulatextBox.Font = new Font("Segoe UI", 12F);
            cedulatextBox.Location = new Point(3, 165);
            cedulatextBox.Mask = "000-0000000-0";
            cedulatextBox.Name = "cedulatextBox";
            cedulatextBox.Size = new Size(245, 34);
            cedulatextBox.TabIndex = 33;
            // 
            // btnguardardoc
            // 
            btnguardardoc.BackColor = Color.LightYellow;
            btnguardardoc.FlatStyle = FlatStyle.Popup;
            btnguardardoc.Location = new Point(683, 324);
            btnguardardoc.Name = "btnguardardoc";
            btnguardardoc.Size = new Size(111, 55);
            btnguardardoc.TabIndex = 32;
            btnguardardoc.Text = "Guardar";
            btnguardardoc.UseVisualStyleBackColor = false;
            btnguardardoc.Click += btnguardardoc_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 12F);
            maskedTextBox1.Location = new Point(564, 79);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(224, 34);
            maskedTextBox1.TabIndex = 31;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            label8.Location = new Point(564, 40);
            label8.Name = "label8";
            label8.Size = new Size(260, 26);
            label8.TabIndex = 29;
            label8.Text = "Fecha de la solicitud";
            // 
            // SubtextBox
            // 
            SubtextBox.Font = new Font("Segoe UI", 12F);
            SubtextBox.Location = new Point(283, 259);
            SubtextBox.Name = "SubtextBox";
            SubtextBox.Size = new Size(259, 34);
            SubtextBox.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            label7.Location = new Point(283, 219);
            label7.Name = "label7";
            label7.Size = new Size(173, 26);
            label7.TabIndex = 27;
            label7.Text = "Sueldo Bruto";
            // 
            // ltrabtextBox
            // 
            ltrabtextBox.Font = new Font("Segoe UI", 12F);
            ltrabtextBox.Location = new Point(3, 259);
            ltrabtextBox.Name = "ltrabtextBox";
            ltrabtextBox.Size = new Size(245, 34);
            ltrabtextBox.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            label5.Location = new Point(3, 219);
            label5.Name = "label5";
            label5.Size = new Size(215, 26);
            label5.TabIndex = 25;
            label5.Text = "Lugar de Trabajo";
            // 
            // CargotextBox
            // 
            CargotextBox.Font = new Font("Segoe UI", 12F);
            CargotextBox.Location = new Point(283, 165);
            CargotextBox.Name = "CargotextBox";
            CargotextBox.Size = new Size(264, 34);
            CargotextBox.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            label3.Location = new Point(283, 134);
            label3.Name = "label3";
            label3.Size = new Size(84, 26);
            label3.TabIndex = 23;
            label3.Text = "Cargo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            label2.Location = new Point(278, 40);
            label2.Name = "label2";
            label2.Size = new Size(227, 26);
            label2.TabIndex = 21;
            label2.Text = "TIEMPO EN SERVICIO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 134);
            label1.Name = "label1";
            label1.Size = new Size(93, 26);
            label1.TabIndex = 19;
            label1.Text = "Cedula";
            // 
            // btnimprimir
            // 
            btnimprimir.BackColor = Color.LightYellow;
            btnimprimir.FlatStyle = FlatStyle.Popup;
            btnimprimir.Location = new Point(801, 324);
            btnimprimir.Name = "btnimprimir";
            btnimprimir.Size = new Size(111, 55);
            btnimprimir.TabIndex = 18;
            btnimprimir.Text = "Imprimir";
            btnimprimir.UseVisualStyleBackColor = false;
            btnimprimir.Click += btnimprimir_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightYellow;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(449, 324);
            button3.Name = "button3";
            button3.Size = new Size(111, 55);
            button3.TabIndex = 12;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnborrar
            // 
            btnborrar.BackColor = Color.LightYellow;
            btnborrar.FlatStyle = FlatStyle.Popup;
            btnborrar.Location = new Point(566, 324);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(111, 55);
            btnborrar.TabIndex = 11;
            btnborrar.Text = "Borrar";
            btnborrar.UseVisualStyleBackColor = false;
            btnborrar.Click += btnborrar_Click;
            // 
            // nombretextBox
            // 
            nombretextBox.Font = new Font("Segoe UI", 12F);
            nombretextBox.Location = new Point(3, 79);
            nombretextBox.Name = "nombretextBox";
            nombretextBox.Size = new Size(245, 34);
            nombretextBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold);
            label4.Location = new Point(3, 40);
            label4.Name = "label4";
            label4.Size = new Size(101, 26);
            label4.TabIndex = 8;
            label4.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightGreen;
            label6.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(87, 32);
            label6.Name = "label6";
            label6.Size = new Size(239, 37);
            label6.TabIndex = 15;
            label6.Text = "Certificacion";
            // 
            // dgvGestor
            // 
            dgvGestor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestor.Location = new Point(87, 479);
            dgvGestor.Name = "dgvGestor";
            dgvGestor.RowHeadersWidth = 51;
            dgvGestor.Size = new Size(946, 201);
            dgvGestor.TabIndex = 17;
            dgvGestor.MouseClick += dgvGestor_MouseClick;
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
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4, 5, 4, 5);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(70, 699);
            MenuVertical.TabIndex = 18;
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
            button4.Size = new Size(59, 49);
            button4.TabIndex = 21;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
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
            button5.Click += button5_Click_1;
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
            button6.Click += button6_Click_1;
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
            button9.Click += button9_Click_1;
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
            // gpanel1
            // 
            gpanel1.ColorBottom = Color.Cornsilk;
            gpanel1.ColorTop = Color.LightGreen;
            gpanel1.Controls.Add(dgvGestor);
            gpanel1.Location = new Point(0, 0);
            gpanel1.Name = "gpanel1";
            gpanel1.Size = new Size(1052, 704);
            gpanel1.TabIndex = 19;
            // 
            // Certificado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 699);
            Controls.Add(MenuVertical);
            Controls.Add(panel6);
            Controls.Add(label6);
            Controls.Add(gpanel1);
            MaximumSize = new Size(1067, 746);
            Name = "Certificado";
            Text = "Certificado";
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestor).EndInit();
            MenuVertical.ResumeLayout(false);
            gpanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel6;
        private Button btnimprimir;
        private Button button3;
        
        private Button btnborrar;
        private TextBox nombretextBox;
        private Label label4;
        private Label label6;
        private DataGridView dgvGestor;
        private Label label1;
        private TextBox ltrabtextBox;
        private Label label5;
        private TextBox CargotextBox;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Label label8;
        private TextBox SubtextBox;
        private Label label7;
        private Button btnguardardoc;
        private MaskedTextBox cedulatextBox;
        private Label label9;
        private TextBox aserv;
        private MaskedTextBox FechatextBox;
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
        private Class.gpanel gpanel1;
    }
}