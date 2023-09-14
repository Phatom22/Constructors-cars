using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_cars
{
    class Program
    {
        static void Main(string[] args)
        {

            Cars CarDes = new Cars("bmw m4","yellow", 2020);
            Cars CarDes1 = new Cars("benz c63","black", 2021);

            Console.WriteLine(CarDes.model);
            Console.WriteLine(CarDes.color);
            Console.WriteLine(CarDes.year);
            Console.ReadLine();

        }
    }
}
