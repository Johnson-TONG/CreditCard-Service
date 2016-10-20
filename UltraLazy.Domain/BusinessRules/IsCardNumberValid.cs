using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public IsCardNumberValid(string cardNumber)
        {
            throw new System.NotImplementedException();
        }
        public bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
