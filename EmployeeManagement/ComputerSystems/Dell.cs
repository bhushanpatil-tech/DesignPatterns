using EmployeeManagement.ComputerSystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.ComputerSystems
{
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return ComputerBrandTypes.DELL.ToString();
        }
    }
}
