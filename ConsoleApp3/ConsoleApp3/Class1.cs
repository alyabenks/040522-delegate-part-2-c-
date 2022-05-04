using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Work
    {
        double[] a = new double[20];
        public Work()
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Math.Round(r.NextDouble() * (100 - (-100)) + (-100), 2);

            }
        }
        public void Show()
        {
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < a.Length; i++)
            { 
                Console.WriteLine(a[i]);
            }
        }
        public void MaxValue()
        {
            Array.Sort(a);
            double maxValue = a[a.Length - 1];
            Console.WriteLine("Максимальное значение = " + maxValue);
        }
        public void Arifm()
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            sum = sum / a.Length;
            Console.WriteLine("Среднее арифметическое = " + sum);
        }
        public void Geom()
        {
            double multi = 1;
            for (int i = 0; i < a.Length; i++)
            {
                multi *= a[i];
            }
            multi = Math.Pow(multi, 1.0 / a.Length);
            Console.WriteLine("Среднее геометрическое = " + multi);
        }
    }
}
