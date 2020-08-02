using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle1;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("Ceilo", "red");
            Vehicle truck = new Vehicle("Tata", "blue", 6, "", VehType.Truck, FuelType.Deisel);
            Vehicle smallcar = new Vehicle("Indica", "silver", VehType.Car, 4);
            Console.WriteLine("Methods called through car object");
            Console.WriteLine("Start--");
            car.Start();
            Console.WriteLine("Stop--");
            car.Stop();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Methods called through truck object");
            Console.WriteLine("Start--");
            truck.Start();
            Console.WriteLine("Stop--");
            truck.Stop();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Methods called through smallcar object");
            Console.WriteLine("Start--");
            smallcar.Start();
            Console.WriteLine("Stop--");
            smallcar.Stop();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("The details of car object is : {0} {1} {2} {3} {4} {5}", car.Name, car.Color, car.NoOfWheels, car.Make, car.VehicleType, car.Fuel);
            Console.WriteLine("The details of truck object is : {0} {1} {2} {3} {4} {5}", truck.Name, truck.Color, truck.NoOfWheels, truck.Make, truck.VehicleType, truck.Fuel);
            Console.WriteLine("The details of smallcar object is : {0} {1} {2} {3} {4} {5}", smallcar.Name, smallcar.Color, smallcar.NoOfWheels, smallcar.Make, smallcar.VehicleType, smallcar.Fuel);
            Console.Read();
        }
    }
}
