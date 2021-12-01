using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_32_prakt17_1_OAP_Kolyasnikova.V
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Размер массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            float[] m = new float[n];
            Console.WriteLine("Элементы массива: ");
            for (int i = 0; i < n; i++)
            {
                m[i] = float.Parse(Console.ReadLine());
            }
            float sum = m.Sum();
            Console.WriteLine("Сумма: " + sum);
            Console.ReadKey();
        }
    }
}
