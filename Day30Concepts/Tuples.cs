using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30Concepts
{
    internal class Tuples
    {
        #region TuplesExample
        /// <summary>
        /// A data structure which can contain data of different data types.
        /// It can be taken upto 8 values.
        /// It can be nested for more then 8 values.
        /// It is a REF type.
        /// </summary>
        public void TuplesExample()
        {
            var employee = GetEmployeeDetails();

            Console.WriteLine($"EmployeeId : {employee.employeeId},{employee.employeeName} has salary Rs.{employee.Salary}");
        }

        public (int employeeId, string employeeName, double Salary) GetEmployeeDetails()
        {
            var employee = (employeeid: 0, employeename: string.Empty, salary: 0.0);
            employee.employeeid = 1331;
            employee.employeename = " Luise";
            double sal = 3000 * 12;
            employee.salary = sal;
            return employee;
        }
        #endregion
    }
}
