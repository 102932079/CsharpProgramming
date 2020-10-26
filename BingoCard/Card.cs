using System;
using System.Collections.Generic;
using System.Linq;

namespace   BingoCard
{
    public class Card
    {   
        public int CardMin;
        public int CardMax;
        
        public int CardSize;

        public List<string> CardNumbers;

        //create an instance of a random object

        Random random =new System.Random();

        public Card()
        {

        }

        public Card(int cardMin, int cardMax, int totalNumberRequired)
        {
            //total 25 min1 max 100
            this.CardMax = cardMax;
            this.CardMin = cardMin;
            this.CardSize = totalNumberRequired;
            this.CardNumbers = new List<string>();

            

            for ( int i = cardMin; i < totalNumberRequired + 1 ; i++)
            {
                //intialise escap variable
                bool vaildNumber  = false;
                
                //generate random number

                var ranCardNum = random.Next(1,CardMax).ToString();

                //check if number is valid

                while (vaildNumber == false)
                {
                    //check if the number is not in the list
                    if (!CardNumbers.Contains(ranCardNum))
                    {
                        //not in list then we can turn the validnumber's value to ture to end the loop
                        vaildNumber = true;
                    }
                    else
                    {
                        //otherwise regenerate a new random number to avoid dulplicate

                        ranCardNum = random.Next(1, cardMax).ToString();

                    }
                }
                //add this number to the list as record

                CardNumbers.Add(ranCardNum);
        
                

            }

            
            
        
        }

        

        

    }
}