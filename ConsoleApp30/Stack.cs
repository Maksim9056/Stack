using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{

    /// <summary>
    /// Стек
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T> : IComparable<T>
    {
        public List<T> Values { get ; set; }


        /// <summary>
        /// Конструктор класса Stack  с параметрами List<T> 
        /// </summary>
        /// <param name="values"></param>
        public Stack(List<T> values)
        {
            Values = values;
        }


        /// <summary>
        /// Максимальный элемент возращает
        /// </summary>
        /// <returns></returns>
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
