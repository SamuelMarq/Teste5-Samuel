using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Testes.CSharp.Teste2.Answers.SecondExercise
{
    public class PizzaCuter : ISharp
    {
        int _sharpness;
        public int Sharpness { get => _sharpness; }
        public void Cut(string s="Pizza")
        {

        }

        public void Sharpen()
        {

        }
        public PizzaCuter()
        {
            _sharpness = 50;
        }
    }
}
