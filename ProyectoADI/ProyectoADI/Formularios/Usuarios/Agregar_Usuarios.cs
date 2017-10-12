using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADI.Formularios.Usuarios
{
    public partial class Agregar_Usuarios : Form
    {
        int a;
        int juntadirectiva;
        public Agregar_Usuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyecto_ADIDataSet);

        }

        private void Agregar_Usuarios_Load(object sender, EventArgs e)
        {
            juntadirectiva = 0;
        }

        public void validacion()
        {
            a = 0;//para obtener resultado de la consulta, si es 1 bien, 0 mal

            a = usuariosTableAdapter.FillBy_validacion_usuario(proyecto_ADIDataSet.Usuarios, nombre_UsuarioTextBox.Text);
            if (a == 0)
            {
                a = usuariosTableAdapter.FillBy_validacion_junta(proyecto_ADIDataSet.Usuarios, juntadirectiva);
            }
            else
            {
                
            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{


                if (nombre_UsuarioTextBox.Text == "" || id_JuntaDirectivaTextBox.Text == "" || perfilComboBox.Text == "" || claveTextBox.Text == "")
                {

                    MessageBox.Show("Debe llenar los campos del formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                juntadirectiva = int.Parse(id_JuntaDirectivaTextBox.Text);

                    string nombre_usuario = ""; int id_junta = 0; string perfil = ""; string clave = "";;
                    nombre_usuario = nombre_UsuarioTextBox.Text;id_junta = int.Parse(id_JuntaDirectivaTextBox.Text); perfil = perfilComboBox.Text; clave = claveTextBox.Text;

                    validacion();
                    if (a == 0)
                    {
                        usuariosTableAdapter.InsertQuery_Usuarios(nombre_usuario, id_junta, perfil, clave);
                        MessageBox.Show("Usuario " + nombre_UsuarioTextBox.Text + " "+" ha sido Agregado al Sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                         nombre_UsuarioTextBox.Text = nombre_usuario;id_JuntaDirectivaTextBox.Text = Convert.ToString( id_junta); perfilComboBox.Text = perfil; claveTextBox.Text = clave;

                        MessageBox.Show("Nombre Usuario repetido");
                    }

                }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("El Usuario ya se encuentra guardado en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}

        }

        private void perfilTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_JuntaDirectivaLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
            Cadena Busqueda = new Cadena();
            Busqueda.DataAdapter("Select * from JuntaDirectiva where Periodo like '%" + cmb_consultaJunta.Text + "%' ");
            DataSet DataSet = new DataSet();
            Busqueda.Adapter.Fill(DataSet, "JuntaDirectiva");
            dataGridView1.DataSource = DataSet;
            dataGridView1.DataMember = "JuntaDirectiva";
        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //            id_JuntaDirectivaTextBox.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            DataGridViewRow Row = dataGridView1.Rows[e.RowIndex];
            id_JuntaDirectivaTextBox.Text = Convert.ToString(Row.Cells[0].Value);
        }
    }
    }

