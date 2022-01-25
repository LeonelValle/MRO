namespace MROInventory_Project
{
    partial class Inventarios
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
            this.lbl_indicaciones = new MetroFramework.Controls.MetroLabel();
            this.lbl_consejos = new MetroFramework.Controls.MetroLabel();
            this.txt_consejos = new MetroFramework.Controls.MetroTextBox();
            this.txt_IndicacionesPeligro = new MetroFramework.Controls.MetroTextBox();
            this.cb_PalabraAdvertencia = new System.Windows.Forms.ComboBox();
            this.lbl_palabraAdevertencia = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_aceptar = new MetroFramework.Controls.MetroTile();
            this.btn_cancelar = new MetroFramework.Controls.MetroTile();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.txt_presentacion = new MetroFramework.Controls.MetroTextBox();
            this.cb_comprador = new System.Windows.Forms.ComboBox();
            this.cb_presentacion = new System.Windows.Forms.ComboBox();
            this.cb_supplier = new System.Windows.Forms.ComboBox();
            this.cb_locacion = new System.Windows.Forms.ComboBox();
            this.cb_caracteristicas = new System.Windows.Forms.ComboBox();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lb_locaciones = new System.Windows.Forms.ListBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.lb_araes = new System.Windows.Forms.ListBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txt_stock = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_min = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_max = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txt_ld = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblc = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.cb_nparte = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_indicaciones
            // 
            this.lbl_indicaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_indicaciones.AutoSize = true;
            this.lbl_indicaciones.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_indicaciones.CustomBackground = true;
            this.lbl_indicaciones.Location = new System.Drawing.Point(284, 172);
            this.lbl_indicaciones.Name = "lbl_indicaciones";
            this.lbl_indicaciones.Size = new System.Drawing.Size(147, 19);
            this.lbl_indicaciones.TabIndex = 152;
            this.lbl_indicaciones.Text = "Indicaciones de peligro:";
            this.lbl_indicaciones.Visible = false;
            // 
            // lbl_consejos
            // 
            this.lbl_consejos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_consejos.AutoSize = true;
            this.lbl_consejos.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_consejos.CustomBackground = true;
            this.lbl_consejos.Location = new System.Drawing.Point(284, 285);
            this.lbl_consejos.Name = "lbl_consejos";
            this.lbl_consejos.Size = new System.Drawing.Size(151, 19);
            this.lbl_consejos.TabIndex = 151;
            this.lbl_consejos.Text = "Consejos de precaucion:";
            this.lbl_consejos.Visible = false;
            // 
            // txt_consejos
            // 
            this.txt_consejos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_consejos.CustomBackground = true;
            this.txt_consejos.Location = new System.Drawing.Point(284, 305);
            this.txt_consejos.MaxLength = 255;
            this.txt_consejos.Multiline = true;
            this.txt_consejos.Name = "txt_consejos";
            this.txt_consejos.Size = new System.Drawing.Size(248, 79);
            this.txt_consejos.TabIndex = 150;
            this.txt_consejos.Visible = false;
            // 
            // txt_IndicacionesPeligro
            // 
            this.txt_IndicacionesPeligro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_IndicacionesPeligro.CustomBackground = true;
            this.txt_IndicacionesPeligro.Location = new System.Drawing.Point(284, 194);
            this.txt_IndicacionesPeligro.MaxLength = 255;
            this.txt_IndicacionesPeligro.Multiline = true;
            this.txt_IndicacionesPeligro.Name = "txt_IndicacionesPeligro";
            this.txt_IndicacionesPeligro.Size = new System.Drawing.Size(248, 78);
            this.txt_IndicacionesPeligro.TabIndex = 149;
            this.txt_IndicacionesPeligro.Visible = false;
            // 
            // cb_PalabraAdvertencia
            // 
            this.cb_PalabraAdvertencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PalabraAdvertencia.FormattingEnabled = true;
            this.cb_PalabraAdvertencia.Items.AddRange(new object[] {
            "Peligro",
            "Atencion",
            "Sin palabra de seguridad"});
            this.cb_PalabraAdvertencia.Location = new System.Drawing.Point(283, 143);
            this.cb_PalabraAdvertencia.Name = "cb_PalabraAdvertencia";
            this.cb_PalabraAdvertencia.Size = new System.Drawing.Size(245, 21);
            this.cb_PalabraAdvertencia.TabIndex = 148;
            this.cb_PalabraAdvertencia.Visible = false;
            // 
            // lbl_palabraAdevertencia
            // 
            this.lbl_palabraAdevertencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_palabraAdevertencia.AutoSize = true;
            this.lbl_palabraAdevertencia.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_palabraAdevertencia.CustomBackground = true;
            this.lbl_palabraAdevertencia.Location = new System.Drawing.Point(282, 120);
            this.lbl_palabraAdevertencia.Name = "lbl_palabraAdevertencia";
            this.lbl_palabraAdevertencia.Size = new System.Drawing.Size(147, 19);
            this.lbl_palabraAdevertencia.TabIndex = 147;
            this.lbl_palabraAdevertencia.Text = "Palabra de advertencia:";
            this.lbl_palabraAdevertencia.Visible = false;
            this.lbl_palabraAdevertencia.Click += new System.EventHandler(this.lbl_palabraAdevertencia_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 20);
            this.dateTimePicker1.TabIndex = 146;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(284, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 19);
            this.metroLabel1.TabIndex = 145;
            this.metroLabel1.Text = "Fecha ingreso a MRO:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_aceptar.CustomBackground = true;
            this.btn_aceptar.Location = new System.Drawing.Point(263, 511);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(91, 46);
            this.btn_aceptar.TabIndex = 144;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.CustomBackground = true;
            this.btn_cancelar.Location = new System.Drawing.Point(399, 511);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(91, 46);
            this.btn_cancelar.TabIndex = 143;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel18.CustomBackground = true;
            this.metroLabel18.Location = new System.Drawing.Point(12, 283);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(133, 19);
            this.metroLabel18.TabIndex = 142;
            this.metroLabel18.Text = "QTY en presentacion:";
            // 
            // txt_presentacion
            // 
            this.txt_presentacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_presentacion.CustomBackground = true;
            this.txt_presentacion.Location = new System.Drawing.Point(12, 305);
            this.txt_presentacion.Name = "txt_presentacion";
            this.txt_presentacion.Size = new System.Drawing.Size(248, 23);
            this.txt_presentacion.TabIndex = 141;
            // 
            // cb_comprador
            // 
            this.cb_comprador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_comprador.FormattingEnabled = true;
            this.cb_comprador.Location = new System.Drawing.Point(9, 194);
            this.cb_comprador.Name = "cb_comprador";
            this.cb_comprador.Size = new System.Drawing.Size(247, 21);
            this.cb_comprador.TabIndex = 140;
            // 
            // cb_presentacion
            // 
            this.cb_presentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_presentacion.FormattingEnabled = true;
            this.cb_presentacion.Location = new System.Drawing.Point(12, 139);
            this.cb_presentacion.Name = "cb_presentacion";
            this.cb_presentacion.Size = new System.Drawing.Size(248, 21);
            this.cb_presentacion.TabIndex = 139;
            // 
            // cb_supplier
            // 
            this.cb_supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_supplier.FormattingEnabled = true;
            this.cb_supplier.Location = new System.Drawing.Point(12, 84);
            this.cb_supplier.Name = "cb_supplier";
            this.cb_supplier.Size = new System.Drawing.Size(245, 21);
            this.cb_supplier.TabIndex = 138;
            // 
            // cb_locacion
            // 
            this.cb_locacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_locacion.FormattingEnabled = true;
            this.cb_locacion.Location = new System.Drawing.Point(590, 246);
            this.cb_locacion.Name = "cb_locacion";
            this.cb_locacion.Size = new System.Drawing.Size(246, 21);
            this.cb_locacion.TabIndex = 137;
            this.cb_locacion.SelectedIndexChanged += new System.EventHandler(this.cb_locacion_SelectedIndexChanged);
            // 
            // cb_caracteristicas
            // 
            this.cb_caracteristicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_caracteristicas.FormattingEnabled = true;
            this.cb_caracteristicas.Location = new System.Drawing.Point(284, 31);
            this.cb_caracteristicas.Name = "cb_caracteristicas";
            this.cb_caracteristicas.Size = new System.Drawing.Size(245, 21);
            this.cb_caracteristicas.TabIndex = 136;
            this.cb_caracteristicas.SelectedIndexChanged += new System.EventHandler(this.cb_caracteristicas_SelectedIndexChanged);
            // 
            // cb_area
            // 
            this.cb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_area.Location = new System.Drawing.Point(590, 31);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(246, 21);
            this.cb_area.TabIndex = 135;
            this.cb_area.SelectedIndexChanged += new System.EventHandler(this.cb_area_SelectedIndexChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel14.CustomBackground = true;
            this.metroLabel14.Location = new System.Drawing.Point(590, 285);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(75, 19);
            this.metroLabel14.TabIndex = 134;
            this.metroLabel14.Text = "Locaciones:";
            // 
            // lb_locaciones
            // 
            this.lb_locaciones.FormattingEnabled = true;
            this.lb_locaciones.Location = new System.Drawing.Point(590, 307);
            this.lb_locaciones.Name = "lb_locaciones";
            this.lb_locaciones.Size = new System.Drawing.Size(246, 121);
            this.lb_locaciones.TabIndex = 133;
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel12.CustomBackground = true;
            this.metroLabel12.Location = new System.Drawing.Point(590, 71);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(45, 19);
            this.metroLabel12.TabIndex = 132;
            this.metroLabel12.Text = "Areas:";
            // 
            // lb_araes
            // 
            this.lb_araes.FormattingEnabled = true;
            this.lb_araes.Location = new System.Drawing.Point(590, 93);
            this.lb_araes.Name = "lb_araes";
            this.lb_araes.Size = new System.Drawing.Size(246, 121);
            this.lb_araes.TabIndex = 131;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(590, 223);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 130;
            this.metroLabel2.Text = "Locacion:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel11.CustomBackground = true;
            this.metroLabel11.Location = new System.Drawing.Point(12, 339);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(43, 19);
            this.metroLabel11.TabIndex = 128;
            this.metroLabel11.Text = "Stock:";
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_stock.CustomBackground = true;
            this.txt_stock.Location = new System.Drawing.Point(12, 361);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(248, 23);
            this.txt_stock.TabIndex = 126;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 392);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(34, 19);
            this.metroLabel4.TabIndex = 125;
            this.metroLabel4.Text = "Min:";
            // 
            // txt_min
            // 
            this.txt_min.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_min.CustomBackground = true;
            this.txt_min.Location = new System.Drawing.Point(12, 414);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(248, 23);
            this.txt_min.TabIndex = 127;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 447);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 124;
            this.metroLabel3.Text = "Max:";
            // 
            // txt_max
            // 
            this.txt_max.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_max.CustomBackground = true;
            this.txt_max.Location = new System.Drawing.Point(12, 469);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(248, 23);
            this.txt_max.TabIndex = 129;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel10.CustomBackground = true;
            this.metroLabel10.Location = new System.Drawing.Point(12, 224);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(24, 19);
            this.metroLabel10.TabIndex = 123;
            this.metroLabel10.Text = "LT:";
            // 
            // txt_ld
            // 
            this.txt_ld.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_ld.CustomBackground = true;
            this.txt_ld.Location = new System.Drawing.Point(12, 246);
            this.txt_ld.Name = "txt_ld";
            this.txt_ld.Size = new System.Drawing.Size(248, 23);
            this.txt_ld.TabIndex = 122;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.Location = new System.Drawing.Point(11, 61);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(61, 19);
            this.metroLabel9.TabIndex = 121;
            this.metroLabel9.Text = "Supplier:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.Location = new System.Drawing.Point(9, 121);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(86, 19);
            this.metroLabel8.TabIndex = 120;
            this.metroLabel8.Text = "Presentacion:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(5, 171);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(83, 19);
            this.metroLabel7.TabIndex = 119;
            this.metroLabel7.Text = "Comprador:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.Location = new System.Drawing.Point(590, 9);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(135, 19);
            this.metroLabel6.TabIndex = 118;
            this.metroLabel6.Text = "Area donde se utiliza:";
            // 
            // lblc
            // 
            this.lblc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblc.AutoSize = true;
            this.lblc.BackColor = System.Drawing.SystemColors.Control;
            this.lblc.CustomBackground = true;
            this.lblc.Location = new System.Drawing.Point(283, 8);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(95, 19);
            this.lblc.TabIndex = 117;
            this.lblc.Text = "Caracteristicas:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel13.CustomBackground = true;
            this.metroLabel13.Location = new System.Drawing.Point(12, 9);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(65, 19);
            this.metroLabel13.TabIndex = 116;
            this.metroLabel13.Text = "No Parte:";
            // 
            // cb_nparte
            // 
            this.cb_nparte.FormattingEnabled = true;
            this.cb_nparte.Location = new System.Drawing.Point(12, 31);
            this.cb_nparte.Name = "cb_nparte";
            this.cb_nparte.Size = new System.Drawing.Size(246, 21);
            this.cb_nparte.TabIndex = 115;
            // 
            // Inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 565);
            this.Controls.Add(this.lbl_indicaciones);
            this.Controls.Add(this.lbl_consejos);
            this.Controls.Add(this.txt_consejos);
            this.Controls.Add(this.txt_IndicacionesPeligro);
            this.Controls.Add(this.cb_PalabraAdvertencia);
            this.Controls.Add(this.lbl_palabraAdevertencia);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.txt_presentacion);
            this.Controls.Add(this.cb_comprador);
            this.Controls.Add(this.cb_presentacion);
            this.Controls.Add(this.cb_supplier);
            this.Controls.Add(this.cb_locacion);
            this.Controls.Add(this.cb_caracteristicas);
            this.Controls.Add(this.cb_area);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.lb_locaciones);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.lb_araes);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txt_ld);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.cb_nparte);
            this.Name = "Inventarios";
            this.Text = "Inventarios";
            this.Load += new System.EventHandler(this.Inventarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_indicaciones;
        private MetroFramework.Controls.MetroLabel lbl_consejos;
        private MetroFramework.Controls.MetroTextBox txt_consejos;
        private MetroFramework.Controls.MetroTextBox txt_IndicacionesPeligro;
        private System.Windows.Forms.ComboBox cb_PalabraAdvertencia;
        private MetroFramework.Controls.MetroLabel lbl_palabraAdevertencia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile btn_aceptar;
        private MetroFramework.Controls.MetroTile btn_cancelar;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox txt_presentacion;
        private System.Windows.Forms.ComboBox cb_comprador;
        private System.Windows.Forms.ComboBox cb_presentacion;
        private System.Windows.Forms.ComboBox cb_supplier;
        private System.Windows.Forms.ComboBox cb_locacion;
        private System.Windows.Forms.ComboBox cb_caracteristicas;
        private System.Windows.Forms.ComboBox cb_area;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.ListBox lb_locaciones;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.ListBox lb_araes;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txt_stock;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_min;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_max;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txt_ld;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblc;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.ComboBox cb_nparte;
    }
}