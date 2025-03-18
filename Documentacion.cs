using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestor_de_rh01.BD.Domain.Entities;

namespace gestor_de_rh01
{
    public partial class Documentacion : Form
    {
        public Documentacion()
        {
            InitializeComponent();
        }

        #region MENU
        private void button8_Click(object sender, EventArgs e)
        {
            //personal
            this.Hide();
            Personal principal = new Personal();
            principal.FormClosed += (s, args) => this.Close();
            principal.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            //registro del personal
            this.Hide();
            Registropers principal = new Registropers();
            principal.FormClosed += (s, args) => this.Close();
            principal.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //documentacion
            this.Hide();
            Documentacion principal = new Documentacion();
            principal.FormClosed += (s, args) => this.Close();
            principal.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //acerca
            this.Hide();
            Acerca1 principal = new Acerca1();
            principal.FormClosed += (s, args) => this.Close();
            principal.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            //registro de usuario
            this.Hide();
            Registrous principal = new Registrous();
            principal.FormClosed += (s, args) => this.Close();
            principal.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //certificado
            this.Hide();
            Certificado form = new Certificado();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //telegrama
            this.Hide();
            teleg21 form = new teleg21();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        #endregion

        private void picture22_Click(object sender, EventArgs e)
        {
            //lista de compra
            this.Hide();
            Lista_de_compra form = new Lista_de_compra();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
    }
}
