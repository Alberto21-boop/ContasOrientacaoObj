using System;

namespace App2020
{
    internal class Contas
    {
        public int Soma { get; set; }
        public int Subtracao { get; set; }
        public double Mutiplicacao { get; set; }
        public double Divicao { get; set; }

        public int Somar()
        {
            return Soma + Subtracao;
        }
        public int Subitrair()
        {
            return Subtracao - Soma;
        }
        public double Multiplicar()
        {
            return Mutiplicacao * Soma;
        }
        public double Dividir()
        {
            return Divicao / Mutiplicacao;
        }
    }
}