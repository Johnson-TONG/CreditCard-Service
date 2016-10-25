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
            if (string.IsNullOrEmpty(_cardNumber)) return false;

            return IsDigital() && IsSixteenDigits() & IsLuhnMod10();
        }

        private bool IsDigital()
        {
            return regex.IsMatch(_cardNumber);
        }
        private bool IsSixteenDigits()
        {
            return _cardNumber.Length == creditCardLength;
        }
        /// <summary>
        /// Double the number if bigger than 9 substract it with 9
        /// 10 become 1, 12 become 3, 14 become 5, 16 become 7, 
        /// so 3 & 6 equal, 1 & 5 equal, 7 & 8 equal 
        /// 0, 2, 4, 9 is unique
        /// </summary>
        /// <param name="DigitNumber"></param>
        /// <returns></returns>
        private int DoublieIt(int DigitNumber)
        {
            DigitNumber *= 2;

            if ( DigitNumber > 9)
            {
                return DigitNumber - 9;
            }
            return DigitNumber;
        }
        /// <summary>
        /// this is the The Luhn algorithm taken from WikiPedia
        /// for detail go into https://en.wikipedia.org/wiki/Luhn_algorithm
        /// </summary>
        /// <returns></returns>
        public bool IsLuhnMod10()
        {
            //each digit subtract 0 to convert string to integer
            int[] Digs = _cardNumber.Select(c => c - '0').ToArray<int>();

            int sumOfDigits = 0;

            bool isAlternateDigit = false;
            for( int Position =Digs.Length-1; Position>=0; Position-- )
            {
                //Double every other
                if (isAlternateDigit)
                {
                    Digs[Position] = DoublieIt(Digs[Position]);

                }
                sumOfDigits += Digs[Position];

                isAlternateDigit = true;
            }
            // take the number and mod 10
            return sumOfDigits  % 10 == 0;
        }
    }
}
