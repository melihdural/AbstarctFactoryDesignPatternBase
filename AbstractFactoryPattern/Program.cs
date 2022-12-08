using System;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            TypeAFactory cf = new TypeAFactory();
            ITypeA typeAC = cf.CreateTypeA();
            ITypeB typeBC = cf.CreateTypeB();
            typeAC.TypeMyName();
            typeAC.DoSomething();
            typeBC.TypeMyName();
            typeBC.DoSomething();

            TypeBFactory mf = new TypeBFactory();
            ITypeA typeAM = mf.CreateTypeA();
            ITypeB typeBM = mf.CreateTypeB();
            typeAM.TypeMyName();
            typeAM.DoSomething();
            typeBM.TypeMyName();
            typeBM.DoSomething();


        }
    }
}