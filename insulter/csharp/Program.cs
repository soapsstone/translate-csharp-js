using System;
using System.Collections.Generic;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

        List<string> insults = new List<string>() 
            {
                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so...like that?",
                "If you were a vegetable, you'd be a cabbitch",
            };

            // Phase one: Print on random insult
            // Step one: print a non-random insult, but just one
            // Console.WriteLine(insults[7]);
            // Console.WriteLine(insults[1]);
            // int randomNum = new Random().Next(0,7);
            // Console.WriteLine(randomNum);
            // Console.WriteLine(insults[randomNum])

            //Phase two: Print 3 random insults 
            // int randomNumOne = new Random().Next(0,7);
            // Console.WriteLine(randomNumOne);
            // Console.WriteLine(insults[randomNumOne]);

            // int randomNumTwo = new Random().Next(0,7);
            // Console.WriteLine(randomNumTwo);
            // Console.WriteLine(insults[randomNumTwo]);

            // int randomNumThree = new Random().Next(0,7);
            // Console.WriteLine(randomNumThree);
            // Console.WriteLine(insults[randomNumThree]);

            //Phase three: prevent duplicates
            
            
            List<int> randomNumbers = new List<int>(){};

            while (randomNumbers.Count < 3){
                int singleRandomNumOne = new Random().Next(0,6);

                if (!randomNumbers.Contains(singleRandomNum)) {
                    randomNumbers.Add(singleRandomNum);
                }
            }
            //randomNumbers.ForEach( numb => Console.WriteLine(num));
            foreach (int randomNumber in randomNumbers) {

            }

        }
    }
}
