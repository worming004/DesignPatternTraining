using ChainOfResponsibility.ChainOfResp;
using ChainOfResponsibility.Exceptions;
using ChainOfResponsibility.Model;
using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var allCarToCheck = new List<Car>();
            ChainCheckHandler handl = new HaveChassisHandler();
            handl.AddHandler(new WrongCancelDate());

            allCarToCheck.Add(new Car()
            {
                Id = 1,
                LicensePlate = "ABC",
                CarType = CarType.A
            });
            allCarToCheck.Add(new Car()
            {
                Id = 2,
                LicensePlate = "ABC",
                CarType = CarType.A,
                StartingDate = DateTime.Now.AddDays(1),
                CancellationDate = DateTime.Now
            });
            allCarToCheck.Add(new Car()
            {
                Id = 3,
                ChassisNumber = "ABC",
                CarType = CarType.A,
                StartingDate = DateTime.Now.AddDays(1),
                CancellationDate = DateTime.Now
            });

            foreach (var currentCar in allCarToCheck)
            {
                try
                {
                    handl.Next(currentCar);
                }
                catch (BaseImportException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("");
            }


            Console.Read();
        }
    }
}
