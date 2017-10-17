namespace ProyectoADI
{
    partial class Inicio_Sesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombre_UsuarioLabel;
            System.Windows.Forms.Label claveLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Sesion));
            this.nombre_UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoADIDataSet = new ProyectoADI.Proyecto_ADIDataSet();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.usuariosTableAdapter = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.TableAdapterManager();
            this.btnSalir = new System.Windows.Forms.Button();
            this.actividadesTableAdapter1 = new ProyectoADI.Proyecto_ADIDataSetTableAdapters.ActividadesTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            nombre_UsuarioLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoADIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_UsuarioLabel
            // 
            nombre_UsuarioLabel.AutoSize = true;
            nombre_UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_UsuarioLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            nombre_UsuarioLabel.Location = new System.Drawing.Point(227, 55);
            nombre_UsuarioLabel.Name = "nombre_UsuarioLabel";
            nombre_UsuarioLabel.Size = new System.Drawing.Size(143, 20);
            nombre_UsuarioLabel.TabIndex = 3;
            nombre_UsuarioLabel.Text = "Nombre Usuario:";
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            claveLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            claveLabel.Location = new System.Drawing.Point(263, 101);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(107, 20);
            claveLabel.TabIndex = 9;
            claveLabel.Text = "Contraseña:";
            // 
            // nombre_UsuarioTextBox
            // 
            this.nombre_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nombre_Usuario", true));
            this.nombre_UsuarioTextBox.Location = new System.Drawing.Point(376, 55);
            this.nombre_UsuarioTextBox.Name = "nombre_UsuarioTextBox";
            this.nombre_UsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_UsuarioTextBox.TabIndex = 4;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.proyectoADIDataSet;
            // 
            // proyectoADIDataSet
            // 
            this.proyectoADIDataSet.DataSetName = "ProyectoADIDataSet";
            this.proyectoADIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(376, 101);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(100, 20);
            this.claveTextBox.TabIndex = 10;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Image = global::ProyectoADI.Properties.Resources.Crystal_Clear_action_apply;
            this.btn_ingresar.Location = new System.Drawing.Point(267, 136);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 59);
            this.btn_ingresar.TabIndex = 11;
            this.btn_ingresar.Text = "&Entrar";
            this.btn_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
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
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Image = global::ProyectoADI.Properties.Resources.Crystal_Clear_app_logout;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(422, 127);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 59);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // actividadesTableAdapter1
            // 
            this.actividadesTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 197);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 251);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(nombre_UsuarioLabel);
            this.Controls.Add(this.nombre_UsuarioTextBox);
            this.Controls.Add(claveLabel);
            this.Controls.Add(this.claveTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio_Sesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesión";
            this.Load += new System.EventHandler(this.Inicio_Sesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoADIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Proyecto_ADIDataSet proyectoADIDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private Proyecto_ADIDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private Proyecto_ADIDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombre_UsuarioTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btnSalir;
        private Proyecto_ADIDataSetTableAdapters.ActividadesTableAdapter actividadesTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

