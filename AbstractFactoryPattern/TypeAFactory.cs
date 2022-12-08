namespace AbstractFactoryPattern
{
    public class TypeAFactory : IAbstarctFactory
    {
        public ITypeA CreateTypeA()
        {
            return new TypeAVariantA();
        }

        public ITypeB CreateTypeB()
        {
            return new TypeBVariantA();
        }
    }
}