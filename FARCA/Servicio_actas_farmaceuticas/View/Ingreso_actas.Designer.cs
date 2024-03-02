namespace Servicio_actas_farmaceuticas
{
    partial class Ingreso_actas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ingreso_actas));
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.lblCosecutivo = new System.Windows.Forms.Label();
            this.gpbAprobación = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSí = new System.Windows.Forms.RadioButton();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbRegistro = new System.Windows.Forms.ComboBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dttFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNumeroUnidades = new System.Windows.Forms.Label();
            this.cmbNumeroUnidades = new System.Windows.Forms.ComboBox();
            this.gpbRotuloPrimario = new System.Windows.Forms.GroupBox();
            this.rdbNoCumpleP = new System.Windows.Forms.RadioButton();
            this.rdbCumpleP = new System.Windows.Forms.RadioButton();
            this.gpbRotuloSecundario = new System.Windows.Forms.GroupBox();
            this.rdbNoCumpleS = new System.Windows.Forms.RadioButton();
            this.rdbCumpleS = new System.Windows.Forms.RadioButton();
            this.gpbAusenciaDefectos = new System.Windows.Forms.GroupBox();
            this.rdbNoCumpleD = new System.Windows.Forms.RadioButton();
            this.rdbCumpleD = new System.Windows.Forms.RadioButton();
            this.gpbEstadoProducto = new System.Windows.Forms.GroupBox();
            this.rdbRechazado = new System.Windows.Forms.RadioButton();
            this.rdbAceptado = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblFormularioActa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbLaboratorio = new System.Windows.Forms.ComboBox();
            this.btnCrearLaboratorio = new System.Windows.Forms.Button();
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.btnCrearEmpresa = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gpbAprobación.SuspendLayout();
            this.gpbRotuloPrimario.SuspendLayout();
            this.gpbRotuloSecundario.SuspendLayout();
            this.gpbAusenciaDefectos.SuspendLayout();
            this.gpbEstadoProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(17, 162);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(155, 15);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Empresa que abastece:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Items.AddRange(new object[] {
            "Empresa 1",
            "Empresa 2",
            "Empresa 3"});
            this.cmbEmpresa.Location = new System.Drawing.Point(20, 181);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(208, 23);
            this.cmbEmpresa.TabIndex = 1;
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsecutivo.Location = new System.Drawing.Point(670, 125);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.Size = new System.Drawing.Size(208, 21);
            this.txtConsecutivo.TabIndex = 2;
            // 
            // lblCosecutivo
            // 
            this.lblCosecutivo.AutoSize = true;
            this.lblCosecutivo.BackColor = System.Drawing.Color.Transparent;
            this.lblCosecutivo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosecutivo.Location = new System.Drawing.Point(504, 125);
            this.lblCosecutivo.Name = "lblCosecutivo";
            this.lblCosecutivo.Size = new System.Drawing.Size(160, 15);
            this.lblCosecutivo.TabIndex = 3;
            this.lblCosecutivo.Text = "Consecutivo de factura:";
            // 
            // gpbAprobación
            // 
            this.gpbAprobación.BackColor = System.Drawing.Color.Transparent;
            this.gpbAprobación.Controls.Add(this.rdbNo);
            this.gpbAprobación.Controls.Add(this.rdbSí);
            this.gpbAprobación.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAprobación.Location = new System.Drawing.Point(20, 222);
            this.gpbAprobación.Name = "gpbAprobación";
            this.gpbAprobación.Size = new System.Drawing.Size(275, 70);
            this.gpbAprobación.TabIndex = 7;
            this.gpbAprobación.TabStop = false;
            this.gpbAprobación.Text = "Aprobación por químico frmacéutico:";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(6, 45);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(42, 19);
            this.rdbNo.TabIndex = 9;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSí
            // 
            this.rdbSí.AutoSize = true;
            this.rdbSí.Location = new System.Drawing.Point(6, 20);
            this.rdbSí.Name = "rdbSí";
            this.rdbSí.Size = new System.Drawing.Size(38, 19);
            this.rdbSí.TabIndex = 8;
            this.rdbSí.TabStop = true;
            this.rdbSí.Text = "Sí";
            this.rdbSí.UseVisualStyleBackColor = true;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(17, 305);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(69, 15);
            this.lblProducto.TabIndex = 9;
            this.lblProducto.Text = "Producto:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "KETOPROFENO GEL",
            "BUMETIN(R) TABLETAS RETARD 300MG",
            "NEUTROGEL SUSPENSIÓN",
            "KETOTIFENO TABLETAS 1 MG",
            "ACYCLOVIR POLVO PARA SUSPENSION 200 MG/ 5ML"});
            this.cmbProducto.Location = new System.Drawing.Point(20, 323);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(208, 23);
            this.cmbProducto.TabIndex = 10;
            // 
            // cmbRegistro
            // 
            this.cmbRegistro.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegistro.FormattingEnabled = true;
            this.cmbRegistro.Items.AddRange(new object[] {
            "INVIMA 2022M-011174-R2",
            "INVIMA M-011182",
            "INVIMA M-007111-R1",
            "INVIMA M-004111",
            "M-011111"});
            this.cmbRegistro.Location = new System.Drawing.Point(20, 375);
            this.cmbRegistro.Name = "cmbRegistro";
            this.cmbRegistro.Size = new System.Drawing.Size(208, 23);
            this.cmbRegistro.TabIndex = 11;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(17, 357);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(130, 15);
            this.lblRegistro.TabIndex = 12;
            this.lblRegistro.Text = "Registro sanitario:";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.lblLaboratorio.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.Location = new System.Drawing.Point(17, 415);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(89, 15);
            this.lblLaboratorio.TabIndex = 13;
            this.lblLaboratorio.Text = "Laboratorio:";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(319, 183);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(208, 21);
            this.txtMarca.TabIndex = 16;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(316, 162);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(272, 15);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca del producto que se va a registrar:";
            // 
            // txtLote
            // 
            this.txtLote.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(319, 240);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(208, 21);
            this.txtLote.TabIndex = 18;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.BackColor = System.Drawing.Color.Transparent;
            this.lblLote.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(316, 222);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(123, 15);
            this.lblLote.TabIndex = 17;
            this.lblLote.Text = "Lote del producto:";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(316, 286);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(211, 15);
            this.lblFechaVencimiento.TabIndex = 19;
            this.lblFechaVencimiento.Text = "Fecha en que vence el producto:";
            // 
            // dttFechaVencimiento
            // 
            this.dttFechaVencimiento.Location = new System.Drawing.Point(319, 305);
            this.dttFechaVencimiento.Name = "dttFechaVencimiento";
            this.dttFechaVencimiento.Size = new System.Drawing.Size(208, 20);
            this.dttFechaVencimiento.TabIndex = 20;
            // 
            // lblNumeroUnidades
            // 
            this.lblNumeroUnidades.AutoSize = true;
            this.lblNumeroUnidades.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroUnidades.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroUnidades.Location = new System.Drawing.Point(316, 344);
            this.lblNumeroUnidades.Name = "lblNumeroUnidades";
            this.lblNumeroUnidades.Size = new System.Drawing.Size(208, 15);
            this.lblNumeroUnidades.TabIndex = 21;
            this.lblNumeroUnidades.Text = "Número de unidades recibidas:";
            // 
            // cmbNumeroUnidades
            // 
            this.cmbNumeroUnidades.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumeroUnidades.FormattingEnabled = true;
            this.cmbNumeroUnidades.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cmbNumeroUnidades.Location = new System.Drawing.Point(319, 362);
            this.cmbNumeroUnidades.Name = "cmbNumeroUnidades";
            this.cmbNumeroUnidades.Size = new System.Drawing.Size(208, 23);
            this.cmbNumeroUnidades.TabIndex = 22;
            // 
            // gpbRotuloPrimario
            // 
            this.gpbRotuloPrimario.BackColor = System.Drawing.Color.Transparent;
            this.gpbRotuloPrimario.Controls.Add(this.rdbNoCumpleP);
            this.gpbRotuloPrimario.Controls.Add(this.rdbCumpleP);
            this.gpbRotuloPrimario.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRotuloPrimario.Location = new System.Drawing.Point(319, 401);
            this.gpbRotuloPrimario.Name = "gpbRotuloPrimario";
            this.gpbRotuloPrimario.Size = new System.Drawing.Size(259, 70);
            this.gpbRotuloPrimario.TabIndex = 10;
            this.gpbRotuloPrimario.TabStop = false;
            this.gpbRotuloPrimario.Text = "Rótulo del empaque primario:";
            // 
            // rdbNoCumpleP
            // 
            this.rdbNoCumpleP.AutoSize = true;
            this.rdbNoCumpleP.Location = new System.Drawing.Point(6, 45);
            this.rdbNoCumpleP.Name = "rdbNoCumpleP";
            this.rdbNoCumpleP.Size = new System.Drawing.Size(93, 19);
            this.rdbNoCumpleP.TabIndex = 9;
            this.rdbNoCumpleP.TabStop = true;
            this.rdbNoCumpleP.Text = "No cumple";
            this.rdbNoCumpleP.UseVisualStyleBackColor = true;
            // 
            // rdbCumpleP
            // 
            this.rdbCumpleP.AutoSize = true;
            this.rdbCumpleP.Location = new System.Drawing.Point(6, 20);
            this.rdbCumpleP.Name = "rdbCumpleP";
            this.rdbCumpleP.Size = new System.Drawing.Size(76, 19);
            this.rdbCumpleP.TabIndex = 8;
            this.rdbCumpleP.TabStop = true;
            this.rdbCumpleP.Text = "Cumple";
            this.rdbCumpleP.UseVisualStyleBackColor = true;
            // 
            // gpbRotuloSecundario
            // 
            this.gpbRotuloSecundario.BackColor = System.Drawing.Color.Transparent;
            this.gpbRotuloSecundario.Controls.Add(this.rdbNoCumpleS);
            this.gpbRotuloSecundario.Controls.Add(this.rdbCumpleS);
            this.gpbRotuloSecundario.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRotuloSecundario.Location = new System.Drawing.Point(619, 162);
            this.gpbRotuloSecundario.Name = "gpbRotuloSecundario";
            this.gpbRotuloSecundario.Size = new System.Drawing.Size(259, 70);
            this.gpbRotuloSecundario.TabIndex = 11;
            this.gpbRotuloSecundario.TabStop = false;
            this.gpbRotuloSecundario.Text = "Rótulo del empaque secundario:";
            // 
            // rdbNoCumpleS
            // 
            this.rdbNoCumpleS.AutoSize = true;
            this.rdbNoCumpleS.Location = new System.Drawing.Point(6, 45);
            this.rdbNoCumpleS.Name = "rdbNoCumpleS";
            this.rdbNoCumpleS.Size = new System.Drawing.Size(93, 19);
            this.rdbNoCumpleS.TabIndex = 9;
            this.rdbNoCumpleS.TabStop = true;
            this.rdbNoCumpleS.Text = "No cumple";
            this.rdbNoCumpleS.UseVisualStyleBackColor = true;
            // 
            // rdbCumpleS
            // 
            this.rdbCumpleS.AutoSize = true;
            this.rdbCumpleS.Location = new System.Drawing.Point(6, 20);
            this.rdbCumpleS.Name = "rdbCumpleS";
            this.rdbCumpleS.Size = new System.Drawing.Size(76, 19);
            this.rdbCumpleS.TabIndex = 8;
            this.rdbCumpleS.TabStop = true;
            this.rdbCumpleS.Text = "Cumple";
            this.rdbCumpleS.UseVisualStyleBackColor = true;
            // 
            // gpbAusenciaDefectos
            // 
            this.gpbAusenciaDefectos.BackColor = System.Drawing.Color.Transparent;
            this.gpbAusenciaDefectos.Controls.Add(this.rdbNoCumpleD);
            this.gpbAusenciaDefectos.Controls.Add(this.rdbCumpleD);
            this.gpbAusenciaDefectos.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAusenciaDefectos.Location = new System.Drawing.Point(619, 238);
            this.gpbAusenciaDefectos.Name = "gpbAusenciaDefectos";
            this.gpbAusenciaDefectos.Size = new System.Drawing.Size(259, 70);
            this.gpbAusenciaDefectos.TabIndex = 23;
            this.gpbAusenciaDefectos.TabStop = false;
            this.gpbAusenciaDefectos.Text = "Ausencia de defectos de fabricación:";
            // 
            // rdbNoCumpleD
            // 
            this.rdbNoCumpleD.AutoSize = true;
            this.rdbNoCumpleD.Location = new System.Drawing.Point(6, 45);
            this.rdbNoCumpleD.Name = "rdbNoCumpleD";
            this.rdbNoCumpleD.Size = new System.Drawing.Size(93, 19);
            this.rdbNoCumpleD.TabIndex = 9;
            this.rdbNoCumpleD.TabStop = true;
            this.rdbNoCumpleD.Text = "No cumple";
            this.rdbNoCumpleD.UseVisualStyleBackColor = true;
            // 
            // rdbCumpleD
            // 
            this.rdbCumpleD.AutoSize = true;
            this.rdbCumpleD.Location = new System.Drawing.Point(6, 20);
            this.rdbCumpleD.Name = "rdbCumpleD";
            this.rdbCumpleD.Size = new System.Drawing.Size(76, 19);
            this.rdbCumpleD.TabIndex = 8;
            this.rdbCumpleD.TabStop = true;
            this.rdbCumpleD.Text = "Cumple";
            this.rdbCumpleD.UseVisualStyleBackColor = true;
            // 
            // gpbEstadoProducto
            // 
            this.gpbEstadoProducto.BackColor = System.Drawing.Color.Transparent;
            this.gpbEstadoProducto.Controls.Add(this.rdbRechazado);
            this.gpbEstadoProducto.Controls.Add(this.rdbAceptado);
            this.gpbEstadoProducto.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEstadoProducto.Location = new System.Drawing.Point(619, 320);
            this.gpbEstadoProducto.Name = "gpbEstadoProducto";
            this.gpbEstadoProducto.Size = new System.Drawing.Size(259, 70);
            this.gpbEstadoProducto.TabIndex = 24;
            this.gpbEstadoProducto.TabStop = false;
            this.gpbEstadoProducto.Text = "Estado del producto:";
            // 
            // rdbRechazado
            // 
            this.rdbRechazado.AutoSize = true;
            this.rdbRechazado.Location = new System.Drawing.Point(6, 45);
            this.rdbRechazado.Name = "rdbRechazado";
            this.rdbRechazado.Size = new System.Drawing.Size(95, 19);
            this.rdbRechazado.TabIndex = 9;
            this.rdbRechazado.TabStop = true;
            this.rdbRechazado.Text = "Rechazado";
            this.rdbRechazado.UseVisualStyleBackColor = true;
            // 
            // rdbAceptado
            // 
            this.rdbAceptado.AutoSize = true;
            this.rdbAceptado.Location = new System.Drawing.Point(6, 20);
            this.rdbAceptado.Name = "rdbAceptado";
            this.rdbAceptado.Size = new System.Drawing.Size(85, 19);
            this.rdbAceptado.TabIndex = 8;
            this.rdbAceptado.TabStop = true;
            this.rdbAceptado.Text = "Aceptado";
            this.rdbAceptado.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(619, 432);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 25);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(6, 93);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 25);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblFormularioActa
            // 
            this.lblFormularioActa.AutoSize = true;
            this.lblFormularioActa.BackColor = System.Drawing.Color.Transparent;
            this.lblFormularioActa.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormularioActa.Location = new System.Drawing.Point(153, 103);
            this.lblFormularioActa.Name = "lblFormularioActa";
            this.lblFormularioActa.Size = new System.Drawing.Size(265, 38);
            this.lblFormularioActa.TabIndex = 27;
            this.lblFormularioActa.Text = "Ingreso de acta";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(619, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 25);
            this.button1.TabIndex = 28;
            this.button1.Text = "Limpiar campos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbLaboratorio
            // 
            this.cmbLaboratorio.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLaboratorio.FormattingEnabled = true;
            this.cmbLaboratorio.Items.AddRange(new object[] {
            "Lab1",
            "Lab2"});
            this.cmbLaboratorio.Location = new System.Drawing.Point(20, 433);
            this.cmbLaboratorio.Name = "cmbLaboratorio";
            this.cmbLaboratorio.Size = new System.Drawing.Size(208, 23);
            this.cmbLaboratorio.TabIndex = 29;
            // 
            // btnCrearLaboratorio
            // 
            this.btnCrearLaboratorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearLaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearLaboratorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearLaboratorio.BackgroundImage")));
            this.btnCrearLaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearLaboratorio.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrearLaboratorio.Location = new System.Drawing.Point(234, 433);
            this.btnCrearLaboratorio.Name = "btnCrearLaboratorio";
            this.btnCrearLaboratorio.Size = new System.Drawing.Size(28, 23);
            this.btnCrearLaboratorio.TabIndex = 30;
            this.btnCrearLaboratorio.Text = "...";
            this.btnCrearLaboratorio.UseVisualStyleBackColor = false;
            this.btnCrearLaboratorio.Click += new System.EventHandler(this.btnCrearLaboratorio_Click);
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearProducto.BackgroundImage")));
            this.btnCrearProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearProducto.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrearProducto.Location = new System.Drawing.Point(234, 323);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(28, 23);
            this.btnCrearProducto.TabIndex = 31;
            this.btnCrearProducto.Text = "...";
            this.btnCrearProducto.UseVisualStyleBackColor = false;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnCrearEmpresa
            // 
            this.btnCrearEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearEmpresa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearEmpresa.BackgroundImage")));
            this.btnCrearEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrearEmpresa.Location = new System.Drawing.Point(234, 181);
            this.btnCrearEmpresa.Name = "btnCrearEmpresa";
            this.btnCrearEmpresa.Size = new System.Drawing.Size(28, 23);
            this.btnCrearEmpresa.TabIndex = 32;
            this.btnCrearEmpresa.Text = "...";
            this.btnCrearEmpresa.UseVisualStyleBackColor = false;
            this.btnCrearEmpresa.Click += new System.EventHandler(this.btnCrearEmpresa_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(619, 478);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 25);
            this.btnSalir.TabIndex = 86;
            this.btnSalir.Text = "Salida segura";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Ingreso_actas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 508);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrearEmpresa);
            this.Controls.Add(this.btnCrearProducto);
            this.Controls.Add(this.btnCrearLaboratorio);
            this.Controls.Add(this.cmbLaboratorio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFormularioActa);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpbEstadoProducto);
            this.Controls.Add(this.gpbAusenciaDefectos);
            this.Controls.Add(this.gpbRotuloSecundario);
            this.Controls.Add(this.gpbRotuloPrimario);
            this.Controls.Add(this.cmbNumeroUnidades);
            this.Controls.Add(this.lblNumeroUnidades);
            this.Controls.Add(this.dttFechaVencimiento);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.cmbRegistro);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.gpbAprobación);
            this.Controls.Add(this.lblCosecutivo);
            this.Controls.Add(this.txtConsecutivo);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.lblEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ingreso_actas";
            this.Text = "Ingreso de actas";
            this.gpbAprobación.ResumeLayout(false);
            this.gpbAprobación.PerformLayout();
            this.gpbRotuloPrimario.ResumeLayout(false);
            this.gpbRotuloPrimario.PerformLayout();
            this.gpbRotuloSecundario.ResumeLayout(false);
            this.gpbRotuloSecundario.PerformLayout();
            this.gpbAusenciaDefectos.ResumeLayout(false);
            this.gpbAusenciaDefectos.PerformLayout();
            this.gpbEstadoProducto.ResumeLayout(false);
            this.gpbEstadoProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.Label lblCosecutivo;
        private System.Windows.Forms.GroupBox gpbAprobación;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSí;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbRegistro;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dttFechaVencimiento;
        private System.Windows.Forms.Label lblNumeroUnidades;
        private System.Windows.Forms.ComboBox cmbNumeroUnidades;
        private System.Windows.Forms.GroupBox gpbRotuloPrimario;
        private System.Windows.Forms.RadioButton rdbNoCumpleP;
        private System.Windows.Forms.RadioButton rdbCumpleP;
        private System.Windows.Forms.GroupBox gpbRotuloSecundario;
        private System.Windows.Forms.RadioButton rdbNoCumpleS;
        private System.Windows.Forms.RadioButton rdbCumpleS;
        private System.Windows.Forms.GroupBox gpbAusenciaDefectos;
        private System.Windows.Forms.RadioButton rdbNoCumpleD;
        private System.Windows.Forms.RadioButton rdbCumpleD;
        private System.Windows.Forms.GroupBox gpbEstadoProducto;
        private System.Windows.Forms.RadioButton rdbRechazado;
        private System.Windows.Forms.RadioButton rdbAceptado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblFormularioActa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbLaboratorio;
        private System.Windows.Forms.Button btnCrearLaboratorio;
        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnCrearEmpresa;
        private System.Windows.Forms.Button btnSalir;
    }
}