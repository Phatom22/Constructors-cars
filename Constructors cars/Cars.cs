using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_cars
{
    class Cars
    {
        public string model;
        public string color;
        public int year;

        public Cars(string aModel, string aColor, int aYear)
        {
            model = aModel;
            color = aColor;
            year = aYear;
        }
    }
}
