using EmployeeManagement.ComputerSystems.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.ComputerSystems
{
    public class Mac: IBrand
    {
        public string GetBrand()
        {
            return ComputerBrandTypes.MAC.ToString();
        }
    }
}
