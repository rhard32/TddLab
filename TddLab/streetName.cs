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
    }
}
