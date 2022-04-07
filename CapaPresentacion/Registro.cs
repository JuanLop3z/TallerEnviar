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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(identificacionTxt.Text);
            string usuario = usuarioTxt.Text;
            string contraseña= contraseñaTxt.Text;
            string nombreEmpleado= nombreTxt.Text;
            string correoEmpleado= correoTxt.Text;
            int numeroCelular= int.Parse(celularTxt.Text);
            string rol= rolTxt.Text;

            if (id.Equals(id)) 
            {
                MessageBox.Show("Registro exitoso ");
                this.Dispose();
            }


            capaLogi.Empleado.establecer(id, usuario, contraseña, nombreEmpleado, correoEmpleado, numeroCelular, rol);
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

        private void cerrarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void contraseñaTxt_TextChanged(object sender, EventArgs e)
        {
            contraseñaTxt.PasswordChar = '*';
        }
    }
}
