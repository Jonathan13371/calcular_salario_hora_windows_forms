using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex03
{
    public partial class frmTelaPrinciopal : Form
    {
        public frmTelaPrinciopal()
        {
            InitializeComponent();
        }

        private void frmTelaPrinciopal_Load(object sender, EventArgs e)
        {

        }

        private void bntSalario_Click(object sender, EventArgs e)
        {
            string nome;

            decimal horas, valorHora, salario;
            nome = textNome.Text;
            horas = Convert.ToDecimal(textHoras.Text);
            valorHora = Convert.ToDecimal(textValorHora.Text);

            salario = horas * valorHora;

            lblSaida.Text = "O Salario do " + nome + " é " + salario +" Reais";


        }
    }
}
