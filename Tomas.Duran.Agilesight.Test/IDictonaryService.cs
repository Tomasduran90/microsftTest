using System;
using System.Collections.Generic;
using System.Text;

namespace Tomas.Duran.Agilesight.Test
{
    public interface IDictonaryService
    {
        List<string> GetEnglishWords(string word);
    }
}
