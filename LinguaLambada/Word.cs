using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada
{
    class Word : IWord
    {
        public Word(string englishName, string russianName, int usedCounter)
        {
            EnglishName = englishName;
            RussianName = russianName;
            UsedCounter = 0;
        }
        public string EnglishName { get; private set; }
        public string RussianName { get; private set; }
        public int UsedCounter { get;  set; }
    }
}
