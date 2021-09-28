using EmployeeBusinessService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusinessService.Models
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerSystemTypes.LAPTOP.ToString();
        }
    }
}
