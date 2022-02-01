namespace UtilityEnum.Test
{
    public class UnitTest2
    {
        [Fact]
        public void CountryInfo_should_return_France_given_Fr()
        {
            Country enu = CountryInfo.GetCountry("Fr");

            enu.Should().Be(Country.France);
        }

        [Fact]
        public void CountryInfo_should_return_Zimbabwe_given_263()
        {
            Country enu = CountryInfo.GetCountry("263");

            enu.Should().Be(Country.Zimbabwe);
        }
    }
}