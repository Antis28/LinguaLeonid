using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada
{
   public  class UserProfile : IUserProfile
    {
        public UserProfile(int id, string name)
        {
            Id = id;
            Name = name;
            
        }
        public int Id { get; private set; }
        public string Name { get; private set; }

        public List<Word> myUnknownWordsListRepository = new List<Word>();
        public List<Word> wordsListRepository = new List<Word>();
        public Random rnd = new Random();
        


        public void solvingQuiz(int number)
        {
            for (int j = 0; j < myUnknownWordsListRepository.Count; j++)
            {
                var currentWord = getCurrentWord(j);
                var currentWordEng = currentWord.EnglishName;

                string[] translationList = getTranslationList(currentWord);

                string[] arrayOfTranslationsToChooseFrom = mixElementsOfTranslations(translationList);

                var numberOfAnswer = chooseNumberOfRightTranslation(number);

                var currentWordNew = changeUsedCounter(arrayOfTranslationsToChooseFrom, numberOfAnswer, currentWord);

                removeWordAfterThreeLuckyTries(currentWordNew);

            }

        }


        public Word getCurrentWord(int j)
        {
            
                Word currentWord = myUnknownWordsListRepository[j];
               
                return currentWord;
            

        }

        public string[] getTranslationList(Word currentWord)
        {
            List<string> translationList = new List<string>();
            var firstNumber = 0;
            var secondNumber = 0;
            var thirdNumber = 0;
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

            translationList.Add(firstRussianWordToChoose);
            translationList.Add(secondRussianWordToChoose);
            translationList.Add(thirdRussianWordToChoose);
            translationList.Add(currentWord.RussianName);

            return translationList.ToArray();
        }

       

        public string[] mixElementsOfTranslations(string[] arrayOfTranslationsToChoose)
        {
            for (int k = 0; k < arrayOfTranslationsToChoose.Length; k++)
            {
                int m = rnd.Next(arrayOfTranslationsToChoose.Length - 1);
                var element = arrayOfTranslationsToChoose[k];
                arrayOfTranslationsToChoose[k] = arrayOfTranslationsToChoose[m];
                arrayOfTranslationsToChoose[m] = element;
            }

            return arrayOfTranslationsToChoose;
        }


        public int chooseNumberOfRightTranslation(int number) //Testing
        {
            int numberOfAnswer = number;

            return numberOfAnswer;
        }

        public Word changeUsedCounter(string[] arrayOfTranslationsToChoose, int numberOfAnswer, Word currentWord )
        {
            if (arrayOfTranslationsToChoose[numberOfAnswer].Equals(currentWord.RussianName)) currentWord.UsedCounter = currentWord.UsedCounter++;
            return currentWord;
        }

        public void removeWordAfterThreeLuckyTries(Word currentWord)
        {
            
                if (currentWord.UsedCounter == 3) myUnknownWordsListRepository.Remove(currentWord);
          
        }
    }
}
