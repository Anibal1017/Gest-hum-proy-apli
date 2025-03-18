
using System;
using System.IO;
using System.Windows.Forms;
using gestor_de_rh01.BD.services;
using gestor_de_rh01.BD.Infrastructure.Contexts;
using gestor_de_rh01.BD.Domain.Entities;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace gestor_de_rh01
{
    public partial class Registropers : Form
    {
        private readonly Personalservices _gestorService;
        private readonly GestorrhhDbcontext _context;
        public Registropers()
        {
            InitializeComponent();

            // Configuración de la base de datos
            _context = new GestorrhhDbcontext();
            _gestorService = new Personalservices(_context);
            _context.Database.EnsureCreated();
            CargarDatos();
        }

        public void CargarDatos()
        {
            dgvGestor.DataSource = _gestorService.Consultar();
            dgvGestor.AutoGenerateColumns = true;
        }

        #region Datagrid y base de datos
        

        private void buttonx1_Click(object sender, EventArgs e)
        {
            try
            {

                string textNombreCompleto  = textNombreP.Text + " " + textApellido.Text;


                var nuevoGestor = new Personalrhh
                {

                    //cambiar

                    NombreP = textNombreCompleto,
                    Cedula = textCedula.Text,
                    Cargo = textCargo.Text,
                    Telefono = textTelefono.Text,
                    Dvive = textDvive.Text,
                    area_trabajo = textarea_trabajo.Text,
                    Genero = textGenero.Text,
                };

                var resultado = _gestorService.Crear(nuevoGestor);
                MessageBox.Show(resultado.message);

                if (resultado.Ok)
                {
                    LimpiarCampos();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en base de datos: {ex.Message}");
            }
        }

                private void LimpiarCampos()
                {
            textNombreP.Clear();
            textCedula.Clear();

            textTelefono.Clear();
            textDvive.Clear();

            textarea_trabajo.Clear();

        }

        #endregion



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
        #endregion

     }
    }