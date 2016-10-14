using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada
{
   public  interface IEnglishTrainingApparatus
    {
        void showHelloMessage(string helloMessage, string rulesOfQuiz);



        void getMyUnknownWordsListRepository(Word[] myUnknownWordsListRepository, int numberOfChosenWord);
        int chooseWord(int numberOfChosenWord);
        

        Word[] saveResults(Word[] myUnknownWordsListRepository);

    }
}
