using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace RutaVioleta
{
    public partial class DatosGenerales : Form
    {
        public DatosGenerales()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DatosGenerales_Load(object sender, EventArgs e)
        {

        }

        private void bttCancelar1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quieres cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar el formulario si el usuario selecciona "Sí"
            }
        }

        private void bttAtras_Click(object sender, EventArgs e)
        {
            frmAutenticacion primerform = new frmAutenticacion();
            primerform.Show();
            this.Close();
        }

        private void bttSiguiente1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrimerNombre.Text) || string.IsNullOrWhiteSpace(txtPrimerApellido.Text) || string.IsNullOrWhiteSpace(txtNoIdentificacion.Text) ||
                string.IsNullOrWhiteSpace(txtDireccionResidencia.Text) || (CboTipoDocumento.SelectedIndex == -1)
                || (CboDepartamentoResidencia.SelectedIndex == -1) || (cboSexo.SelectedIndex == -1) || (cboOrientaciónSexual.SelectedIndex == -1)
                || (cboIdentidadGenero.SelectedIndex == -1) || (cboFacultad.SelectedIndex == -1) || (cboMunicipioResidencia.SelectedIndex == -1))
            {
                MessageBox.Show("No se puede dejar espacios sin responder");
                return;
            }
            VinculoDetalle tercerform = new VinculoDetalle();
            tercerform.Show();
            this.Close();



        }



      
        private void CboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPrimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblDatosGenerales_Click(object sender, EventArgs e)
        {

        }

       


        

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
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

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

        

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void cboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                cboFacultad.Items.Clear();
                if(cboSede.SelectedItem != null)
                {
                    string selectedSede = cboSede.SelectedItem.ToString();
                    if(selectedSede == "Medellín - Área de la Salud")
                    {
                        cboFacultad.Items.Add("Medicina");
                        cboFacultad.Items.Add("Salud Publica");
                        cboFacultad.Items.Add("Odontologia");
                        cboFacultad.Items.Add("Enfermeria");
                        
                    }
                    if (selectedSede == "Seccional Oriente")
                    {
                        cboFacultad.Items.Add("Administración de Empresas");
                        cboFacultad.Items.Add("Ingeniería Ambiental");
                        cboFacultad.Items.Add("Ingeniería de Sistemas");
                        cboFacultad.Items.Add("Contaduría Pública");
                        cboFacultad.Items.Add("Trabajo Social");

                    }
                    if (selectedSede == "Seccional Bajo Cauca")
                    {
                        cboFacultad.Items.Add("Administración de Empresas");
                        cboFacultad.Items.Add("Ingeniería Agropecuaria");
                        cboFacultad.Items.Add("Ingeniería de Sistemas");
                        cboFacultad.Items.Add("Enfermeria");
                        cboFacultad.Items.Add("Trabajo Social");

                    }
                    if (selectedSede == "Seccional Urabá")
                    {
                        cboFacultad.Items.Add("Administración de Empresas");
                        cboFacultad.Items.Add("Ingeniería Agropecuaria");
                        cboFacultad.Items.Add("Ingeniería Ambiental");
                        cboFacultad.Items.Add("Contaduría Pública");
                        cboFacultad.Items.Add("Trabajo Social");

                    }
                    if (selectedSede == "Seccional Magdalena Medio")
                    {
                        cboFacultad.Items.Add("Administración de Empresas");
                        cboFacultad.Items.Add("Ingeniería de Sistemas");
                        cboFacultad.Items.Add("Ingeniería Ambiental");
                        cboFacultad.Items.Add("Contaduría Pública");
                        cboFacultad.Items.Add("Ingenieria Industrial");

                    }


                }

            }
        }

        private void CboDepartamentoResidencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                cboMunicipioResidencia.Items.Clear();
                if (CboDepartamentoResidencia.SelectedItem != null)
                {
                    string selectedDepartment = CboDepartamentoResidencia.SelectedItem.ToString();


                    if (selectedDepartment == "Antioquia")
                    {
                        cboMunicipioResidencia.Items.Add("Medellín");
                        cboMunicipioResidencia.Items.Add("Envigado");
                        cboMunicipioResidencia.Items.Add("Bello");
                        cboMunicipioResidencia.Items.Add("La Estrella");

                    }
                    if (selectedDepartment == "Amazonas")
                    {
                        cboMunicipioResidencia.Items.Add("Leticia");
                        cboMunicipioResidencia.Items.Add("Puerto Nariño");
                        cboMunicipioResidencia.Items.Add("El Encanto");
                        cboMunicipioResidencia.Items.Add("La Pedrera");

                    }
                    if (selectedDepartment == "Arauca")
                    {
                        cboMunicipioResidencia.Items.Add("Saravena");
                        cboMunicipioResidencia.Items.Add("Arauquita");
                        cboMunicipioResidencia.Items.Add("Tame");
                        cboMunicipioResidencia.Items.Add("Fortul");

                    }
                    if (selectedDepartment == "Atlántico")
                    {
                        cboMunicipioResidencia.Items.Add("Barranquilla");
                        cboMunicipioResidencia.Items.Add("Soledad");
                        cboMunicipioResidencia.Items.Add("Malambo");
                        cboMunicipioResidencia.Items.Add("Sabanalarga");

                    }
                    if (selectedDepartment == "Bolívar")
                    {
                        cboMunicipioResidencia.Items.Add("Cartagena de Indias");
                        cboMunicipioResidencia.Items.Add("Magangué");
                        cboMunicipioResidencia.Items.Add("Arjona");
                        cboMunicipioResidencia.Items.Add("Turbaco");

                    }
                    if (selectedDepartment == "Boyacá")
                    {
                        cboMunicipioResidencia.Items.Add("Tunja");
                        cboMunicipioResidencia.Items.Add("Sogamoso");
                        cboMunicipioResidencia.Items.Add("Duitama");
                        cboMunicipioResidencia.Items.Add("Chiquinquirá");

                    }
                    if (selectedDepartment == "Caldas")
                    {
                        cboMunicipioResidencia.Items.Add("Manizales");
                        cboMunicipioResidencia.Items.Add("La dorada");
                        cboMunicipioResidencia.Items.Add("Villamaria");
                        cboMunicipioResidencia.Items.Add("Riosucio");

                    }
                    if (selectedDepartment == "Caquetá")
                    {
                        cboMunicipioResidencia.Items.Add("florencia");
                        cboMunicipioResidencia.Items.Add("San vicente del caguán");
                        cboMunicipioResidencia.Items.Add("Cartagena del chairá");
                        cboMunicipioResidencia.Items.Add("Puerto rico");

                    }
                    if (selectedDepartment == "Casanare")
                    {
                        cboMunicipioResidencia.Items.Add("Yopal");
                        cboMunicipioResidencia.Items.Add("Villanueva");
                        cboMunicipioResidencia.Items.Add("Aguazul");
                        cboMunicipioResidencia.Items.Add("Paz de ariporo");

                    }
                    if (selectedDepartment == "Cauca")
                    {
                        cboMunicipioResidencia.Items.Add("Popayán");
                        cboMunicipioResidencia.Items.Add("Santander de Quilichao");
                        cboMunicipioResidencia.Items.Add("El Tambo");
                        cboMunicipioResidencia.Items.Add("La Vega");

                    }
                    if (selectedDepartment == "Cesar")
                    {
                        cboMunicipioResidencia.Items.Add("Valledupar");
                        cboMunicipioResidencia.Items.Add("Agiachica");
                        cboMunicipioResidencia.Items.Add("Codazzi");
                        cboMunicipioResidencia.Items.Add("La Jagua de Ibirico");

                    }
                    if (selectedDepartment == "Chocó")
                    {
                        cboMunicipioResidencia.Items.Add("Quibdó");
                        cboMunicipioResidencia.Items.Add("Alto Baudó");
                        cboMunicipioResidencia.Items.Add("Medio Atrato");
                        cboMunicipioResidencia.Items.Add("Riosucio");

                    }
                    if (selectedDepartment == "Córdoba")
                    {
                        cboMunicipioResidencia.Items.Add("Montería");
                        cboMunicipioResidencia.Items.Add("Santa Cruz de Lorica");
                        cboMunicipioResidencia.Items.Add("Tierralta");
                        cboMunicipioResidencia.Items.Add("Cereté");

                    }
                    if (selectedDepartment == "Cundinamarca")
                    {
                        cboMunicipioResidencia.Items.Add("Bogotá");
                        cboMunicipioResidencia.Items.Add("Soacha");
                        cboMunicipioResidencia.Items.Add("Fusagasugá");
                        cboMunicipioResidencia.Items.Add("Mosquera");

                    }
                    if (selectedDepartment == "Guainía")
                    {
                        cboMunicipioResidencia.Items.Add("Inírida");
                        cboMunicipioResidencia.Items.Add("Barranco Minas");
                        cboMunicipioResidencia.Items.Add("Mapiripana");
                        cboMunicipioResidencia.Items.Add("Pana Pana");

                    }
                }
            }
        }

        private void txtDireccionResidencia_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void cboOrientaciónSexual_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboIdentidadGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Cancelar el efecto de la tecla presionada
                e.Handled = true;
            }
        }

        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            this.dtFechaNacimiento.MaxDate = DateTime.Now;
        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboFacultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
