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
        public void TestWithdrawMethodToWithdrawTheCorrectAmount()
        {
            // Arrange
            decimal testBalance = 50;
            decimal testWithdrawAmount = 20;
            // Act
            decimal outputFromMethod = Withdraw(testWithdrawAmount, testBalance);
            // Assert
            Assert.Equal((testBalance - testWithdrawAmount), outputFromMethod);
        }
        [Fact]
        public void TestWithdrawMethodToMakeSureTheMethodDoesntAdd()
        {
            // Arrange
            decimal testBalance = 1000;
            decimal testWithdrawAmount = 20;
            // Act
            decimal outputFromMethod = Withdraw(testWithdrawAmount, testBalance);
            // Assert
            Assert.NotEqual((testBalance + testWithdrawAmount), outputFromMethod);
        }

        [Fact]
        public void TestWithdrawMethodToPreventTheBalanceFromGoingBelowZero()
        {
            // Arrange
            decimal testBalance = 10;
            decimal testWithdrawAmount = 20;
            // Act
            decimal outputFromMethod = Withdraw(testWithdrawAmount, testBalance);
            // Assert
            Assert.NotEqual(20, outputFromMethod);
        }

        [Fact]
        public void TestDepositMethodForProperFunctionality()
        {
            // Arrange
            decimal testBalance = 100;
            decimal testDepositAmount = 20;
            // Act
            decimal outputFromMethod = Deposit(testDepositAmount, testBalance);
            // Assert
            Assert.Equal((testDepositAmount + testBalance), outputFromMethod);
        }

        [Fact]
        public void TestDepositMethodDoesntSubtractValues()
        {
            // Arrange
            decimal testBalance = 1000;
            decimal testDepositAmount = 20;
            // Act
            decimal outputFromMethod = Deposit(testDepositAmount, testBalance);
            // Assert
            Assert.NotEqual((testDepositAmount - testBalance), outputFromMethod);
        }

        [Fact]
        public void TestDepositMethodDoesntAcceptNegativeNumbers()
        {
            // Arrange
            decimal testBalance = 10;
            decimal testDepositAmount = -20;
            // Act
            decimal outputFromMethod = Deposit(testDepositAmount, testBalance);
            // Assert
            Assert.NotEqual((testDepositAmount + testBalance), outputFromMethod);
        }

    }
}
