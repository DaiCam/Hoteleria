namespace Hoteleria
{
    partial class Form2
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
            this.calendar1 = new System.Windows.Forms.MonthCalendar();
            this.calendar2 = new System.Windows.Forms.MonthCalendar();
            this.txtCheckIn = new System.Windows.Forms.TextBox();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptarReserva = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantAdultos = new System.Windows.Forms.TextBox();
            this.txtCantMenores = new System.Windows.Forms.TextBox();
            this.txtCantHab = new System.Windows.Forms.TextBox();
            this.CboxTipoHab = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboxTipoCama = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comBoxCliente = new System.Windows.Forms.ComboBox();
            this.bLLClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bLLReservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.txtCantDias = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBMontoCalc = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFechanac = new System.Windows.Forms.TextBox();
            this.ID_cliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bLLClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLLReservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calendar1
            // 
            this.calendar1.BackColor = System.Drawing.Color.White;
            this.calendar1.Location = new System.Drawing.Point(23, 81);
            this.calendar1.Margin = new System.Windows.Forms.Padding(7);
            this.calendar1.Name = "calendar1";
            this.calendar1.TabIndex = 1;
            this.calendar1.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.calendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar1_DateSelected);
            // 
            // calendar2
            // 
            this.calendar2.Location = new System.Drawing.Point(311, 81);
            this.calendar2.Margin = new System.Windows.Forms.Padding(7);
            this.calendar2.Name = "calendar2";
            this.calendar2.TabIndex = 2;
            this.calendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar2_DateSelected);
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCheckIn.Location = new System.Drawing.Point(79, 58);
            this.txtCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(96, 20);
            this.txtCheckIn.TabIndex = 3;
            this.txtCheckIn.Click += new System.EventHandler(this.txtCheckIn_Click);
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCheckOut.Location = new System.Drawing.Point(375, 58);
            this.txtCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(92, 20);
            this.txtCheckOut.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Check-in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Check-out :";
            // 
            // btnAceptarReserva
            // 
            this.btnAceptarReserva.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarReserva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptarReserva.Location = new System.Drawing.Point(257, 485);
            this.btnAceptarReserva.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptarReserva.Name = "btnAceptarReserva";
            this.btnAceptarReserva.Size = new System.Drawing.Size(102, 30);
            this.btnAceptarReserva.TabIndex = 7;
            this.btnAceptarReserva.Text = "Aceptar";
            this.btnAceptarReserva.UseVisualStyleBackColor = false;
            this.btnAceptarReserva.Click += new System.EventHandler(this.btnAceptarReserva_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adultos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(566, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Menores de 10 años:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Habitaciones:";
            // 
            // txtCantAdultos
            // 
            this.txtCantAdultos.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCantAdultos.Location = new System.Drawing.Point(680, 118);
            this.txtCantAdultos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantAdultos.Name = "txtCantAdultos";
            this.txtCantAdultos.Size = new System.Drawing.Size(76, 20);
            this.txtCantAdultos.TabIndex = 11;
            // 
            // txtCantMenores
            // 
            this.txtCantMenores.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCantMenores.Location = new System.Drawing.Point(680, 140);
            this.txtCantMenores.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantMenores.Name = "txtCantMenores";
            this.txtCantMenores.Size = new System.Drawing.Size(76, 20);
            this.txtCantMenores.TabIndex = 12;
            // 
            // txtCantHab
            // 
            this.txtCantHab.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCantHab.Location = new System.Drawing.Point(680, 163);
            this.txtCantHab.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantHab.Name = "txtCantHab";
            this.txtCantHab.Size = new System.Drawing.Size(76, 20);
            this.txtCantHab.TabIndex = 13;
            // 
            // CboxTipoHab
            // 
            this.CboxTipoHab.BackColor = System.Drawing.Color.Cornsilk;
            this.CboxTipoHab.FormattingEnabled = true;
            this.CboxTipoHab.Items.AddRange(new object[] {
            "Junior",
            "Superior",
            "Deluxe"});
            this.CboxTipoHab.Location = new System.Drawing.Point(680, 203);
            this.CboxTipoHab.Margin = new System.Windows.Forms.Padding(2);
            this.CboxTipoHab.Name = "CboxTipoHab";
            this.CboxTipoHab.Size = new System.Drawing.Size(92, 21);
            this.CboxTipoHab.TabIndex = 14;
            this.CboxTipoHab.SelectedIndexChanged += new System.EventHandler(this.CboxTipoHab_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tipo de habitación:";
            // 
            // CboxTipoCama
            // 
            this.CboxTipoCama.BackColor = System.Drawing.Color.Cornsilk;
            this.CboxTipoCama.FormattingEnabled = true;
            this.CboxTipoCama.Items.AddRange(new object[] {
            "Cama simple",
            "Cama doble"});
            this.CboxTipoCama.Location = new System.Drawing.Point(680, 227);
            this.CboxTipoCama.Margin = new System.Windows.Forms.Padding(2);
            this.CboxTipoCama.Name = "CboxTipoCama";
            this.CboxTipoCama.Size = new System.Drawing.Size(92, 21);
            this.CboxTipoCama.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tipo de cama:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 266);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Seleccionar Cliente:";
            // 
            // comBoxCliente
            // 
            this.comBoxCliente.BackColor = System.Drawing.Color.Cornsilk;
            this.comBoxCliente.DataSource = this.bLLClientesBindingSource;
            this.comBoxCliente.FormattingEnabled = true;
            this.comBoxCliente.Location = new System.Drawing.Point(23, 282);
            this.comBoxCliente.Margin = new System.Windows.Forms.Padding(2);
            this.comBoxCliente.Name = "comBoxCliente";
            this.comBoxCliente.Size = new System.Drawing.Size(506, 21);
            this.comBoxCliente.TabIndex = 19;
            this.comBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comBoxCliente_SelectedIndexChanged);
            // 
            // bLLClientesBindingSource
            // 
            this.bLLClientesBindingSource.DataSource = typeof(Reglas_de_Negocio_BLL.BLLClientes);
            // 
            // bLLReservasBindingSource
            // 
            this.bLLReservasBindingSource.DataSource = typeof(Reglas_de_Negocio_BLL.BLLReservas);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 24);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 17);
            this.label17.TabIndex = 59;
            this.label17.Text = "Nueva Reserva";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCorreo.Location = new System.Drawing.Point(453, 383);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(76, 20);
            this.txtCorreo.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 389);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Correo:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Cornsilk;
            this.txtId.Location = new System.Drawing.Point(79, 320);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 412);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Dirección:";
            // 
            // txtNac
            // 
            this.txtNac.BackColor = System.Drawing.Color.Cornsilk;
            this.txtNac.Location = new System.Drawing.Point(453, 351);
            this.txtNac.Margin = new System.Windows.Forms.Padding(2);
            this.txtNac.Name = "txtNac";
            this.txtNac.Size = new System.Drawing.Size(76, 20);
            this.txtNac.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 356);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Nacionalidad:";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.Cornsilk;
            this.txtTel.Location = new System.Drawing.Point(453, 320);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(76, 20);
            this.txtTel.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(400, 322);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 72;
            this.label11.Text = "Teléfono:";
            // 
            // txtDire
            // 
            this.txtDire.BackColor = System.Drawing.Color.Cornsilk;
            this.txtDire.Location = new System.Drawing.Point(283, 407);
            this.txtDire.Margin = new System.Windows.Forms.Padding(2);
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(76, 20);
            this.txtDire.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 383);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 70;
            this.label12.Text = "Localidad:";
            // 
            // txtCuit
            // 
            this.txtCuit.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCuit.Location = new System.Drawing.Point(283, 320);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(2);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(76, 20);
            this.txtCuit.TabIndex = 69;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(212, 325);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "CUIT/CUIL:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 353);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 60;
            this.label15.Text = "Nombre:";
            // 
            // textDni
            // 
            this.textDni.BackColor = System.Drawing.Color.Cornsilk;
            this.textDni.Location = new System.Drawing.Point(79, 410);
            this.textDni.Margin = new System.Windows.Forms.Padding(2);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(76, 20);
            this.textDni.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 409);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 66;
            this.label16.Text = "DNI/cédula:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.BackColor = System.Drawing.Color.Cornsilk;
            this.txtLocalidad.Location = new System.Drawing.Point(283, 378);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(76, 20);
            this.txtLocalidad.TabIndex = 65;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(165, 354);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "Fecha de Nacimiento:";
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.Color.Cornsilk;
            this.textApellido.Location = new System.Drawing.Point(79, 380);
            this.textApellido.Margin = new System.Windows.Forms.Padding(2);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(76, 20);
            this.textApellido.TabIndex = 63;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 381);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 62;
            this.label19.Text = "Apellido:";
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.Cornsilk;
            this.textNombre.Location = new System.Drawing.Point(79, 350);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(76, 20);
            this.textNombre.TabIndex = 61;
            // 
            // txtCantDias
            // 
            this.txtCantDias.BackColor = System.Drawing.Color.Cornsilk;
            this.txtCantDias.Location = new System.Drawing.Point(680, 95);
            this.txtCantDias.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantDias.Name = "txtCantDias";
            this.txtCantDias.Size = new System.Drawing.Size(76, 20);
            this.txtCantDias.TabIndex = 82;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(570, 100);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 13);
            this.label20.TabIndex = 83;
            this.label20.Text = "Cantidad de noches:";
            // 
            // txtBMontoCalc
            // 
            this.txtBMontoCalc.BackColor = System.Drawing.Color.Cornsilk;
            this.txtBMontoCalc.ForeColor = System.Drawing.Color.Red;
            this.txtBMontoCalc.Location = new System.Drawing.Point(680, 256);
            this.txtBMontoCalc.Margin = new System.Windows.Forms.Padding(2);
            this.txtBMontoCalc.Name = "txtBMontoCalc";
            this.txtBMontoCalc.Size = new System.Drawing.Size(76, 20);
            this.txtBMontoCalc.TabIndex = 84;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(602, 261);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 85;
            this.label21.Text = "Monto aprox.:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(413, 485);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 30);
            this.button2.TabIndex = 87;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hoteleria.Properties.Resources.calendar_12958944;
            this.pictureBox1.Location = new System.Drawing.Point(680, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // txtFechanac
            // 
            this.txtFechanac.BackColor = System.Drawing.Color.Cornsilk;
            this.txtFechanac.Location = new System.Drawing.Point(283, 349);
            this.txtFechanac.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechanac.Name = "txtFechanac";
            this.txtFechanac.Size = new System.Drawing.Size(76, 20);
            this.txtFechanac.TabIndex = 89;
            // 
            // ID_cliente
            // 
            this.ID_cliente.AutoSize = true;
            this.ID_cliente.Location = new System.Drawing.Point(17, 325);
            this.ID_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID_cliente.Name = "ID_cliente";
            this.ID_cliente.Size = new System.Drawing.Size(58, 13);
            this.ID_cliente.TabIndex = 90;
            this.ID_cliente.Text = "ID_cliente:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(781, 526);
            this.Controls.Add(this.ID_cliente);
            this.Controls.Add(this.txtFechanac);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtBMontoCalc);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCantDias);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDire);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comBoxCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CboxTipoCama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CboxTipoHab);
            this.Controls.Add(this.txtCantHab);
            this.Controls.Add(this.txtCantMenores);
            this.Controls.Add(this.txtCantAdultos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptarReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCheckOut);
            this.Controls.Add(this.txtCheckIn);
            this.Controls.Add(this.calendar2);
            this.Controls.Add(this.calendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Registrar Nueva Reserva";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bLLClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLLReservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar1;
        private System.Windows.Forms.MonthCalendar calendar2;
        private System.Windows.Forms.TextBox txtCheckIn;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptarReserva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantAdultos;
        private System.Windows.Forms.TextBox txtCantMenores;
        private System.Windows.Forms.TextBox txtCantHab;
        private System.Windows.Forms.ComboBox CboxTipoHab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboxTipoCama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comBoxCliente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.BindingSource bLLReservasBindingSource;
        private System.Windows.Forms.BindingSource bLLClientesBindingSource;
        private System.Windows.Forms.TextBox txtCantDias;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtBMontoCalc;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFechanac;
        private System.Windows.Forms.Label ID_cliente;
    }
}