using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_System
{
    internal class parttime_staff : staff
    {
        private double rate;
        public double Rate { get => rate; set => rate = value; }

        public parttime_staff()
        {
        }
        public parttime_staff(int id, string name, double rate) : base(id, name)
        {
            //base.Id = id;
            //base.Name = name;
            this.rate = rate;
        }
        public void input()
        {
            base.input();
            Console.Write("\nEnter the Rate: ");
            this.rate = Convert.ToDouble(Console.ReadLine());
        }

        public void print()
        {
            base.print();
            Console.WriteLine("\nRate: {0}", this.rate);
        }

    }
}
