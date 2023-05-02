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
    }
}
