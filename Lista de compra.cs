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
using Microsoft.VisualBasic.ApplicationServices;

namespace gestor_de_rh01
{
    public partial class Lista_de_compra : Form
    {
        private readonly ListcompService _gestorService;
        private readonly GestorrhhDbcontext _context;
        public Lista_de_compra()
        {
            InitializeComponent();

            // Configuración de la base de datos
            _context = new GestorrhhDbcontext();
            _gestorService = new ListcompService(_context);
            _context.Database.EnsureCreated();
            CargarDatos();
        }
        public void CargarDatos()
        {
            dgvGestor.DataSource = _gestorService.Consultar();
            dgvGestor.AutoGenerateColumns = true;
        }

        #region Datagrid y base de datos
         
        private void guar_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime fecha = dateTimePicker1.Value; 
                string fechaComoCadena = fecha.ToString("yyyyMMdd"); 

                var nuevoGestor = new Listacompra
                {
                    //cambiar
                    Nombreact = textnomact.Text,
                    Categ = txtcateg.Text,
                    Cantidad22 = Textcantidad1.Text,
                    Nomar = textnombart.Text,
                    Lugd = textlugd.Text,
                    Fechalist = fechaComoCadena,
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

                     //cambiar o hacer una clase borrar 
                    textnomact.Clear();
                    textnombart.Clear();
                    Textcantidad1.Clear();
                    textlugd.Clear();
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