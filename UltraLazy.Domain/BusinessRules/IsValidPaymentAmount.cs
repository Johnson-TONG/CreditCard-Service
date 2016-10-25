using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraLazy.Domain.BusinessRules
{
    public class IsValidPaymentAmount : IBusinessRule
    {
        private long _amount;
        /// <summary>
		/// Checks if the amount represents a valid payment amount 
		/// </summary>
		/// <param name="amount">An amount value in cents (1 Dollar = 100 cents)</param>
		/// <remarks>
		/// Validation:
		/// The amount must be between 99 cents and 99999999 cents
        /// long is actually is the same as Int64
		/// </remarks>
        public IsValidPaymentAmount(long amount)
        {
            _amount = amount;
        }
        /// <summary>
        /// Must be between equal or greater than 1$ and equal or less then 1 million dollars
        /// between 99 cents and 99999999
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            if (_amount >= 1 && _amount <= 1000000)
                return true;
            else
                return false;
        }
    }
}
