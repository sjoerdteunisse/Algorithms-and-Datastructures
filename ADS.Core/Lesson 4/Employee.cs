using System;

namespace ADS.Core.Lesson_4
{
    public class Employee
    {
        private string name;
        private double salary;

        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public Employee(Employee employee)
        {
            name = new string(employee.name.ToCharArray());
            salary = employee.salary;
        }
    }
}