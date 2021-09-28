using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusinessService.Interfaces
{
    public interface IComputerFactory
    {
        IProcessor Processor();
        IBrand Brand();
        ISystemType SystemType();
    }
}
