namespace ProyectoADI.Formularios.Usuarios
{
    partial class Agregar_Usuarios
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
            System.Windows.Forms.Label nombre_UsuarioLabel;
            System.Windows.Forms.Label id_JuntaDirectivaLabel;
            System.Windows.Forms.Label perfilLabel;
            System.Windows.Forms.Label claveLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nombre_UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyecto_ADIDataSet = new ProyectoADI.Proyecto_ADIDataSet();
            this.id_JuntaDirectivaTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.usuariosTableAdapter = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.TableAdapterManager();
            this.groupconsulta = new System.Windows.Forms.GroupBox();
            this.cmb_consultaJunta = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lb_tipo_consulta = new System.Windows.Forms.Label();
            this.juntaDirectivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juntaDirectivaTableAdapter = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.JuntaDirectivaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perfilComboBox = new System.Windows.Forms.ComboBox();
            nombre_UsuarioLabel = new System.Windows.Forms.Label();
            id_JuntaDirectivaLabel = new System.Windows.Forms.Label();
            perfilLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_ADIDataSet)).BeginInit();
            this.groupconsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.juntaDirectivaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_UsuarioLabel
            // 
            nombre_UsuarioLabel.AutoSize = true;
            nombre_UsuarioLabel.Location = new System.Drawing.Point(52, 48);
            nombre_UsuarioLabel.Name = "nombre_UsuarioLabel";
            nombre_UsuarioLabel.Size = new System.Drawing.Size(86, 13);
            nombre_UsuarioLabel.TabIndex = 2;
            nombre_UsuarioLabel.Text = "Nombre Usuario:";
            // 
            // id_JuntaDirectivaLabel
            // 
            id_JuntaDirectivaLabel.AutoSize = true;
            id_JuntaDirectivaLabel.Location = new System.Drawing.Point(52, 74);
            id_JuntaDirectivaLabel.Name = "id_JuntaDirectivaLabel";
            id_JuntaDirectivaLabel.Size = new System.Drawing.Size(93, 13);
            id_JuntaDirectivaLabel.TabIndex = 4;
            id_JuntaDirectivaLabel.Text = "Id Junta Directiva:";
            id_JuntaDirectivaLabel.Click += new System.EventHandler(this.id_JuntaDirectivaLabel_Click);
            // 
            // perfilLabel
            // 
            perfilLabel.AutoSize = true;
            perfilLabel.Location = new System.Drawing.Point(52, 100);
            perfilLabel.Name = "perfilLabel";
            perfilLabel.Size = new System.Drawing.Size(33, 13);
            perfilLabel.TabIndex = 6;
            perfilLabel.Text = "Perfil:";
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(52, 126);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 8;
            claveLabel.Text = "Clave:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.perfilComboBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(nombre_UsuarioLabel);
            this.groupBox1.Controls.Add(this.nombre_UsuarioTextBox);
            this.groupBox1.Controls.Add(id_JuntaDirectivaLabel);
            this.groupBox1.Controls.Add(this.id_JuntaDirectivaTextBox);
            this.groupBox1.Controls.Add(perfilLabel);
            this.groupBox1.Controls.Add(claveLabel);
            this.groupBox1.Controls.Add(this.claveTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Usuarios";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre_UsuarioTextBox
            // 
            this.nombre_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nombre_Usuario", true));
            this.nombre_UsuarioTextBox.Location = new System.Drawing.Point(151, 45);
            this.nombre_UsuarioTextBox.Name = "nombre_UsuarioTextBox";
            this.nombre_UsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_UsuarioTextBox.TabIndex = 3;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.proyecto_ADIDataSet;
            // 
            // proyecto_ADIDataSet
            // 
            this.proyecto_ADIDataSet.DataSetName = "Proyecto_ADIDataSet";
            this.proyecto_ADIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_JuntaDirectivaTextBox
            // 
            this.id_JuntaDirectivaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Id_JuntaDirectiva", true));
            this.id_JuntaDirectivaTextBox.Location = new System.Drawing.Point(151, 71);
            this.id_JuntaDirectivaTextBox.Name = "id_JuntaDirectivaTextBox";
            this.id_JuntaDirectivaTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_JuntaDirectivaTextBox.TabIndex = 5;
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(151, 123);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(100, 20);
            this.claveTextBox.TabIndex = 9;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.JuntaDirectivaTableAdapter = null;
            this.tableAdapterManager.Presupuesto_de_ActividadesTableAdapter = null;
            this.tableAdapterManager.ProyectosTableAdapter = null;
            this.tableAdapterManager.Recursos_NecesariosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoADI.Proyecto_ADIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // groupconsulta
            // 
            this.groupconsulta.Controls.Add(this.cmb_consultaJunta);
            this.groupconsulta.Controls.Add(this.btn_buscar);
            this.groupconsulta.Controls.Add(this.lb_tipo_consulta);
            this.groupconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupconsulta.Location = new System.Drawing.Point(309, 21);
            this.groupconsulta.Name = "groupconsulta";
            this.groupconsulta.Size = new System.Drawing.Size(301, 143);
            this.groupconsulta.TabIndex = 32;
            this.groupconsulta.TabStop = false;
            this.groupconsulta.Text = "Consulta Usuario";
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
            this.cmb_consultaJunta.Location = new System.Drawing.Point(38, 60);
            this.cmb_consultaJunta.Name = "cmb_consultaJunta";
            this.cmb_consultaJunta.Size = new System.Drawing.Size(121, 28);
            this.cmb_consultaJunta.TabIndex = 27;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(58, 94);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 26);
            this.btn_buscar.TabIndex = 26;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lb_tipo_consulta
            // 
            this.lb_tipo_consulta.AutoSize = true;
            this.lb_tipo_consulta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.juntaDirectivaBindingSource, "Periodo", true));
            this.lb_tipo_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tipo_consulta.Location = new System.Drawing.Point(6, 39);
            this.lb_tipo_consulta.Name = "lb_tipo_consulta";
            this.lb_tipo_consulta.Size = new System.Drawing.Size(247, 18);
            this.lb_tipo_consulta.TabIndex = 25;
            this.lb_tipo_consulta.Text = "Seccione el Periodo de la Junta";
            this.lb_tipo_consulta.Visible = false;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(348, 150);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // perfilComboBox
            // 
            this.perfilComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Perfil", true));
            this.perfilComboBox.FormattingEnabled = true;
            this.perfilComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.perfilComboBox.Location = new System.Drawing.Point(151, 96);
            this.perfilComboBox.Name = "perfilComboBox";
            this.perfilComboBox.Size = new System.Drawing.Size(100, 21);
            this.perfilComboBox.TabIndex = 11;
            // 
            // Agregar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 497);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupconsulta);
            this.Controls.Add(this.groupBox1);
            this.Name = "Agregar_Usuarios";
            this.Text = "Agregar_Usuarios";
            this.Load += new System.EventHandler(this.Agregar_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyecto_ADIDataSet)).EndInit();
            this.groupconsulta.ResumeLayout(false);
            this.groupconsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.juntaDirectivaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Proyecto_ADIDataSet proyecto_ADIDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private Proyecto_ADIDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private Proyecto_ADIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombre_UsuarioTextBox;
        private System.Windows.Forms.TextBox id_JuntaDirectivaTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.GroupBox groupconsulta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lb_tipo_consulta;
        private System.Windows.Forms.BindingSource juntaDirectivaBindingSource;
        private Proyecto_ADIDataSetTableAdapters.JuntaDirectivaTableAdapter juntaDirectivaTableAdapter;
        private System.Windows.Forms.ComboBox cmb_consultaJunta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox perfilComboBox;
    }
}