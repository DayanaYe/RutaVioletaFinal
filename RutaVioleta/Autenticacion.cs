using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace RutaVioleta
{
    public partial class frmAutenticacion : Form
    {
        public frmAutenticacion()
        {
            InitializeComponent();
        }
        
        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        
          
        {
            string usuarioesperado = "primer.usuario";



            if (txtUsuario.Text == usuarioesperado)
            {
                bttAceptar.Enabled = true;
                Error.SetError(txtUsuario, string.Empty);

            }
            else
            {
                {
                    Error.SetError(txtUsuario, "El usuario es incorrecto");
                }

            }



        }

     

        private void bttAceptar_Click(object sender, EventArgs e)

        
        {
            string usuarioesperado = "primer.usuario";
            string contraseña = "RutaVioleta";
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) && string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                    return;
            }
           

            if (txtUsuario.Text == usuarioesperado && txtContraseña.Text == contraseña)
                {
                bttAceptar.Enabled = true;
                }
            else
            {
                MessageBox.Show("usuario o contraseña incorrectos");
                return;
            }

            DatosGenerales secondform = new DatosGenerales();
            secondform.Show();
            this.Hide();
        }

        private void frmAutenticacion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            string contraseña = "RutaVioleta";



            if (txtContraseña.Text == contraseña)
            {
                bttAceptar.Enabled = true;
                Error.SetError(txtContraseña, string.Empty);
            }
            else
            {
                {
                    Error.SetError(txtContraseña, "La contraseña es incorrecta");
                }

            }
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar el formulario si el usuario selecciona "Sí"
            }
        }
    }
    
}