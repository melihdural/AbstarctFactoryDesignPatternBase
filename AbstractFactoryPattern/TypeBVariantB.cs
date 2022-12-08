using System;

namespace AbstractFactoryPattern
{
    public class TypeBVariantB : ITypeB
    {
        public void TypeMyName()
        {
            Console.WriteLine("TypeBVariantB");
        }

        public void DoSomething()
        {
            Console.WriteLine("DoItLikeTypeBVariantB!");
        }
    }
}