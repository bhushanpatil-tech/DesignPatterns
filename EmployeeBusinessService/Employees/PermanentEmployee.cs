using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBusinessService.Models
{
    class PermanentEmployee : Employee, IEmployee
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetHourlyPay()
        {
            return 100;
        }

        public decimal GetHouseAllowance()
        {
            return 15;
        }

        public decimal GetMedicalAllowance()
        {
            return 15;
        }
    }
}