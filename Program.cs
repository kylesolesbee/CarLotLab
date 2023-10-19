//Kyle Solesbee 10/18/23
//Car Lot Lab
namespace CarLotLab
{
    internal class Program
    {
        public static List<Car> CarInventory = new List<Car>();
        static void Main(string[] args)
        {
            CarInventory.Add(new NewCar("Honda", "Civic", 2022, 25000.0M));
            CarInventory.Add(new NewCar("Toyota", "Camry", 2021, 28000.0M));
            CarInventory.Add(new NewCar("Ford", "F-150", 2023, 35000.0M));
            CarInventory.Add(new UsedCar("Chevrolet", "Malibu", 2019, 18000.0M, 30000));
            CarInventory.Add(new UsedCar("Nissan", "Altima", 2018, 15000.0M, 35000));
            CarInventory.Add(new UsedCar("Jeep", "Cherokee", 2017, 22000.0M, 40000));

            bool shouldContinue = true;

            while (true)
            {
                ListCars();

                int selection = Validator.GetValidCarSelection(CarInventory.Count);
                Car chosenCar = CarInventory[selection];
                Console.WriteLine("You have chosen to purchase the following car:");
                Console.WriteLine(chosenCar);
                CarInventory.RemoveAt(selection);

                ListCars(); // Display the updated list after removing the car

                if (!Validator.ShouldContinue())
                {
                    Console.WriteLine("Have a great day!");
                    break;
                }
                
                Console.Clear();
            }

            static void ListCars()
            {
                Console.WriteLine("Welcome to Grand Circus’ Car Emporium!");
                Console.WriteLine("Car Inventory: ");

                for (int i = 0; i < CarInventory.Count; i++)
                {
                    Car car = CarInventory[i];
                    string status = car is UsedCar ? " (Used)" : "";
                    string mileage = car is UsedCar ? $" {((UsedCar)car).Mileage} miles" : "";

                    Console.WriteLine($"{i + 1}. {car.Make,-10} {car.Model,-12} {car.Year,-6} {car.Price:C}{status}{mileage}");
                }
            }
        }
    }
}