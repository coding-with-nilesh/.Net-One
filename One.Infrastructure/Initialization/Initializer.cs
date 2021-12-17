using System.Threading.Tasks;
using System;
using One.Core.Initialization;

namespace One.Infrastructure.Initialization
{
    public class Initializer : IInitializable
    {
        #region Declarations
        protected readonly object SyncObject = new object();
        protected Task InitilizationTask;
        private Func<Task> _initializationWork;
        #endregion

        #region Ctor
        public Initializer()
        {
        }

        public Initializer(Func<Task> initializationWork)
        {
            SetInitializationWork(initializationWork);
        }

        #endregion

        #region Properties
        public bool IsInitialized { get; protected set; }
        #endregion

        #region Public methods
        public void SetInitializationWork(Func<Task> initializationWork)
        {
            lock (SyncObject)
            {
                if (_initializationWork != null)
                {
                    throw new NotSupportedException("Initialization Work can be set only once.");
                }

                _initializationWork = initializationWork;
            }
        }

        public Task InitializeAsync()
        {
            // start the task if its not already started
            lock (SyncObject)
            {
                if (_initializationWork == null)
                {
                    throw new ArgumentNullException("InitializationWork can't be null");
                }

                if (InitilizationTask == null)
                {
                    InitilizationTask = _initializationWork();
                    InitilizationTask.ContinueWith(task => { IsInitialized = true; }, TaskContinuationOptions.OnlyOnRanToCompletion);
                }
            }

            return InitilizationTask;
        }

        public async Task AwaitInitialization()
        {
            await InitializeAsync().ConfigureAwait(false);
        }
        #endregion
    }
}


