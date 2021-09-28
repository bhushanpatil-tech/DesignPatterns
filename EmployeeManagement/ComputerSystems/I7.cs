using EmployeeManagement.ComputerSystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.ComputerSystems
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I7.ToString();
        }
    }
}
