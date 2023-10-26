using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public class Stack<T> : IComparable<T>
    {
        public List<T> Values { get ; set; } 

        public Stack(List<T> values)
        {
            Values = values;
        }

        public object Max()
        {
            var MAX=    Values .Max();
            Console.WriteLine(MAX);
            return MAX;
        }
    }



    public interface IComparable<T>
    {
        List<T> Values { get; set; }

        object Max();
      
    }
}
