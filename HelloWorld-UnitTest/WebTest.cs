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

        [Fact]
        public void CheckAddFunction()
        {
            functions func = new functions();
            int y = func.Add(3, 2);
            bool result = false;
            if( y == 5 ) result = true;

            Assert.True(result, "value should be equal to 5");

        }
    }
}