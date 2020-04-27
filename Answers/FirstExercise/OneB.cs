using System;
using System.Collections.Generic;

namespace Recodme.Testes.CSharp.Teste2.Answers.FirstExercise
{
    public static class OneB
    {
       public static string Metade(string s)
        {
            int len = s.Length;
            double val = (len / 2);
            len = (int)Math.Floor(val);
            s=s.Substring(len, len);
            return s;
        }

        public static bool Validar(string s)
        {
            if (s[0] == 'a' && s[s.Length - 1] == 'z')
                return true;
            else
                return false;
        }

        public static string RemoverEspacos(string s)
        {
            return s.Trim();
        }
    }

  
}
