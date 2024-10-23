using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GenericClass
{
    //class SortedList<T>
    //{
    //    private List<T> _data = new List<T>();
    //    public int Count => _data.Count;

    //    public void Add(T data)
    //    {
    //        _data.Add(data);
    //        _data.Sort();
    //    }
    //}

    class Dictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _data = new Dictionary<TKey, TValue>();
        private int Count => _data.Count;

        public void Add(TKey key, TValue value)
        {
            _data.Add(key, value);  
        }
            
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var lst = new List<int>();
            //lst.Add(10);
            //lst.Add(20);
            //lst.Add(30);

            var data = new Dictionary<string, string>();
            data.Add("Name", "Soni");
        }
    }
}
