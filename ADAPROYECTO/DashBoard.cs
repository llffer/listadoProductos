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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pMenuVertical.Width==200)
            {
                pMenuVertical.Width = 70;
            }
            else
            {
                pMenuVertical.Width = 200;
            }
        }

        private void pcCerrar_Click(object sender, EventArgs e)
        {

            DialogResult r=  MessageBox.Show("DESEA FINALIZAR LA APLICACÓN", "AVISO-SISTEMAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AbriFormularioPanel(object formHijo,Panel panel)
        {

        }

        private void btnRegCliente_Click(object sender, EventArgs e)
        {
            //mostrar productos | northwind
            frmProducto prod=new frmProducto();
            prod.MdiParent=this;
            prod.Show();

        }

        private void DashBoard_Shown(object sender, EventArgs e)
        {
           Form1 login = new Form1();
           login.MdiParent = this;
           login.Show();

           this.Show();
           login.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProductoNombre prod = new frmProductoNombre();
            prod.MdiParent = this;
            prod.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //filtro venta por fecha | northwind
            frmVentaFecha vf= new frmVentaFecha();
            vf.MdiParent = this;
            vf.Show();
        }
    }
}
