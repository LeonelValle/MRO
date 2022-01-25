namespace MROInventory_Project
{
    partial class Busqueda
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
            this.lbl_FechaCaducidad = new MetroFramework.Controls.MetroLabel();
            this.txt_FechaCaducidad = new MetroFramework.Controls.MetroTextBox();
            this.cb_obsoleto = new System.Windows.Forms.ComboBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txt_purch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txt_area = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.txt_max = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txt_min = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txt_caracteristicas = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_comprador = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txt_lt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txt_qtypresentacion = new MetroFramework.Controls.MetroTextBox();
            this.txt_presentacion = new MetroFramework.Controls.MetroTextBox();
            this.txt_stock = new MetroFramework.Controls.MetroTextBox();
            this.txt_supplier = new MetroFramework.Controls.MetroTextBox();
            this.txt_mensaje = new MetroFramework.Controls.MetroTextBox();
            this.txt_locacion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_descripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cb_nparte = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_fecha = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btn_buscar = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.txt_FechaIngreso = new MetroFramework.Controls.MetroTextBox();
            this.lbl_advertencia = new MetroFramework.Controls.MetroLabel();
            this.txt_advertencia = new MetroFramework.Controls.MetroTextBox();
            this.lbl_peligro = new MetroFramework.Controls.MetroLabel();
            this.txt_peligro = new MetroFramework.Controls.MetroTextBox();
            this.lbl_consejo = new MetroFramework.Controls.MetroLabel();
            this.txt_precaucion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FechaCaducidad
            // 
            this.lbl_FechaCaducidad.AutoSize = true;
            this.lbl_FechaCaducidad.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_FechaCaducidad.CustomBackground = true;
            this.lbl_FechaCaducidad.Location = new System.Drawing.Point(763, 542);
            this.lbl_FechaCaducidad.Name = "lbl_FechaCaducidad";
            this.lbl_FechaCaducidad.Size = new System.Drawing.Size(132, 19);
            this.lbl_FechaCaducidad.TabIndex = 83;
            this.lbl_FechaCaducidad.Text = "Fecha de Caducidad:";
            this.lbl_FechaCaducidad.Visible = false;
            // 
            // txt_FechaCaducidad
            // 
            this.txt_FechaCaducidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_FechaCaducidad.CustomBackground = true;
            this.txt_FechaCaducidad.Location = new System.Drawing.Point(763, 564);
            this.txt_FechaCaducidad.Name = "txt_FechaCaducidad";
            this.txt_FechaCaducidad.ReadOnly = true;
            this.txt_FechaCaducidad.Size = new System.Drawing.Size(248, 23);
            this.txt_FechaCaducidad.TabIndex = 82;
            this.txt_FechaCaducidad.Visible = false;
            // 
            // cb_obsoleto
            // 
            this.cb_obsoleto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_obsoleto.FormattingEnabled = true;
            this.cb_obsoleto.Items.AddRange(new object[] {
            "Obsoleto",
            "No Obsoleto"});
            this.cb_obsoleto.Location = new System.Drawing.Point(763, 457);
            this.cb_obsoleto.Name = "cb_obsoleto";
            this.cb_obsoleto.Size = new System.Drawing.Size(248, 21);
            this.cb_obsoleto.TabIndex = 81;
            this.cb_obsoleto.SelectedIndexChanged += new System.EventHandler(this.cb_obsoleto_SelectedIndexChanged);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel18.CustomBackground = true;
            this.metroLabel18.Location = new System.Drawing.Point(763, 435);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(66, 19);
            this.metroLabel18.TabIndex = 80;
            this.metroLabel18.Text = "Obsoleto:";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel17.CustomBackground = true;
            this.metroLabel17.Location = new System.Drawing.Point(763, 385);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(90, 19);
            this.metroLabel17.TabIndex = 79;
            this.metroLabel17.Text = "QTY to purch:";
            // 
            // txt_purch
            // 
            this.txt_purch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_purch.CustomBackground = true;
            this.txt_purch.Location = new System.Drawing.Point(763, 407);
            this.txt_purch.Name = "txt_purch";
            this.txt_purch.ReadOnly = true;
            this.txt_purch.Size = new System.Drawing.Size(248, 23);
            this.txt_purch.TabIndex = 78;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel16.CustomBackground = true;
            this.metroLabel16.Location = new System.Drawing.Point(763, 333);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(135, 19);
            this.metroLabel16.TabIndex = 77;
            this.metroLabel16.Text = "Area donde se utiliza:";
            // 
            // txt_area
            // 
            this.txt_area.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_area.CustomBackground = true;
            this.txt_area.Location = new System.Drawing.Point(763, 355);
            this.txt_area.Name = "txt_area";
            this.txt_area.ReadOnly = true;
            this.txt_area.Size = new System.Drawing.Size(248, 23);
            this.txt_area.TabIndex = 76;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel15.CustomBackground = true;
            this.metroLabel15.Location = new System.Drawing.Point(440, 431);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(167, 19);
            this.metroLabel15.TabIndex = 75;
            this.metroLabel15.Text = "Cantidad maxima en stock:";
            // 
            // txt_max
            // 
            this.txt_max.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_max.CustomBackground = true;
            this.txt_max.Location = new System.Drawing.Point(440, 453);
            this.txt_max.Name = "txt_max";
            this.txt_max.ReadOnly = true;
            this.txt_max.Size = new System.Drawing.Size(248, 23);
            this.txt_max.TabIndex = 74;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel14.CustomBackground = true;
            this.metroLabel14.Location = new System.Drawing.Point(440, 376);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(164, 19);
            this.metroLabel14.TabIndex = 73;
            this.metroLabel14.Text = "Cantidad minima en stock:";
            // 
            // txt_min
            // 
            this.txt_min.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_min.CustomBackground = true;
            this.txt_min.Location = new System.Drawing.Point(440, 398);
            this.txt_min.Name = "txt_min";
            this.txt_min.ReadOnly = true;
            this.txt_min.Size = new System.Drawing.Size(248, 23);
            this.txt_min.TabIndex = 72;
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel13.CustomBackground = true;
            this.metroLabel13.Location = new System.Drawing.Point(19, 72);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(65, 19);
            this.metroLabel13.TabIndex = 71;
            this.metroLabel13.Text = "No Parte:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel12.CustomBackground = true;
            this.metroLabel12.Location = new System.Drawing.Point(440, 322);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(92, 19);
            this.metroLabel12.TabIndex = 70;
            this.metroLabel12.Text = "Caracteristicas";
            // 
            // txt_caracteristicas
            // 
            this.txt_caracteristicas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_caracteristicas.CustomBackground = true;
            this.txt_caracteristicas.Location = new System.Drawing.Point(440, 344);
            this.txt_caracteristicas.Name = "txt_caracteristicas";
            this.txt_caracteristicas.ReadOnly = true;
            this.txt_caracteristicas.Size = new System.Drawing.Size(248, 23);
            this.txt_caracteristicas.TabIndex = 69;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.Location = new System.Drawing.Point(440, 255);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(79, 19);
            this.metroLabel11.TabIndex = 68;
            this.metroLabel11.Text = "Comprador";
            // 
            // txt_comprador
            // 
            this.txt_comprador.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_comprador.CustomBackground = true;
            this.txt_comprador.Location = new System.Drawing.Point(440, 277);
            this.txt_comprador.Name = "txt_comprador";
            this.txt_comprador.ReadOnly = true;
            this.txt_comprador.Size = new System.Drawing.Size(248, 23);
            this.txt_comprador.TabIndex = 67;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel10.CustomBackground = true;
            this.metroLabel10.Location = new System.Drawing.Point(440, 195);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(24, 19);
            this.metroLabel10.TabIndex = 66;
            this.metroLabel10.Text = "LT:";
            // 
            // txt_lt
            // 
            this.txt_lt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_lt.CustomBackground = true;
            this.txt_lt.Location = new System.Drawing.Point(440, 217);
            this.txt_lt.Name = "txt_lt";
            this.txt_lt.ReadOnly = true;
            this.txt_lt.Size = new System.Drawing.Size(248, 23);
            this.txt_lt.TabIndex = 65;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.Location = new System.Drawing.Point(440, 135);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(119, 19);
            this.metroLabel9.TabIndex = 64;
            this.metroLabel9.Text = "Mensaje de Alerta:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.Location = new System.Drawing.Point(85, 457);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 63;
            this.metroLabel8.Text = "Supplier:";
            // 
            // txt_qtypresentacion
            // 
            this.txt_qtypresentacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_qtypresentacion.CustomBackground = true;
            this.txt_qtypresentacion.Location = new System.Drawing.Point(154, 398);
            this.txt_qtypresentacion.Name = "txt_qtypresentacion";
            this.txt_qtypresentacion.ReadOnly = true;
            this.txt_qtypresentacion.Size = new System.Drawing.Size(248, 23);
            this.txt_qtypresentacion.TabIndex = 62;
            // 
            // txt_presentacion
            // 
            this.txt_presentacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_presentacion.CustomBackground = true;
            this.txt_presentacion.Location = new System.Drawing.Point(154, 344);
            this.txt_presentacion.Name = "txt_presentacion";
            this.txt_presentacion.ReadOnly = true;
            this.txt_presentacion.Size = new System.Drawing.Size(248, 23);
            this.txt_presentacion.TabIndex = 61;
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_stock.CustomBackground = true;
            this.txt_stock.Location = new System.Drawing.Point(154, 292);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.ReadOnly = true;
            this.txt_stock.Size = new System.Drawing.Size(248, 23);
            this.txt_stock.TabIndex = 60;
            // 
            // txt_supplier
            // 
            this.txt_supplier.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_supplier.CustomBackground = true;
            this.txt_supplier.Location = new System.Drawing.Point(154, 453);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.ReadOnly = true;
            this.txt_supplier.Size = new System.Drawing.Size(248, 23);
            this.txt_supplier.TabIndex = 59;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_mensaje.CustomBackground = true;
            this.txt_mensaje.Location = new System.Drawing.Point(440, 157);
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.ReadOnly = true;
            this.txt_mensaje.Size = new System.Drawing.Size(248, 23);
            this.txt_mensaje.TabIndex = 58;
            // 
            // txt_locacion
            // 
            this.txt_locacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_locacion.CustomBackground = true;
            this.txt_locacion.Location = new System.Drawing.Point(154, 240);
            this.txt_locacion.Name = "txt_locacion";
            this.txt_locacion.ReadOnly = true;
            this.txt_locacion.Size = new System.Drawing.Size(248, 23);
            this.txt_locacion.TabIndex = 57;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(14, 402);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(133, 19);
            this.metroLabel7.TabIndex = 56;
            this.metroLabel7.Text = "QTY en presentacion:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.Location = new System.Drawing.Point(105, 296);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.TabIndex = 55;
            this.metroLabel6.Text = "Stock:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.Location = new System.Drawing.Point(62, 348);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 54;
            this.metroLabel5.Text = "Presentacion:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(85, 244);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 53;
            this.metroLabel3.Text = "Locacion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_descripcion.CustomBackground = true;
            this.txt_descripcion.Location = new System.Drawing.Point(154, 161);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ReadOnly = true;
            this.txt_descripcion.Size = new System.Drawing.Size(248, 56);
            this.txt_descripcion.TabIndex = 52;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(69, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "Descripcion:";
            // 
            // cb_nparte
            // 
            this.cb_nparte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nparte.FormattingEnabled = true;
            this.cb_nparte.Location = new System.Drawing.Point(19, 94);
            this.cb_nparte.Name = "cb_nparte";
            this.cb_nparte.Size = new System.Drawing.Size(377, 28);
            this.cb_nparte.TabIndex = 50;
            this.cb_nparte.SelectedIndexChanged += new System.EventHandler(this.cb_obsoleto_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(764, 81);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Imagen";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_fecha.CustomBackground = true;
            this.lbl_fecha.Location = new System.Drawing.Point(815, 19);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(83, 19);
            this.lbl_fecha.TabIndex = 48;
            this.lbl_fecha.Text = "metroLabel5";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.Location = new System.Drawing.Point(763, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 47;
            this.metroLabel4.Text = "Fecha:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(411, 94);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(108, 29);
            this.btn_buscar.Style = MetroFramework.MetroColorStyle.White;
            this.btn_buscar.TabIndex = 45;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(763, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel19.CustomBackground = true;
            this.metroLabel19.Location = new System.Drawing.Point(763, 490);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(93, 19);
            this.metroLabel19.TabIndex = 85;
            this.metroLabel19.Text = "Fecha Ingreso:";
            // 
            // txt_FechaIngreso
            // 
            this.txt_FechaIngreso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_FechaIngreso.CustomBackground = true;
            this.txt_FechaIngreso.Location = new System.Drawing.Point(763, 512);
            this.txt_FechaIngreso.Name = "txt_FechaIngreso";
            this.txt_FechaIngreso.ReadOnly = true;
            this.txt_FechaIngreso.Size = new System.Drawing.Size(248, 23);
            this.txt_FechaIngreso.TabIndex = 84;
            // 
            // lbl_advertencia
            // 
            this.lbl_advertencia.AutoSize = true;
            this.lbl_advertencia.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_advertencia.CustomBackground = true;
            this.lbl_advertencia.Location = new System.Drawing.Point(5, 496);
            this.lbl_advertencia.Name = "lbl_advertencia";
            this.lbl_advertencia.Size = new System.Drawing.Size(149, 19);
            this.lbl_advertencia.TabIndex = 87;
            this.lbl_advertencia.Text = "Palabra de Advertencia:";
            this.lbl_advertencia.Visible = false;
            // 
            // txt_advertencia
            // 
            this.txt_advertencia.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_advertencia.CustomBackground = true;
            this.txt_advertencia.Location = new System.Drawing.Point(154, 492);
            this.txt_advertencia.Name = "txt_advertencia";
            this.txt_advertencia.ReadOnly = true;
            this.txt_advertencia.Size = new System.Drawing.Size(248, 23);
            this.txt_advertencia.TabIndex = 86;
            this.txt_advertencia.Visible = false;
            // 
            // lbl_peligro
            // 
            this.lbl_peligro.AutoSize = true;
            this.lbl_peligro.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_peligro.CustomBackground = true;
            this.lbl_peligro.Location = new System.Drawing.Point(1, 532);
            this.lbl_peligro.Name = "lbl_peligro";
            this.lbl_peligro.Size = new System.Drawing.Size(146, 19);
            this.lbl_peligro.TabIndex = 89;
            this.lbl_peligro.Text = "Indicaciones de Peligro:";
            this.lbl_peligro.Visible = false;
            // 
            // txt_peligro
            // 
            this.txt_peligro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_peligro.CustomBackground = true;
            this.txt_peligro.Location = new System.Drawing.Point(154, 532);
            this.txt_peligro.Multiline = true;
            this.txt_peligro.Name = "txt_peligro";
            this.txt_peligro.ReadOnly = true;
            this.txt_peligro.Size = new System.Drawing.Size(248, 79);
            this.txt_peligro.TabIndex = 88;
            this.txt_peligro.Visible = false;
            // 
            // lbl_consejo
            // 
            this.lbl_consejo.AutoSize = true;
            this.lbl_consejo.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_consejo.CustomBackground = true;
            this.lbl_consejo.Location = new System.Drawing.Point(440, 483);
            this.lbl_consejo.Name = "lbl_consejo";
            this.lbl_consejo.Size = new System.Drawing.Size(146, 19);
            this.lbl_consejo.TabIndex = 91;
            this.lbl_consejo.Text = "Consejo de Precaucion:";
            this.lbl_consejo.Visible = false;
            // 
            // txt_precaucion
            // 
            this.txt_precaucion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_precaucion.CustomBackground = true;
            this.txt_precaucion.Location = new System.Drawing.Point(440, 505);
            this.txt_precaucion.Multiline = true;
            this.txt_precaucion.Name = "txt_precaucion";
            this.txt_precaucion.ReadOnly = true;
            this.txt_precaucion.Size = new System.Drawing.Size(248, 106);
            this.txt_precaucion.TabIndex = 90;
            this.txt_precaucion.Visible = false;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel20.CustomBackground = true;
            this.metroLabel20.Location = new System.Drawing.Point(763, 277);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(132, 19);
            this.metroLabel20.TabIndex = 93;
            this.metroLabel20.Text = "Fecha de Caducidad:";
            this.metroLabel20.Visible = false;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroTextBox1.CustomBackground = true;
            this.metroTextBox1.Location = new System.Drawing.Point(763, 299);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.Size = new System.Drawing.Size(248, 23);
            this.metroTextBox1.TabIndex = 92;
            this.metroTextBox1.Visible = false;
            // 
            // metroLabel21
            // 
            this.metroLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel21.CustomBackground = true;
            this.metroLabel21.Location = new System.Drawing.Point(19, 19);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(42, 19);
            this.metroLabel21.TabIndex = 95;
            this.metroLabel21.Text = "Filtro:";
            // 
            // cb_Filtro
            // 
            this.cb_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Filtro.FormattingEnabled = true;
            this.cb_Filtro.Items.AddRange(new object[] {
            "Part N#",
            "Item Masterwork"});
            this.cb_Filtro.Location = new System.Drawing.Point(19, 41);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(256, 28);
            this.cb_Filtro.TabIndex = 94;
            this.cb_Filtro.SelectedIndexChanged += new System.EventHandler(this.cb_Filtro_SelectedIndexChanged);
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 623);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.cb_Filtro);
            this.Controls.Add(this.metroLabel20);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.lbl_consejo);
            this.Controls.Add(this.txt_precaucion);
            this.Controls.Add(this.lbl_peligro);
            this.Controls.Add(this.txt_peligro);
            this.Controls.Add(this.lbl_advertencia);
            this.Controls.Add(this.txt_advertencia);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.txt_FechaIngreso);
            this.Controls.Add(this.lbl_FechaCaducidad);
            this.Controls.Add(this.txt_FechaCaducidad);
            this.Controls.Add(this.cb_obsoleto);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.txt_purch);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txt_caracteristicas);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txt_comprador);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txt_lt);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txt_qtypresentacion);
            this.Controls.Add(this.txt_presentacion);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_supplier);
            this.Controls.Add(this.txt_mensaje);
            this.Controls.Add(this.txt_locacion);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cb_nparte);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_buscar);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_FechaCaducidad;
        private MetroFramework.Controls.MetroTextBox txt_FechaCaducidad;
        private System.Windows.Forms.ComboBox cb_obsoleto;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox txt_purch;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txt_area;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox txt_max;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txt_min;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txt_caracteristicas;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txt_comprador;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txt_lt;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txt_qtypresentacion;
        private MetroFramework.Controls.MetroTextBox txt_presentacion;
        private MetroFramework.Controls.MetroTextBox txt_stock;
        private MetroFramework.Controls.MetroTextBox txt_supplier;
        private MetroFramework.Controls.MetroTextBox txt_mensaje;
        private MetroFramework.Controls.MetroTextBox txt_locacion;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_descripcion;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cb_nparte;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbl_fecha;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btn_buscar;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox txt_FechaIngreso;
        private MetroFramework.Controls.MetroLabel lbl_advertencia;
        private MetroFramework.Controls.MetroTextBox txt_advertencia;
        private MetroFramework.Controls.MetroLabel lbl_peligro;
        private MetroFramework.Controls.MetroTextBox txt_peligro;
        private MetroFramework.Controls.MetroLabel lbl_consejo;
        private MetroFramework.Controls.MetroTextBox txt_precaucion;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.ComboBox cb_Filtro;
    }
}