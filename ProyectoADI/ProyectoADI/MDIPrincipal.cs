using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADI
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registroAfiliadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Afiliados.Afiliados fr = new Formularios.Afiliados.Afiliados();
            fr.MdiParent = this;
            fr.Show();
        }

        private void consultaDeAfiliadosPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Afiliados.ConsultaAfiliado C = new Formularios.Afiliados.ConsultaAfiliado();
            C.MdiParent = this;

            C.Show();
        }

        private void ediciónAfiliadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Afiliados.ConsultaAfiliado C = new Formularios.Afiliados.ConsultaAfiliado();
            C.MdiParent = this;
            C.Show();
            
        }

        private void registroJuntaDirectivaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formularios.Crear_Junta_Directiva j = new Formularios.Crear_Junta_Directiva();
            j.MdiParent = this;
            j.Show();

        }

        private void consultaDeJuntaDirectivaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formularios.JuntaDirectiva.Consulta_junta_Directiva j = new Formularios.JuntaDirectiva.Consulta_junta_Directiva();
            j.MdiParent = this;
            j.Show();
        }

        private void registroDeInstitucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Instituciones.Instituciones i = new Formularios.Instituciones.Instituciones();
            i.MdiParent = this;
            i.Show();
        }

        private void consultaDeInstitucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Instituciones.Consulta_instituciones i = new Formularios.Instituciones.Consulta_instituciones();
            i.MdiParent = this;
            i.Show();
        }

        private void registroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.Usuarios.Agregar_Usuarios u = new Formularios.Usuarios.Agregar_Usuarios();
            u.MdiParent = this;
            u.Show();
        }
    }
}
