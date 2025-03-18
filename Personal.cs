using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestor_de_rh01.BD.services;
using gestor_de_rh01.BD.Infrastructure.Contexts;
using gestor_de_rh01.BD.Domain.Entities;
using System.Data.SqlClient;
using gestor_de_rh01.Controldis;

namespace gestor_de_rh01
{
    public partial class Personal : Form
    {
        private readonly Personalservices _dataService;
        private PersonalControl _controlEdicion = new PersonalControl();

        public Personal()
        {
            InitializeComponent();
            var dbContext = new GestorrhhDbcontext();
            _dataService = new Personalservices(dbContext);

            LlenarBotones(flowpers1);

        }
        
        private void LlenarBotones(FlowLayoutPanel Contenedor)
        {
            Contenedor.Controls.Clear();
            using (var db = new GestorrhhDbcontext())
            {
                var servicio = new Personalservices(db);
                var personal = servicio.Consultar();

                foreach (var persona in personal)
                {
                    var control = new PersonalControl();
                    control.IdU = persona.Id;
                    control.NombreU = persona.NombreP;
                    control.CargoU = persona.Cargo;
                    control.TelefonoU = persona.Telefono;
                    control.DireccionU = persona.Dvive;

                    Contenedor.Controls.Add(control);
                }
            }
        }
        private void Btnactualizar_Click_1(object sender, EventArgs e)
        {
            LlenarBotones(flowpers1);
        }

        #region    MENU
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
        private void button9_Click(object sender, EventArgs e)
        {
            //registro de usuario
            this.Hide();
            Registrous principal = new Registrous();
            principal.FormClosed += (s, args) => this.Close();
            principal.Show();
        }
        #endregion


        }
    }

