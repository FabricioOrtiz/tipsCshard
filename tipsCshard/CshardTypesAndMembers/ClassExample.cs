using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshardTypesAndMembers
{
    public class ClassExample
    {
        public void ShowClassExample()
        {
            MyClass myClass = new MyClass();
            MyClass copy = myClass;

            myClass.Id = 1;
            myClass.Id = 2;

            Console.WriteLine(" Las clases son variables de tipo de referencia y viven en el montón con referencia a ese montón dentro de la pila.");
            Console.WriteLine("EXAMPLE");
            Console.WriteLine("");
            Console.WriteLine("MyClass copy = myClass;");
            Console.WriteLine("");
            Console.WriteLine("myClass.Id = 1;");
            Console.WriteLine("myClass.Id = 2;");
            Console.WriteLine("");
            Console.WriteLine(myClass.Id);
            Console.WriteLine(copy.Id);
        }


       
    }

    public class MyClass
    {
        public int Id { get; set; }
    }
}
