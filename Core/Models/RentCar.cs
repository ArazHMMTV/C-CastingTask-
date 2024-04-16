using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RentCar
    {
        public int carLimit { get; set; }
        public int truckLimit { get; set; }
        Vehicle[] _vehicles = { };
        Car[] _cars = { };
        Truck[] _truck = { };


        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                if (_cars.Length < carLimit)
                {
                    Array.Resize(ref _cars, _cars.Length + 1);
                    _cars[_cars.Length - 1] = (Car)vehicle;

                    Array.Resize(ref _vehicles, _vehicles.Length + 1);
                    _vehicles[_vehicles.Length - 1] = vehicle;
                }
                else
                {
                    Console.WriteLine("Car Limiti asilmisdir");
                }



                if (vehicle is Truck)
                {
                    if (_truck.Length < truckLimit)
                    {
                        Array.Resize(ref _truck, _truck.Length + 1);
                        _truck[_truck.Length - 1] = (Truck)vehicle;

                        Array.Resize(ref _vehicles, _vehicles.Length + 1);
                        _vehicles[_vehicles.Length - 1] = vehicle;
                    }
                    else
                    {
                        Console.WriteLine("Truck Limiti asilmisdir");
                    }
                }
            }
        }
        public void ShowAllVehicles()
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle is Truck)
                {
                    Truck truck = (Truck)vehicle;
                    Console.WriteLine($"Markası:{truck.Marka};Modeli:{truck.Model};Ili:{truck.Year};Yük Tutumu: {truck.CarryingCapacity}");
                }
                else if (vehicle is Car)
                {
                    Car car = (Car)vehicle;
                    Console.WriteLine($"Markası:{car.Marka};Modeli:{car.Model};Ili:{car.Year};Sernisin Tutumu {car.PassengerCapacity}");
                }
            }
        }
    }
}
