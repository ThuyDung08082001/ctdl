using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onctdl
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(" So phan tu hien tai cua Stack la: {0}", stack.Count);
            Console.WriteLine(" Phan tu dau cua Stack la: {0}", stack.Peek());
            Console.WriteLine(" So phan tu cua Stack sau khi goi ham Peek: {0}", stack.Count);

            Console.WriteLine(".....................................");
            int Length = stack.Count;
            for (int i = 0; i < Length; i++)
            {
                Console.Write(" " + stack.Pop());
            }
            Console.WriteLine();
            Console.WriteLine(" So phan tu cua Stack sau khi Pop la: {0}", stack.Count);

            Queue queue = new Queue();

            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3); Console.WriteLine(" So phan tu hien tai cua Queue la: {0}", queue.Count);
            Console.WriteLine(" Phan tu dau cua Queue la: {0}", queue.Peek());
            Console.WriteLine(" So phan tu cua Queue sau khi goi ham Peek: {0}", queue.Count);

            Console.WriteLine("..........................................");
            int n = queue.Count;
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + queue.DeQueue());
            }
            Console.WriteLine();
            Console.WriteLine(" So phan tu cua Queue sau khi Pop la: {0}");
        }
        static DateTime DateTime()
        {
            int day;
            int monht;
            int year;
            do
            {
                Console.WriteLine("nhap ngay sinh:");
            } while (!int.TryParse(Console.ReadLine(),out day));
            do
            {
                Console.WriteLine("nhap thang sinh:");
            } while (!int.TryParse(Console.ReadLine(), out monht));
            do
            {
                Console.WriteLine("nhap nam sinh:");
            } while (!int.TryParse(Console.ReadLine(), out year));
            DateTime dt = new DateTime(year, monht, day);
            return dt;

        }
    }
}
