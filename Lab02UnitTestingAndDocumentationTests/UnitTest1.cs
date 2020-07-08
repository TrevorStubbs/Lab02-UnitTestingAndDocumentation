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
            decimal balanceFromProgram = Balance;
            // Act
            decimal testBalance = ViewBalance();
            // Assert
            Assert.Equal(balanceFromProgram, testBalance);
        }

        [Fact]
        public void TestWithdrawMethod1()
        {
            // Arrange
            decimal testBalance = 50;
            decimal testWithdrawAmount = 20;
            // Act
            decimal outputFromMethod = Withdraw(testWithdrawAmount, testBalance);
            // Assert
            Assert.Equal(30, outputFromMethod);
        }
        [Fact]
        public void TestWithdrawMethod2()
        {
            // Arrange
            decimal testBalance = 1000;
            decimal testWithdrawAmount = 20;
            // Act
            decimal outputFromMethod = Withdraw(testWithdrawAmount, testBalance);
            // Assert
            Assert.NotEqual(20, outputFromMethod);
        }

        [Fact]
        public void TestWithdrawMethod3()
        {
            // Arrange
            decimal testBalance = 10;
            decimal testWithdrawAmount = 20;
            // Act
            decimal outputFromMethod = Withdraw(testWithdrawAmount, testBalance);
            // Assert
            Assert.NotEqual(20, outputFromMethod);
        }

    }
}
