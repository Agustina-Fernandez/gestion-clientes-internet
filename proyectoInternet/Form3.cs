using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoInternet
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string conexion = "server=localhost;port=3306;user=root;database=internet;password=";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                string consulta = "SELECT * FROM clientes";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvDatos.DataSource = tabla;
            }
        }
    }
}
