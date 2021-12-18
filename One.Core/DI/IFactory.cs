namespace One.Core.DI
{
    public interface IFactory
    {
        void RegisterSingleton<TBase, TImplementation>()
            where TImplementation : TBase;

        void RegisterScoped<TBase, TImplementation>()
            where TImplementation : TBase;

        T Resolve<T>();
    }
}
