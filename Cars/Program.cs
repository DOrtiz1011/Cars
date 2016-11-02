using System;
using System.Collections.Generic;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            // object intializer syntax, much prettier :)
            var BMW = new Car
            {
                Make = "BMW",
                Model = "328xi",
                VIN = "FU1234"
            };

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft  .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";

            // ArrayList are dynamically sized,
            // cool features sorting, remove items
            // BETTER TO USE A LIST
            List<Car> carList = new List<Car>();
            carList.Add(car1);
            carList.Add(car2);
            carList.Add(BMW);
            //myArrayList.Add(b1);   <--- this is now a compile error

            foreach (Car car in carList)
            {
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\n");
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}