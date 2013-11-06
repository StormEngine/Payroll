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
    /// An interface for person objects
    /// </summary>
    interface IPersonable
    {
        public string FullName
        { get; set; }

        public string FirstName
        { get; set; }

        public string MiddleName
        { get; set; }

        public string LastName
        { get; set; }

        public string Initials
        { get; }

        public DateTime DOB
        { get; set; }

        public ILocatable Address
        { get; set; }

    }  // END interface IPersonable

}   //  END namespace Payroll
