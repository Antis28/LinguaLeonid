using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada
{
    public  interface IMyUnknownWords
    {
       public List<Word> myUnknownWordsListRepository;
        
       public  void removeWord(Word wordForRemoving);

    }
}
