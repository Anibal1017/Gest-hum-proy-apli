namespace gestor_de_rh01.Controldis
{
    partial class PersonalControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalControl));
            usercpictureBox1 = new PictureBox();
            gpanel1 = new Class.gpanel();
            usercpanel1 = new Panel();
            txtCampo4 = new TextBox();
            txtCampo3 = new TextBox();
            txtCampo2 = new TextBox();
            txtCampo1 = new TextBox();
            labeldonv = new Label();
            labeltel = new Label();
            labelcargo = new Label();
            labelnom = new Label();
            ((System.ComponentModel.ISupportInitialize)usercpictureBox1).BeginInit();
            gpanel1.SuspendLayout();
            usercpanel1.SuspendLayout();
            SuspendLayout();
            // 
            // usercpictureBox1
            // 
            usercpictureBox1.BackColor = Color.Black;
            usercpictureBox1.Enabled = false;
            usercpictureBox1.Image = (Image)resources.GetObject("usercpictureBox1.Image");
            usercpictureBox1.Location = new Point(104, 7);
            usercpictureBox1.Name = "usercpictureBox1";
            usercpictureBox1.Size = new Size(136, 166);
            usercpictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            usercpictureBox1.TabIndex = 0;
            usercpictureBox1.TabStop = false;
            // 
            // gpanel1
            // 
            gpanel1.BackColor = Color.Transparent;
            gpanel1.ColorBottom = Color.FromArgb(192, 255, 192);
            gpanel1.ColorTop = Color.FromArgb(0, 192, 0);
            gpanel1.Controls.Add(usercpictureBox1);
            gpanel1.Controls.Add(usercpanel1);
            gpanel1.ForeColor = SystemColors.ButtonFace;
            gpanel1.Location = new Point(0, -1);
            gpanel1.MaximumSize = new Size(365, 542);
            gpanel1.Name = "gpanel1";
            gpanel1.Size = new Size(365, 542);
            gpanel1.TabIndex = 3;
            // 
            // usercpanel1
            // 
            usercpanel1.AutoSize = true;
            usercpanel1.BackColor = Color.FromArgb(192, 255, 192);
            usercpanel1.BackgroundImageLayout = ImageLayout.None;
            usercpanel1.Controls.Add(txtCampo4);
            usercpanel1.Controls.Add(txtCampo3);
            usercpanel1.Controls.Add(txtCampo2);
            usercpanel1.Controls.Add(txtCampo1);
            usercpanel1.Controls.Add(labeldonv);
            usercpanel1.Controls.Add(labeltel);
            usercpanel1.Controls.Add(labelcargo);
            usercpanel1.Controls.Add(labelnom);
            usercpanel1.ForeColor = Color.Snow;
            usercpanel1.Location = new Point(33, 175);
            usercpanel1.Name = "usercpanel1";
            usercpanel1.Size = new Size(293, 357);
            usercpanel1.TabIndex = 2;
            // 
            // txtCampo4
            // 
            txtCampo4.Location = new Point(15, 288);
            txtCampo4.Name = "txtCampo4";
            txtCampo4.ReadOnly = true;
            txtCampo4.Size = new Size(237, 27);
            txtCampo4.TabIndex = 14;
            // 
            // txtCampo3
            // 
            txtCampo3.Location = new Point(15, 220);
            txtCampo3.Name = "txtCampo3";
            txtCampo3.ReadOnly = true;
            txtCampo3.Size = new Size(237, 27);
            txtCampo3.TabIndex = 13;
            // 
            // txtCampo2
            // 
            txtCampo2.Location = new Point(15, 142);
            txtCampo2.Name = "txtCampo2";
            txtCampo2.ReadOnly = true;
            txtCampo2.Size = new Size(237, 27);
            txtCampo2.TabIndex = 12;
            // 
            // txtCampo1
            // 
            txtCampo1.Location = new Point(15, 65);
            txtCampo1.Name = "txtCampo1";
            txtCampo1.ReadOnly = true;
            txtCampo1.Size = new Size(237, 27);
            txtCampo1.TabIndex = 11;
            // 
            // labeldonv
            // 
            labeldonv.AutoSize = true;
            labeldonv.BackColor = Color.Transparent;
            labeldonv.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeldonv.ForeColor = Color.Black;
            labeldonv.Location = new Point(15, 259);
            labeldonv.Name = "labeldonv";
            labeldonv.Size = new Size(135, 26);
            labeldonv.TabIndex = 6;
            labeldonv.Text = "Direccion:";
            // 
            // labeltel
            // 
            labeltel.AutoSize = true;
            labeltel.BackColor = Color.Transparent;
            labeltel.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltel.ForeColor = Color.Black;
            labeltel.Location = new Point(15, 181);
            labeltel.Name = "labeltel";
            labeltel.Size = new Size(58, 26);
            labeltel.TabIndex = 5;
            labeltel.Text = "Tel:";
            // 
            // labelcargo
            // 
            labelcargo.AutoSize = true;
            labelcargo.BackColor = Color.Transparent;
            labelcargo.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcargo.ForeColor = Color.Black;
            labelcargo.Location = new Point(15, 104);
            labelcargo.Name = "labelcargo";
            labelcargo.Size = new Size(92, 26);
            labelcargo.TabIndex = 3;
            labelcargo.Text = "Cargo:";
            // 
            // labelnom
            // 
            labelnom.AutoSize = true;
            labelnom.BackColor = Color.Transparent;
            labelnom.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnom.ForeColor = Color.Black;
            labelnom.Location = new Point(15, 26);
            labelnom.Name = "labelnom";
            labelnom.Size = new Size(109, 26);
            labelnom.TabIndex = 1;
            labelnom.Text = "Nombre:";
            // 
            // PersonalControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(gpanel1);
            Margin = new Padding(5);
            MaximumSize = new Size(365, 542);
            Name = "PersonalControl";
            Padding = new Padding(3);
            Size = new Size(363, 540);
            ((System.ComponentModel.ISupportInitialize)usercpictureBox1).EndInit();
            gpanel1.ResumeLayout(false);
            gpanel1.PerformLayout();
            usercpanel1.ResumeLayout(false);
            usercpanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox usercpictureBox1;
        private Class.gpanel gpanel1;
        private Panel usercpanel1;
        private Label labeldonv;
        private Label labeltel;
        private Label labelcargo;
        private Label labelnom;
        private TextBox txtCampo4;
        private TextBox txtCampo3;
        private TextBox txtCampo2;
        private TextBox txtCampo1;
    }
}
