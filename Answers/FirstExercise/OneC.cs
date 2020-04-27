using System;
using System.Collections.Generic;
using System.Linq;

namespace Recodme.Testes.CSharp.Teste2.Answers.FirstExercise
{
    public class OneC
    {
        public static List<int> Operacao(List<int> l)
        {
            var result = new List<int> { };
            foreach (var n in l)
            {
                result.Add(Op(n));
            }
            return result;
        }

        public static List<int> OperacaoLINQ(List<int> l)
        {
            var result = l.Select(n => Op(n)).ToList();
            return result;
        }

        private static int Op(int n)
        {
            return ((int)Math.Pow(n, 2)+(8*3));
        }
    }

}
