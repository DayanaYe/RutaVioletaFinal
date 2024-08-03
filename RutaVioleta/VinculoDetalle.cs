using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RutaVioleta
{
    public partial class VinculoDetalle : Form
    {
        public VinculoDetalle()
        {
            InitializeComponent();
        }

        private void lblPrimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttSiguiente1_Click(object sender, EventArgs e)
        {    
            if (clbVinculoPersonaV.CheckedItems.Count == 0  || clbTipoViolenciaPsicologica.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se puede dejar espacios sin responder");
                return;
            }
            TipoViolencia tercerform = new TipoViolencia();
            tercerform.Show();
            this.Close();
        }

        private void bttAtras1_Click(object sender, EventArgs e)
        {
            DatosGenerales primerform = new DatosGenerales();
            primerform.Show();
            this.Close();
        }

        private void bttCancelar2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar el formulario si el usuario selecciona "Sí"
            }
        }

        

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

       
    }
}
