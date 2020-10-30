using System;
using System.Collections.Generic;
using System.Linq;

namespace Tomas.Duran.Agilesight.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary dictionary = new Dictionary("Resources/EnglishWords.txt");
            IDictonaryService dictonaryHelper = new DictonaryService(dictionary);
            var words = dictonaryHelper.GetEnglishWords("microsoft");
        }
    }
}