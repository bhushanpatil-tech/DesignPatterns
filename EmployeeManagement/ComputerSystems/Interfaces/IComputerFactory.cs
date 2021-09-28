using EmployeeManagement.ComputerSystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.ComputerSystems.Interfaces
{
    public interface IComputerFactory
    {
        IProcessor Processor();
        IBrand Brand();
        ISystemType SystemType();
    }
}
