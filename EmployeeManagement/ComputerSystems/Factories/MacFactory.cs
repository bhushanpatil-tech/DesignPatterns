using EmployeeManagement.ComputerSystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.ComputerSystems
{
    public class MacFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Mac();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }
}
