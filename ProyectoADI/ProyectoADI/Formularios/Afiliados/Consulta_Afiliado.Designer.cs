namespace ProyectoADI.Formularios.Afiliados
{
    partial class ConsultaAfiliado
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
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellido1Label;
            System.Windows.Forms.Label apellido2Label;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label fecha_NacimientoLabel;
            System.Windows.Forms.Label estadoLabel;
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
            this.afiliadosTableAdapter = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.AfiliadosTableAdapter();
            this.tableAdapterManager = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cedulaLabel2 = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.Button();
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellido1TextBox = new System.Windows.Forms.TextBox();
            this.apellido2TextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_NacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            cedulaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellido1Label = new System.Windows.Forms.Label();
            apellido2Label = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            fecha_NacimientoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.groupconsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_ADIDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(193, 83);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 2;
            cedulaLabel.Text = "Cedula:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(193, 109);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            // 
            // apellido1Label
            // 
            apellido1Label.AutoSize = true;
            apellido1Label.Location = new System.Drawing.Point(193, 135);
            apellido1Label.Name = "apellido1Label";
            apellido1Label.Size = new System.Drawing.Size(53, 13);
            apellido1Label.TabIndex = 6;
            apellido1Label.Text = "Apellido1:";
            // 
            // apellido2Label
            // 
            apellido2Label.AutoSize = true;
            apellido2Label.Location = new System.Drawing.Point(193, 161);
            apellido2Label.Name = "apellido2Label";
            apellido2Label.Size = new System.Drawing.Size(53, 13);
            apellido2Label.TabIndex = 8;
            apellido2Label.Text = "Apellido2:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(193, 187);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 10;
            direccionLabel.Text = "Direccion:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(193, 213);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(35, 13);
            edadLabel.TabIndex = 12;
            edadLabel.Text = "Edad:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(193, 239);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(193, 265);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 16;
            correoLabel.Text = "Correo:";
            // 
            // fecha_NacimientoLabel
            // 
            fecha_NacimientoLabel.AutoSize = true;
            fecha_NacimientoLabel.Location = new System.Drawing.Point(193, 292);
            fecha_NacimientoLabel.Name = "fecha_NacimientoLabel";
            fecha_NacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fecha_NacimientoLabel.TabIndex = 18;
            fecha_NacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(193, 317);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 20;
            estadoLabel.Text = "Estado:";
            // 
            // groupconsulta
            // 
            this.groupconsulta.Controls.Add(this.btn_editar);
            this.groupconsulta.Controls.Add(this.lb_tipo_consulta);
            this.groupconsulta.Controls.Add(this.label1);
            this.groupconsulta.Controls.Add(this.txt_ced_nombre);
            this.groupconsulta.Controls.Add(this.cmb_tipo_ced_nomb);
            this.groupconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupconsulta.Location = new System.Drawing.Point(234, 23);
            this.groupconsulta.Name = "groupconsulta";
            this.groupconsulta.Size = new System.Drawing.Size(420, 143);
            this.groupconsulta.TabIndex = 31;
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
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
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
            this.lb_tipo_consulta.Click += new System.EventHandler(this.lb_tipo_consulta_Click);
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
            this.cmb_tipo_ced_nomb.SelectedValueChanged += new System.EventHandler(this.cmb_tipo_ced_nomb_SelectedIndexChanged);
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
            this.afiliadosDataGridView.Location = new System.Drawing.Point(18, 207);
            this.afiliadosDataGridView.Name = "afiliadosDataGridView";
            this.afiliadosDataGridView.ReadOnly = true;
            this.afiliadosDataGridView.Size = new System.Drawing.Size(817, 220);
            this.afiliadosDataGridView.TabIndex = 32;
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
            // afiliadosTableAdapter
            // 
            this.afiliadosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.JuntaDirectivaTableAdapter = null;
            this.tableAdapterManager.Presupuesto_de_ActividadesTableAdapter = null;
            this.tableAdapterManager.ProyectosTableAdapter = null;
            this.tableAdapterManager.Recursos_NecesariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoADI.Proyecto_ADIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cedulaLabel2);
            this.panel1.Controls.Add(this.m);
            this.panel1.Controls.Add(cedulaLabel);
            this.panel1.Controls.Add(this.cedulaTextBox);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(apellido1Label);
            this.panel1.Controls.Add(this.apellido1TextBox);
            this.panel1.Controls.Add(apellido2Label);
            this.panel1.Controls.Add(this.apellido2TextBox);
            this.panel1.Controls.Add(direccionLabel);
            this.panel1.Controls.Add(this.direccionTextBox);
            this.panel1.Controls.Add(edadLabel);
            this.panel1.Controls.Add(this.edadTextBox);
            this.panel1.Controls.Add(telefonoLabel);
            this.panel1.Controls.Add(this.telefonoTextBox);
            this.panel1.Controls.Add(correoLabel);
            this.panel1.Controls.Add(this.correoTextBox);
            this.panel1.Controls.Add(fecha_NacimientoLabel);
            this.panel1.Controls.Add(this.fecha_NacimientoDateTimePicker);
            this.panel1.Controls.Add(estadoLabel);
            this.panel1.Controls.Add(this.estadoComboBox);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 415);
            this.panel1.TabIndex = 33;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cedulaLabel2
            // 
            this.cedulaLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Cedula", true));
            this.cedulaLabel2.Location = new System.Drawing.Point(29, 29);
            this.cedulaLabel2.Name = "cedulaLabel2";
            this.cedulaLabel2.Size = new System.Drawing.Size(10, 10);
            this.cedulaLabel2.TabIndex = 28;
            this.cedulaLabel2.Text = "label1";
            this.cedulaLabel2.Visible = false;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(556, 132);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(156, 51);
            this.m.TabIndex = 22;
            this.m.Text = "Modificar";
            this.m.UseVisualStyleBackColor = true;
            this.m.Click += new System.EventHandler(this.m_Click);
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Cedula", true));
            this.cedulaTextBox.Enabled = false;
            this.cedulaTextBox.Location = new System.Drawing.Point(295, 80);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(200, 20);
            this.cedulaTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(295, 106);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // apellido1TextBox
            // 
            this.apellido1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Apellido1", true));
            this.apellido1TextBox.Location = new System.Drawing.Point(295, 132);
            this.apellido1TextBox.Name = "apellido1TextBox";
            this.apellido1TextBox.Size = new System.Drawing.Size(200, 20);
            this.apellido1TextBox.TabIndex = 7;
            // 
            // apellido2TextBox
            // 
            this.apellido2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Apellido2", true));
            this.apellido2TextBox.Location = new System.Drawing.Point(295, 158);
            this.apellido2TextBox.Name = "apellido2TextBox";
            this.apellido2TextBox.Size = new System.Drawing.Size(200, 20);
            this.apellido2TextBox.TabIndex = 9;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(295, 184);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 11;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(295, 210);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(200, 20);
            this.edadTextBox.TabIndex = 13;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(295, 236);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(295, 262);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(200, 20);
            this.correoTextBox.TabIndex = 17;
            // 
            // fecha_NacimientoDateTimePicker
            // 
            this.fecha_NacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.afiliadosBindingSource, "Fecha_Nacimiento", true));
            this.fecha_NacimientoDateTimePicker.Location = new System.Drawing.Point(295, 288);
            this.fecha_NacimientoDateTimePicker.Name = "fecha_NacimientoDateTimePicker";
            this.fecha_NacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_NacimientoDateTimePicker.TabIndex = 19;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(295, 314);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(200, 21);
            this.estadoComboBox.TabIndex = 21;
            // 
            // ConsultaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 476);
            this.Controls.Add(this.afiliadosDataGridView);
            this.Controls.Add(this.groupconsulta);
            this.Controls.Add(this.panel1);
            this.Name = "ConsultaAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta_Afiliado";
            this.Load += new System.EventHandler(this.Consulta_Afiliado_Load);
            this.groupconsulta.ResumeLayout(false);
            this.groupconsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_ADIDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupconsulta;
        private System.Windows.Forms.Label lb_tipo_consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ced_nombre;
        private System.Windows.Forms.ComboBox cmb_tipo_ced_nomb;
        private Proyecto_ADIDataSet proyecto_ADIDataSet;
        private System.Windows.Forms.BindingSource afiliadosBindingSource;
        private Proyecto_ADIDataSetTableAdapters.AfiliadosTableAdapter afiliadosTableAdapter;
        private Proyecto_ADIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button m;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellido1TextBox;
        private System.Windows.Forms.TextBox apellido2TextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.DateTimePicker fecha_NacimientoDateTimePicker;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.Label cedulaLabel2;
    }
}