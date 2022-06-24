using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshardTypesAndMembers
{
    public class Struct
    {
        public void ShowStrutExample()
        {
            MyStruct myStruct = new MyStruct();
            MyStruct copy = myStruct;

            myStruct.Id = 1;
            myStruct.Id = 2;

            Console.WriteLine(" Las estructuras son variables de tipo valor y viven en la pila. Por eso que pueden ser copy exacta sin referencia, solo copio valores y alojo en la pila");
            Console.WriteLine("EXAMPLE");
            Console.WriteLine("");
            Console.WriteLine("Struct copy = myStruct;");
            Console.WriteLine("");
            Console.WriteLine("myStruct.Id = 1;");
            Console.WriteLine("myStruct.Id = 2;");
            Console.WriteLine("");
            Console.WriteLine(myStruct.Id);
            Console.WriteLine(copy.Id);
        }
    }
    public struct MyStruct
    {
        public int Id { get; set; }
    }
}
