namespace ProyectoADI.Formularios
{
    partial class Crear_Junta_Directiva
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
            System.Windows.Forms.Label id_JuntaDirectivaLabel;
            System.Windows.Forms.Label id_AfiliadoLabel;
            System.Windows.Forms.Label nombre_Puesto_JuntaLabel;
            System.Windows.Forms.Label periodoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_JuntaDirectivaTextBox = new System.Windows.Forms.TextBox();
            this.id_AfiliadoTextBox = new System.Windows.Forms.TextBox();
            this.nombre_Puesto_JuntaComboBox = new System.Windows.Forms.ComboBox();
            this.periodoTextBox = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupconsulta = new System.Windows.Forms.GroupBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.lb_tipo_consulta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ced_nombre = new System.Windows.Forms.TextBox();
            this.cmb_tipo_ced_nomb = new System.Windows.Forms.ComboBox();
            this.afiliadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afiliadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyecto_ADIDataSet = new ProyectoADI.Proyecto_ADIDataSet();
            this.juntaDirectivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juntaDirectivaTableAdapter = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.JuntaDirectivaTableAdapter();
            this.tableAdapterManager = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.TableAdapterManager();
            this.afiliadosTableAdapter = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.AfiliadosTableAdapter();
            id_JuntaDirectivaLabel = new System.Windows.Forms.Label();
            id_AfiliadoLabel = new System.Windows.Forms.Label();
            nombre_Puesto_JuntaLabel = new System.Windows.Forms.Label();
            periodoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupconsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_ADIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juntaDirectivaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(id_JuntaDirectivaLabel);
            this.groupBox1.Controls.Add(this.id_JuntaDirectivaTextBox);
            this.groupBox1.Controls.Add(id_AfiliadoLabel);
            this.groupBox1.Controls.Add(this.id_AfiliadoTextBox);
            this.groupBox1.Controls.Add(nombre_Puesto_JuntaLabel);
            this.groupBox1.Controls.Add(this.nombre_Puesto_JuntaComboBox);
            this.groupBox1.Controls.Add(periodoLabel);
            this.groupBox1.Controls.Add(this.periodoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // id_JuntaDirectivaLabel
            // 
            id_JuntaDirectivaLabel.AutoSize = true;
            id_JuntaDirectivaLabel.Location = new System.Drawing.Point(21, 25);
            id_JuntaDirectivaLabel.Name = "id_JuntaDirectivaLabel";
            id_JuntaDirectivaLabel.Size = new System.Drawing.Size(93, 13);
            id_JuntaDirectivaLabel.TabIndex = 0;
            id_JuntaDirectivaLabel.Text = "Id Junta Directiva:";
            // 
            // id_JuntaDirectivaTextBox
            // 
            this.id_JuntaDirectivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.juntaDirectivaBindingSource, "Id_JuntaDirectiva", true));
            this.id_JuntaDirectivaTextBox.Enabled = false;
            this.id_JuntaDirectivaTextBox.Location = new System.Drawing.Point(139, 22);
            this.id_JuntaDirectivaTextBox.Name = "id_JuntaDirectivaTextBox";
            this.id_JuntaDirectivaTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_JuntaDirectivaTextBox.TabIndex = 1;
            // 
            // id_AfiliadoLabel
            // 
            id_AfiliadoLabel.AutoSize = true;
            id_AfiliadoLabel.Location = new System.Drawing.Point(21, 51);
            id_AfiliadoLabel.Name = "id_AfiliadoLabel";
            id_AfiliadoLabel.Size = new System.Drawing.Size(56, 13);
            id_AfiliadoLabel.TabIndex = 2;
            id_AfiliadoLabel.Text = "Id Afiliado:";
            // 
            // id_AfiliadoTextBox
            // 
            this.id_AfiliadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.juntaDirectivaBindingSource, "Id_Afiliado", true));
            this.id_AfiliadoTextBox.Enabled = false;
            this.id_AfiliadoTextBox.Location = new System.Drawing.Point(139, 48);
            this.id_AfiliadoTextBox.Name = "id_AfiliadoTextBox";
            this.id_AfiliadoTextBox.Size = new System.Drawing.Size(121, 20);
            this.id_AfiliadoTextBox.TabIndex = 3;
            // 
            // nombre_Puesto_JuntaLabel
            // 
            nombre_Puesto_JuntaLabel.AutoSize = true;
            nombre_Puesto_JuntaLabel.Location = new System.Drawing.Point(21, 77);
            nombre_Puesto_JuntaLabel.Name = "nombre_Puesto_JuntaLabel";
            nombre_Puesto_JuntaLabel.Size = new System.Drawing.Size(112, 13);
            nombre_Puesto_JuntaLabel.TabIndex = 4;
            nombre_Puesto_JuntaLabel.Text = "Nombre Puesto Junta:";
            // 
            // nombre_Puesto_JuntaComboBox
            // 
            this.nombre_Puesto_JuntaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.juntaDirectivaBindingSource, "Nombre_Puesto_Junta", true));
            this.nombre_Puesto_JuntaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombre_Puesto_JuntaComboBox.FormattingEnabled = true;
            this.nombre_Puesto_JuntaComboBox.Items.AddRange(new object[] {
            "Presidente",
            "Vicepresidente",
            "Secretario",
            "Tesorero",
            "Vocal1",
            "Vocal2",
            "Fiscal"});
            this.nombre_Puesto_JuntaComboBox.Location = new System.Drawing.Point(139, 74);
            this.nombre_Puesto_JuntaComboBox.Name = "nombre_Puesto_JuntaComboBox";
            this.nombre_Puesto_JuntaComboBox.Size = new System.Drawing.Size(121, 21);
            this.nombre_Puesto_JuntaComboBox.TabIndex = 5;
            // 
            // periodoLabel
            // 
            periodoLabel.AutoSize = true;
            periodoLabel.Location = new System.Drawing.Point(21, 104);
            periodoLabel.Name = "periodoLabel";
            periodoLabel.Size = new System.Drawing.Size(46, 13);
            periodoLabel.TabIndex = 6;
            periodoLabel.Text = "Periodo:";
            // 
            // periodoTextBox
            // 
            this.periodoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.juntaDirectivaBindingSource, "Periodo", true));
            this.periodoTextBox.Location = new System.Drawing.Point(139, 101);
            this.periodoTextBox.Name = "periodoTextBox";
            this.periodoTextBox.Size = new System.Drawing.Size(121, 20);
            this.periodoTextBox.TabIndex = 7;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(119, 142);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupconsulta
            // 
            this.groupconsulta.Controls.Add(this.btn_editar);
            this.groupconsulta.Controls.Add(this.lb_tipo_consulta);
            this.groupconsulta.Controls.Add(this.label1);
            this.groupconsulta.Controls.Add(this.txt_ced_nombre);
            this.groupconsulta.Controls.Add(this.cmb_tipo_ced_nomb);
            this.groupconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupconsulta.Location = new System.Drawing.Point(307, 34);
            this.groupconsulta.Name = "groupconsulta";
            this.groupconsulta.Size = new System.Drawing.Size(398, 143);
            this.groupconsulta.TabIndex = 32;
            this.groupconsulta.TabStop = false;
            this.groupconsulta.Text = "Consulta y Edición de Afiliados";
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(152, 111);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 26);
            this.btn_editar.TabIndex = 26;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // lb_tipo_consulta
            // 
            this.lb_tipo_consulta.AutoSize = true;
            this.lb_tipo_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tipo_consulta.Location = new System.Drawing.Point(6, 76);
            this.lb_tipo_consulta.Name = "lb_tipo_consulta";
            this.lb_tipo_consulta.Size = new System.Drawing.Size(221, 18);
            this.lb_tipo_consulta.TabIndex = 25;
            this.lb_tipo_consulta.Text = "Digite el Nombre del Afiliado";
            this.lb_tipo_consulta.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Seleccione el tipo de consulta";
            // 
            // txt_ced_nombre
            // 
            this.txt_ced_nombre.Location = new System.Drawing.Point(268, 78);
            this.txt_ced_nombre.Name = "txt_ced_nombre";
            this.txt_ced_nombre.Size = new System.Drawing.Size(121, 26);
            this.txt_ced_nombre.TabIndex = 23;
            this.txt_ced_nombre.Visible = false;
            this.txt_ced_nombre.TextChanged += new System.EventHandler(this.txt_ced_nombre_TextChanged);
            // 
            // cmb_tipo_ced_nomb
            // 
            this.cmb_tipo_ced_nomb.FormattingEnabled = true;
            this.cmb_tipo_ced_nomb.Items.AddRange(new object[] {
            "Cedula",
            "Nombre"});
            this.cmb_tipo_ced_nomb.Location = new System.Drawing.Point(268, 38);
            this.cmb_tipo_ced_nomb.Name = "cmb_tipo_ced_nomb";
            this.cmb_tipo_ced_nomb.Size = new System.Drawing.Size(121, 28);
            this.cmb_tipo_ced_nomb.TabIndex = 22;
            this.cmb_tipo_ced_nomb.SelectedIndexChanged += new System.EventHandler(this.cmb_tipo_ced_nomb_SelectedIndexChanged);
            // 
            // afiliadosDataGridView
            // 
            this.afiliadosDataGridView.AllowUserToAddRows = false;
            this.afiliadosDataGridView.AllowUserToDeleteRows = false;
            this.afiliadosDataGridView.AutoGenerateColumns = false;
            this.afiliadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afiliadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.afiliadosDataGridView.DataSource = this.afiliadosBindingSource;
            this.afiliadosDataGridView.Location = new System.Drawing.Point(12, 221);
            this.afiliadosDataGridView.Name = "afiliadosDataGridView";
            this.afiliadosDataGridView.ReadOnly = true;
            this.afiliadosDataGridView.Size = new System.Drawing.Size(775, 220);
            this.afiliadosDataGridView.TabIndex = 32;
            this.afiliadosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.afiliadosDataGridView_CellClick);
            this.afiliadosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.afiliadosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Afiliado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Afiliado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cedula";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cedula";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Apellido1";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellido1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Apellido2";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellido2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn7.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Fecha_Nacimiento";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fecha_Nacimiento";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn11.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // afiliadosBindingSource
            // 
            this.afiliadosBindingSource.DataMember = "Afiliados";
            this.afiliadosBindingSource.DataSource = this.proyecto_ADIDataSet;
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
            this.tableAdapterManager.AfiliadosTableAdapter = this.afiliadosTableAdapter;
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
            // afiliadosTableAdapter
            // 
            this.afiliadosTableAdapter.ClearBeforeFill = true;
            // 
            // Crear_Junta_Directiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 491);
            this.Controls.Add(this.afiliadosDataGridView);
            this.Controls.Add(this.groupconsulta);
            this.Controls.Add(this.groupBox1);
            this.Name = "Crear_Junta_Directiva";
            this.Text = "Junta_Directiva";
            this.Load += new System.EventHandler(this.Junta_Directiva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupconsulta.ResumeLayout(false);
            this.groupconsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_ADIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juntaDirectivaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Proyecto_ADIDataSet proyecto_ADIDataSet;
        private System.Windows.Forms.BindingSource juntaDirectivaBindingSource;
        private Proyecto_ADIDataSetTableAdapters.JuntaDirectivaTableAdapter juntaDirectivaTableAdapter;
        private Proyecto_ADIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox id_JuntaDirectivaTextBox;
        private System.Windows.Forms.TextBox id_AfiliadoTextBox;
        private System.Windows.Forms.ComboBox nombre_Puesto_JuntaComboBox;
        private System.Windows.Forms.TextBox periodoTextBox;
        private Proyecto_ADIDataSetTableAdapters.AfiliadosTableAdapter afiliadosTableAdapter;
        private System.Windows.Forms.GroupBox groupconsulta;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label lb_tipo_consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ced_nombre;
        private System.Windows.Forms.ComboBox cmb_tipo_ced_nomb;
        private System.Windows.Forms.BindingSource afiliadosBindingSource;
        private System.Windows.Forms.DataGridView afiliadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}