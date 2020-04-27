using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Testes.CSharp.Teste2.Answers.SecondExercise
{
    public class Knife : ISharp
    {
        private int _sharpness;
        public int Sharpness { get => _sharpness; }

        public void Cut(string s)
        {
            if (Sharpness - 10 < 0)
                Console.WriteLine($"A faca não está afiada o sufeciente para cortar {s}");
            else
            {
                _sharpness -= 10;
                Console.WriteLine($"Cortou {s}");
            }
        }

        public void Sharpen()
        {
            _sharpness = (Sharpness + 25 > 100) ? 100 : Sharpness + 25;
            if (Sharpness == 100)
                Console.WriteLine("A faca está completamente afiada");
            else
                Console.WriteLine("Afiou a faca");
        }

        public Knife()
        {
            _sharpness = 100;
        }
    }
}
