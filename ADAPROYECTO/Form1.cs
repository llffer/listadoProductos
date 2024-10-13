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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //instanciar la clase usuario
        clsUsuario ousu=new clsUsuario();
        private void btnInciar_Click(object sender, EventArgs e)
        {
            ousu.verificarUsuario(txtusuario.Text,txtclave.Text);
            if (ousu.verificarUsuario(txtusuario.Text, txtclave.Text)==true)
            {
                MessageBox.Show("Bienvenido al sistema","Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 fm1 = new Form1();
                fm1.Hide();

                //mostrar el MDI
                DashBoard principal=new DashBoard();
                principal.Show();

            }
            else
            {
                MessageBox.Show("Usuario y/o clave incorrecto", "Aviso del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Clear();
                txtclave.Clear();
                txtusuario.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfechahora.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
