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
                Metodos.Calcular(float.Parse(textBox_Valor.Text), float.Parse(textBox_Taxa.Text), float.Parse(textBox_Tempo.Text), comboBox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Insira apenas valores válidos.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
