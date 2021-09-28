using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBusinessService.Models
{
    public class ContractEmployee : Employee, IEmployee
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetHourlyPay()
        {
            return 80;
        }

        public decimal GetHouseAllowance()
        {
            return 10;
        }

        public decimal GetMedicalAllowance()
        {
            return 10;
        }
    }
}
