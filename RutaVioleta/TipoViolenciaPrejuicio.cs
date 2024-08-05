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
    public partial class TipoViolenciaPrejuicio : Form
    {
        public TipoViolenciaPrejuicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttAtras3_Click(object sender, EventArgs e)
        {
            TipoViolencia primerform = new TipoViolencia();
            primerform.Show();
            this.Close();
        }

        private void bttCancelar4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar el formulario si el usuario selecciona "Sí"
            }
        }

        private void TipoViolenciaPrejuicio_Load(object sender, EventArgs e)
        {

        }

        

        private void bttGuardar2_Click(object sender, EventArgs e)
        {
            if (clbTipoViolenciaPrejuicio.CheckedItems.Count == 0 || cblTipoViolenciaInstitucional.CheckedItems.Count == 0 ||
                clbActivacionInterna.CheckedItems.Count == 0 || clbRemisionEspecialistas.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se puede dejar espacios sin responder");
                return;
            }
            if (clbTipoViolenciaPrejuicio.CheckedItems.Count == 1 || cblTipoViolenciaInstitucional.CheckedItems.Count == 1 ||
                clbActivacionInterna.CheckedItems.Count == 1 || clbRemisionEspecialistas.CheckedItems.Count == 1)
            {
                MessageBox.Show("Sus datos han sido guardados correctamente");
            }
                Application.Exit();
        }

        
    }
}
