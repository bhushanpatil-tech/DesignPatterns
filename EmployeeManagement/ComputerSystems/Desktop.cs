using EmployeeManagement.ComputerSystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.ComputerSystems
{
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerSystemTypes.DESKTOP.ToString();
        }
    }
}
