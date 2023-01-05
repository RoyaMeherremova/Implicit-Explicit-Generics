using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class StringList
    {
        private string[] arr;

        public StringList()
        {
            arr= new string[0];
        }
        public void Add(string str)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1]= str;
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
