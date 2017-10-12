using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADI.Formularios
{
    public partial class Crear_Junta_Directiva : Form
    {
        public Crear_Junta_Directiva()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            id_AfiliadoTextBox.Text = "";
            nombre_Puesto_JuntaComboBox.Text = "Presidente";
            periodoTextBox.Text = "";

        }
        private void juntaDirectivaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.juntaDirectivaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyecto_ADIDataSet);

        }

        private void Junta_Directiva_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto_ADIDataSet.Afiliados' Puede moverla o quitarla según sea necesario.
            this.afiliadosTableAdapter.Fill(this.proyecto_ADIDataSet.Afiliados);
            // TODO: esta línea de código carga datos en la tabla 'proyecto_ADIDataSet.JuntaDirectiva' Puede moverla o quitarla según sea necesario.
            this.juntaDirectivaTableAdapter.Fill(this.proyecto_ADIDataSet.JuntaDirectiva);

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
            try
            {
                if (cmb_tipo_ced_nomb.Text == "Cedula")
            {
                //this.afiliadosBindingSource.Filter = afiliadosTableAdapter.FillBy_Validacion_Cedula(int.Parse(txt_ced_nombre.Text));
                this.afiliadosBindingSource.Filter = string.Format("Cedula like '%'", txt_ced_nombre.Text);
                //select DISTINCT *from Afiliados where Cedula like'205%'

            }
            else
            {
                this.afiliadosBindingSource.Filter = String.Format("Nombre like '{0}%'", txt_ced_nombre.Text);
            }

        }
            catch (Exception)
            {
                MessageBox.Show("verifique que no haya digitado un caracter indebido", "Verifique...");


            }
}

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_AfiliadoTextBox.Text == "" || nombre_Puesto_JuntaComboBox.Text == "" || periodoTextBox.Text == "")
                {

                    MessageBox.Show("Debe llenar los campos del formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    juntaDirectivaTableAdapter.InsertQuery_JuntaDirectiva(Convert.ToInt32(id_AfiliadoTextBox.Text), nombre_Puesto_JuntaComboBox.Text, periodoTextBox.Text);
                    
                    MessageBox.Show("Miembro de la Junta ha sido Agregado al Sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }


        }

        private void afiliadosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow Row = afiliadosDataGridView.Rows[e.RowIndex];
                id_AfiliadoTextBox.Text = Convert.ToString(Row.Cells[0].Value);
            }
            catch (Exception)
            {
                
            }
  
  
        }

        private void afiliadosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
