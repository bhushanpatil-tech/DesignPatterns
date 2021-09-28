using EmployeeBusinessService.Interfaces;
using EmployeeBusinessService.Models;
using EmployeeBusinessService.Models.Factories;

namespace WebApp.Helpers
{
    public class EmployeeCenter
    {

        public Employee LoadEmployeeDetails(Employee employee)
        {
            var empFact = new EmployeeFactory();
            IEmployee _emp = empFact.GetEmployee(employee.EmployeeTypeID);
            employee.Bonus = _emp.GetBonus();
            employee.HourlyPay = _emp.GetHourlyPay();
            employee.HouseAllowance = _emp.GetHouseAllowance();
            employee.MedicalAllowance = _emp.GetMedicalAllowance();

            var empSysFac = new EmployeeSystemFactory();
            IComputerFactory comp = empSysFac.Create(employee);
            employee.ComputerDetails = GetSystemDetails(comp);

            return employee;
        }

        private string GetSystemDetails(IComputerFactory comp)
        {
            IBrand brand = comp.Brand();
            IProcessor processor = comp.Processor();
            ISystemType systemType = comp.SystemType();

            string returnValue = string.Format("{0} {1} {2}", brand.GetBrand(),
                systemType.GetSystemType(), processor.GetProcessor());
            return returnValue;
        }
    }
}
