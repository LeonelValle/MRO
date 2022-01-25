namespace MROInventory_Project
{
    partial class SeleccionAjuste
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
            this.btn_Salida = new MetroFramework.Controls.MetroTile();
            this.btn_entrada = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btn_Salida
            // 
            this.btn_Salida.Location = new System.Drawing.Point(32, 154);
            this.btn_Salida.Name = "btn_Salida";
            this.btn_Salida.Size = new System.Drawing.Size(129, 80);
            this.btn_Salida.TabIndex = 1;
            this.btn_Salida.Text = "Salida";
            this.btn_Salida.Click += new System.EventHandler(this.btn_Salida_Click);
            // 
            // btn_entrada
            // 
            this.btn_entrada.Location = new System.Drawing.Point(32, 32);
            this.btn_entrada.Name = "btn_entrada";
            this.btn_entrada.Size = new System.Drawing.Size(129, 80);
            this.btn_entrada.TabIndex = 2;
            this.btn_entrada.Text = "Entrada";
            this.btn_entrada.Click += new System.EventHandler(this.btn_entrada_Click);
            // 
            // SeleccionAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 268);
            this.Controls.Add(this.btn_Salida);
            this.Controls.Add(this.btn_entrada);
            this.Name = "SeleccionAjuste";
            this.Text = "SeleccionAjuste";
            this.Load += new System.EventHandler(this.SeleccionAjuste_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_Salida;
        private MetroFramework.Controls.MetroTile btn_entrada;
    }
}