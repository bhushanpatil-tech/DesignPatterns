using EmployeeBusinessService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusinessService.Models
{
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerSystemTypes.DESKTOP.ToString();
        }
    }
}
