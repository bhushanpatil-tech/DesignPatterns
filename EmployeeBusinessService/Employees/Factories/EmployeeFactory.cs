using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBusinessService.Models.Factories
{
    public class EmployeeFactory
    {
        public IEmployee GetEmployee(int empTypeId)
        {
            IEmployee returnValue = null;

            if (empTypeId == 1)
                returnValue = new PermanentEmployee();
            else if (empTypeId == 2)
                returnValue = new ContractEmployee();

            return returnValue;
        }

    }
}
