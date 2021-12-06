//Code added to the develop branch...
using EmployeeBusinessService.Interfaces;
using EmployeeBusinessService.Models;
using EmployeeBusinessService.Models.Factories;
using System;

namespace WebApp.Helpers
{
    public class EmployeeCenter
    {
        private enum takeHome
        {
            One = 1
        }
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

            //int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            int[] intArray = { 1, 2, 3, 4, 5 };

            try
            {
                var newVal = intArray[10];
            }
            finally
            {
                Console.WriteLine("Error Occured....");
            }
            //catch (Exception ex)
            //{

            //}
            //catch (IndexOutOfRangeException ex1) { 

            //}
            //catch (NullReferenceException ex2) { 

            //}

            //int iLink;
            //int jLink = iLink;

            string str1, str2;
            str1 = "C#";
            str2 = "C#";
            float f = 10.12f;
            long l = 9999L;

            var xy = f + l;

            var x = (object.ReferenceEquals(str1, str2));

            int[,] arr1 = new int[5, 2];
            int[][,] arr2 = new int[5][,];

            Point p = new Point();
            p.x = 10;

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

    struct Point
    {
        private int _x;

        public int x
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
    }
}
