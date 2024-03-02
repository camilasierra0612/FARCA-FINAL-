namespace Servicio_actas_farmaceuticas
{
    partial class Registro_laboratorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_laboratorio));
            this.btnRegresarMenu = new System.Windows.Forms.Button();
            this.cmbEstadoLaboratorio = new System.Windows.Forms.ComboBox();
            this.txtNombreLaboratorio = new System.Windows.Forms.TextBox();
            this.lblNombreLaboratorio = new System.Windows.Forms.Label();
            this.lblRegistroLaboratorio = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnRegresarActas = new System.Windows.Forms.Button();
            this.btnCrearLaboratorio = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresarMenu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarMenu.Location = new System.Drawing.Point(12, 451);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(285, 36);
            this.btnRegresarMenu.TabIndex = 33;
            this.btnRegresarMenu.Text = "Regresar al menú de opciones";
            this.btnRegresarMenu.UseVisualStyleBackColor = true;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cmbEstadoLaboratorio
            // 
            this.cmbEstadoLaboratorio.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoLaboratorio.FormattingEnabled = true;
            this.cmbEstadoLaboratorio.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoLaboratorio.Location = new System.Drawing.Point(89, 301);
            this.cmbEstadoLaboratorio.Name = "cmbEstadoLaboratorio";
            this.cmbEstadoLaboratorio.Size = new System.Drawing.Size(373, 23);
            this.cmbEstadoLaboratorio.TabIndex = 31;
            // 
            // txtNombreLaboratorio
            // 
            this.txtNombreLaboratorio.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLaboratorio.Location = new System.Drawing.Point(89, 246);
            this.txtNombreLaboratorio.Name = "txtNombreLaboratorio";
            this.txtNombreLaboratorio.Size = new System.Drawing.Size(373, 21);
            this.txtNombreLaboratorio.TabIndex = 30;
            // 
            // lblNombreLaboratorio
            // 
            this.lblNombreLaboratorio.AutoSize = true;
            this.lblNombreLaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreLaboratorio.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLaboratorio.Location = new System.Drawing.Point(86, 228);
            this.lblNombreLaboratorio.Name = "lblNombreLaboratorio";
            this.lblNombreLaboratorio.Size = new System.Drawing.Size(376, 15);
            this.lblNombreLaboratorio.TabIndex = 29;
            this.lblNombreLaboratorio.Text = "Nombre del laboratorio que fabrica el producto a recibir:";
            // 
            // lblRegistroLaboratorio
            // 
            this.lblRegistroLaboratorio.AutoSize = true;
            this.lblRegistroLaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroLaboratorio.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroLaboratorio.Location = new System.Drawing.Point(256, 147);
            this.lblRegistroLaboratorio.Name = "lblRegistroLaboratorio";
            this.lblRegistroLaboratorio.Size = new System.Drawing.Size(399, 38);
            this.lblRegistroLaboratorio.TabIndex = 34;
            this.lblRegistroLaboratorio.Text = "Registro de laboratorio";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(86, 283);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(156, 15);
            this.lblEstado.TabIndex = 35;
            this.lblEstado.Text = "Estado del laboratorio:";
            // 
            // btnRegresarActas
            // 
            this.btnRegresarActas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresarActas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarActas.Location = new System.Drawing.Point(12, 409);
            this.btnRegresarActas.Name = "btnRegresarActas";
            this.btnRegresarActas.Size = new System.Drawing.Size(285, 36);
            this.btnRegresarActas.TabIndex = 36;
            this.btnRegresarActas.Text = "Regresar a formulario de actas";
            this.btnRegresarActas.UseVisualStyleBackColor = true;
            this.btnRegresarActas.Click += new System.EventHandler(this.btnRegresarActas_Click);
            // 
            // btnCrearLaboratorio
            // 
            this.btnCrearLaboratorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearLaboratorio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearLaboratorio.Location = new System.Drawing.Point(551, 228);
            this.btnCrearLaboratorio.Name = "btnCrearLaboratorio";
            this.btnCrearLaboratorio.Size = new System.Drawing.Size(235, 36);
            this.btnCrearLaboratorio.TabIndex = 37;
            this.btnCrearLaboratorio.Text = "Crear nuevo laboratorio";
            this.btnCrearLaboratorio.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(551, 312);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(235, 36);
            this.btnLimpiarCampos.TabIndex = 38;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(551, 270);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(235, 36);
            this.btnActualizar.TabIndex = 84;
            this.btnActualizar.Text = "Actualizar datos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(753, 358);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 36);
            this.btnSalir.TabIndex = 85;
            this.btnSalir.Text = "Salida segura";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Registro_laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(894, 509);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnCrearLaboratorio);
            this.Controls.Add(this.btnRegresarActas);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblRegistroLaboratorio);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.cmbEstadoLaboratorio);
            this.Controls.Add(this.txtNombreLaboratorio);
            this.Controls.Add(this.lblNombreLaboratorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_laboratorio";
            this.Text = "Registro de laboratorios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarMenu;
        private System.Windows.Forms.ComboBox cmbEstadoLaboratorio;
        private System.Windows.Forms.TextBox txtNombreLaboratorio;
        private System.Windows.Forms.Label lblNombreLaboratorio;
        private System.Windows.Forms.Label lblRegistroLaboratorio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnRegresarActas;
        private System.Windows.Forms.Button btnCrearLaboratorio;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
    }
}