using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Tomas.Duran.Agilesight.Test
{
    public class Dictionary : IDictionary
    {
        public Dictionary<string, string> words;

        public Dictionary(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new Exception("Path can not be null.");

            List<string> fileWords = File.ReadLines(path).ToList();
            this.words = new Dictionary<string, string>();

            fileWords.ForEach(x =>
            {
                if(!this.words.ContainsKey(x.ToLower()))
                {
                    this.words.Add(x.ToLower(), x);
                }
            });
        }

        public bool IsEnglishWord(string word)
        {
            return this.words.ContainsKey(word.ToLower());
        }
    }
}
