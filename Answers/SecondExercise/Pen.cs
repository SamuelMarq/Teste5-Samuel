using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Testes.CSharp.Teste2.Answers.SecondExercise
{
    public class Pen
    {
        string _color;
        public string Color { get => _color; }
        public Pen(int c)
        {
            _color = c;
        }
    }
}
