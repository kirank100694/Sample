using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Concepts
{
    public static class Tuples
    {
        public static (int EmpId, string EmpName, double Salary) GetEmployeeDetails()
        {
            var em = (eid :0, ename:string.Empty, salary: 0.0);
            em.eid = 1331;
            em.ename = "Luise";
            double sal = 3000 * 12;
            em.salary = sal;
            return em;
        }
        public static void TuplesExample()
        {
            var emp = GetEmployeeDetails();

            Console.WriteLine($"EmpId {emp.EmpId},{emp.EmpName} has salary Rs.{emp.Salary}");
        }

        
    }
    

}
