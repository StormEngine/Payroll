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
    /// An interface to represent addresses for parts of the world.
    /// Addresses are represented differently in different parts of the world (e.g., US, UK, GE etc...)
    /// </summary>
    interface ILocatable
    {
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        { get; set; }

    }  //  END interface ILocatable
}  // END interface ILocatable
