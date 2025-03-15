using Assignment1_C_.Generation;
using Microsoft.EntityFrameworkCore;

namespace Assignment1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using GenerationDbContext Context = new GenerationDbContext();

            #region CRUD
            //Car car1 = new Car()
            //{
            //    Make = "Tesla",
            //    Model = "Model1",
            //    NumberOfDoors = 4,
            //};

            //Car car2 = new Car()
            //{
            //    Make = "Tesla",
            //    Model = "Model2",
            //    NumberOfDoors = 2,
            //};

            //Truck truck1 = new Truck()
            //{
            //    Make = "Ford",
            //    Model = "FX1",
            //    LoadCapacity = 500,
            //};

            //Truck truck2 = new Truck()
            //{
            //    Make = "Ford",
            //    Model = "FX2",
            //    LoadCapacity = 800,
            //};

            //Context.Vehicles.Add(car1);
            //Context.Vehicles.Add(car2);
            //Context.Vehicles.Add(truck1);
            //Context.Vehicles.Add(truck2);

            //Context.SaveChanges();

            //var cars = Context.Vehicles.Where(x => EF.Property<string>(x, "VehicleType") == "Car");

            //foreach (var car in cars)
            //    Console.WriteLine(car);

            //foreach (var car in Context.Vehicles.OfType<Car>())
            //    Console.WriteLine(car);

            //foreach (var car in Context.Cars)
            //    Console.WriteLine(car);
            #endregion
        }
    }
}
