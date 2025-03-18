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
using gestor_de_rh01.BD.Infrastructure.Contexts;
using gestor_de_rh01.BD.services;


namespace gestor_de_rh01.Controldis
{

    public partial class PersonalControl : UserControl
    {
        private int idp = 0;
        public PersonalControl()
        {
            InitializeComponent();
        }

        public int IdU
        {
            get { return idp; }
            set { idp = value; }
        }
        public string NombreU
        {
            get { return txtCampo1.Text; }
            set { txtCampo1.Text = value; }
        }

        public string CargoU
        {
            get { return txtCampo2.Text; }
            set { txtCampo2.Text = value; }
        }

        public string TelefonoU
        {
            get { return txtCampo3.Text; }
            set { txtCampo3.Text = value; }
        }

        public string DireccionU
        {
            get { return txtCampo4.Text; }
            set { txtCampo4.Text = value; }
        }

    }
}
