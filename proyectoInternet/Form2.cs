using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyectoInternet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblPrecio.Visible = false;
        }

        private void btnAlmacenar_Click(object sender, EventArgs e)
        {
            string conexion = "server=localhost;port=3306;user=root;database=internet;password=";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                string servicio = cmbServicio.SelectedItem.ToString();


                switch (servicio)
                {
                    case "Cable":
                        lblPrecio.Text = "10500.50";
                        lblPrecio.Visible = true;
                        break;
                    case "Internet":
                        lblPrecio.Text = "12000.80";
                        lblPrecio.Visible = true;
                        break;
                    case "Teléfono":
                        lblPrecio.Text = "8700.45";
                        lblPrecio.Visible = true;
                        break;
                    case "Pack completo":
                        lblPrecio.Text = "25000.00";
                        lblPrecio.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Error al calcular el precio");
                        break;
                }

                

                string consulta = "INSERT INTO clientes (nombre_completo,direccion,localidad,servicio,precio) VALUES (@nombre_completo,@direccion,@localidad,@servicio,@precio)";

                using (MySqlCommand comando = new MySqlCommand(consulta, conn))
                {
                    Double precio = double.Parse(lblPrecio.Text);

                    comando.Parameters.AddWithValue("@nombre_completo", txtNombre.Text);
                    comando.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    comando.Parameters.AddWithValue("@localidad", txtLocalidad.Text);
                    comando.Parameters.AddWithValue("@servicio", servicio);
                    comando.Parameters.AddWithValue("@precio", precio);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente agregado correctamente");
                }

                conn.Close();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3();
            formulario3.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 formulario1 = new Form1();
            formulario1.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtLocalidad.Clear();
            cmbServicio.SelectedIndex = -1;
            lblPrecio.Text = "";
            lblPrecio.Visible = false;
        }
    }
}
