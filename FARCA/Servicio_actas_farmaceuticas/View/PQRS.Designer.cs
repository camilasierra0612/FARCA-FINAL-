namespace Servicio_actas_farmaceuticas.View
{
    partial class PQRS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PQRS));
            this.lblRegistroLaboratorio = new System.Windows.Forms.Label();
            this.cbxSolicitud = new System.Windows.Forms.ComboBox();
            this.lblSolicitud = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.fechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistroLaboratorio
            // 
            this.lblRegistroLaboratorio.AutoSize = true;
            this.lblRegistroLaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistroLaboratorio.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroLaboratorio.Location = new System.Drawing.Point(373, 106);
            this.lblRegistroLaboratorio.Name = "lblRegistroLaboratorio";
            this.lblRegistroLaboratorio.Size = new System.Drawing.Size(112, 38);
            this.lblRegistroLaboratorio.TabIndex = 37;
            this.lblRegistroLaboratorio.Text = "PQRS";
            // 
            // cbxSolicitud
            // 
            this.cbxSolicitud.FormattingEnabled = true;
            this.cbxSolicitud.Items.AddRange(new object[] {
            "Petición",
            "Queja",
            "Reclamo"});
            this.cbxSolicitud.Location = new System.Drawing.Point(38, 202);
            this.cbxSolicitud.Name = "cbxSolicitud";
            this.cbxSolicitud.Size = new System.Drawing.Size(250, 21);
            this.cbxSolicitud.TabIndex = 38;
            // 
            // lblSolicitud
            // 
            this.lblSolicitud.AutoSize = true;
            this.lblSolicitud.BackColor = System.Drawing.Color.Transparent;
            this.lblSolicitud.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitud.Location = new System.Drawing.Point(35, 165);
            this.lblSolicitud.Name = "lblSolicitud";
            this.lblSolicitud.Size = new System.Drawing.Size(114, 15);
            this.lblSolicitud.TabIndex = 110;
            this.lblSolicitud.Text = "Tipo de solicitud";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(35, 265);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(105, 15);
            this.lblFecha.TabIndex = 111;
            this.lblFecha.Text = "Fecha solicitud";
            // 
            // fechaSolicitud
            // 
            this.fechaSolicitud.Location = new System.Drawing.Point(38, 315);
            this.fechaSolicitud.Name = "fechaSolicitud";
            this.fechaSolicitud.Size = new System.Drawing.Size(250, 20);
            this.fechaSolicitud.TabIndex = 112;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacion.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(380, 165);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(88, 15);
            this.lblObservacion.TabIndex = 113;
            this.lblObservacion.Text = "Observación";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(385, 203);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(494, 132);
            this.txtObservacion.TabIndex = 114;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(385, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 36);
            this.btnGuardar.TabIndex = 128;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(750, 106);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 36);
            this.btnSalir.TabIndex = 129;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PQRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 499);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.fechaSolicitud);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblSolicitud);
            this.Controls.Add(this.cbxSolicitud);
            this.Controls.Add(this.lblRegistroLaboratorio);
            this.Name = "PQRS";
            this.Text = "PQRS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroLaboratorio;
        private System.Windows.Forms.ComboBox cbxSolicitud;
        private System.Windows.Forms.Label lblSolicitud;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker fechaSolicitud;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
    }
}