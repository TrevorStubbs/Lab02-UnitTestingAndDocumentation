using System;
using Xunit;
using static Lab02UnitTestingAndDocumentation.Program;

namespace Lab02UnitTestingAndDocumentationTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestTheBalanceMethod()
        {
            // Arrange
            decimal balanceFromPrgram = Balance;
            // Act
            decimal testBalance = ViewBalance();
            // Assert
            Assert.Equal(balanceFromPrgram, testBalance);
        }
    }
}
