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
    public partial class Donaciones : Form
    {
        public Donaciones()
        {
            InitializeComponent();
        }

        private void donacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.donacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proyecto_ADIDataSet);

        }

        private void Donaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyecto_ADIDataSet.Donaciones' Puede moverla o quitarla según sea necesario.
            this.donacionesTableAdapter.Fill(this.proyecto_ADIDataSet.Donaciones);

        }
    }
}
