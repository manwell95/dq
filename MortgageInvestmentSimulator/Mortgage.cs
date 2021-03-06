using System.Diagnostics;
using JetBrains.Annotations;

namespace MortgageInvestmentSimulator
{
    /// <summary>
    ///     Our mortgage.
    /// </summary>
    [PublicAPI]
    [DebuggerDisplay("{" + nameof(ToString) + "()}")]
    public sealed class Mortgage
    {
        /// <summary>
        ///     Gets or sets the amount of the mortgage.
        /// </summary>
        /// <value>The amount.</value>
        public decimal Amount { get; set; }

        /// <summary>
        ///     Gets or sets the balance of the mortgage.
        /// </summary>
        /// <value>The balance.</value>
        public decimal Balance { get; set; }

        /// <summary>
        ///     Gets or sets the years left on the mortgage..
        /// </summary>
        /// <value>The years.</value>
        public int Years { get; set; }

        public decimal InterestRate { get; set; }

        public decimal Payment { get; set; }

        /// <summary>
        /// Gets or sets the amount you received from the loan.
        /// </summary>
        /// <value>The pay out.</value>
        public decimal Proceeds { get; set; }

        /// <inheritdoc />
        public override string ToString()
            => $"{Amount:C0} mortgage for {Years} years @ {InterestRate:P2}; {Balance:C0} balance with {Payment:C0} payment";
    }
}
