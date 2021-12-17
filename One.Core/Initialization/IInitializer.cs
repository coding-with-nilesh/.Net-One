using System;
using System.Threading.Tasks;

namespace One.Core.Initialization
{
    public interface IInitializer: IInitializable
    {
        void SetInitializationWork(Func<Task> initializationWork);
    }
}
