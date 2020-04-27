using System;
using System.Collections.Generic;

namespace Recodme.Testes.CSharp.Teste2.Answers.FirstExercise
{
    public static class OneA
    {
        public static int[] NumerosArray(int[] a)
        {
            var resultL = new List<int> { };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 50 && a[i] % 2 == 1 && a[i] % 9 == 0)
                    resultL.Add(a[i]);
            }
            var result = new int[resultL.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = resultL[i];
            }
            return result;
        }

        
        public static List<int> NumerosLista(List<int> l)
        {
            var result = new List<int> { };
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i] > 50 && l[i] % 2 == 1 && l[i] % 9 == 0)
                    result.Add(l[i]);
            }
            return result;
        }
    }

  
}
