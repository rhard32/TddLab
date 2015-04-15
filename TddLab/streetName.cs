using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddLab
{
    public class streetName
    {
        public List<char> GetConsanants(String input)
        {
            var constList = new List<char>() ;
            var consonants = new List<char>() { 
            'b','c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','v',
            'B','C','D','F','G','H','J','K','L','M','N','P','Q','R','S','T','V','W','X','Y','V'}; 

            for (int i = 0; i < input.Length; i++)
			{
                if (consonants.Contains(input[i]))
                {
                    constList.Add(input[i]);
                }
			 
			}

            return constList;
        }
        public List<char> GetAlphabetizedConsantants(String input)
        {
            var constList = new List<char>(); // puts list in new var so that it can call an outside method
            constList = GetConsanants(input);

           constList.Sort();//puts in alpha order
           return constList;
               
        }

public List<char> GetUniqueConsantants(String input) //Returns each consonant only once
        {

            var uniqueConstList = new List<char>();
            uniqueConstList = GetAlphabetizedConsantants(input);
            for (int i = 1; i < uniqueConstList.Count; i++) //starts a count so that starting at the second occurrence because the first occurance has nothing to compare
            {
                if (uniqueConstList[i] == uniqueConstList[i - 1]) //actually compares the new occurane to the new occurence
                    uniqueConstList.Remove(uniqueConstList[i]);
            }
            return uniqueConstList;
        }

    }
}
