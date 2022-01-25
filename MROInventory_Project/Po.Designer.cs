namespace MROInventory_Project
{
    partial class Po
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
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_po = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_nparte = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cb_PNDelete = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_DeletePN = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb_UpdatePN = new System.Windows.Forms.ComboBox();
            this.btn_SubmitUpdate = new System.Windows.Forms.Button();
            this.cb_POSearch = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dateNew = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_NewQty = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(284, 253);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(91, 32);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Submit";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PO\'s:";
            // 
            // txt_po
            // 
            this.txt_po.Location = new System.Drawing.Point(284, 24);
            this.txt_po.Name = "txt_po";
            this.txt_po.Size = new System.Drawing.Size(288, 20);
            this.txt_po.TabIndex = 2;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(284, 88);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(288, 20);
            this.txt_cantidad.TabIndex = 4;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad:";
            // 
            // cb_nparte
            // 
            this.cb_nparte.FormattingEnabled = true;
            this.cb_nparte.Location = new System.Drawing.Point(284, 194);
            this.cb_nparte.Name = "cb_nparte";
            this.cb_nparte.Size = new System.Drawing.Size(288, 21);
            this.cb_nparte.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Part Number:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(481, 253);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(91, 32);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancel";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de llegada:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 388);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Cancelar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_Aceptar);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_po);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cb_nparte);
            this.tabPage1.Controls.Add(this.txt_cantidad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New PO\'s";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cb_PNDelete);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btn_Submit);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.cb_DeletePN);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(767, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Del PO\'s";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cb_PNDelete
            // 
            this.cb_PNDelete.FormattingEnabled = true;
            this.cb_PNDelete.Location = new System.Drawing.Point(236, 154);
            this.cb_PNDelete.Name = "cb_PNDelete";
            this.cb_PNDelete.Size = new System.Drawing.Size(293, 21);
            this.cb_PNDelete.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(198, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "PN:";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(321, 195);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(108, 34);
            this.btn_Submit.TabIndex = 13;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Delete PO\'s";
            // 
            // cb_DeletePN
            // 
            this.cb_DeletePN.FormattingEnabled = true;
            this.cb_DeletePN.Location = new System.Drawing.Point(236, 106);
            this.cb_DeletePN.Name = "cb_DeletePN";
            this.cb_DeletePN.Size = new System.Drawing.Size(293, 21);
            this.cb_DeletePN.TabIndex = 11;
            this.cb_DeletePN.SelectedIndexChanged += new System.EventHandler(this.cb_DeletePN_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "PO\'s:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cb_UpdatePN);
            this.tabPage2.Controls.Add(this.btn_SubmitUpdate);
            this.tabPage2.Controls.Add(this.cb_POSearch);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_dateNew);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txt_NewQty);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update PO\'s";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_UpdatePN
            // 
            this.cb_UpdatePN.FormattingEnabled = true;
            this.cb_UpdatePN.Location = new System.Drawing.Point(258, 83);
            this.cb_UpdatePN.Name = "cb_UpdatePN";
            this.cb_UpdatePN.Size = new System.Drawing.Size(287, 21);
            this.cb_UpdatePN.TabIndex = 23;
            this.cb_UpdatePN.SelectedIndexChanged += new System.EventHandler(this.cb_UpdatePN_SelectedIndexChanged);
            // 
            // btn_SubmitUpdate
            // 
            this.btn_SubmitUpdate.Location = new System.Drawing.Point(354, 241);
            this.btn_SubmitUpdate.Name = "btn_SubmitUpdate";
            this.btn_SubmitUpdate.Size = new System.Drawing.Size(98, 35);
            this.btn_SubmitUpdate.TabIndex = 22;
            this.btn_SubmitUpdate.Text = "Submit";
            this.btn_SubmitUpdate.UseVisualStyleBackColor = true;
            this.btn_SubmitUpdate.Click += new System.EventHandler(this.btn_SubmitUpdate_Click);
            // 
            // cb_POSearch
            // 
            this.cb_POSearch.FormattingEnabled = true;
            this.cb_POSearch.Location = new System.Drawing.Point(258, 48);
            this.cb_POSearch.Name = "cb_POSearch";
            this.cb_POSearch.Size = new System.Drawing.Size(287, 21);
            this.cb_POSearch.TabIndex = 21;
            this.cb_POSearch.SelectedIndexChanged += new System.EventHandler(this.cb_POSearch_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Update PO\'s:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "PO\'s:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha de llegada:";
            // 
            // txt_dateNew
            // 
            this.txt_dateNew.Location = new System.Drawing.Point(257, 190);
            this.txt_dateNew.Name = "txt_dateNew";
            this.txt_dateNew.Size = new System.Drawing.Size(288, 20);
            this.txt_dateNew.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "PN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cantidad:";
            // 
            // txt_NewQty
            // 
            this.txt_NewQty.Location = new System.Drawing.Point(257, 155);
            this.txt_NewQty.Name = "txt_NewQty";
            this.txt_NewQty.Size = new System.Drawing.Size(288, 20);
            this.txt_NewQty.TabIndex = 13;
            // 
            // Po
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.tabControl1);
            this.Name = "Po";
            this.Text = "PO\'s";
            this.Load += new System.EventHandler(this.Po_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_po;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_nparte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_SubmitUpdate;
        private System.Windows.Forms.ComboBox cb_POSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txt_dateNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_NewQty;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_DeletePN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_PNDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_UpdatePN;
    }
}