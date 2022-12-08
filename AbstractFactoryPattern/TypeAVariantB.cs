using System;

namespace AbstractFactoryPattern
{
    public class TypeAVariantB : ITypeA
    {
        public void TypeMyName()
        {
            Console.WriteLine("TypeAVariantB");
        }

        public void DoSomething()
        {
            Console.WriteLine("DoItLikeTypeAVariantB!");
        }
    }
}