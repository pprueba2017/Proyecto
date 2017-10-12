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
    public partial class ConsultaAfiliado : Form
    { 
        
        public ConsultaAfiliado()
        {
            InitializeComponent();
        }

        private void cmb_tipo_ced_nomb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipo_ced_nomb.Text == "Cedula")
            {
                lb_tipo_consulta.Text = "Digite la Cedula del Afiliado";
                lb_tipo_consulta.Show();
                afiliadosDataGridView.Show();
                txt_ced_nombre.Show();
            }
            else
            {
                lb_tipo_consulta.Text = "Digite el Nombre del Afiliado";
                lb_tipo_consulta.Show();
                afiliadosDataGridView.Show();
                txt_ced_nombre.Show();
            }
          
        }

        private void txt_ced_nombre_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
                if (cmb_tipo_ced_nomb.Text=="Cedula")
                {

                //this.afiliadosBindingSource.Filter = afiliadosTableAdapter.FillBy_Validacion_Cedula(int.Parse(txt_ced_nombre.Text));
                    this.afiliadosBindingSource.Filter = string.Format("Cedula like '%'", txt_ced_nombre.Text);
                //select DISTINCT *from Afiliados where Cedula like'205%'

            }
            else
                {
                    this.afiliadosBindingSource.Filter = String.Format("Nombre like '{0}%'", txt_ced_nombre.Text);
                }

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("verifique que no haya digitado un caracter indebido", "Verifique...");
              
              
            //}
        }
        private void afiliadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.afiliadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyecto_ADIDataSet);

        }

        private void Consulta_Afiliado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto_ADIDataSet.Afiliados' Puede moverla o quitarla según sea necesario.
            this.afiliadosTableAdapter.Fill(this.proyecto_ADIDataSet.Afiliados);
            panel1.Visible = false;

        }

        private void lb_tipo_consulta_Click(object sender, EventArgs e)
        {

        }

        private void m_Click(object sender, EventArgs e)
        {
            cedulaLabel2.Visible = true;
            try
            {
                if (cedulaTextBox.Text == "" || nombreTextBox.Text == "" || apellido1TextBox.Text == "" || apellido2TextBox.Text == "" || direccionTextBox.Text == "" || edadTextBox.Text == "" || fecha_NacimientoDateTimePicker.Text == "" || estadoComboBox.Text == "")
                {

                    MessageBox.Show("Debe llenar los campos del formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cedulaLabel2.Visible = false;
                }
                else
                {
                    afiliadosTableAdapter.UpdateQuery_Afiliado(int.Parse(cedulaTextBox.Text), nombreTextBox.Text, apellido1TextBox.Text, apellido2TextBox.Text, direccionTextBox.Text, int.Parse(edadTextBox.Text), int.Parse(telefonoTextBox.Text), correoTextBox.Text, fecha_NacimientoDateTimePicker.Text, estadoComboBox.Text, int.Parse(cedulaLabel2.Text));
                    MessageBox.Show("El Registro ha sido actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cedulaLabel2.Visible = false;

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error");
                cedulaLabel2.Visible = false;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            groupconsulta. Visible = false;
            afiliadosDataGridView.Visible = false;
           panel1.Visible = true;
           
        }

        private void afiliadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
