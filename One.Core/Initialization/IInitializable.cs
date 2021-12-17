using System.Threading.Tasks;

namespace One.Core.Initialization
{
    /// <summary>
    /// Interface for objects that can be initialized
    /// </summary>
    public interface IInitializable
    {
        /// <summary>
        /// Specifies whether the instance has been initialized successfully
        /// </summary>
        bool IsInitialized { get; }

        /// <summary>
        /// Initializes the task.
        /// </summary>
        /// <returns></returns>
        Task InitializeAsync();

        /// <summary>
        /// Waits for initialization task to complete
        /// </summary>
        /// <returns></returns>
        Task AwaitInitialization();
    }
}
