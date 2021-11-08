using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using System.Threading.Tasks;
using myStringer;


namespace DemoAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("implementing Assemblies");

            stringer myStringInstance = new stringer();
            Console.WriteLine("Client code executes");
            myStringInstance.stringermethod();
        }
    }
}
