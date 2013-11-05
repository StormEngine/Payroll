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
    /// 
    /// </summary>
    interface IEmployable
    {
        public ulong ID
        { get; set; }

        public DateTime StartDate
        { get; set; }

        public DateTime EndDate
        { get; set; }

        public string Department
        { get; set; }

        public string PositionTitle
        { get; set; }

        public string Manager
        { get; set; }

        public EmploymentStatus Type
        { get; set; }

        public Boolean IsSalaried();

        public Boolean IsHourly();

        public Boolean IsProjectBasis();

        public WageRate Wages
        { get; set; }

        public decimal Salary
        { get; set; }

    }  // END interface IEmployable

}  //  END namespace Payroll
