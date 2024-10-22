using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faturamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            do {
                List<Estado> estados = new List<Estado>
                {
                    new Estado("São Paulo", 67836.43),
                    new Estado("Rio de Janeiro", 36678.66),
                    new Estado("Minas Gerais", 29229.88),
                    new Estado("Espírito Santo", 27165.48),
                    new Estado("Outros", 19849.53)
                };

                // Passo 2: Calculando o total de faturamento
                double faturamentoTotal = 0;
                foreach (var estado in estados)
                {
                    faturamentoTotal += estado.Faturamento;
                }

                // Passo 3: Calculando e exibindo o percentual para cada estado
                Console.WriteLine("Percentuais de Faturamento:");
                foreach (var estado in estados)
                {
                    double percentual = (estado.Faturamento / faturamentoTotal) * 100;
                    Console.WriteLine($"{estado.Nome}: {percentual:F2}%");
                }
                Console.WriteLine("\n\nDigite 0 para fechar\n");
                valor = Convert.ToInt32(Console.ReadLine());
            } while(valor != 0);
        
        }
        class Estado
        {
            public string Nome { get; set; }
            public double Faturamento { get; set; }

            public Estado(string nome, double faturamento)
            {
                Nome = nome;
                Faturamento = faturamento;
            }
        }
    }
}
