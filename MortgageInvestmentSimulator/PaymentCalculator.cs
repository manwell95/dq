using System;

namespace MortgageInvestmentSimulator
{
    /// <summary>
    ///     Class to calculate loan payments
    /// </summary>
    public sealed class PaymentCalculator
    {
        /// <summary>
        ///     Loan amount
        /// </summary>
        public decimal LoanAmount { get; set; }

        /// <summary>
        ///     The annual interest rate to be charged on the loan
        /// </summary>
        public decimal InterestRate { get; set; }

        /// <summary>
        ///     The term of the loan in years. This is the number of years
        ///     that payments will be made.
        /// </summary>
        public int Years { get; set; }

        /// <summary>
        ///     Calculates the monthly payment amount based on current
        ///     settings.
        /// </summary>
        /// <returns>Returns the monthly payment amount</returns>
        public decimal Payment
        {
            get
            {
                decimal payment = 0;
                if (Years <= 0)
                    return payment;

                if (InterestRate > 0)
                {
                    var rate = (double)InterestRate / 12;
                    var factor = (decimal)(rate + (rate / (Math.Pow(rate + 1, Years * 12) - 1)));
                    payment = (LoanAmount * factor);
                }
                else
                    payment = (LoanAmount / Years * 12);

                return payment.ToDollarCents();
            }
        }

        public static decimal CalculatePayment(decimal loanAmount, decimal interestRate, int years)
        {
            var calculator = new PaymentCalculator
            {
                Years = years,
                InterestRate = interestRate,
                LoanAmount = loanAmount,
            };
            return calculator.Payment;
        }
    }
}
