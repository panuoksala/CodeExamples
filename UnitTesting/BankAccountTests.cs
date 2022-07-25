using System;
using Xunit;

namespace UnitTesting
{
    public class BankAccountTests
    {
        [Fact]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            var account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.Equal(expected, actual, 3);
        }

        [Fact]
        public void Debit_WithTooBigAmount_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            double beginningBalance = 20;
            double debitAmount = 35;
            var account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                account.Debit(debitAmount);
            });
        }

        // Exercise 1
        [Fact]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 10.99;
            double creditAmount = 4.02;
            double expected = 15.01;
            var account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Credit(creditAmount);

            // Assert
            double actual = account.Balance;
            Assert.Equal(expected, actual, 3);
        }

        [Fact]
        public void CustomerName_WithLowerCase_IsReturnedInUpperCase()
        {
            // Arrange
            var account = new BankAccount("Mr. Bryan Walton", 0);

            // Act
            var name = account.CustomerName;

            // Assert (Use ctrl+shift+u to capitalize)
            Assert.Equal("MR. BRYAN WALTON", name);
        }

        [Fact]
        public void Balance_WithValidBalance_ReturnsBalanceAmount()
        {
            // Arrange
            var initialBalance = 50;
            var account = new BankAccount("Mr. Bryan Walton", initialBalance);

            // Act
            var actualBalance = account.Balance;

            // Assert
            Assert.Equal(initialBalance, actualBalance);
        }

        [Fact]
        public void CustomerName_WithNullValue_InitializesNameWithEmptyString()
        {
            // Arrange
            var account = new BankAccount(null, 0);

            // Act
            var actualName = account.CustomerName;

            // Assert (Crashes before code change)
            Assert.Equal(string.Empty, actualName);
        }
    }
}