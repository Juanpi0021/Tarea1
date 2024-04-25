using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Paso 1: validar que ambas contraseñas sean iguales
            // Paso 2: Validadr que la contraseña cuente: 
            //          12 caracteres, mayusculas, minusculas, 3 simbolos especiales y al menos un numero
            string condicionRegex = @"^(?=(?:[^A-Z]*[A-Z]){1})(?=(?:[^a-z]*[a-z]){1})(?=(?:\D*\d){1})(?=(?:[^\W_]*[\W_]){3}[^\W_]*$)[A-Za-z\d\W_]{12}$";
            string primeraContrasena = txtPrimeraContrasena.Text;
            string segundaContrasena = txtRepetirContrasena.Text;

            if(!primeraContrasena.Equals(segundaContrasena))
            {
                MessageBox.Show("Las contraseñas no son iguales", "V E R I F I Q U E", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
           
          
            if (!Regex.IsMatch(primeraContrasena, condicionRegex))
            {
                MessageBox.Show("La contraseña no fue valida", "V E R I F I Q U E", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            MessageBox.Show("La contraseña fue valida", "E X I T O", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPrimeraContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                txtPrimeraContrasena.UseSystemPasswordChar = true;
            }    
            
        }
    }
}
