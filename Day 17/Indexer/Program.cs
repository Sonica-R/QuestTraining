using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        class ShoppingList
        {
            private List<string> _items = new List<string>();

            public string this[int index]
            {
                get => _items[index];
                set { _items[index] = value;}
            }
        }
        static void Main(string[] args)
        {
            var list = new ShoppingList();
            list[0] = "A";
            list[1] = "B";

        }
    }
}
