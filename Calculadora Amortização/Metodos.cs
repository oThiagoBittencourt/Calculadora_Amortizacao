using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Amortização
{
    static partial class Metodos
    {
        // Propriedades | Método_main

        static double _jurosTotal;
        static double _amortizacaoTotal;
        static double _pagamentoTotal;

        public static double JurosTotal { get { return _jurosTotal; } private set { _jurosTotal = value; } }
        public static double AmortizacaoTotal { get { return _amortizacaoTotal; } private set { _amortizacaoTotal = value; } }
        public static double PagamentoTotal { get { return _pagamentoTotal; } private set { _pagamentoTotal = value; } }

        public static void Calcular(double valor, double taxa, int tempo, double comboBoxIndex)
        {
            switch (comboBoxIndex)
            {
                case 0:
                    // Pagamento Único
                    Unico(valor, taxa, tempo);
                    break;
                case 1:
                    // Americano
                    Americano(valor, taxa, tempo);
                    break;
                case 2:
                    // Amortização Constante (SAC)
                    Constante(valor, taxa, tempo);
                    break;
                case 3:
                    // Price
                    Price(valor, taxa, tempo);
                    break;
                case 4:
                    // Amortização Misto (SAM)
                    Misto(valor, taxa, tempo);
                    break;
                case 5:
                    // Alemão
                    Alemao(valor, taxa, tempo);
                    break;
            }
        }
    }

    static partial class Metodos
    {
        // Cálculos

        static void Unico(double valor, double taxa, int tempo)
        {
            PagamentoTotal = valor * Math.Pow(1 + (taxa / 100), tempo);
            AmortizacaoTotal = valor;
            JurosTotal = PagamentoTotal - AmortizacaoTotal;
        }
        static void Americano(double valor, double taxa, int tempo)
        {
            double juros = 0;

            for (int i = 0; i < tempo; i++)
            {
                juros += valor * (taxa / 100);
            }

            JurosTotal = juros;
            AmortizacaoTotal = valor;
            PagamentoTotal = AmortizacaoTotal + JurosTotal;
        }
        static void Constante(double valor, double taxa, int tempo)
        {
            double valorTemp = valor;
            double juros = 0;
            double amortizacao = valor / tempo;
            double pagamentos = 0;

            for (int i = 0; i < tempo; i++)
            {
                juros += valorTemp * (taxa / 100);
                pagamentos += valorTemp * (taxa / 100) + amortizacao;
                valorTemp -= amortizacao;
            }

            JurosTotal = juros;
            AmortizacaoTotal = valor;
            PagamentoTotal = AmortizacaoTotal + JurosTotal;
        }
        static void Price(double valor, double taxa, int tempo)
        {
            double k = (taxa / 100) * Math.Pow(1 + (taxa / 100), tempo) / (Math.Pow(1 + (taxa / 100), tempo) - 1);
            double pagamentos = valor * k;

            double valorTemp = valor;
            double juros = 0;
            double amortizacao = 0;

            for (int i = 0; i < tempo; i++)
            {
                juros += valorTemp * (taxa / 100);
                amortizacao = pagamentos - valorTemp * (taxa / 100);
                valorTemp -= amortizacao;
            }

            JurosTotal = juros;
            AmortizacaoTotal = valor;
            PagamentoTotal = AmortizacaoTotal + JurosTotal;
        }
        static void Misto(double valor, double taxa, int tempo)
        {
            double k = (taxa / 100) * Math.Pow(1 + (taxa / 100), tempo) / (Math.Pow(1 + (taxa / 100), tempo) - 1);
            double p = valor * k;

            double sac_valorTemp = valor;
            double sac_juros = 0;
            double sac_amortizacao = valor / tempo;

            double[] x = new double[tempo];
            for (int i = 0; i < tempo; i++)
            {
                sac_juros = sac_valorTemp * (taxa / 100);
                x[i] = sac_juros + sac_amortizacao;
                sac_valorTemp -= sac_amortizacao;
            }

            double valorTemp = valor;
            double juros = 0;
            double amortizacao = 0;

            for (int i = 0; i < tempo; i++)
            {
                juros += valorTemp * (taxa / 100);
                amortizacao += ((x[i] + p) / 2) - valorTemp * (taxa / 100);
                valorTemp -= ((x[i] + p) / 2) - valorTemp * (taxa / 100);
            }

            JurosTotal = juros;
            AmortizacaoTotal = amortizacao;
            PagamentoTotal = AmortizacaoTotal + JurosTotal;
        }
        static void Alemao(double valor, double taxa, int tempo)
        {
            double pagamentos = (valor * (taxa / 100)) / (1 - Math.Pow(1 - (taxa / 100), tempo));
            double[] A = new double[tempo];

            for (int i = 0; i < tempo; i++)
            {
                if (i == 0)
                    A[i] = pagamentos * Math.Pow(1 - (taxa / 100), tempo - 1);
                else
                    A[i] = A[0] / Math.Pow(1 - (taxa / 100), i);
            }

            double valorTemp = valor;
            double amortizacao = 0;
            double juros = 0;

            for (int i = 0; i < tempo; i++)
            {
                juros += valorTemp * (taxa / 100);
                amortizacao += A[i];
                valorTemp -= A[i];
            }

            JurosTotal = juros;
            AmortizacaoTotal = amortizacao;
            PagamentoTotal = AmortizacaoTotal + JurosTotal;
        }
    }
}
