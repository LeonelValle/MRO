using System;
using System.Net;
using System.Windows.Forms;
using MROInventory_Project.ServiceReference1;

namespace MROInventory_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private readonly Planta planta = new Planta();
        private readonly Usuarios user = new Usuarios();
        private readonly TipoUsuario tipoUsuario = new TipoUsuario();
        private readonly Usuarios usuarios = new Usuarios();

        private void Login_Load(object sender, EventArgs e)
        {
            //try
            //{

            //ServiceReference1.Notification_MROSoapClient servicio = new ServiceReference1.Notification_MROSoapClient();

            
            //servicio.Notification_Caducidad(100000000);

            cb_planta.DataSource = planta.FillCB("select * from tb_Planta");
            cb_planta.DisplayMember = "planta";
            cb_planta.ValueMember = "id_planta";
            this.cb_planta.SelectedItem = null;

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_password.Text == "" || cb_planta.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor ingrese toda la informacion");
                return;
            }
            //try
            //{
            usuarios.Id_usuario = user.Login(txt_usuario.Text, txt_password.Text);
            if (usuarios.Id_usuario >= 0)
            {

                tipoUsuario.Id_tipousuario = int.Parse(tipoUsuario.ReturnValue("select tu.id_tipousuario from tb_Usuario u join tb_TipoUsuario tu on u.id_tipousuario = tu.id_tipousuario where u.id_usuario = " + usuarios.Id_usuario));
                planta.Id_planta = int.Parse(cb_planta.SelectedValue.ToString());
                //MessageBox.Show("Login Successful!");
                Log();

                //if (UserGeneric() == 1)
                //    Log();
                //else if (UserGeneric() == 2)
                //    Log();
                //else if (UserGeneric() == 3)
                //    Log();
                //else
                //    MessageBox.Show("No access!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void Log()
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private int UserGeneric()
        {
            int log = -1;
            if (usuarios.Id_usuario == 5 && int.Parse(cb_planta.SelectedValue.ToString()) == 1)
                log = 1;
            else if (usuarios.Id_usuario == 7 && int.Parse(cb_planta.SelectedValue.ToString()) == 2)
                log = 2;
            else if (usuarios.Id_usuario == 8 && int.Parse(cb_planta.SelectedValue.ToString()) == 3)
                log = 3;

            return log;
        }
    }
}
