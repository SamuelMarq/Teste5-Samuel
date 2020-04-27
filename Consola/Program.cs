using Recodme.Testes.CSharp.Teste2.Answers.FirstExercise;
using System;
using System.Collections.Generic;


namespace Recodme.Testes.CSharp.Teste2.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = new List<int> { 239, 23, 56, 92, 44, 93, 99 };
            var result2A = OneA.NumerosArray(l.ToArray());
            var result2A2 = OneA.NumerosLista(l);
            var result2Bi = OneB.Metade("banana");
            var result2Bii = OneB.Validar("ananaz");
            var result2Biii = OneB.RemoverEspacos("  ananaz      ");
            var l2 = new List<int> { 1, 2, 3, 4, 5 };
            var result2C = OneC.Operacao(l2);
            var result2C2 = OneC.OperacaoLINQ(l2);
            var origin = DateTime.Now;
            var nexDay = origin.NextWorkDay();

        }
    }

    /*class ListaTel
    {
        public string Nome { get; set; }
        string _telefone;
        public string Telefone
        {
            get => _telefone;
            set => _telefone = (value.Length == 9) ? value : _telefone;
        }
        public string Telefone2
        {
            get { return _telefone; }
        }
    }

    struct CodigoPais
    {
        public string Pais { get;}
        public int Codigo { get;}
        public CodigoPais(string pais, int cod)
        {
            Pais = pais;
            Codigo = cod;
        }
    }*/
}
