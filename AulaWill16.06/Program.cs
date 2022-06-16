using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaWill16._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var calculadora = new Calculadora();

                Console.WriteLine("Escolha qual operação deseja realizar, sendo: " +
                    "\n1 para adicao" +
                    "\n2 para subtração" +
                    "\n3 para multiplicação" +
                    "\n4 para divisão");

                var operacaoEscolhida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o primeiro numero: ");
                var num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero: ");
                var num2 = Convert.ToInt32(Console.ReadLine());

                var resultado = 0d;


                if (operacaoEscolhida == 1)
                    resultado = calculadora.Adicao(num1, num2);
                else if (operacaoEscolhida == 2)
                    resultado = calculadora.Subtracao(num1, num2);
                else if (operacaoEscolhida == 3)
                    resultado = calculadora.Multiplicacao(num1, num2);
                else
                {
                    if (num2 == 0)
                    {
                        throw new Exception("CodError001 - Divisão por 0 não é possível.");
                    }

                    resultado = calculadora.Divisao(num1, num2);
                }

                Console.WriteLine($"O resultado da conta é igual a {resultado}");
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("CodError002 - O usuário não pode inserir qualquer valor além de números.");
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.StackTrace);


                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);


                Console.ReadLine();
            }

        }
    }
}
