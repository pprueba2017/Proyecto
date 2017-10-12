using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADI.Formularios.Instituciones
{
    public partial class Instituciones : Form
    {
        public int a;

        public void validacion()
        {
            a = 0;//para obtener resultado de la consulta, si es 1 bien, 0 mal

            a = institucionesTableAdapter.FillBy_Validacion_cedula_Ju(proyecto_ADIDataSet.Instituciones, int.Parse(cedula_JuridicaTextBox.Text));

        }

        public Instituciones()
        {
            InitializeComponent();
        }

        private void institucionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.institucionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyecto_ADIDataSet);

        }

        private void Instituciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto_ADIDataSet.Instituciones' Puede moverla o quitarla según sea necesario.
            this.institucionesTableAdapter.Fill(this.proyecto_ADIDataSet.Instituciones);

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            try
            {


                if (nombreTextBox.Text == "" || cedula_JuridicaTextBox.Text == "" || descripcion_InstitucionTextBox.Text == "" || direccionTextBox.Text == "" || representante_Legal_InstitucionTextBox.Text == "" || nombre_EncargadoTextBox.Text == "" || correoTextBox.Text == "" || telefonoTextBox.Text == "")
                {

                    MessageBox.Show("Debe llenar los campos del formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    int cedulajuridica = 0; string nombre = ""; string descrip = ""; string direccion = ""; string representante = ""; string encargado = ""; string correo = ""; int telefono = 0;
                    cedulajuridica = int.Parse(cedula_JuridicaTextBox.Text); nombre = nombreTextBox.Text; descrip = descripcion_InstitucionTextBox.Text; representante = representante_Legal_InstitucionTextBox.Text; encargado = nombre_EncargadoTextBox.Text; correo = correoTextBox.Text; telefono = int.Parse(telefonoTextBox.Text);

                    validacion();
                    if (a == 0)
                    {
                        institucionesTableAdapter.InsertQuery_Institucion(nombre, cedulajuridica, descrip, direccion, representante, encargado, correo, telefono);
                        MessageBox.Show("Institución " + nombreTextBox.Text + " " + " ha sido Agregado al Sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        cedula_JuridicaTextBox.Text = Convert.ToString(cedulajuridica); nombreTextBox.Text = nombre; descripcion_InstitucionTextBox.Text = descrip; representante_Legal_InstitucionTextBox.Text = representante; nombre_EncargadoTextBox.Text = nombre; correoTextBox.Text = correo; telefonoTextBox.Text = Convert.ToString(telefono);

                        MessageBox.Show("Cedula repetida");
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("El Institución ya se encuentra guardado en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        
    }
    }
}
