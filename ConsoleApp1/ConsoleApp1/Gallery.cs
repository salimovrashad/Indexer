using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Gallery
    {
        public string Name { get; set; }
        public Car[] cars;

        public Gallery() 
        {
            cars = new Car[3];
        }

    }
}
