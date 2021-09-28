using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBusinessService.Models
{
    public interface IEmployee
    {
        decimal GetBonus();
        decimal GetHourlyPay();
        decimal GetHouseAllowance();
        decimal GetMedicalAllowance();
    }
}
