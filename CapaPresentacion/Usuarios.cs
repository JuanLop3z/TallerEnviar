using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            dataGridView1.DataSource = capaLogi.Empleado.Get();
        }

        public void exportarWord(DataGridView listado)
        {
            var app = new Microsoft.Office.Interop.Word.Application();
            var doc = app.Documents.Add();

            object missing = System.Reflection.Missing.Value;

            Table tbl = doc.Tables.Add(doc.Content, listado.RowCount + 1, listado.ColumnCount);

            for (var columna = 0; columna < listado.ColumnCount; columna++)
            {
                tbl.Cell(1, columna).Range.Text = listado.Columns[columna].HeaderText;

            }
            for (var fila = 0; fila < listado.RowCount; fila++)
            {
                for (var columna = 0; columna < listado.ColumnCount; columna++)
                {
                    tbl.Cell(fila + 2, columna + 1).Range.Text = listado.Rows[fila].Cells[columna].FormattedValue.ToString();
                }
            }

            tbl.set_Style(WdBuiltinStyle.wdStyleTableLightListAccent1);
            app.Visible = true;
        }

        public void exportarExcel(DataGridView listado)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Application.Workbooks.Add(true);
            int indexColumn = 0;
            foreach (DataGridViewColumn columna in listado.Columns)
            {
                indexColumn++;
                app.Cells[1, indexColumn] = columna.Name;
            }
            int indexRow = 0;
            foreach (DataGridViewRow fila in listado.Rows)
            {
                indexRow++;
                indexColumn = 0;
                foreach (DataGridViewColumn columna in listado.Columns)
                {
                    indexColumn++;
                    app.Cells[indexRow + 1, indexColumn] = fila.Cells[columna.Name].Value;
                }
            }
            app.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            exportarExcel(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exportarWord(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(57, 55, 55);
            button3.ForeColor = Color.FromArgb(199, 238, 255);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(199, 238, 255);
            button3.ForeColor = Color.FromArgb(57, 55, 55);
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
    }
}
