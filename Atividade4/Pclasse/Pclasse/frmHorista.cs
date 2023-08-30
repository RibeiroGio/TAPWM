using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasse
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmHorista_Load(object sender, EventArgs e)
        {

        }

        private void BtnInstanciar_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtNumeroHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumeroHora.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFaltas.Text);

            MessageBox.Show("Nome: " + objHorista.NomeEmpregado + "\n" +
                "Matrícula: " + objHorista.Matricula + "\n" +
                "Tempo trabalho: " + objHorista.TempoTrabalho().ToString() + "\n" +
                "Salário: " + objHorista.SalarioBruto().ToString("N2"));
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
