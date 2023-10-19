using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotLab
{
    public class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string make, string model, int year, decimal price, double mileage)
            : base(make, model, year, price)
        {
            Mileage = mileage;
        }

        public override string ToString()
        {
            return base.ToString() + $", Mileage: {Mileage} miles (Used)";
        }
    }
 }