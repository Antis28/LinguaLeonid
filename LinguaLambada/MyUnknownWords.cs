using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada
{
   public class MyUnknownWords : IMyUnknownWords
    {

        public List<Word> myUnknownWordsListRepository;

        public void removeWord(Word wordForRemoving)
        {
            for (int i = 0; i < myUnknownWordsListRepository.Count; i++)
            {
                if (myUnknownWordsListRepository[i].Equals(wordForRemoving))
                {
                    myUnknownWordsListRepository.RemoveAt(i);
                }
            }
                
        }
    }
}
