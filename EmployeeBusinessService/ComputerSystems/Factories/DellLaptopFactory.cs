using EmployeeBusinessService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusinessService.Models
{
    public class DellLaptopFactory: DellFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
