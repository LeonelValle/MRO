using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace MROInventory_Project
{
    public partial class Form1 : Form
    {
        private readonly Planta planta = new Planta();
        private readonly TipoUsuario tipoUsuario = new TipoUsuario();
        private readonly Inventario inventario = new Inventario();
        private readonly Caducidad caducidad = new Caducidad();

        public Form1()
        {
            InitializeComponent();

            //timer1.Start();
        }

        private void SendEmail()
        {

            MailMessage msg = new MailMessage("scanner@masterworkelectronics.com", "leonel.valle@masterworkelectronics.com");
            msg.Subject = "MRO item next to expiration";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Check the following part numbers: ");
            sb.AppendLine("PN: "+ "AP149105" + "Description: "+ "SOLDER BAR LEAD FREE (LB) (158728) ");
            msg.Body = sb.ToString();

            SmtpClient SmtpClient = new SmtpClient();
            SmtpClient.Host = "192.168.1.4";
            SmtpClient.UseDefaultCredentials = true;
            SmtpClient.Port = 25;
            SmtpClient.EnableSsl = false;
            SmtpClient.Send(msg);




        }

        private void CompareToDB()
        {
            caducidad.Cad = caducidad.LlenarDG("select id_caducidad, caducidad, cantidad, nparte, mfg,descripcion from tb_Caducidad cad join tb_Nparte pn on cad.id_nparte = pn.id_nparte").Tables[0];


            foreach (DataRow item in caducidad.Cad.Rows)
            {
                //caducidad.Caduco.Add(item["caducidad"].ToString());
                var a = item["caducidad"].ToString();
                var b = DateTime.Now.AddDays(3);
                var diff = DateTime.Compare((DateTime)item["caducidad"], DateTime.Now.AddDays(3));
                if (diff == 1)
                {
                    caducidad.Caduco.Add(new Caducidad(int.Parse(item["id_caducidad"].ToString()), DateTime.Parse(item["caducidad"].ToString()), int.Parse(item["cantidad"].ToString()), item["nparte"].ToString(), item["mfg"].ToString(), item["descripcion"].ToString()));
                }
            }
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SendEmail();
            //CompareToDB();

            lbl_plant.Text = planta.ReturnValue("select planta from tb_Planta where id_planta = " + planta.Id_planta);

            //if (tipoUsuario.Id_tipousuario != 1)
            //    btn_reportes.Visible = false;

            inventario.Obsoletos();

            if (tipoUsuario.Id_tipousuario == 3)
            {
                btn_inventario.Visible = false;
                btn_manto.Visible = false;
                btn_obsoletos.Visible = false;
                btn_reportes.Visible = false;
                metroTile1.Visible = false;
            }
            if (tipoUsuario.Id_tipousuario == 4)
                metroTile2.Visible = false;

        }

        private void btn_busqueda_Click(object sender, EventArgs e)
        {
            Busqueda busqueda = new Busqueda();

            Form next;
            if ((next = IsFormAlreadyOpen(typeof(Busqueda))) == null)
            {
                busqueda.ShowDialog(this);
            }

            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void btn_salidas_Click(object sender, EventArgs e)
        {
            Salidas salidas = new Salidas();
            Form next;
            if ((next = IsFormAlreadyOpen(typeof(Salidas))) == null)
            {
                salidas.ShowDialog(this);
            }

            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void btn_manto_Click(object sender, EventArgs e)
        {
            Mantenimiento manto = new Mantenimiento();
            //salidas.Show();
            Form next;
            if ((next = IsFormAlreadyOpen(typeof(Mantenimiento))) == null)
            {
                manto.ShowDialog(this);
            }

            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void btn_entradas_Click(object sender, EventArgs e)
        {
            Entradas entrada = new Entradas();
            //salidas.Show();
            Form next;
            if ((next = IsFormAlreadyOpen(typeof(Entrada))) == null)
            {
                entrada.ShowDialog(this);
            }

            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            Inventarios inventarios = new Inventarios();
            //salidas.Show();
            Form next;
            if ((next = IsFormAlreadyOpen(typeof(Inventarios))) == null)
            {
                inventarios.ShowDialog(this);
            }

            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

            //salidas.Show();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(Login))) == null)
            //{
            //    login.ShowDialog(this);
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lbl_fecha.Text = DateTime.Now.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            //salidas.Show();
            Form next;
            if ((next = IsFormAlreadyOpen(typeof(Reportes))) == null)
            {
                reportes.ShowDialog(this);
            }

            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void btn_obsoletos_Click(object sender, EventArgs e)
        {
            Obsoletos obsoletos = new Obsoletos();
            //salidas.Show();
            Form next;
            if ((next = IsFormAlreadyOpen(typeof(Obsoletos))) == null)
            {
                obsoletos.ShowDialog(this);
            }

            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            SeleccionAjuste seleccioAjuste = new SeleccionAjuste();
            //salidas.Show();
            Form next;
            if ((next = IsFormAlreadyOpen(typeof(SeleccionAjuste))) == null)
            {
                seleccioAjuste.ShowDialog(this);
            }

            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Po po = new Po();
            //salidas.Show();
            Form next;
            if ((next = IsFormAlreadyOpen(typeof(Po))) == null)
            {
                po.ShowDialog(this);
            }

            else
            {
                next.WindowState = FormWindowState.Normal;
                next.BringToFront();
            }
        }
    }
}
