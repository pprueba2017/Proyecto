namespace ProyectoADI.Formularios.JuntaDirectiva
{
    partial class Consulta_junta_Directiva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cmb_consultaJunta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proyecto_ADIDataSet = new ProyectoADI.Proyecto_ADIDataSet();
            this.juntaDirectivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juntaDirectivaTableAdapter = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.JuntaDirectivaTableAdapter();
            this.tableAdapterManager = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.TableAdapterManager();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_ADIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juntaDirectivaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.cmb_consultaJunta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(171, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(136, 56);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cmb_consultaJunta
            // 
            this.cmb_consultaJunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_consultaJunta.FormattingEnabled = true;
            this.cmb_consultaJunta.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmb_consultaJunta.Location = new System.Drawing.Point(136, 19);
            this.cmb_consultaJunta.Name = "cmb_consultaJunta";
            this.cmb_consultaJunta.Size = new System.Drawing.Size(121, 21);
            this.cmb_consultaJunta.TabIndex = 2;
            this.cmb_consultaJunta.SelectedIndexChanged += new System.EventHandler(this.cmb_consultaJunta_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el Año";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(403, 197);
            this.dataGridView1.TabIndex = 1;
            // 
            // proyecto_ADIDataSet
            // 
            this.proyecto_ADIDataSet.DataSetName = "Proyecto_ADIDataSet";
            this.proyecto_ADIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // juntaDirectivaBindingSource
            // 
            this.juntaDirectivaBindingSource.DataMember = "JuntaDirectiva";
            this.juntaDirectivaBindingSource.DataSource = this.proyecto_ADIDataSet;
            // 
            // juntaDirectivaTableAdapter
            // 
            this.juntaDirectivaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadesTableAdapter = null;
            this.tableAdapterManager.AfiliadosTableAdapter = null;
            this.tableAdapterManager.Asigna_Afiliados_ProyectosTableAdapter = null;
            this.tableAdapterManager.Asignacion_RecursosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cronograma_ProyectosTableAdapter = null;
            this.tableAdapterManager.DonacionesTableAdapter = null;
            this.tableAdapterManager.InstitucionesTableAdapter = null;
            this.tableAdapterManager.JuntaDirectivaTableAdapter = this.juntaDirectivaTableAdapter;
            this.tableAdapterManager.Presupuesto_de_ActividadesTableAdapter = null;
            this.tableAdapterManager.ProyectosTableAdapter = null;
            this.tableAdapterManager.Recursos_NecesariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoADI.Proyecto_ADIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(361, 150);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(403, 197);
            this.dataGridView2.TabIndex = 2;
            // 
            // Consulta_junta_Directiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 399);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Consulta_junta_Directiva";
            this.Text = "Consulta_junta_Directiva";
            this.Load += new System.EventHandler(this.Consulta_junta_Directiva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_ADIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juntaDirectivaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_consultaJunta;
        private System.Windows.Forms.Label label1;
        private Proyecto_ADIDataSet proyecto_ADIDataSet;
        private System.Windows.Forms.BindingSource juntaDirectivaBindingSource;
        private Proyecto_ADIDataSetTableAdapters.JuntaDirectivaTableAdapter juntaDirectivaTableAdapter;
        private Proyecto_ADIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}