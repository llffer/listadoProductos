using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADAPROYECTO
{
    public partial class frmVentaFecha : Form
    {
        public frmVentaFecha()
        {
            InitializeComponent();
        }

        clsVenta ov= new clsVenta();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt= new DataTable();
            dt = ov.MostrarVentaFecha(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.DataSource = dt;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
