namespace ProyectoADI.Formularios.Afiliados
{
    partial class Afiliados
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
            this.cedulaTextBox = new System.Windows.Forms.TextBox();
            this.afiliadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoADIDataSet = new ProyectoADI.Proyecto_ADIDataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellido1TextBox = new System.Windows.Forms.TextBox();
            this.apellido2TextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_NacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.afiliadosTableAdapter = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.AfiliadosTableAdapter();
            this.tableAdapterManager = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.TableAdapterManager();
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
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoADIDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(33, 23);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(43, 13);
            cedulaLabel.TabIndex = 3;
            cedulaLabel.Text = "Cedula:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(33, 49);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // apellido1Label
            // 
            apellido1Label.AutoSize = true;
            apellido1Label.Location = new System.Drawing.Point(33, 75);
            apellido1Label.Name = "apellido1Label";
            apellido1Label.Size = new System.Drawing.Size(53, 13);
            apellido1Label.TabIndex = 7;
            apellido1Label.Text = "Apellido1:";
            // 
            // apellido2Label
            // 
            apellido2Label.AutoSize = true;
            apellido2Label.Location = new System.Drawing.Point(33, 101);
            apellido2Label.Name = "apellido2Label";
            apellido2Label.Size = new System.Drawing.Size(53, 13);
            apellido2Label.TabIndex = 9;
            apellido2Label.Text = "Apellido2:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(33, 127);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 11;
            direccionLabel.Text = "Direccion:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(33, 153);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(35, 13);
            edadLabel.TabIndex = 13;
            edadLabel.Text = "Edad:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(33, 179);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 15;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(33, 205);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 17;
            correoLabel.Text = "Correo:";
            // 
            // fecha_NacimientoLabel
            // 
            fecha_NacimientoLabel.AutoSize = true;
            fecha_NacimientoLabel.Location = new System.Drawing.Point(33, 232);
            fecha_NacimientoLabel.Name = "fecha_NacimientoLabel";
            fecha_NacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fecha_NacimientoLabel.TabIndex = 19;
            fecha_NacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(39, 259);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 25;
            estadoLabel.Text = "Estado:";
            // 
            // cedulaTextBox
            // 
            this.cedulaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Cedula", true));
            this.cedulaTextBox.Location = new System.Drawing.Point(135, 20);
            this.cedulaTextBox.Name = "cedulaTextBox";
            this.cedulaTextBox.Size = new System.Drawing.Size(200, 20);
            this.cedulaTextBox.TabIndex = 2;
            // 
            // afiliadosBindingSource
            // 
            this.afiliadosBindingSource.DataMember = "Afiliados";
            this.afiliadosBindingSource.DataSource = this.proyectoADIDataSet;
            // 
            // proyectoADIDataSet
            // 
            this.proyectoADIDataSet.DataSetName = "ProyectoADIDataSet";
            this.proyectoADIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(135, 46);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 3;
            // 
            // apellido1TextBox
            // 
            this.apellido1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Apellido1", true));
            this.apellido1TextBox.Location = new System.Drawing.Point(135, 72);
            this.apellido1TextBox.Name = "apellido1TextBox";
            this.apellido1TextBox.Size = new System.Drawing.Size(200, 20);
            this.apellido1TextBox.TabIndex = 4;
            // 
            // apellido2TextBox
            // 
            this.apellido2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Apellido2", true));
            this.apellido2TextBox.Location = new System.Drawing.Point(135, 98);
            this.apellido2TextBox.Name = "apellido2TextBox";
            this.apellido2TextBox.Size = new System.Drawing.Size(200, 20);
            this.apellido2TextBox.TabIndex = 5;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(135, 124);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 6;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(135, 150);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(200, 20);
            this.edadTextBox.TabIndex = 7;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(135, 176);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 8;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(135, 202);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(200, 20);
            this.correoTextBox.TabIndex = 9;
            // 
            // fecha_NacimientoDateTimePicker
            // 
            this.fecha_NacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.afiliadosBindingSource, "Fecha_Nacimiento", true));
            this.fecha_NacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_NacimientoDateTimePicker.Location = new System.Drawing.Point(135, 228);
            this.fecha_NacimientoDateTimePicker.Name = "fecha_NacimientoDateTimePicker";
            this.fecha_NacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_NacimientoDateTimePicker.TabIndex = 10;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(23, 19);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 0;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afiliadosBindingSource, "Estado", true));
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Activo",
            "Desactivo"});
            this.estadoComboBox.Location = new System.Drawing.Point(135, 256);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(121, 21);
            this.estadoComboBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Location = new System.Drawing.Point(379, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 65);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 13);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Afiliado";
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
            // Afiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 543);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoComboBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellido1Label);
            this.Controls.Add(this.apellido1TextBox);
            this.Controls.Add(apellido2Label);
            this.Controls.Add(this.apellido2TextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(fecha_NacimientoLabel);
            this.Controls.Add(this.fecha_NacimientoDateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Afiliados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Afiliados";
            this.Load += new System.EventHandler(this.Afiliados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.afiliadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoADIDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Proyecto_ADIDataSet proyectoADIDataSet;
        private System.Windows.Forms.BindingSource afiliadosBindingSource;
        private Proyecto_ADIDataSetTableAdapters.AfiliadosTableAdapter afiliadosTableAdapter;
        private Proyecto_ADIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cedulaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellido1TextBox;
        private System.Windows.Forms.TextBox apellido2TextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.DateTimePicker fecha_NacimientoDateTimePicker;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}