using System;
using System.Collections.Generic;
using System.Text;

namespace Tomas.Duran.Agilesight.Test
{
    public class DictonaryService : IDictonaryService
    {
        private readonly IDictionary dictionary;

        public DictonaryService(IDictionary dictionary)
        {
            this.dictionary = dictionary;
        }

        public List<string> GetEnglishWords(string word)
        {
            List<string> rvlaue = new List<string>();

            var convinations = Permutations.FindPermutations(word);

            foreach (var conv in convinations)
            {
                if(this.dictionary.IsEnglishWord(conv))
                {
                    rvlaue.Add(conv);
                }
            }

            return rvlaue;
        }
    }
}
