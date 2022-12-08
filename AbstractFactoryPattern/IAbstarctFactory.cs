namespace AbstractFactoryPattern
{
    public interface IAbstarctFactory
    {
        ITypeA CreateTypeA();
        ITypeB CreateTypeB();
    }
}