using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestor_de_rh01
{
    public partial class Acerca1 : Form
    {
        public Acerca1()
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

        private void button5_Click(object sender, EventArgs e)
        {
            //registro del personal
            this.Hide();
            Registropers principal = new Registropers();
            principal.FormClosed += (s, args) => this.Close();
            principal.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            //registro de usuario
            this.Hide();
            Registrous principal = new Registrous();
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
            //certificado
            this.Hide();
            Acerca1 principal = new Acerca1();
            principal.FormClosed += (s, args) => this.Close();
            principal.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        #endregion

    }
}
