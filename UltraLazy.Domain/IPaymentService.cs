using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraLazy.Domain
{
    public interface IPaymentService
    {
        /// <summary>
        /// Returns the unique ID allocated to a user
        /// </summary>
        string WhatsYourId();

        /// <summary>
		/// Returns the GUID allocated to payment
		/// </summary>
		Guid MakePayment(CreditCard creditCard);
    }
}
