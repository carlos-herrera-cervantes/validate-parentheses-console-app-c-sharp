using ValidParentheses.Models;
using Xunit;

namespace ValidParenthesesTests.Models
{
    public class SuperStringTest
    {
        [Fact]
        public void IsValidParentheses_Should_Return_False()
        {
            var str = "(}";
            bool result = SuperString.IsValidParentheses(str);

            Assert.False(result, "str should be false");
        }

        [Fact]
        public void IsValidParentheses_Should_Return_True()
        {
            var str = "{}";
            bool result = SuperString.IsValidParentheses(str);

            Assert.True(result, "str should be true");
        }
    }
}