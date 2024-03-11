using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RazumovMO.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.RazumovMO.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумма трех чисел = " + DataService.Calc(13, 44 , 1678));
            Console.ReadKey();
        }
    }
}
