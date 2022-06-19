using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Amortização
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void cmd_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                Metodos.Calcular(double.Parse(textBox_Valor.Text), double.Parse(textBox_Taxa.Text), int.Parse(textBox_Tempo.Text), comboBox.SelectedIndex);

                lb_Juros.Text = String.Format("$ {0:0.00}", Metodos.JurosTotal);
                lb_Amortizacao.Text = String.Format("$ {0:0.00}", Metodos.AmortizacaoTotal);
                lb_Pagamento.Text = String.Format("$ {0:0.00}", Metodos.PagamentoTotal);
            }
            catch
            {
                MessageBox.Show("Insira apenas valores válidos.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
