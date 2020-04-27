using System;
using System.Collections.Generic;
using System.IO;

namespace Recodme.Testes.CSharp.Teste2.Answers.FirstExercise
{
    public static class OneD 
    {
        public static DateTime NextWorkDay(this DateTime date)
        {
            date = date.AddDays(1);
            while (date.DayOfWeek==(DayOfWeek)0 || date.DayOfWeek == (DayOfWeek)6)
            {
                date = date.AddDays(1);
            } 
            return date;
        }
    }
}
