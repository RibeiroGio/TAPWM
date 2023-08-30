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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //chamando o objeto botão
            frmHorista frmH = new frmHorista();

            frmH.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmMensalista frmMen = new frmMensalista();
            frmMen.Show();
        }
    }
}
