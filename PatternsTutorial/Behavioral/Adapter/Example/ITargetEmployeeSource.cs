namespace PatternsTutorial.Behavioral.Adapter.Example
{
    using System.Collections.Generic;

    /// <summary>
    /// The 'ITarget' interface
    /// </summary>
    internal interface ITargetEmployeeSource
    {
        /// <summary>
        /// The get employee list.
        /// </summary>
        /// <returns>
        /// The List
        /// </returns>
        List<string> GetEmployeeList();
    }
}
