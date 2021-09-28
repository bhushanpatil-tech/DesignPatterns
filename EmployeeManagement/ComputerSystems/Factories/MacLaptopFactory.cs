using EmployeeManagement.ComputerSystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.ComputerSystems
{
    public class MacLaptopFactory: MacFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
