using Xunit;

namespace HelloWorld_UnitTest
{
    public class WebTest
    {
        [Fact]
        public void DemoTest()
        {
            int i = 1;
            bool result = false;
            if ( i == 1 ) result = true;
            Assert.True(result,"Value should not be equal to 1");

        }
    }
}