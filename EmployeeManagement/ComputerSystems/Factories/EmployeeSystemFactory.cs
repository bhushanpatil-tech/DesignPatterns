using EmployeeManagement.ComputerSystems.Interfaces;
using EmployeeManagement.EmployeeCenter;

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.ComputerSystems.Factories
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee e)
        {
            IComputerFactory returnValue = null;
            if (e.EmployeeTypeID == 1)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new MacLaptopFactory();
                }
                else
                {
                    returnValue = new MacFactory();
                }
            }
            else if (e.EmployeeTypeID == 2)
            {
                if (e.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                    returnValue = new DellFactory();
            }
            return returnValue;
        }
    }
}

