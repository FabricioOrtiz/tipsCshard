using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CshardTypesAndMembers
{
    /*
     Interfaces
An interface defines a contract that can be implemented by classes and structs. You define an interface to declare capabilities 
    that are shared among distinct types. For example, the System.Collections.Generic.IEnumerable<T> interface defines a consistent 
    way to traverse all the items in a collection, such as an array. An interface can contain methods, properties, events, and indexers. 
    An interface typically doesn't provide implementations of 
    the members it defines—it merely specifies the members that must be supplied by classes or structs that implement the interface.
Interfaces may employ multiple inheritance. In the following example, the interface IComboBox inherits from both ITextBox and IListBox.C#
     */


    /*example: Interfaces may employ multiple inheritance*/
    interface IControl
    {
        void Paint();
    }

    interface ITextBox : IControl
    {
        void SetText(string text);
    }

    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }

    interface IComboBox : ITextBox, IListBox { }


    interface IDataBound
    {
        void Bind(Binder b);
    }

    /*
     Classes and structs can implement multiple interfaces. In the following example, the class EditBox implements both IControl and IDataBound.
     */
    public class EditBox : IControl, IDataBound
    {
        public void Paint() { }
        public void Bind(Binder b) { }
    }

    

    public class Interface
    {
        public Interface()
        {
            /*
             When a class or struct implements a particular interface, instances of that class or struct can be implicitly converted to that interface type. For example
             */
            EditBox editBox = new();
            IControl control = editBox;
            IDataBound dataBound = editBox;
        }
    }
}
