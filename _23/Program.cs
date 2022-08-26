/*Разработать асинхронный метод для 
вычисления факториала числа. В методе 
Main выполнить проверку работы метода.*/

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FakAsync(n);

            Console.ReadKey();  
        }

        static void Fak(int n)
        {
            int s = 1;
            for (int i = 1; i < n; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);
        }
        static async void FakAsync(int n)
        {
            await Task.Run(() => Fak(n));
        }
    }
}
