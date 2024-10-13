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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        clsProducto oprod=new clsProducto();
        private void frmProducto_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = oprod.ListarProductos();
        }
    }
}
