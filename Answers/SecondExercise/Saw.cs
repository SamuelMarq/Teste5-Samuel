using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Testes.CSharp.Teste2.Answers.SecondExercise
{
    public class Saw : ISharp
    {
        int _sharpness;
        public int Sharpness { get => _sharpness; }
        public void Cut(string s)
        {
            
        }

        public void Sharpen()
        {
            
        }
        public Saw()
        {
            _sharpness = 70;
        }
    }
}
