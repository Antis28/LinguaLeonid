using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada
{
   public  class TrainingApparatusLogic : ITrainingAppartusLogic
    {
        public List<Word> myUnknownWordsListRepository = new List<Word>();
        public void removeThreeTimesRightSelectedWord(Word word)
        {
            if (word.UsedCounter == 3)
            {
                for (int i = 0; i < myUnknownWordsListRepository.Count; i++)
                {
                    if (word.Equals(myUnknownWordsListRepository[i])) myUnknownWordsListRepository.RemoveAt(i);
                }
            }
        }
    }
}
