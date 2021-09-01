using System;

namespace Gen_delegate
{
    class GenricDeligater
    {
        public delegate void MyGenericDelegate<y>(y arg);
         public void GenDelMethod()
        {
            Console.WriteLine(  "Genric deligate"); ;
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(stringTarget);
            strTarget("some string");
            MyGenericDelegate<int> intTarget = IntTarget;
            intTarget(9);

        }
        public void strTarget(string arg)
        {
            Console.WriteLine("arg in uppercase {0}",arg.ToUpper());
        }
        public void IntTarget(int arg)
        {
            Console.WriteLine("++arg is {0}", ++arg);


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenricDeligater g = new GenricDeligater();
            g.strTarget("hri");
            g.IntTarget(9);
            g.GenDelMethod();

        }
    }
}
