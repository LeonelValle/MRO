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
    public partial class SeleccionAjuste : Form
    {
        public SeleccionAjuste()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }


        private void btn_entrada_Click(object sender, EventArgs e)
        {
            AjusteEntrada ajuste = new AjusteEntrada();
            //salidas.Show();
            Form next;
            if ((next = IsFormAlreadyOpen(typeof(AjusteEntrada))) == null)
            {
                ajuste.ShowDialog(this);
            }

            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void btn_Salida_Click(object sender, EventArgs e)
        {
            AjusteSalida ajuste = new AjusteSalida();
            //salidas.Show();
            Form next;
            if ((next = IsFormAlreadyOpen(typeof(AjusteSalida))) == null)
            {
                ajuste.ShowDialog(this);
            }

            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void SeleccionAjuste_Load(object sender, EventArgs e)
        {

        }
    }
}
