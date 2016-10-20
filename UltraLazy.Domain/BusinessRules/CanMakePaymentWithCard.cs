using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraLazy.Domain.BusinessRules
{
    public class CanMakePaymentWithCard : IBusinessRule
    {
        /// <summary>
		/// Validates the card number, expiry motnh and year to ensure the details can be used to make a payment
		/// </summary>
		/// <param name="cardNumber">A 16 digit card number</param>
		/// <param name="expiryMonth">Month part of the expiry date</param>
		/// <param name="expiryYear">Year part of the expiry date</param>
		/// <returns>true if the details represent a valid card, otherwise false</returns>
		/// <remarks>
		/// Validations:
		/// cardNumber: Ensure the passed string is 16 in length and passes the MOD10/LUHN check
		/// expiryMonth: should represent a month number between 1 and 12
		/// expiryYear: Should represent a year value, 4 characters in lenght and either the current or a future year
		/// The expiry month + year should represent a date in the future
		/// </remarks>
        public CanMakePaymentWithCard(string cardNumber, int expiryMonth, int expiryYear)
        {
            throw new System.NotImplementedException();
        }
        public bool Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
