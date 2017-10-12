using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADI.Formularios.JuntaDirectiva
{
    public partial class Consulta_junta_Directiva : Form
    {
        public Consulta_junta_Directiva()
        {
            InitializeComponent();
        }

        private void cmb_consultaJunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_consultaJunta.Text == "Año")
            {
               
                dataGridView1.Show();
             
      
            }
        }

    

        private void juntaDirectivaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.juntaDirectivaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyecto_ADIDataSet);

        }

        private void Consulta_junta_Directiva_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto_ADIDataSet.JuntaDirectiva' Puede moverla o quitarla según sea necesario.
            //this.juntaDirectivaTableAdapter.Fill(this.proyecto_ADIDataSet.JuntaDirectiva);
            //dataGridView2.Visible = false;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            List<personas> p1 = new List<personas>();
            Cadena Busqueda = new Cadena();
            Busqueda.DataAdapter("Select * from JuntaDirectiva where Periodo like '%" + cmb_consultaJunta.Text + "%' ");
            DataSet DataSet = new DataSet();
            Busqueda.Adapter.Fill(DataSet, "JuntaDirectiva");
            dataGridView1 .DataSource = DataSet;
            dataGridView1.DataMember = "JuntaDirectiva";
            int cont = dataGridView1.RowCount;//sirve para contar la cantidad de campos para hacer el while
          

            for (int i = 0; i <= cont -1; i++)
            {
                string puesto = dataGridView1.Rows[i].Cells[2].Value.ToString();
                string periodo = dataGridView1.Rows[i].Cells[3].Value.ToString();
             
                //prueba 
                int id = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()); //Para obtener el nombre
                

                Cadena Busqueda2 = new Cadena();
                Busqueda2.DataAdapter("Select Nombre from Afiliados where Id_Afiliado like '%" + id + "%' ");
                DataSet DataSet2 = new DataSet();
                Busqueda2.Adapter.Fill(DataSet2, "Afiliados");
                dataGridView2.DataSource = DataSet2;
                dataGridView2.DataMember = "Afiliados";

                string nombre = dataGridView2.Rows[0].Cells[0].Value.ToString();
                p1.Add(new personas() { nombre = nombre, puesto = puesto, periodo = periodo });

            }
         

            // dataGridView1.Visible = false;
            // dataGridView2.Visible = true; 
           
           


            //for (int i = 0; i <= cont - 1; i++)
            //{

            //    int id = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()); //Para obtener el nombre
          

            //    Cadena Busqueda2 = new Cadena();
            //    Busqueda2.DataAdapter("Select Nombre from Afiliados where Id_Afiliado like '%" + id + "%' ");
            //    DataSet DataSet2 = new DataSet();
            //    Busqueda2.Adapter.Fill(DataSet2, "Afiliados");
            //    dataGridView2.DataSource = DataSet2;
            //    dataGridView2.DataMember = "Afiliados";
            //    string nombre = dataGridView2.Rows[0].Cells[0].Value.ToString();
            //    p1.Add(new personas() { nombre = nombre });
            //}
            dataGridView2.DataSource = p1;


        }
    }
}
