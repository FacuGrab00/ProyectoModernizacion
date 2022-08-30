using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoModernizacion
{
    public static class StringExtensions
    {
        public static string UpperFirstChar(this string input)
        {
            string[] name = input.Split(" ");
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }
            
            return char.ToUpper(name[0][0]) + name[0].Substring(1) + " " + char.ToUpper(name[1][0]) + name[1].Substring(1);
        }
    }
}
