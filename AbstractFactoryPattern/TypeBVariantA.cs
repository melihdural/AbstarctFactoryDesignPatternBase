using System;

namespace AbstractFactoryPattern
{
    public class TypeBVariantA : ITypeB
    {
        public void TypeMyName()
        {
            Console.WriteLine("TypeBVariantA");
        }

        public void DoSomething()
        {
            Console.WriteLine("DoItLikeTypeBVariantA!");
        }
    }
}