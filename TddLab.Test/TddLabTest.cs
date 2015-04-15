using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TddLab;

namespace TddLab.Test //Tdd Lab 1 Initial
{
    public class TddLabTest
    {
        [Fact]
        public void StreetNamePropertyReturnsNotVoid()

    {
        var testStreetName = new streetName();

        Assert.False(testStreetName == null);


    }
        [Fact]
        public void GetTheConsanants() //Tdd Lab 1 Question 1
        {
            var input = "Short Phrase";
            var engine = new streetName();
            var answer = engine.GetConsanants(input);

            // answer should be the same sequence as output.
            var output = new List<char> 
            {
                'S',
                'h',
                'r',
                't',
                'P',
                'h',
                'r',
                's'
            };
            Assert.Equal(output, answer);


        }

        [Fact]
        public void TestForNuberEntry() //Tdd Lab 1 Testing for number entry
        {
            var input = "1st";
            var engine = new streetName();
            var answer = engine.GetConsanants(input);

            // answer should be the same sequence as output.
            var output = new List<char> 
            {
                's',
                't'
               
            };
            Assert.Equal(output, answer);


        }

        [Fact] //Lab 1 Question 2 Alphabetizing
        public void TestGettingConsonantsInOrder()
        {
            var input = "short phrase 1";
            var engine = new streetName();
            var answer = engine.GetAlphabetizedConsantants(input);

            // answer should be the same sequence as output.
            var output = new List<char> 
            {
                'h',
                'h',
                'p',
                'r',
                'r',
                's',
                's',
                't'
               
            };
            Assert.Equal(output, answer);


        }
        [Fact]
        public void TestUniqueConsonants()
        {
            var input = "short phrase 1";
            var engine = new streetName();
            var answer = engine.GetUniqueConsantants(input);

            // answer should be the same sequence as output.
            var output = new List<char> 
            {
                'h',
                'p',
                'r',
                's',
                't'
               
            };
            Assert.Equal(output, answer);


        }
    }
}
