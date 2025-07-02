using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_System
{
    internal class staff
    {
        private int id;
        private string name;

        public staff()
        {
        }

        public staff(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        ~staff() { }  //destructor

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public void input()
        {
            Console.Write("\nEnter the Id: ");
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the Employee name: ");
            this.name = Console.ReadLine();
        }

        public void print()
        {
            Console.Write("\nId is : {0}", this.id);
            Console.Write("\nName is : {0}", this.name);
        }




    }
}
