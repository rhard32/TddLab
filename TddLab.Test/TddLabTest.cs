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
    }
}
