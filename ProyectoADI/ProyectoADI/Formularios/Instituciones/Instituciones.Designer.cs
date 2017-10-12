namespace ProyectoADI.Formularios.Instituciones
{
    partial class Instituciones
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label cedula_JuridicaLabel;
            System.Windows.Forms.Label descripcion_InstitucionLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label representante_Legal_InstitucionLabel;
            System.Windows.Forms.Label nombre_EncargadoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.cedula_JuridicaTextBox = new System.Windows.Forms.TextBox();
            this.descripcion_InstitucionTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.representante_Legal_InstitucionTextBox = new System.Windows.Forms.TextBox();
            this.nombre_EncargadoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.institucionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyecto_ADIDataSet = new ProyectoADI.Proyecto_ADIDataSet();
            this.institucionesTableAdapter = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.InstitucionesTableAdapter();
            this.tableAdapterManager = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.TableAdapterManager();
            nombreLabel = new System.Windows.Forms.Label();
            cedula_JuridicaLabel = new System.Windows.Forms.Label();
            descripcion_InstitucionLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            representante_Legal_InstitucionLabel = new System.Windows.Forms.Label();
            nombre_EncargadoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.institucionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_ADIDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(21, 58);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // cedula_JuridicaLabel
            // 
            cedula_JuridicaLabel.AutoSize = true;
            cedula_JuridicaLabel.Location = new System.Drawing.Point(21, 27);
            cedula_JuridicaLabel.Name = "cedula_JuridicaLabel";
            cedula_JuridicaLabel.Size = new System.Drawing.Size(120, 13);
            cedula_JuridicaLabel.TabIndex = 4;
            cedula_JuridicaLabel.Text = "Cedula Juridica / Fisica:";
            // 
            // descripcion_InstitucionLabel
            // 
            descripcion_InstitucionLabel.AutoSize = true;
            descripcion_InstitucionLabel.Location = new System.Drawing.Point(21, 89);
            descripcion_InstitucionLabel.Name = "descripcion_InstitucionLabel";
            descripcion_InstitucionLabel.Size = new System.Drawing.Size(117, 13);
            descripcion_InstitucionLabel.TabIndex = 6;
            descripcion_InstitucionLabel.Text = "Descripcion Institucion:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(21, 120);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 8;
            direccionLabel.Text = "Direccion:";
            // 
            // representante_Legal_InstitucionLabel
            // 
            representante_Legal_InstitucionLabel.AutoSize = true;
            representante_Legal_InstitucionLabel.Location = new System.Drawing.Point(21, 151);
            representante_Legal_InstitucionLabel.Name = "representante_Legal_InstitucionLabel";
            representante_Legal_InstitucionLabel.Size = new System.Drawing.Size(160, 13);
            representante_Legal_InstitucionLabel.TabIndex = 10;
            representante_Legal_InstitucionLabel.Text = "Representante Legal Institucion:";
            // 
            // nombre_EncargadoLabel
            // 
            nombre_EncargadoLabel.AutoSize = true;
            nombre_EncargadoLabel.Location = new System.Drawing.Point(21, 182);
            nombre_EncargadoLabel.Name = "nombre_EncargadoLabel";
            nombre_EncargadoLabel.Size = new System.Drawing.Size(102, 13);
            nombre_EncargadoLabel.TabIndex = 12;
            nombre_EncargadoLabel.Text = "Nombre Encargado:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(21, 213);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 14;
            correoLabel.Text = "Correo:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(21, 244);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 16;
            telefonoLabel.Text = "Telefono:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.cedula_JuridicaTextBox);
            this.groupBox1.Controls.Add(this.descripcion_InstitucionTextBox);
            this.groupBox1.Controls.Add(this.direccionTextBox);
            this.groupBox1.Controls.Add(this.representante_Legal_InstitucionTextBox);
            this.groupBox1.Controls.Add(this.nombre_EncargadoTextBox);
            this.groupBox1.Controls.Add(this.correoTextBox);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Controls.Add(this.btn_volver);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(cedula_JuridicaLabel);
            this.groupBox1.Controls.Add(descripcion_InstitucionLabel);
            this.groupBox1.Controls.Add(direccionLabel);
            this.groupBox1.Controls.Add(representante_Legal_InstitucionLabel);
            this.groupBox1.Controls.Add(nombre_EncargadoLabel);
            this.groupBox1.Controls.Add(correoLabel);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Instituciones";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institucionesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(187, 55);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(230, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // cedula_JuridicaTextBox
            // 
            this.cedula_JuridicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institucionesBindingSource, "Cedula_Juridica", true));
            this.cedula_JuridicaTextBox.Location = new System.Drawing.Point(187, 24);
            this.cedula_JuridicaTextBox.Name = "cedula_JuridicaTextBox";
            this.cedula_JuridicaTextBox.Size = new System.Drawing.Size(130, 20);
            this.cedula_JuridicaTextBox.TabIndex = 0;
            // 
            // descripcion_InstitucionTextBox
            // 
            this.descripcion_InstitucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institucionesBindingSource, "Descripcion_Institucion", true));
            this.descripcion_InstitucionTextBox.Location = new System.Drawing.Point(187, 86);
            this.descripcion_InstitucionTextBox.Name = "descripcion_InstitucionTextBox";
            this.descripcion_InstitucionTextBox.Size = new System.Drawing.Size(238, 20);
            this.descripcion_InstitucionTextBox.TabIndex = 2;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institucionesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(187, 117);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(238, 20);
            this.direccionTextBox.TabIndex = 3;
            // 
            // representante_Legal_InstitucionTextBox
            // 
            this.representante_Legal_InstitucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institucionesBindingSource, "Representante_Legal_Institucion", true));
            this.representante_Legal_InstitucionTextBox.Location = new System.Drawing.Point(187, 148);
            this.representante_Legal_InstitucionTextBox.Name = "representante_Legal_InstitucionTextBox";
            this.representante_Legal_InstitucionTextBox.Size = new System.Drawing.Size(238, 20);
            this.representante_Legal_InstitucionTextBox.TabIndex = 4;
            // 
            // nombre_EncargadoTextBox
            // 
            this.nombre_EncargadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institucionesBindingSource, "Nombre_Encargado", true));
            this.nombre_EncargadoTextBox.Location = new System.Drawing.Point(187, 179);
            this.nombre_EncargadoTextBox.Name = "nombre_EncargadoTextBox";
            this.nombre_EncargadoTextBox.Size = new System.Drawing.Size(238, 20);
            this.nombre_EncargadoTextBox.TabIndex = 5;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institucionesBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(187, 210);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(238, 20);
            this.correoTextBox.TabIndex = 6;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institucionesBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(187, 241);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(147, 20);
            this.telefonoTextBox.TabIndex = 7;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(216, 283);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(408, 283);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // institucionesBindingSource
            // 
            this.institucionesBindingSource.DataMember = "Instituciones";
            this.institucionesBindingSource.DataSource = this.proyecto_ADIDataSet;
            // 
            // proyecto_ADIDataSet
            // 
            this.proyecto_ADIDataSet.DataSetName = "Proyecto_ADIDataSet";
            this.proyecto_ADIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // institucionesTableAdapter
            // 
            this.institucionesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.InstitucionesTableAdapter = this.institucionesTableAdapter;
            this.tableAdapterManager.JuntaDirectivaTableAdapter = null;
            this.tableAdapterManager.Presupuesto_de_ActividadesTableAdapter = null;
            this.tableAdapterManager.ProyectosTableAdapter = null;
            this.tableAdapterManager.Recursos_NecesariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoADI.Proyecto_ADIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // Instituciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 359);
            this.Controls.Add(this.groupBox1);
            this.Name = "Instituciones";
            this.Text = "Instituciones";
            this.Load += new System.EventHandler(this.Instituciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.institucionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_ADIDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_volver;
        private Proyecto_ADIDataSet proyecto_ADIDataSet;
        private System.Windows.Forms.BindingSource institucionesBindingSource;
        private Proyecto_ADIDataSetTableAdapters.InstitucionesTableAdapter institucionesTableAdapter;
        private Proyecto_ADIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox cedula_JuridicaTextBox;
        private System.Windows.Forms.TextBox descripcion_InstitucionTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox representante_Legal_InstitucionTextBox;
        private System.Windows.Forms.TextBox nombre_EncargadoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
    }
}