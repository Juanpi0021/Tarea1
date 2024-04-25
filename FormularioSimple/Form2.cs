using FormularioSimple.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioSimple
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conexion dataAcces = new Conexion();
            string servidor = txtServidor.Text;
            string usuario = txtUsuario.Text;
            string bd = txtBD.Text;
            string contrasena = txtContrasena.Text;

            string cadena = $"Server={servidor}; Database={bd}; User={usuario}; Password={contrasena};";

            if(dataAcces.IntentoDeConexion(cadena))
            {
                dataGrid.DataSource = dataAcces.ObtenerDatos(cadena);
            }
            else
            {
                MessageBox.Show("No se pudo establecer la conexión");
            }
        }
    }
}
