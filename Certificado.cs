using Aspose.Words;
using Aspose.Words.Replacing;
using System;
using System.IO;
using System.Windows.Forms;
using gestor_de_rh01.BD.services;
using gestor_de_rh01.BD.Infrastructure.Contexts;
using gestor_de_rh01.BD.Domain.Entities;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace gestor_de_rh01
{
    public partial class Certificado : Form
    {
        private readonly GestorrhhServices _gestorService;
        private readonly GestorrhhDbcontext _context;

        public Certificado()
        {
            InitializeComponent();

            // Configuración de la base de datos
            _context = new GestorrhhDbcontext();
            _gestorService = new GestorrhhServices(_context);
            _context.Database.EnsureCreated();
            CargarDatos();
        }

        public void CargarDatos()
        {
            dgvGestor.DataSource = _gestorService.Consultar();
            dgvGestor.AutoGenerateColumns = true;
        }

        #region Modificar   y Guardar documento
        private void btnimprimir_Click(object sender, EventArgs e)
        {
            try
            {

                string docPath = @"C:\Users\Nero\Desktop\CERTIFICACIONPRUEBA.docx";


                Document doc = new Document(docPath);


                FindReplaceOptions options = new FindReplaceOptions();

                //textbox 1 es nombre, textbox4 es 
                doc.Range.Replace("text1", nombretextBox.Text, options);
                doc.Range.Replace("text2", cedulatextBox.Text, options);
                doc.Range.Replace("text3", FechatextBox.Text, options);
                doc.Range.Replace("text4", CargotextBox.Text, options);
                doc.Range.Replace("text5", ltrabtextBox.Text, options);
                doc.Range.Replace("text6", SubtextBox.Text, options);
                doc.Range.Replace("text7", aserv.Text, options);


                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


                string namearch = $"{FechatextBox.Text}_{nombretextBox.Text}.docx";


                foreach (char c in Path.GetInvalidFileNameChars())
                {
                    namearch = namearch.Replace(c.ToString(), "_");
                }


                string guardarPath = Path.Combine(desktopPath, namearch);

                doc.Save(guardarPath);


                MessageBox.Show($"El documento ha sido Guardado Con Exito en: {guardarPath}");


            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
        #endregion

        #region Datagrid y base de datos

        private void btnguardardoc_Click(object sender, EventArgs e)
        {
            try
            {


                var nuevoGestor = new GestorRhh
                {
                    //cambiar

                    Nombre = nombretextBox.Text,
                    cedula = cedulatextBox.Text,
                    Fecha = FechatextBox.Text,
                    Cargo = CargotextBox.Text,
                    lugar_de_trabajo = ltrabtextBox.Text,
                    Sueldo_bruto = SubtextBox.Text,
                    a_en_servicios = aserv.Text
                };

                var resultado = _gestorService.Crear(nuevoGestor);
                MessageBox.Show(resultado.message);

                if (resultado.Ok)
                {
                    //LimpiarCampos();
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en base de datos: {ex.Message}");
            }
        }


        private void dgvGestor_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvGestor.HitTest(e.X, e.Y);

                if (hitTest.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvGestor.Rows[hitTest.RowIndex];

                    nombretextBox.Text = fila.Cells[1].Value?.ToString();
                    cedulatextBox.Text = fila.Cells[2].Value?.ToString();
                    FechatextBox.Text = fila.Cells[3].Value?.ToString();
                    CargotextBox.Text = fila.Cells[4].Value?.ToString();
                    ltrabtextBox.Text = fila.Cells[5].Value?.ToString();
                    SubtextBox.Text = fila.Cells[6].Value?.ToString();
                    aserv.Text = fila.Cells[7].Value?.ToString();

                }
            }
        }
        #endregion

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

        private void button9_Click_1(object sender, EventArgs e)
        {

            //registro de usuario
            this.Hide();
            Registrous principal = new Registrous();
            principal.FormClosed += (s, args) => this.Close();
            principal.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //documentacion
            this.Hide();
            Documentacion principal = new Documentacion();
            principal.FormClosed += (s, args) => this.Close();
            principal.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //acerca
            this.Hide();
            Acerca1 principal = new Acerca1();
            principal.FormClosed += (s, args) => this.Close();
            principal.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        #endregion

        private void btnborrar_Click(object sender, EventArgs e)
        {

            //cambiar o hacer una clase borrar 
            nombretextBox.Clear();
            cedulatextBox.Clear();
            ltrabtextBox.Clear();
            ltrabtextBox.Clear();
            FechatextBox.Clear();
            CargotextBox.Clear();
            SubtextBox.Clear();
            maskedTextBox1.Clear();
            aserv.Clear();
        }

    }
}


