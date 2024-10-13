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
    public partial class frmProductoNombre : Form
    {
        public frmProductoNombre()
        {
            InitializeComponent();
        }
        clsProducto oprod=new clsProducto();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=oprod.ListarProductosNombre(textBox1.Text);
            dataGridView1.DataSource = dt;  

            //contar las filas
            label2.Text="Cantidad de productos son: "+dt.Rows.Count;
        }
    }
}
