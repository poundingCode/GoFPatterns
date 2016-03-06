namespace PatternsTutorial.Behavioral.Adapter.Example
{
    using System;

    /// <summary>
    /// The third party billing system.
    /// </summary>
    internal class ThirdPartyBillingSystem
    {
        /// <summary>
        /// The employee source.
        /// </summary>
        private readonly ITargetEmployeeSource employeeSource;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyBillingSystem"/> class.
        /// </summary>
        /// <param name="employeeSource">
        /// The employee source.
        /// </param>
        public ThirdPartyBillingSystem(ITargetEmployeeSource employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        /// <summary>
        /// The show employee list.
        /// </summary>
        public void ShowEmployeeList()
        {
            var employee = this.employeeSource.GetEmployeeList();

            // To DO: Implement you business logic
            Console.WriteLine("######### Employee List ##########");
            foreach (var item in employee)
            {
                Console.Write(item);
            }
        }
    }
}
