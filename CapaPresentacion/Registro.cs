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
    }
}
