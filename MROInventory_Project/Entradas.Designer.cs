namespace MROInventory_Project
{
    partial class Entradas
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_caducidad = new MetroFramework.Controls.MetroLabel();
            this.txt_noempleado = new MetroFramework.Controls.MetroTextBox();
            this.txt_cantidad = new MetroFramework.Controls.MetroTextBox();
            this.btn_cancelar = new MetroFramework.Controls.MetroTile();
            this.btn_aceptar = new MetroFramework.Controls.MetroTile();
            this.txt_turno = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txt_desc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbl_fecha = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dv_Po = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_PN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            this.ckb_caducidad = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dv_Po)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_nparte
            // 
            this.cb_nparte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nparte.FormattingEnabled = true;
            this.cb_nparte.Location = new System.Drawing.Point(11, 96);
            this.cb_nparte.Name = "cb_nparte";
            this.cb_nparte.Size = new System.Drawing.Size(270, 28);
            this.cb_nparte.TabIndex = 130;
            this.cb_nparte.SelectedIndexChanged += new System.EventHandler(this.cb_nparte_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 531);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 20);
            this.dateTimePicker1.TabIndex = 129;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 16, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_caducidad
            // 
            this.lbl_caducidad.AutoSize = true;
            this.lbl_caducidad.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_caducidad.CustomBackground = true;
            this.lbl_caducidad.Location = new System.Drawing.Point(10, 506);
            this.lbl_caducidad.Name = "lbl_caducidad";
            this.lbl_caducidad.Size = new System.Drawing.Size(113, 19);
            this.lbl_caducidad.TabIndex = 128;
            this.lbl_caducidad.Text = "Fecha Caducidad:";
            this.lbl_caducidad.Visible = false;
            // 
            // txt_noempleado
            // 
            this.txt_noempleado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_noempleado.CustomBackground = true;
            this.txt_noempleado.Location = new System.Drawing.Point(8, 433);
            this.txt_noempleado.Name = "txt_noempleado";
            this.txt_noempleado.Size = new System.Drawing.Size(270, 23);
            this.txt_noempleado.TabIndex = 127;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_cantidad.CustomBackground = true;
            this.txt_cantidad.Location = new System.Drawing.Point(9, 312);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(270, 23);
            this.txt_cantidad.TabIndex = 126;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.CustomBackground = true;
            this.btn_cancelar.Location = new System.Drawing.Point(425, 601);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 65);
            this.btn_cancelar.TabIndex = 113;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Green;
            this.btn_aceptar.CustomBackground = true;
            this.btn_aceptar.Location = new System.Drawing.Point(268, 601);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(106, 65);
            this.btn_aceptar.TabIndex = 125;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_turno
            // 
            this.txt_turno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_turno.CustomBackground = true;
            this.txt_turno.Location = new System.Drawing.Point(8, 372);
            this.txt_turno.Name = "txt_turno";
            this.txt_turno.Size = new System.Drawing.Size(270, 23);
            this.txt_turno.TabIndex = 124;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(374, 63);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 19);
            this.metroLabel7.TabIndex = 123;
            this.metroLabel7.Text = "Po\'s entradas:";
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_desc.CustomBackground = true;
            this.txt_desc.Location = new System.Drawing.Point(10, 197);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(272, 89);
            this.txt_desc.TabIndex = 121;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.Location = new System.Drawing.Point(7, 410);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(137, 19);
            this.metroLabel6.TabIndex = 120;
            this.metroLabel6.Text = "No empleado Recibe:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.Location = new System.Drawing.Point(6, 349);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 119;
            this.metroLabel5.Text = "Turno:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(79, 19);
            this.metroLabel4.TabIndex = 118;
            this.metroLabel4.Text = "Descripcion:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.CustomBackground = true;
            this.lbl_fecha.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_fecha.Location = new System.Drawing.Point(719, 9);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(86, 19);
            this.lbl_fecha.TabIndex = 117;
            this.lbl_fecha.Text = "metroLabel4";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(666, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 116;
            this.metroLabel3.Text = "Fecha:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 115;
            this.metroLabel2.Text = "Item Masterwork:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 289);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 114;
            this.metroLabel1.Text = "Cantidad:";
            // 
            // dv_Po
            // 
            this.dv_Po.AllowUserToAddRows = false;
            this.dv_Po.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_Po.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dv_Po.Location = new System.Drawing.Point(374, 85);
            this.dv_Po.Name = "dv_Po";
            this.dv_Po.Size = new System.Drawing.Size(453, 353);
            this.dv_Po.TabIndex = 133;
            this.dv_Po.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_Po_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Check";
            this.Column1.Name = "Column1";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.Location = new System.Drawing.Point(10, 127);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 135;
            this.metroLabel9.Text = "Part N#:";
            // 
            // txt_PN
            // 
            this.txt_PN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_PN.CustomBackground = true;
            this.txt_PN.Location = new System.Drawing.Point(10, 149);
            this.txt_PN.Name = "txt_PN";
            this.txt_PN.Size = new System.Drawing.Size(272, 23);
            this.txt_PN.TabIndex = 134;
            // 
            // metroLabel21
            // 
            this.metroLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel21.CustomBackground = true;
            this.metroLabel21.Location = new System.Drawing.Point(12, 10);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(42, 19);
            this.metroLabel21.TabIndex = 137;
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
            this.cb_Filtro.Location = new System.Drawing.Point(12, 32);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(256, 28);
            this.cb_Filtro.TabIndex = 136;
            this.cb_Filtro.SelectedIndexChanged += new System.EventHandler(this.cb_Filtro_SelectedIndexChanged);
            // 
            // ckb_caducidad
            // 
            this.ckb_caducidad.AutoSize = true;
            this.ckb_caducidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_caducidad.Location = new System.Drawing.Point(10, 479);
            this.ckb_caducidad.Name = "ckb_caducidad";
            this.ckb_caducidad.Size = new System.Drawing.Size(83, 24);
            this.ckb_caducidad.TabIndex = 138;
            this.ckb_caducidad.Text = "Caduca";
            this.ckb_caducidad.UseVisualStyleBackColor = true;
            this.ckb_caducidad.CheckedChanged += new System.EventHandler(this.ckb_caducidad_CheckedChanged);
            // 
            // Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 706);
            this.Controls.Add(this.ckb_caducidad);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.cb_Filtro);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txt_PN);
            this.Controls.Add(this.dv_Po);
            this.Controls.Add(this.cb_nparte);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_caducidad);
            this.Controls.Add(this.txt_noempleado);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_turno);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Entradas";
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.Entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv_Po)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_nparte;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel lbl_caducidad;
        private MetroFramework.Controls.MetroTextBox txt_noempleado;
        private MetroFramework.Controls.MetroTextBox txt_cantidad;
        private MetroFramework.Controls.MetroTile btn_cancelar;
        private MetroFramework.Controls.MetroTile btn_aceptar;
        private MetroFramework.Controls.MetroTextBox txt_turno;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txt_desc;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lbl_fecha;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dv_Po;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_PN;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.ComboBox cb_Filtro;
        private System.Windows.Forms.CheckBox ckb_caducidad;
    }
}