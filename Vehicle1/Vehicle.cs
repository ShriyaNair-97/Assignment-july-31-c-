using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle1
{
    public enum VehType
    {
        Truck,
        Sumo,
        Car
    }
    public enum FuelType
    {
        Deisel,
        Petrol,
        CNG
    }
    public class Vehicle
    {
        string name;
        string color;
        int noOfWheels;
        string make;
        VehType vehicleType;
        FuelType fuel;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int NoOfWheels
        {
            get { return noOfWheels; }
            set { noOfWheels = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public VehType VehicleType
        {
            get { return vehicleType; }
            set { vehicleType = value; }
        }
        public FuelType Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }




        public void Start()
        {
            Console.WriteLine(VehType.Car + " has started or " + VehType.Truck + " has started ");
        }
        public void Stop()
        {
            Console.WriteLine(VehType.Car + " has stopped or " + VehType.Truck + " has stopped ");
        }
        public Vehicle()
        {



        }
        public Vehicle(string _name, string _color, int _noOfWheels, string _make, VehType _vehicleType, FuelType _fuel)
        {
            name = _name;
            color = _color;
            noOfWheels = _noOfWheels;
            make = _make;
            this.vehicleType = _vehicleType;
            this.fuel = _fuel;



        }
        public Vehicle(string _name, string _color, VehType _vehicleType, int _noOfWheels)
        {
            name = _name;
            color = _color;
            this.vehicleType = _vehicleType;
            noOfWheels = _noOfWheels;
            //FuelType.Petrol;

        }
        public Vehicle(string _name, string _color) : this("", "", 4, "", VehType.Car, FuelType.Petrol)
        {
            name = _name;
            color = _color;

        }
 
    }
}
