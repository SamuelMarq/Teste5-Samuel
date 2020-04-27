using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Testes.CSharp.Teste2.Answers.SecondExercise
{
    public class Lamp
    {
        string _color;
        public string Color { get => _color; }
        public Lamp(int c)
        {
            _color = c;
        }
    }
}
