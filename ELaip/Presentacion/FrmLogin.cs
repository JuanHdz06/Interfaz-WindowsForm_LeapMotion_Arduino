using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELaip.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {


                MessageBox.Show("Bienvenido Sr: " + txtUsuario.Text + " :)");
                this.Hide();
                FrmPrincipal Principal = new FrmPrincipal();
                Principal.ShowDialog();
            }
            else
                MessageBox.Show("Asegúrese de llenar todos los Campos!!!");
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegistro Registro = new FrmRegistro();
            Registro.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
