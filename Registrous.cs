using System;
using System.Windows.Forms;
using gestor_de_rh01.BD.services;
using gestor_de_rh01.BD.Infrastructure.Contexts;
using gestor_de_rh01.BD.Domain.Entities;


namespace gestor_de_rh01
{
    public partial class Registrous : Form
    {
        private readonly LoginServices _gestorService;
        private readonly GestorrhhDbcontext _context;

        public Registrous()
        {
            InitializeComponent();

            // Configuración de la base de datos
            _context = new GestorrhhDbcontext();
            _gestorService = new LoginServices(_context);
            _context.Database.EnsureCreated();
            CargarDatos();
        }

        public void CargarDatos()
        {
            dgvGestor.DataSource = _gestorService.Consultar();
            dgvGestor.AutoGenerateColumns = true;
        }


        int nvadmint;
        string contrasenausario;

        #region  base de datos
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
               

                var nuevoGestor = new Loginrh
                {

                    //cambiar
                    usuario = usuario.Text,
                    contrasena = textBox2.Text,
                    Niveladmin = comboBoxnvadm.Text

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
#endregion
private void btnborrar_Click(object sender, EventArgs e)
{

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
private void button7_Click_1(object sender, EventArgs e)
{
    this.Close();

}
#endregion





}
}

/*
private void LimpiarCampos()
{
//cambiar o hacer una clase borrar 
usuario.Clear();
textBox2.Clear();
textBox3.Clear();
}
*/


