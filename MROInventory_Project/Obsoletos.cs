using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MROInventory_Project
{
    public partial class Obsoletos : Form
    {
        public Obsoletos()
        {
            InitializeComponent();
        }


        private readonly Inventario inventario = new Inventario();
        private readonly Planta planta = new Planta();

        private void Obsoletos_Load(object sender, EventArgs e)
        {
            inventario.Obsoletos();
            dataGridView1.DataSource = inventario.LlenarDG("select n.id_nparte, n.nparte, i.stock, i.min,i.max,i.LD,c.caracteristicas, p.presentacion, s.supplier, u.usuario  from tb_Inventario i join tb_Caracteristicas c on i.id_caracteristicas = c.id_caracteristicas join tb_Nparte n on i.id_nparte = n.id_nparte join tb_Supplier s on i.id_supplier = s.id_supplier join tb_Presentacion p on i.id_presentacion = p.id_presentacion join tb_Usuario u on i.id_comprador = u.id_usuario join tb_Planta pl on i.id_planta = pl.id_planta where i.obsoleto = 1  and pl.id_planta = " + planta.Id_planta).Tables[0];
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_nparte.Text = row.Cells["nparte"].Value.ToString();
                inventario.Id_nparte = int.Parse(row.Cells["id_nparte"].Value.ToString());
            }
        }

        private void btn_habilitar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro/a que desea habilitar este No Parte?", "Obsoletao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                inventario.Crud("update tb_Inventario set obsoleto = 0 where id_nparte = " + inventario.Id_nparte + " and id_planta = " + planta.Id_planta);
                MessageBox.Show("Cambio realizado!");
                Obsoletos_Load(sender, e);

            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
