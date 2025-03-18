using System;
using System.Windows.Forms;
using gestor_de_rh01.BD.services;
using gestor_de_rh01.BD.Infrastructure.Contexts;
using System;


namespace gestor_de_rh01
{
    public partial class login : Form
    {
        private readonly ILoginServices _loginService;

        public login()
        {
            InitializeComponent();
            // Configurar el contexto y servicio
            var context = new GestorrhhDbcontext();
            _loginService = new LoginServices(context);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string contrasena = textBox2.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña");
                return;
            }

            try
            {
                // Buscar usuarios que coincidan con el filtro
                var usuarios = _loginService.Consultar(usuario);

                // Verificar coincidencia exacta de usuario y contraseña
                var usuarioValido = usuarios.FirstOrDefault(u =>
                    u.usuario.Equals(usuario, StringComparison.OrdinalIgnoreCase) &&
                    u.contrasena == contrasena);

                if (usuarioValido != null)
                {
                    MessageBox.Show($"¡Bienvenido {usuarioValido.usuario}!");
                    // Aquí puedes redirigir al formulario principal
                    AbrirFormularioPrincipal(usuarioValido.Niveladmin);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AbrirFormularioPrincipal(string nivelAcceso)
        {
            this.Hide();
            Documentacion form = new Documentacion();
            form.FormClosed += (s, args) => this.Close();
            form.Show();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir login con Enter en el campo de contraseña
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}

/*



   

*/



/*
        private void button1_Click(object sender, EventArgs e)
        {
            ValidarCredenciales();
        }

        private void TxtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir login con tecla Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidarCredenciales();
                e.Handled = true;
            }
        }

        private void ValidarCredenciales()
        {
            string usuario = textBox1.Text.Trim();
            string contrasena = textBox2.Text;

            if (usuario == "anibal" && contrasena == "1234")
            {
                this.Hide();
                Certificado principal = new Certificado();
                principal.FormClosed += (s, args) => this.Close();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error de login",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}

    */