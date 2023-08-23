﻿using System;
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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMensalista_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnInstanciar1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(label2.Text);
            objMensalista.NomeEmpregado = label1.Text;
            objMensalista.SalarioMensal = Convert.ToDouble(label3.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(label4.Text);

            if (rbtnSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            //get 
            MessageBox.Show("Matricula: " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmpregado + "\n" + "Data Entrada: " +
                objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() +
                "\n" + objMensalista.VerificaHome());


           
        }
    }
}
