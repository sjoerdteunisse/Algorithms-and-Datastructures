using System;
using System.Collections.Generic;

namespace ADS.Core.Lesson_4
{
    public class LinkedListExercise : ICloneable
    {
        private LinkedList<Employee> _employees;

        public LinkedListExercise()
        {
            _employees = new LinkedList<Employee>();
        }
        public LinkedList<Employee> Employees
        {
            set { _employees = value; }
            get { return _employees; }
        }

        public LinkedList<Employee> DeepCopy()
        {
            var x = new LinkedList<Employee>();

            foreach (var employee in _employees)
            {
                x.AddLast(new Employee(employee));
            }

            return x;
        }

        public LinkedList<Employee> ShallowCopyCollection()
        {
            return new LinkedList<Employee>(_employees);
        }

        public LinkedList<Employee> ShallowCopy()
        {
            return (this.Clone() as LinkedListExercise)._employees;
        }

        public object Clone()
        {
            return (MemberwiseClone() as LinkedListExercise) ?? throw new InvalidOperationException();
        }
    }
}
