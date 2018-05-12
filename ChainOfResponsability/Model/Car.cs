using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Model
{
    public enum CarType
    {
        A,
        B,
        C
    }

    public class Car
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string ChassisNumber { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public CarType CarType { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? CancellationDate { get; set; }
    }
}
