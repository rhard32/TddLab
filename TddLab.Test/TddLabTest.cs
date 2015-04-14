using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TddLab;

namespace TddLab.Test
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
        public void GetTheConsanants()
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
        public void TestForNuberEntry()
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
    }
}
