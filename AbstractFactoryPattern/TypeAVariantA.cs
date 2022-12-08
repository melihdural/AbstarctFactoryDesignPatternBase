using System;

namespace AbstractFactoryPattern
{
    public class TypeAVariantA : ITypeA
    {
        public void TypeMyName()
        {
            Console.WriteLine("TypeAVariantA");
        }

        public void DoSomething()
        {
            Console.WriteLine("DoItLikeTypeAVariantA!");
        }
    }
}