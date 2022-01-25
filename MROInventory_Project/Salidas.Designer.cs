namespace MROInventory_Project
{
    partial class Salidas
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
            this.cb_nparte = new System.Windows.Forms.ComboBox();
            this.txt_Nempleado = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new MetroFramework.Controls.MetroTile();
            this.btn_aceptar = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_fecha = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_empleadoentrega = new MetroFramework.Controls.MetroTextBox();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_cantidad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_descripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_PN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            this.ckb_caducidad = new System.Windows.Forms.CheckBox();
            this.lbl_caducidad = new MetroFramework.Controls.MetroLabel();
            this.txt_label = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_nparte
            // 
            this.cb_nparte.FormattingEnabled = true;
            this.cb_nparte.Location = new System.Drawing.Point(12, 122);
            this.cb_nparte.Name = "cb_nparte";
            this.cb_nparte.Size = new System.Drawing.Size(272, 21);
            this.cb_nparte.TabIndex = 37;
            this.cb_nparte.SelectedIndexChanged += new System.EventHandler(this.cb_nparte_SelectedIndexChanged);
            // 
            // txt_Nempleado
            // 
            this.txt_Nempleado.Location = new System.Drawing.Point(12, 410);
            this.txt_Nempleado.Name = "txt_Nempleado";
            this.txt_Nempleado.Size = new System.Drawing.Size(272, 20);
            this.txt_Nempleado.TabIndex = 36;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.CustomBackground = true;
            this.btn_cancelar.Location = new System.Drawing.Point(559, 540);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 75);
            this.btn_cancelar.TabIndex = 21;
            this.btn_cancelar.Text = "Cancelar";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Green;
            this.btn_aceptar.CustomBackground = true;
            this.btn_aceptar.Location = new System.Drawing.Point(393, 540);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(106, 75);
            this.btn_aceptar.TabIndex = 35;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.Location = new System.Drawing.Point(319, 117);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(97, 19);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "Ultimas salidas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(319, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 283);
            this.dataGridView1.TabIndex = 33;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.CustomBackground = true;
            this.lbl_fecha.Location = new System.Drawing.Point(611, 9);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 19);
            this.lbl_fecha.TabIndex = 32;
            this.lbl_fecha.Text = "fecha";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(559, 9);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 19);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "Fecha:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.Location = new System.Drawing.Point(319, 38);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(155, 19);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "No empleado solicitante:";
            // 
            // txt_empleadoentrega
            // 
            this.txt_empleadoentrega.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_empleadoentrega.CustomBackground = true;
            this.txt_empleadoentrega.Location = new System.Drawing.Point(319, 60);
            this.txt_empleadoentrega.Name = "txt_empleadoentrega";
            this.txt_empleadoentrega.Size = new System.Drawing.Size(272, 23);
            this.txt_empleadoentrega.TabIndex = 29;
            // 
            // cb_area
            // 
            this.cb_area.FormattingEnabled = true;
            this.cb_area.Location = new System.Drawing.Point(12, 474);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(272, 21);
            this.cb_area.TabIndex = 28;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.Location = new System.Drawing.Point(12, 451);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(120, 19);
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = "Area del solicitante";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.Location = new System.Drawing.Point(11, 388);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(143, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "No empleado entrega:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 317);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_cantidad.CustomBackground = true;
            this.txt_cantidad.Location = new System.Drawing.Point(12, 339);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(272, 23);
            this.txt_cantidad.TabIndex = 24;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 194);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_descripcion.CustomBackground = true;
            this.txt_descripcion.Location = new System.Drawing.Point(12, 216);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(272, 76);
            this.txt_descripcion.TabIndex = 22;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Item Masterwork:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.Location = new System.Drawing.Point(11, 146);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 39;
            this.metroLabel9.Text = "Part N#:";
            // 
            // txt_PN
            // 
            this.txt_PN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_PN.CustomBackground = true;
            this.txt_PN.Location = new System.Drawing.Point(11, 168);
            this.txt_PN.Name = "txt_PN";
            this.txt_PN.Size = new System.Drawing.Size(272, 23);
            this.txt_PN.TabIndex = 38;
            // 
            // metroLabel21
            // 
            this.metroLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel21.CustomBackground = true;
            this.metroLabel21.Location = new System.Drawing.Point(11, 22);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(42, 19);
            this.metroLabel21.TabIndex = 139;
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
            this.cb_Filtro.Location = new System.Drawing.Point(11, 44);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(256, 28);
            this.cb_Filtro.TabIndex = 138;
            this.cb_Filtro.SelectedIndexChanged += new System.EventHandler(this.cb_Filtro_SelectedIndexChanged);
            // 
            // ckb_caducidad
            // 
            this.ckb_caducidad.AutoSize = true;
            this.ckb_caducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_caducidad.Location = new System.Drawing.Point(12, 513);
            this.ckb_caducidad.Name = "ckb_caducidad";
            this.ckb_caducidad.Size = new System.Drawing.Size(83, 24);
            this.ckb_caducidad.TabIndex = 142;
            this.ckb_caducidad.Text = "Caduca";
            this.ckb_caducidad.UseVisualStyleBackColor = true;
            this.ckb_caducidad.CheckedChanged += new System.EventHandler(this.ckb_caducidad_CheckedChanged);
            // 
            // lbl_caducidad
            // 
            this.lbl_caducidad.AutoSize = true;
            this.lbl_caducidad.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_caducidad.CustomBackground = true;
            this.lbl_caducidad.Location = new System.Drawing.Point(12, 540);
            this.lbl_caducidad.Name = "lbl_caducidad";
            this.lbl_caducidad.Size = new System.Drawing.Size(74, 19);
            this.lbl_caducidad.TabIndex = 140;
            this.lbl_caducidad.Text = "Scan Label:";
            this.lbl_caducidad.Visible = false;
            // 
            // txt_label
            // 
            this.txt_label.Location = new System.Drawing.Point(12, 562);
            this.txt_label.Name = "txt_label";
            this.txt_label.Size = new System.Drawing.Size(272, 20);
            this.txt_label.TabIndex = 143;
            // 
            // Salidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 660);
            this.Controls.Add(this.txt_label);
            this.Controls.Add(this.ckb_caducidad);
            this.Controls.Add(this.lbl_caducidad);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.cb_Filtro);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txt_PN);
            this.Controls.Add(this.cb_nparte);
            this.Controls.Add(this.txt_Nempleado);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txt_empleadoentrega);
            this.Controls.Add(this.cb_area);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Salidas";
            this.Text = "Salidas";
            this.Load += new System.EventHandler(this.Salidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_nparte;
        private System.Windows.Forms.TextBox txt_Nempleado;
        private MetroFramework.Controls.MetroTile btn_cancelar;
        private MetroFramework.Controls.MetroTile btn_aceptar;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel lbl_fecha;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_empleadoentrega;
        private System.Windows.Forms.ComboBox cb_area;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_cantidad;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_descripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_PN;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.ComboBox cb_Filtro;
        private System.Windows.Forms.CheckBox ckb_caducidad;
        private MetroFramework.Controls.MetroLabel lbl_caducidad;
        private System.Windows.Forms.TextBox txt_label;
    }
}