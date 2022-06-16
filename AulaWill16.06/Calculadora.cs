using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaWill16._06
{
    internal class Calculadora
    {
        public double Adicao(double primeiroNumero, double segundoNumero) =>
            primeiroNumero + segundoNumero;

        public double Subtracao(double primeiroNumero, double segundoNumero) =>
            primeiroNumero - segundoNumero;

        public double Multiplicacao(double primeiroNumero, double segundoNumero) =>
            primeiroNumero * segundoNumero;

        public double Divisao(double primeiroNumero, double segundoNumero) =>
            primeiroNumero / segundoNumero;
    }
}
