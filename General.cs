using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    /// <summary>
    /// Type of employee (e.g. part-time, full-time, intern, freelancer, project-basis/per-job, seasonal etc . . .)
    /// 
    /// </summary>
    
    public enum EmploymentStatus {FullTime,PartTime,Intern,Freelancer,ProjectBasis,Seasonal,Unclassified};
    public enum WRate {PerHour, PerWeek, PerProject, SalariedPerHourEst, SalariedPerWeekEst, SalariedPerYear};

}   // END namespace Payroll
