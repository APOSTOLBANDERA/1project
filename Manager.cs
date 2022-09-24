using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Manager : Worker
    {
        public int ClientsCount { get; set; }

        public Manager(string name, int age, double salary, int clientsCount) 
            : base(name, age, salary)
        {
            Console.WriteLine("Manager full constructor");
            ClientsCount = clientsCount;
        }
        public Manager() 
            : base()
        {

        }
        public override double GetResultSalary()
        {
            return Salary * ClientsCount;
        }
    }
}
