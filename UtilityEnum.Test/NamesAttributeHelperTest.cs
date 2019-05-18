using System;
using Xunit;
using FluentAssertions;
namespace UtilityEnum.Test
{
    public class UnitTest1
    {
        [Fact]
        public void NamesAttributeHelper_should_return_Jack_given_J()
        {
            Name enu= NamesAttributeHelper.GetMatch<Name>("J");

            enu.Should().Be(Name.Jack);

        }


    }
}
