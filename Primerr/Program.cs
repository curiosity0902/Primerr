using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primerr
{
    abstract class Transport
    {
        public abstract void Ride();
    }

    class Car : Transport
    {
        public override void Ride()
        {
            Console.WriteLine("Машина едет");
        }
    }

    class Ship : Transport
    {
        public override void Ride()
        {
            Console.WriteLine("Корабль плывет");
        }
    }

    class Airplane : Transport
    {
        public override void Ride()
        {
            Console.WriteLine("Самолет летит");
        }
    }
    class Train : Transport
    {
        public override void Ride()
        {
            Console.WriteLine("Поезд делает чух-чух");
        }
    }

    class Driver
    {
        public void Ride(Transport transport)
        {
            transport.Ride();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Ride();
            Ship ship = new Ship();
            ship.Ride();
            Airplane airplane = new Airplane();
            airplane.Ride();
            Train train = new Train();
            train.Ride();

            Console.WriteLine("- - - - - - - - - - -");

            Driver driver = new Driver();
            driver.Ride(car);

            Console.ReadKey();





        }
    }
}
