namespace MROInventory_Project
{
    partial class AjusteEntrada
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
            this.txt_noempleado = new MetroFramework.Controls.MetroTextBox();
            this.btn_cancelar = new MetroFramework.Controls.MetroTile();
            this.btn_aceptar = new MetroFramework.Controls.MetroTile();
            this.txt_turno = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_desc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_justificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fecha = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cb_nparte = new System.Windows.Forms.ComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_PN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_noempleado
            // 
            this.txt_noempleado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_noempleado.CustomBackground = true;
            this.txt_noempleado.Location = new System.Drawing.Point(12, 443);
            this.txt_noempleado.Name = "txt_noempleado";
            this.txt_noempleado.Size = new System.Drawing.Size(270, 23);
            this.txt_noempleado.TabIndex = 113;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.CustomBackground = true;
            this.btn_cancelar.Location = new System.Drawing.Point(565, 487);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 42);
            this.btn_cancelar.TabIndex = 103;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Green;
            this.btn_aceptar.CustomBackground = true;
            this.btn_aceptar.Location = new System.Drawing.Point(452, 487);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 42);
            this.btn_aceptar.TabIndex = 112;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // txt_turno
            // 
            this.txt_turno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_turno.CustomBackground = true;
            this.txt_turno.Location = new System.Drawing.Point(12, 375);
            this.txt_turno.Name = "txt_turno";
            this.txt_turno.Size = new System.Drawing.Size(270, 23);
            this.txt_turno.TabIndex = 111;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(374, 32);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(109, 19);
            this.metroLabel7.TabIndex = 110;
            this.metroLabel7.Text = "Ultimas entradas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 375);
            this.dataGridView1.TabIndex = 109;
            // 
            // txt_desc
            // 
            this.txt_desc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_desc.CustomBackground = true;
            this.txt_desc.Location = new System.Drawing.Point(12, 239);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(272, 89);
            this.txt_desc.TabIndex = 108;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = true;
            this.metroLabel6.Location = new System.Drawing.Point(11, 420);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(94, 19);
            this.metroLabel6.TabIndex = 107;
            this.metroLabel6.Text = "No empleado:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = true;
            this.metroLabel5.Location = new System.Drawing.Point(10, 352);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 106;
            this.metroLabel5.Text = "Turno:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 217);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 105;
            this.metroLabel1.Text = "Descripcion:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 104;
            this.metroLabel2.Text = "Item Masterwork:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txt_justificacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(13, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 139);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajuste de Inventario";
            // 
            // txt_justificacion
            // 
            this.txt_justificacion.Location = new System.Drawing.Point(6, 37);
            this.txt_justificacion.Name = "txt_justificacion";
            this.txt_justificacion.Size = new System.Drawing.Size(259, 20);
            this.txt_justificacion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Justificacion:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(6, 99);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(259, 20);
            this.txt_cantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_fecha.CustomBackground = true;
            this.lbl_fecha.Location = new System.Drawing.Point(694, 9);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(83, 19);
            this.lbl_fecha.TabIndex = 101;
            this.lbl_fecha.Text = "metroLabel5";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.Location = new System.Drawing.Point(642, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 100;
            this.metroLabel4.Text = "Fecha:";
            // 
            // cb_nparte
            // 
            this.cb_nparte.FormattingEnabled = true;
            this.cb_nparte.Location = new System.Drawing.Point(14, 102);
            this.cb_nparte.Name = "cb_nparte";
            this.cb_nparte.Size = new System.Drawing.Size(269, 21);
            this.cb_nparte.TabIndex = 114;
            this.cb_nparte.SelectedIndexChanged += new System.EventHandler(this.cb_nparte_SelectedIndexChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.Location = new System.Drawing.Point(11, 154);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 139;
            this.metroLabel9.Text = "Part N#:";
            // 
            // txt_PN
            // 
            this.txt_PN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_PN.CustomBackground = true;
            this.txt_PN.Location = new System.Drawing.Point(11, 176);
            this.txt_PN.Name = "txt_PN";
            this.txt_PN.Size = new System.Drawing.Size(272, 23);
            this.txt_PN.TabIndex = 138;
            // 
            // metroLabel21
            // 
            this.metroLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel21.CustomBackground = true;
            this.metroLabel21.Location = new System.Drawing.Point(14, 10);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(42, 19);
            this.metroLabel21.TabIndex = 143;
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
            this.cb_Filtro.Location = new System.Drawing.Point(14, 32);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(256, 28);
            this.cb_Filtro.TabIndex = 142;
            this.cb_Filtro.SelectedIndexChanged += new System.EventHandler(this.cb_Filtro_SelectedIndexChanged);
            // 
            // AjusteEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 695);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.cb_Filtro);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txt_PN);
            this.Controls.Add(this.cb_nparte);
            this.Controls.Add(this.txt_noempleado);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_turno);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.metroLabel4);
            this.Name = "AjusteEntrada";
            this.Text = "Item Masterwork:";
            this.Load += new System.EventHandler(this.AjusteEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_noempleado;
        private MetroFramework.Controls.MetroTile btn_cancelar;
        private MetroFramework.Controls.MetroTile btn_aceptar;
        private MetroFramework.Controls.MetroTextBox txt_turno;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox txt_desc;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_justificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLabel lbl_fecha;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ComboBox cb_nparte;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_PN;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.ComboBox cb_Filtro;
    }
}