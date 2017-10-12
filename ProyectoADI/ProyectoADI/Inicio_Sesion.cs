using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADI
{
    public partial class Inicio_Sesion : Form
    {

      
        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyectoADIDataSet);

        }

        private void Inicio_Sesion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoADIDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.proyectoADIDataSet.Usuarios);

            nombre_UsuarioTextBox.Focus();
        }

#region btn Entrar
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nombre_UsuarioTextBox.Text == "" || claveTextBox.Text =="" )
                {

                    MessageBox.Show("Debe llenar todos los campos del formulario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                
            int a=0;//para obtener resultado de la consulta, si es 1 bien, 0 mal

            a = usuariosTableAdapter.FillBy_select_login(proyectoADIDataSet.Usuarios,nombre_UsuarioTextBox.Text, claveTextBox.Text);


            
                        if (a==1)
                        {
                            MessageBox.Show("Bienvenido " + nombre_UsuarioTextBox.Text, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MDIPrincipal f1 = new MDIPrincipal();
                            f1.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña Incorrectas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         

                        }
                    }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        #endregion

#region btn Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

  
    }
}
