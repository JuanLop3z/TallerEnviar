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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            iniciarsesion from = new iniciarsesion();
            from.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosBtn_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
        }

        private void usuariosBtn_MouseEnter(object sender, EventArgs e)
        {
            usuariosBtn.BackColor = Color.FromArgb(57, 55, 55);
            usuariosBtn.ForeColor = Color.FromArgb(199, 238, 255);
        }

        private void usuariosBtn_MouseLeave(object sender, EventArgs e)
        {
            usuariosBtn.BackColor = Color.FromArgb(199, 238, 255);
            usuariosBtn.ForeColor = Color.FromArgb(57, 55, 55);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(57, 55, 55);
            button1.ForeColor = Color.FromArgb(199, 238, 255);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(199, 238, 255);
            button1.ForeColor = Color.FromArgb(57, 55, 55);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(57, 55, 55);
            button2.ForeColor = Color.FromArgb(199, 238, 255);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(199, 238, 255);
            button2.ForeColor = Color.FromArgb(57, 55, 55);
        }
    }
}
