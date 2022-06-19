using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Amortização
{
    static class Metodos
    {
        static float _jurosTotal;
        static float _amortizacaoTotal;
        static float _pagamentoTotal;

        public static float JurosTotal { get { return _jurosTotal; } private set { _jurosTotal = value; } }
        public static float AmortizacaoTotal { get { return _amortizacaoTotal; } private set { _amortizacaoTotal = value; } }
        public static float PagamentoTotal { get { return _pagamentoTotal; } private set { _pagamentoTotal = value; } }

        public static void Calcular(float valor, float taxa, float tempo, int comboBoxIndex)
        {
            switch (comboBoxIndex)
            {
                case 0:
                    // Pagamento Único
                    break;
                case 1:
                    // Americano
                    break;
                case 2:
                    // Amortização Constante (SAC)
                    break;
                case 3:
                    // Price
                    break;
                case 4:
                    // Amortização Misto (SAM)
                    break;
                case 5:
                    // Alemão
                    break;
                case 6:
                    // Amortização Crescente (SACRE)
                    break;
            }
        }
    }
}
