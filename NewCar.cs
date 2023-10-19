using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotLab
{
    public class NewCar : Car
    {
        public NewCar(string make, string model, int year, decimal price)
            : base(make, model, year, price)
        {
            
        }
    }
}