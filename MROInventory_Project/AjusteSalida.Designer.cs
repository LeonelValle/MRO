namespace MROInventory_Project
{
    partial class AjusteSalida
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_descripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_justficacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_PN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.cb_Filtro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_nparte
            // 
            this.cb_nparte.FormattingEnabled = true;
            this.cb_nparte.Location = new System.Drawing.Point(13, 128);
            this.cb_nparte.Name = "cb_nparte";
            this.cb_nparte.Size = new System.Drawing.Size(271, 21);
            this.cb_nparte.TabIndex = 120;
            this.cb_nparte.SelectedIndexChanged += new System.EventHandler(this.cb_nparte_SelectedIndexChanged);
            // 
            // txt_Nempleado
            // 
            this.txt_Nempleado.Location = new System.Drawing.Point(14, 328);
            this.txt_Nempleado.Name = "txt_Nempleado";
            this.txt_Nempleado.Size = new System.Drawing.Size(271, 20);
            this.txt_Nempleado.TabIndex = 119;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.CustomBackground = true;
            this.btn_cancelar.Location = new System.Drawing.Point(551, 445);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(79, 49);
            this.btn_cancelar.TabIndex = 110;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.Green;
            this.btn_aceptar.CustomBackground = true;
            this.btn_aceptar.Location = new System.Drawing.Point(413, 445);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(82, 49);
            this.btn_aceptar.TabIndex = 118;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.CustomBackground = true;
            this.metroLabel8.Location = new System.Drawing.Point(318, 105);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(97, 19);
            this.metroLabel8.TabIndex = 117;
            this.metroLabel8.Text = "Ultimas salidas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 283);
            this.dataGridView1.TabIndex = 116;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.CustomBackground = true;
            this.lbl_fecha.Location = new System.Drawing.Point(801, 23);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 19);
            this.lbl_fecha.TabIndex = 115;
            this.lbl_fecha.Text = "fecha";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = true;
            this.metroLabel7.Location = new System.Drawing.Point(749, 23);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 19);
            this.metroLabel7.TabIndex = 114;
            this.metroLabel7.Text = "Fecha:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 305);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 113;
            this.metroLabel4.Text = "No empleado:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 204);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 112;
            this.metroLabel2.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_descripcion.CustomBackground = true;
            this.txt_descripcion.Location = new System.Drawing.Point(13, 226);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(272, 76);
            this.txt_descripcion.TabIndex = 111;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 105);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.TabIndex = 109;
            this.metroLabel1.Text = "Item Masterwork:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txt_justficacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 357);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 148);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajuste de Inventario";
            // 
            // txt_justficacion
            // 
            this.txt_justficacion.Location = new System.Drawing.Point(9, 44);
            this.txt_justficacion.Name = "txt_justficacion";
            this.txt_justficacion.Size = new System.Drawing.Size(263, 20);
            this.txt_justficacion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Justificacion:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(9, 103);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(263, 20);
            this.txt_cantidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.CustomBackground = true;
            this.metroLabel9.Location = new System.Drawing.Point(13, 152);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(58, 19);
            this.metroLabel9.TabIndex = 137;
            this.metroLabel9.Text = "Part N#:";
            // 
            // txt_PN
            // 
            this.txt_PN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_PN.CustomBackground = true;
            this.txt_PN.Location = new System.Drawing.Point(13, 174);
            this.txt_PN.Name = "txt_PN";
            this.txt_PN.Size = new System.Drawing.Size(272, 23);
            this.txt_PN.TabIndex = 136;
            // 
            // metroLabel21
            // 
            this.metroLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel21.CustomBackground = true;
            this.metroLabel21.Location = new System.Drawing.Point(12, 14);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(42, 19);
            this.metroLabel21.TabIndex = 141;
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
            this.cb_Filtro.Location = new System.Drawing.Point(12, 36);
            this.cb_Filtro.Name = "cb_Filtro";
            this.cb_Filtro.Size = new System.Drawing.Size(256, 28);
            this.cb_Filtro.TabIndex = 140;
            this.cb_Filtro.SelectedIndexChanged += new System.EventHandler(this.cb_Filtro_SelectedIndexChanged);
            // 
            // AjusteSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 568);
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
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjusteSalida";
            this.Text = "AjusteSalida";
            this.Load += new System.EventHandler(this.AjusteSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_descripcion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_justficacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_PN;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.ComboBox cb_Filtro;
    }
}