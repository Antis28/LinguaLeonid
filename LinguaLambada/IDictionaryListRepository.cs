using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada
{
    public interface IDictionaryListRepository
    {
        List<Word> wordsListRepository;
        string getWord(Word word);
    }
}
