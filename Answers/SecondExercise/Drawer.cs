using System;
using System.Collections.Generic;

namespace Recodme.Testes.CSharp.Teste2.Answers.SecondExercise
{
    [Stuck]
    public class Drawer
    {
        Dictionary<string, object> _divisoria;
        public Drawer()
        {
            _divisoria = new Dictionary<string, object>();
        }
        public object this[string index]
        {
            get => _divisoria.ContainsKey(index);
            set { if (!(value is ISharp)) _divisoria[index] = value; }
        }
    }


    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class Stuck : Attribute
    {
    }

    public class StuckExceptio : Exception
    {
        public StuckExceptio() : base("A gaveta está presa")
        {

        }
    }
}
