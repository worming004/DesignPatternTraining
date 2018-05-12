using System;
using System.Collections.Generic;
using System.Text;
using ChainOfResponsibility.Model;

namespace ChainOfResponsibility.ChainOfResp
{
    public class WrongCancelDate : ChainCheckHandler
    {
        public override void HandleRequest(Car car)
        {
            if (car.CancellationDate < car.StartingDate)
            {
                car.CancellationDate = null;
                Console.WriteLine($"CancellationDate is set to null for car {car.Id}");
            }
        }
    }
}
