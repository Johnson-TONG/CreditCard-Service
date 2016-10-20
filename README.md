# CreditCard-Service #
Credit Card Service with ServiceStack Framework.
The CreditCard-Service can supply credit-card validation, but supplying credit-card number to the service.
There will showcases for 2 ways :
1. the ASP.Web API
2. service stack API


# Description #
The service requires 2 operations to be implemented:

1. YourId: the Pin that is supply to you by the system like: 008ab27c-36b2-43e5-91d5-edbd1e5b564b. Before you can use this service  
2. Your UserName and Password
3. MakePayment: should validate the card and amount and return a Guid if successful and null if information is not valid.


# Business rule #
1. IsCardNumberValid: Implement the MOD10 algorithm as explained here: https://en.wikipedia.org/wiki/Luhn_algorithm. Include a validation for the number of digits in the card number to ensure 16 digits are passed.

2. IsValidPaymentAmount: Check if the passed number is a valid number between 99 and 99999999.

3. CanMakePaymentWithCard: Evaluate the parameters passed to ensure they represent a valid card that can be 

used to make payments:

 * cardNumber: is a valid 16 digit number that passes the MOD10 check as explained in 2 above

 * expiryMonth: should represent a month number between 1 and 12

 * expiryYear: Should represent a year value, 4 characters in lenght and either the current or a future year

 * The expiry month + year should represent a date in the future

