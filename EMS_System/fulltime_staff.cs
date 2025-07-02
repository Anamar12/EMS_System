using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_System
{
    internal class fulltime_staff : staff
    {
        private double salary;
        public double Salary { get => salary; set => salary = value; }

        public fulltime_staff()
        {
        }
        public fulltime_staff(int id, string name, double salary) : base(id, name)
        {
            //base.Id = id;
            //base.Name = name;
            this.salary = salary;
        }
        public void input()
        {
            base.input();
            Console.Write("\nEnter the salary: ");
            this.salary = Convert.ToDouble(Console.ReadLine());
        }

        public void print()
        {
            base.print();
            Console.WriteLine("\nSalary: {0}", this.salary);
        }


    }
}