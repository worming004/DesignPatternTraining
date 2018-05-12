using ChainOfResponsibility.Exceptions;
using ChainOfResponsibility.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ChainOfResp
{
    public class HaveChassisHandler : ChainCheckHandler
    {
        public override void HandleRequest(Car car)
        {
            if (string.IsNullOrWhiteSpace(car.LicensePlate) && !string.IsNullOrWhiteSpace(car.ChassisNumber))
                throw new NoChassisNumberException($"Car {car.Id} have Chassis number {car.ChassisNumber} but no license plate");
            Console.WriteLine($"Car {car.Id} HaveChassisHandler OK");
        }
    }
}
