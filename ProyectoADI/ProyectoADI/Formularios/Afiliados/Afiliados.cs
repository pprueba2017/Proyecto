using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADI.Formularios.Afiliados
{
    public partial class Afiliados : Form
    {
         public int a;        
        public Afiliados()
        {
            
            InitializeComponent();
        }
        public void validacion()
        {
            a = 0;//para obtener resultado de la consulta, si es 1 bien, 0 mal

            a = afiliadosTableAdapter.FillBy_Validacion_Cedula(proyectoADIDataSet.Afiliados, int.Parse(cedulaTextBox.Text));

        }
        private void Afiliados_Load(object sender, EventArgs e)
         {
            
            // TODO: esta línea de código carga datos en la tabla 'proyectoADIDataSet.Afiliados' Puede moverla o quitarla según sea necesario.
           // this.afiliadosTableAdapter.Fill(this.proyectoADIDataSet.Afiliados);
            estadoComboBox.Text = "Activo";

        }
        #region Guardar

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
           
            try
            {
          

                if (cedulaTextBox.Text == "" || nombreTextBox.Text == "" || apellido1TextBox.Text == "" || apellido2TextBox.Text == "" || direccionTextBox.Text == "" || edadTextBox.Text == "" || fecha_NacimientoDateTimePicker.Text == "" || estadoComboBox.Text == "")
                {

                    MessageBox.Show("Debe llenar los campos del formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                int cedula = 0; string nombre = ""; string apellido1 = ""; string apellido2 = ""; string dire = ""; int edad = 0; string fecha = ""; string correo = ""; string estado = ""; int telefono = 0;
                cedula = int.Parse(cedulaTextBox.Text); nombre = nombreTextBox.Text; apellido1 = apellido1TextBox.Text; apellido2 = apellido2TextBox.Text; dire = direccionTextBox.Text; edad = int.Parse(edadTextBox.Text); fecha = fecha_NacimientoDateTimePicker.Text; correo = correoTextBox.Text; estado = estadoComboBox.Text; telefono = int.Parse(telefonoTextBox.Text);

                validacion();
                    if (a == 0)
                    {
                    afiliadosTableAdapter.InsertQuery_Afiliados(cedula, nombre, apellido1, apellido2, dire, edad, telefono, correo, fecha, estado);
                     MessageBox.Show("Afiliado " + nombreTextBox.Text + " " + apellido1TextBox.Text + " ha sido Agregado al Sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                    cedulaTextBox.Text = Convert.ToString(cedula);   nombreTextBox.Text = nombre ;  apellido1TextBox.Text = apellido1 ;  apellido2TextBox.Text = apellido2 ;  direccionTextBox.Text=  dire;  (edadTextBox.Text)= Convert.ToString( edad );   fecha_NacimientoDateTimePicker.Text = fecha;  correoTextBox.Text = correo; estadoComboBox.Text = estado; telefonoTextBox.Text = Convert.ToString(telefono);

                    MessageBox.Show("Cedula repetida");
                    }
                 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El afiliado ya se encuentra guardado en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #endregion

        }
}
