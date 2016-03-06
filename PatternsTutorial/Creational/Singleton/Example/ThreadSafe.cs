// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThreadSafe.cs"  company="James Fleming">
//   poundingCode@gmail.com
// </copyright>
// <summary>
//   The class is thread safe, but If this instance property is accessed by two threads at exactly the same time,
//   you could wind up with a second instance of the class
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PatternsTutorial.Creational.Singleton.Example
{
    /// <summary>
    /// The class is thread safe, but If this instance property is accessed by two threads at exactly the same time, 
    /// you could wind up with a second instance of the class
    /// </summary>
    internal class ThreadSafe
    {
        /// <summary>
        /// The instance.
        /// </summary>
        private static ThreadSafe instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafe"/> class from being created.
        /// </summary>
        private ThreadSafe()
       {
       }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static ThreadSafe Instance
       {
           get
           {
               return instance ?? (instance = new ThreadSafe());
           }
        }

        /// <summary>
        /// The do something interesting.
        /// </summary>
        public void DoSomethingInteresting()
        {
            // something thread-safe happens...
        }
    }
}
