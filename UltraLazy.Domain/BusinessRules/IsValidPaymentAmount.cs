using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraLazy.Domain.BusinessRules
{
    public class IsValidPaymentAmount : IBusinessRule
    {
        /// <summary>
		/// Checks if the amount represents a valid payment amount 
		/// </summary>
		/// <param name="amount">An amount value in cents (1 Dollar = 100 cents)</param>
		/// <remarks>
		/// Validation:
		/// The amount must be between 99 cents and 99999999 cents
		/// </remarks>
        public IsValidPaymentAmount(long amount)
        {
            throw new System.NotImplementedException();
        }
        public bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
