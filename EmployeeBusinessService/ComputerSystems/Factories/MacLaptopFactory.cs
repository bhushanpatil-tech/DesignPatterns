using EmployeeBusinessService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusinessService.Models
{
    public class MacLaptopFactory: MacFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
