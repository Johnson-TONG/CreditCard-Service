using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UltraLazy.Domain.BusinessRules
{
    /// <summary>
    /// Performs a Mod-10/LUHN check on the passed number and returns true if the check passed
    /// </summary>
    /// <param name="cardNumber">A 16 digit card number</param>
    /// <returns>true if the card number is valid, otherwise false</returns>
    /// <remarks>
    /// Refer here for MOD10 algorithm: https://en.wikipedia.org/wiki/Luhn_algorithm
    /// </remarks>
    public class IsCardNumberValid : IBusinessRule
    {
        private string _cardNumber;

        // confirm only digital number and nothing else
        private Regex regex = new Regex("^[0-9]+$", RegexOptions.Compiled);
        const int creditCardLength = 16;

        public IsCardNumberValid(string cardNumber)
        {
            _cardNumber = cardNumber;
        }
        public bool Validate()
        {
            //don't use int.TryParse because '+' and '-' value is valid in tryparse method

            return IsDigital() && IsSixteenDigits();
        }

        private bool IsDigital()
        {
            return regex.IsMatch(_cardNumber);
        }
        private bool IsSixteenDigits()
        {
            return _cardNumber.Length == creditCardLength;
        }
    }
}
