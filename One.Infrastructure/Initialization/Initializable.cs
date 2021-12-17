using System.Threading.Tasks;
using One.Core.Initialization;

namespace One.Infrastructure.Initialization
{
    public class Initializable : IInitializable
    {
        #region Declarations
        private Task _completedTask = Task.Delay(0);
        private Initializer _initializer;
        #endregion

        #region Ctor
        public Initializable()
        {
            _initializer = new Initializer(Initialize);
        }
        #endregion

        #region Properties
        public bool IsInitialized { get { return _initializer.IsInitialized; } }
        public Task CompletedTask => _completedTask;
        #endregion

        #region Public methods
        public virtual Task InitializeAsync()
        {
            return _initializer.InitializeAsync();
        }

        public Task AwaitInitialization()
        {
            return _initializer.AwaitInitialization();
        }
        #endregion

        #region Helpers

        // Actually performs the initialization
        protected virtual Task Initialize()
        {
            return CompletedTask;
        }
        #endregion
    }
}


