namespace MROInventory_Project
{
    partial class Form1
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btn_obsoletos = new MetroFramework.Controls.MetroTile();
            this.btn_reportes = new MetroFramework.Controls.MetroTile();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_plant = new System.Windows.Forms.Label();
            this.btn_inventario = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_manto = new MetroFramework.Controls.MetroTile();
            this.btn_salidas = new MetroFramework.Controls.MetroTile();
            this.btn_entradas = new MetroFramework.Controls.MetroTile();
            this.btn_busqueda = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(149)))), ((int)(((byte)(119)))));
            this.metroTile1.CustomBackground = true;
            this.metroTile1.Location = new System.Drawing.Point(398, 249);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(127, 125);
            this.metroTile1.TabIndex = 36;
            this.metroTile1.Text = "Ajuste Inventario";
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // btn_obsoletos
            // 
            this.btn_obsoletos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(149)))), ((int)(((byte)(119)))));
            this.btn_obsoletos.CustomBackground = true;
            this.btn_obsoletos.Location = new System.Drawing.Point(218, 249);
            this.btn_obsoletos.Name = "btn_obsoletos";
            this.btn_obsoletos.Size = new System.Drawing.Size(127, 125);
            this.btn_obsoletos.TabIndex = 35;
            this.btn_obsoletos.Text = "Obsoletos";
            this.btn_obsoletos.Click += new System.EventHandler(this.btn_obsoletos_Click);
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(149)))), ((int)(((byte)(119)))));
            this.btn_reportes.CustomBackground = true;
            this.btn_reportes.Location = new System.Drawing.Point(39, 249);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(127, 125);
            this.btn_reportes.TabIndex = 34;
            this.btn_reportes.Text = "Reportes";
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 496);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 16);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LogOut";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_plant
            // 
            this.lbl_plant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_plant.AutoSize = true;
            this.lbl_plant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_plant.Location = new System.Drawing.Point(936, 482);
            this.lbl_plant.Name = "lbl_plant";
            this.lbl_plant.Size = new System.Drawing.Size(76, 25);
            this.lbl_plant.TabIndex = 30;
            this.lbl_plant.Text = "label1";
            // 
            // btn_inventario
            // 
            this.btn_inventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(149)))), ((int)(((byte)(119)))));
            this.btn_inventario.CustomBackground = true;
            this.btn_inventario.Location = new System.Drawing.Point(577, 73);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(127, 125);
            this.btn_inventario.TabIndex = 29;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MROInventory_Project.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(749, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btn_manto
            // 
            this.btn_manto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(149)))), ((int)(((byte)(119)))));
            this.btn_manto.CustomBackground = true;
            this.btn_manto.Location = new System.Drawing.Point(749, 73);
            this.btn_manto.Name = "btn_manto";
            this.btn_manto.Size = new System.Drawing.Size(127, 125);
            this.btn_manto.TabIndex = 27;
            this.btn_manto.Text = "Mantenimiento";
            this.btn_manto.Click += new System.EventHandler(this.btn_manto_Click);
            // 
            // btn_salidas
            // 
            this.btn_salidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(149)))), ((int)(((byte)(119)))));
            this.btn_salidas.CustomBackground = true;
            this.btn_salidas.Location = new System.Drawing.Point(398, 73);
            this.btn_salidas.Name = "btn_salidas";
            this.btn_salidas.Size = new System.Drawing.Size(127, 125);
            this.btn_salidas.TabIndex = 26;
            this.btn_salidas.Text = "Salidas";
            this.btn_salidas.Click += new System.EventHandler(this.btn_salidas_Click);
            // 
            // btn_entradas
            // 
            this.btn_entradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(149)))), ((int)(((byte)(119)))));
            this.btn_entradas.CustomBackground = true;
            this.btn_entradas.Location = new System.Drawing.Point(218, 73);
            this.btn_entradas.Name = "btn_entradas";
            this.btn_entradas.Size = new System.Drawing.Size(127, 125);
            this.btn_entradas.TabIndex = 25;
            this.btn_entradas.Text = "Entradas";
            this.btn_entradas.Click += new System.EventHandler(this.btn_entradas_Click);
            // 
            // btn_busqueda
            // 
            this.btn_busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(149)))), ((int)(((byte)(119)))));
            this.btn_busqueda.CustomBackground = true;
            this.btn_busqueda.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_busqueda.Location = new System.Drawing.Point(41, 73);
            this.btn_busqueda.Name = "btn_busqueda";
            this.btn_busqueda.Size = new System.Drawing.Size(127, 125);
            this.btn_busqueda.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_busqueda.TabIndex = 24;
            this.btn_busqueda.Text = "Busqueda";
            this.btn_busqueda.Click += new System.EventHandler(this.btn_busqueda_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(149)))), ((int)(((byte)(119)))));
            this.metroTile2.CustomBackground = true;
            this.metroTile2.Location = new System.Drawing.Point(577, 249);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(127, 125);
            this.metroTile2.TabIndex = 37;
            this.metroTile2.Text = "PO\'s";
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 521);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.btn_obsoletos);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_plant);
            this.Controls.Add(this.btn_inventario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_manto);
            this.Controls.Add(this.btn_salidas);
            this.Controls.Add(this.btn_entradas);
            this.Controls.Add(this.btn_busqueda);
            this.Name = "Form1";
            this.Text = "MainMenu [V4.0]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile btn_obsoletos;
        private MetroFramework.Controls.MetroTile btn_reportes;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_plant;
        private MetroFramework.Controls.MetroTile btn_inventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btn_manto;
        private MetroFramework.Controls.MetroTile btn_salidas;
        private MetroFramework.Controls.MetroTile btn_entradas;
        private MetroFramework.Controls.MetroTile btn_busqueda;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}

