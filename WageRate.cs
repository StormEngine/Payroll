using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 
/// </summary>
namespace Payroll
{
    /// <summary>
    /// Represents an employees wages (e.g, $10/Hour, $50K/annual, $30/per-project
    /// </summary>
    class WageRate
    {
        /// <summary>
        /// The wages in some world currencty (e.g., $10USD, $50USD)
        /// </summary>
        private decimal _wages;

        /// <summary>
        /// The rate (e.g. per/hour per/project, per/year etc . . .)
        /// </summary>
        private WRate _rate;

        /// <summary>
        /// Initializes a new instance of the <see cref="WageRate"/> class.
        /// </summary>
        /// <param name="wages">The wages.</param>
        /// <param name="rate">The rate.</param>
        public WageRate(decimal wages, WRate rate)
        {
            this._wages = wages;
            this._rate = rate;

        }  //  END public WageRate(decimal wages, WageRate rate)

        /// <summary>
        /// Gets or sets the wages.
        /// </summary>
        /// <value>
        /// The wages.
        /// </value>
        public decimal Wages
        {
            get { return this._wages; }
            set { this._wages = value; }
        }  //  END public decimal Wages

        /// <summary>
        /// Gets or sets the rate.
        /// </summary>
        /// <value>
        /// The rate.
        /// </value>
        public WRate Rate
        {
            get { return this._rate; }
            set { this._rate = value; }
        }  // END public WageRate Rate

    }  //  END class WageRate

}  //  END namespace Payroll
