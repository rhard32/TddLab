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
            var vowels = new List<char>() { 
            'a','e','i','o','u','A','E','I','O','U',' '}; 

            for (int i = 0; i < input.Length; i++)
			{
                if (!(vowels.Contains(input[i])))
                {
                    constList.Add(input[i]);
                }
			 
			}

            return constList;
        }
    }
}
