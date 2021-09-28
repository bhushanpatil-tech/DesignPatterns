using EmployeeBusinessService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusinessService.Models
{
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return ComputerBrandTypes.DELL.ToString();
        }
    }
}
