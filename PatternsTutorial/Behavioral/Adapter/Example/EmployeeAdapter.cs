// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeAdapter.cs" >
//   
// </copyright>
// <summary>
//   The 'Adapter' class
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PatternsTutorial.Behavioral.Adapter.Example
{
    using System.Collections.Generic;

    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    internal class EmployeeAdapter : HRSystem, ITargetEmployeeSource
    {
        /// <summary>
        /// The get employee list.
        /// </summary>
        /// <returns>The employee list.</returns>
        public List<string> GetEmployeeList()
        {
            var employeeList = new List<string>();
            var employees = GetEmployees();
            foreach (var employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add(",");
                employeeList.Add(employee[1]);
                employeeList.Add(",");
                employeeList.Add(employee[2]);
                employeeList.Add("\n");
            }

            return employeeList;
        }
    }
}
