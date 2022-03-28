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
            capaLogi.Empleado.loguear(contraseña,nombreUsuario);
        }
    }
}
