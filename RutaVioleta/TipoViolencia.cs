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
    public partial class TipoViolencia : Form
    {
        public TipoViolencia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblViolenciaEconomica_Click(object sender, EventArgs e)
        {

        }

        private void bttAtras2_Click(object sender, EventArgs e)
        {
            VinculoDetalle primerform = new VinculoDetalle();
            primerform.Show();
            this.Close();
        }

        private void bttSiguiente3_Click(object sender, EventArgs e)
        {
            if (clbTipoViolenciaSexual.CheckedItems.Count == 0 || clbTipoViolenciaFisica.CheckedItems.Count == 0 || clbViolenciaEconomica.CheckedItems.Count == 0)
            {
                MessageBox.Show("No se puede dejar espacios sin responder");
                return;
            }
            TipoViolenciaPrejuicio tercerform = new TipoViolenciaPrejuicio();
            tercerform.Show();
            this.Close();
        }

        private void bttCancelar3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar el formulario si el usuario selecciona "Sí"
            }
        }

        private void TipoViolencia_Load(object sender, EventArgs e)
        {

        }

        
    }
}
