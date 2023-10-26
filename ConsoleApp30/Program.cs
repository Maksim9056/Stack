namespace ConsoleApp30
{
    internal class Program
    {
        /// <summary>
        /// Напишите обобщенный класс Stack<T>,
        /// который реализует структуру данных стек 
        /// для хранения элементов типа T. 
        /// Затем напишите ограничение для этого класса,
        /// чтобы он мог работать только с типами, 
        /// которые реализуют интерфейс IComparable<T>. 
        /// Затем напишите метод T Max(), который возвращает 
        /// максимальный элемент стека с помощью интерфейса IComparable<T>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            List<int > list = new List<int>() { 1,2,3,4,5,6,7,8,9};
            Stack<int> stack = new Stack<int>(list);

            var value  = stack.Max();

            var i = value.ToString(); ;
            Console.WriteLine(i);
            
            Console.ReadLine();
        }
    }
}