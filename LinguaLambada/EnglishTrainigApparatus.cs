using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada 
{
   public class EnglishTrainigApparatus : IEnglishTrainingApparatus
    {
        public Random rnd = new Random();
        public List<Word> wordsListRepository = new List<Word>();

       
        public void showHelloMessage(string helloMessage, string rulesOfQuiz);
        public void getMyUnknownWordsListRepository(Word[] myUnknownWordsListRepository, int numberOfChosenWord)
        {
            for (int i = 0; i < myUnknownWordsListRepository.Length; i++)
            {
                var firstNumber = 0;
                var secondNumber = 0;
                var thirdNumber = 0;
  
                var currentWord = myUnknownWordsListRepository[i];
                while (true)
                {
                    firstNumber = rnd.Next(0, 1000);
                    secondNumber = rnd.Next(0, 1000);
                    thirdNumber = rnd.Next(0, 1000);
                    if ((firstNumber != secondNumber) && (secondNumber != thirdNumber) && (firstNumber != thirdNumber))
                    {
                        break;
                    }
                }

                var firstRussianWordToChoose = wordsListRepository[firstNumber].RussianName;
                var secondRussianWordToChoose = wordsListRepository[secondNumber].RussianName;
                var thirdRussianWordToChoose = wordsListRepository[thirdNumber].RussianName;

                string[] arrayOfTranslationsToChoose = new string[4] { firstRussianWordToChoose, secondRussianWordToChoose, thirdRussianWordToChoose, currentWord.RussianName };
                for (int k = 0; k < arrayOfTranslationsToChoose.Length; k++)
                {
                    int m = rnd.Next(arrayOfTranslationsToChoose.Length - 1);
                    var element = arrayOfTranslationsToChoose[k];
                    arrayOfTranslationsToChoose[k] = arrayOfTranslationsToChoose[m];
                    arrayOfTranslationsToChoose[m] = element;
                }

                var number = chooseWord(numberOfChosenWord);
                if (arrayOfTranslationsToChoose[number].Equals(currentWord.RussianName)) currentWord.UsedCounter = currentWord.UsedCounter++;

            }
        }

        public int chooseWord(int numberOfChosenWord)
        {
            return numberOfChosenWord;
        }


        public Word[] saveResults(Word[] myUnknownWordsListRepository)
        {
            return myUnknownWordsListRepository;
        }
        
    }
}
