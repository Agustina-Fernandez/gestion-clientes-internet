using MySql.Data.MySqlClient;

namespace proyectoInternet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSiguiente.Visible = false;
            lblBienvenido.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string conexion = "server=localhost;port=3306;user=root;database=internet;password=";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                string consulta = "SELECT * FROM empleados WHERE usuario= @usuario AND pass= @pass";

                using (MySqlCommand comando = new MySqlCommand(consulta, conn))
                {
                    comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@pass", txtPassword.Text);

                    MySqlDataReader leer = comando.ExecuteReader();

                    if (leer.HasRows == true)
                    {
                        string usuario, pass;
                        usuario = txtUsuario.Text;
                        pass = txtPassword.Text;
                        lblBienvenido.Visible = true;
                        lblBienvenido.Text = $"Bienvenido/a {usuario}!!";
                        btnGuardar.Visible = false;
                        btnSiguiente.Visible = true;

                    }
                    else if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPassword.Text))
                    {
                        lblBienvenido.Text = "Por favor,complete todos los campos";
                        lblBienvenido.Visible = true;
                    }
                    else
                    {
                        lblBienvenido.Text = "Usuario y/o contraseña incorrecto/s";
                        lblBienvenido.Visible = true;
                    }


                }

                conn.Close();
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2();
            formulario2.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios!!");
            Application.Exit();
        }
    }
}
