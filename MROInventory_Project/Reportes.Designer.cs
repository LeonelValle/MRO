namespace MROInventory_Project
{
    partial class Reportes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_Busqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_inventario = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_ReporteEntrada = new System.Windows.Forms.Button();
            this.dg_entradas = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_ReporteSalidas = new System.Windows.Forms.Button();
            this.dg_salidas = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_ReporteAjusteEntradas = new System.Windows.Forms.Button();
            this.dg_ajusteEntrada = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_ReporteAjusteSalidas = new System.Windows.Forms.Button();
            this.dg_ajusteSalida = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_ReportePo = new System.Windows.Forms.Button();
            this.btn_BuscarPo = new System.Windows.Forms.Button();
            this.txt_Po = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_Po = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btn_ReportePOInv = new System.Windows.Forms.Button();
            this.dg_POInventario = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.gv_Caducidades = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_inventario)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_entradas)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_salidas)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ajusteEntrada)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ajusteSalida)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Po)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_POInventario)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Caducidades)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 492);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_reporte);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.txt_Busqueda);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dg_inventario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inventario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_reporte
            // 
            this.btn_reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reporte.Location = new System.Drawing.Point(894, 70);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(75, 23);
            this.btn_reporte.TabIndex = 4;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(358, 18);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.Location = new System.Drawing.Point(70, 21);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Size = new System.Drawing.Size(261, 20);
            this.txt_Busqueda.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busqueda:";
            // 
            // dg_inventario
            // 
            this.dg_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_inventario.Location = new System.Drawing.Point(6, 99);
            this.dg_inventario.Name = "dg_inventario";
            this.dg_inventario.RowHeadersWidth = 51;
            this.dg_inventario.Size = new System.Drawing.Size(963, 361);
            this.dg_inventario.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ReporteEntrada);
            this.tabPage2.Controls.Add(this.dg_entradas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entradas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_ReporteEntrada
            // 
            this.btn_ReporteEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReporteEntrada.Location = new System.Drawing.Point(894, 69);
            this.btn_ReporteEntrada.Name = "btn_ReporteEntrada";
            this.btn_ReporteEntrada.Size = new System.Drawing.Size(75, 23);
            this.btn_ReporteEntrada.TabIndex = 2;
            this.btn_ReporteEntrada.Text = "Reporte";
            this.btn_ReporteEntrada.UseVisualStyleBackColor = true;
            this.btn_ReporteEntrada.Click += new System.EventHandler(this.btn_ReporteEntrada_Click);
            // 
            // dg_entradas
            // 
            this.dg_entradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_entradas.Location = new System.Drawing.Point(6, 98);
            this.dg_entradas.Name = "dg_entradas";
            this.dg_entradas.RowHeadersWidth = 51;
            this.dg_entradas.Size = new System.Drawing.Size(963, 372);
            this.dg_entradas.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_ReporteSalidas);
            this.tabPage3.Controls.Add(this.dg_salidas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(975, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Salidas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_ReporteSalidas
            // 
            this.btn_ReporteSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReporteSalidas.Location = new System.Drawing.Point(897, 69);
            this.btn_ReporteSalidas.Name = "btn_ReporteSalidas";
            this.btn_ReporteSalidas.Size = new System.Drawing.Size(75, 23);
            this.btn_ReporteSalidas.TabIndex = 3;
            this.btn_ReporteSalidas.Text = "Reporte";
            this.btn_ReporteSalidas.UseVisualStyleBackColor = true;
            this.btn_ReporteSalidas.Click += new System.EventHandler(this.btn_ReporteSalidas_Click);
            // 
            // dg_salidas
            // 
            this.dg_salidas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_salidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_salidas.Location = new System.Drawing.Point(3, 98);
            this.dg_salidas.Name = "dg_salidas";
            this.dg_salidas.RowHeadersWidth = 51;
            this.dg_salidas.Size = new System.Drawing.Size(969, 365);
            this.dg_salidas.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_ReporteAjusteEntradas);
            this.tabPage4.Controls.Add(this.dg_ajusteEntrada);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(975, 466);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "AjusteEntradas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_ReporteAjusteEntradas
            // 
            this.btn_ReporteAjusteEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReporteAjusteEntradas.Location = new System.Drawing.Point(894, 70);
            this.btn_ReporteAjusteEntradas.Name = "btn_ReporteAjusteEntradas";
            this.btn_ReporteAjusteEntradas.Size = new System.Drawing.Size(75, 23);
            this.btn_ReporteAjusteEntradas.TabIndex = 3;
            this.btn_ReporteAjusteEntradas.Text = "Reporte";
            this.btn_ReporteAjusteEntradas.UseVisualStyleBackColor = true;
            this.btn_ReporteAjusteEntradas.Click += new System.EventHandler(this.btn_ReporteAjusteEntradas_Click);
            // 
            // dg_ajusteEntrada
            // 
            this.dg_ajusteEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_ajusteEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ajusteEntrada.Location = new System.Drawing.Point(6, 99);
            this.dg_ajusteEntrada.Name = "dg_ajusteEntrada";
            this.dg_ajusteEntrada.RowHeadersWidth = 51;
            this.dg_ajusteEntrada.Size = new System.Drawing.Size(963, 361);
            this.dg_ajusteEntrada.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_ReporteAjusteSalidas);
            this.tabPage5.Controls.Add(this.dg_ajusteSalida);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(975, 466);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "AjusteSalidas";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_ReporteAjusteSalidas
            // 
            this.btn_ReporteAjusteSalidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReporteAjusteSalidas.Location = new System.Drawing.Point(894, 70);
            this.btn_ReporteAjusteSalidas.Name = "btn_ReporteAjusteSalidas";
            this.btn_ReporteAjusteSalidas.Size = new System.Drawing.Size(75, 23);
            this.btn_ReporteAjusteSalidas.TabIndex = 3;
            this.btn_ReporteAjusteSalidas.Text = "Reporte";
            this.btn_ReporteAjusteSalidas.UseVisualStyleBackColor = true;
            this.btn_ReporteAjusteSalidas.Click += new System.EventHandler(this.btn_ReporteAjusteSalidas_Click);
            // 
            // dg_ajusteSalida
            // 
            this.dg_ajusteSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_ajusteSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ajusteSalida.Location = new System.Drawing.Point(6, 99);
            this.dg_ajusteSalida.Name = "dg_ajusteSalida";
            this.dg_ajusteSalida.RowHeadersWidth = 51;
            this.dg_ajusteSalida.Size = new System.Drawing.Size(963, 361);
            this.dg_ajusteSalida.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btn_ReportePo);
            this.tabPage6.Controls.Add(this.btn_BuscarPo);
            this.tabPage6.Controls.Add(this.txt_Po);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.dg_Po);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(975, 466);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "PO\'s";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_ReportePo
            // 
            this.btn_ReportePo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReportePo.Location = new System.Drawing.Point(894, 53);
            this.btn_ReportePo.Name = "btn_ReportePo";
            this.btn_ReportePo.Size = new System.Drawing.Size(75, 23);
            this.btn_ReportePo.TabIndex = 4;
            this.btn_ReportePo.Text = "Reporte";
            this.btn_ReportePo.UseVisualStyleBackColor = true;
            this.btn_ReportePo.Click += new System.EventHandler(this.btn_ReportePo_Click);
            // 
            // btn_BuscarPo
            // 
            this.btn_BuscarPo.Location = new System.Drawing.Point(357, 28);
            this.btn_BuscarPo.Name = "btn_BuscarPo";
            this.btn_BuscarPo.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarPo.TabIndex = 3;
            this.btn_BuscarPo.Text = "Buscar";
            this.btn_BuscarPo.UseVisualStyleBackColor = true;
            this.btn_BuscarPo.Click += new System.EventHandler(this.btn_BuscarPo_Click);
            // 
            // txt_Po
            // 
            this.txt_Po.Location = new System.Drawing.Point(9, 32);
            this.txt_Po.Name = "txt_Po";
            this.txt_Po.Size = new System.Drawing.Size(272, 20);
            this.txt_Po.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Busqueda:";
            // 
            // dg_Po
            // 
            this.dg_Po.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Po.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Po.Location = new System.Drawing.Point(7, 82);
            this.dg_Po.Name = "dg_Po";
            this.dg_Po.RowHeadersWidth = 51;
            this.dg_Po.Size = new System.Drawing.Size(965, 378);
            this.dg_Po.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btn_ReportePOInv);
            this.tabPage7.Controls.Add(this.dg_POInventario);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage7.Size = new System.Drawing.Size(975, 466);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "PO/Inventario";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btn_ReportePOInv
            // 
            this.btn_ReportePOInv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReportePOInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReportePOInv.Location = new System.Drawing.Point(891, 39);
            this.btn_ReportePOInv.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReportePOInv.Name = "btn_ReportePOInv";
            this.btn_ReportePOInv.Size = new System.Drawing.Size(80, 34);
            this.btn_ReportePOInv.TabIndex = 1;
            this.btn_ReportePOInv.Text = "Reporte";
            this.btn_ReportePOInv.UseVisualStyleBackColor = true;
            this.btn_ReportePOInv.Click += new System.EventHandler(this.btn_ReportePOInv_Click);
            // 
            // dg_POInventario
            // 
            this.dg_POInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_POInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_POInventario.Location = new System.Drawing.Point(4, 77);
            this.dg_POInventario.Margin = new System.Windows.Forms.Padding(2);
            this.dg_POInventario.Name = "dg_POInventario";
            this.dg_POInventario.RowHeadersWidth = 51;
            this.dg_POInventario.RowTemplate.Height = 24;
            this.dg_POInventario.Size = new System.Drawing.Size(968, 387);
            this.dg_POInventario.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.gv_Caducidades);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(975, 466);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Caducidades";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // gv_Caducidades
            // 
            this.gv_Caducidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Caducidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Caducidades.Location = new System.Drawing.Point(6, 123);
            this.gv_Caducidades.Name = "gv_Caducidades";
            this.gv_Caducidades.Size = new System.Drawing.Size(963, 337);
            this.gv_Caducidades.TabIndex = 0;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_inventario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_entradas)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_salidas)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ajusteEntrada)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ajusteSalida)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Po)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_POInventario)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Caducidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_Busqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_inventario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_ReporteEntrada;
        private System.Windows.Forms.DataGridView dg_entradas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_ReporteSalidas;
        private System.Windows.Forms.DataGridView dg_salidas;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_ReporteAjusteEntradas;
        private System.Windows.Forms.DataGridView dg_ajusteEntrada;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btn_ReporteAjusteSalidas;
        private System.Windows.Forms.DataGridView dg_ajusteSalida;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btn_BuscarPo;
        private System.Windows.Forms.TextBox txt_Po;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_Po;
        private System.Windows.Forms.Button btn_ReportePo;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dg_POInventario;
        private System.Windows.Forms.Button btn_ReportePOInv;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView gv_Caducidades;
    }
}