using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class DataList<T>
    {
        private T[] arr;

        public DataList()
        {
            arr = new T[0];
        }
        public void Add(T data)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = data;
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }

    }
}
