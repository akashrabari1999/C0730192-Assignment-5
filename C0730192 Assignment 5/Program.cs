using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730192_Assignment_5
{
    class Program2
    {
        
        string[] Letters = new string[26] { "a", "b", "c", "d", "e", "P,"g","h","T, "JT,"K","T, "m", "n", "o", "p", "", "r", "s", "t", "u'", "V", "W"',"X","y"', "z" };
        public static void Main()
        {
            Program2 orange=new Program2();
            Console.WriteLine(orange.Gematria("universe"));
        }
        public int Gematria(string word)
        {
            int GematriaValue = 0;
            for (int i = 0; i < word.Length; i++)
            { GematriaValue += LetterValue(word[i].ToString()); }
            return GematriaValue;
        }


    }
}
