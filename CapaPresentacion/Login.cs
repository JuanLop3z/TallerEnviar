using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro form = new Registro();
            form.ShowDialog();
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            String nombreUsuario = usuarioIngresoTxt.Text;
            String contraseña = usuarioContraseñaTxt.Text;
            var login = capaLogi.Empleado.loguear(contraseña,nombreUsuario);
            if (login.Count() >= 1)
            {
                foreach (var listado in login)
                {
                    if (listado.rol == "admin")
                    {
                        /*MessageBox.Show("Bienvenido de vuelta: " + listado.nombreEmpleado);
                        Home from = new Home();
                        from.Show();
                        this.Hide();*/
                    }
                    else if (listado.rol == "empleado")
                    {
                        MessageBox.Show("Bienvenido de vuelta: " + listado.nombreEmpleado);
                        Home from = new Home();
                        from.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe..." + "ERROR");
                    }
                }
            }

        }

        private void aceptarBtn_MouseEnter(object sender, EventArgs e)
        {
            aceptarBtn.BackColor = Color.FromArgb(57, 55, 55);
            aceptarBtn.ForeColor = Color.FromArgb(199, 238, 255);
        }

        private void aceptarBtn_MouseLeave(object sender, EventArgs e)
        {
            aceptarBtn.BackColor = Color.FromArgb(199, 238, 255);
            aceptarBtn.ForeColor = Color.FromArgb(57, 55, 55);
        }

        private void cerrarBtn_MouseEnter(object sender, EventArgs e)
        {
            cerrarBtn.BackColor = Color.FromArgb(57, 55, 55);
            cerrarBtn.ForeColor = Color.FromArgb(199, 238, 255);
        }

        private void cerrarBtn_MouseLeave(object sender, EventArgs e)
        {
            cerrarBtn.BackColor = Color.FromArgb(199, 238, 255);
            cerrarBtn.ForeColor = Color.FromArgb(57, 55, 55);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
