using Xunit;
using Blockchain.Utils;

namespace Blockchain.Tests
{
    public class HashingTest
    {
        [Fact]
        public void HashSholdBeLenght64()
        {
            string hash = Hashing.ToSha256("alexandre servian");
            int expectedResult = 64;
            Assert.Equal(expectedResult, hash.Length);
        }

        [Theory]
        [InlineData("alexandre servian","B1D6E2F40ADAB3597DDBB74CB2FF0BECC7CA2B6306359EB74ECA7C5CD8A855E9")]
        [InlineData("Alexandre Servian","2CFC80D94BF974597523FD85D62039FC6FD6CF6D6F341139B15AFE6F3E5CF051")]
        [InlineData("600 price","3B770296140BBD6032062BC8B41B49D24DA56FA302179A4F5B774E83051C6B53")]
        [InlineData("-700 dollars","AC591998EA45FFE992449079565CFAC42879A8A1B0EC97C0DFE14127EA43786D")]
        [InlineData("This is a Blockchain","AE2495CC1672963BD690131D99CDD19AFA73EE3E158B11A29E63567F39D8A7AB")]
        public void IsValidGeneratedHash(string data, string expectedResult) {
            string hash = Hashing.ToSha256(data);
            Assert.Equal(expectedResult, hash);
        }
    }
}
