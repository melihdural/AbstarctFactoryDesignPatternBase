namespace AbstractFactoryPattern
{
    public class TypeBFactory : IAbstarctFactory
    {
        public ITypeA CreateTypeA()
        {
            return new TypeAVariantB();
        }

        public ITypeB CreateTypeB()
        {
            return new TypeBVariantB();
        }
    }
}