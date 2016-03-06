namespace PatternsTutorial.Behavioral.Adapter.Example
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    internal class HRSystem
    {
        /// <summary>
        /// The get employees.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string[][] GetEmployees()
        {
            var employees = new string[4][];

            employees[0] = new[] { "100", "Deepak", "Team Leader" };
            employees[1] = new[] { "101", "Rohit", "Developer" };
            employees[2] = new[] { "102", "Gautam", "Developer" };
            employees[3] = new[] { "103", "Dev", "Tester" };

            return employees;
        }
    }
}
