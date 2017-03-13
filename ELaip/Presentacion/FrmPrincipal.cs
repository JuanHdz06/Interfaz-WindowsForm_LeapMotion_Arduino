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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmEntrenamiento Entrenamiento = new FrmEntrenamiento();
            Entrenamiento.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAjustes Ajustes = new FrmAjustes();
            Ajustes.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmHistorial Historial = new FrmHistorial();
            Historial.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmResultados Resultados = new FrmResultados();
            Resultados.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin Login = new FrmLogin();
            Login.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmReportes Reportes = new FrmReportes();
            Reportes.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmPerfil Perfil = new FrmPerfil();
            Perfil.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmEmpezar Empezar = new FrmEmpezar();
            Empezar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmPerfilDoctor PerfilDoctor = new FrmPerfilDoctor();
            PerfilDoctor.Show();
        }
    }
}
