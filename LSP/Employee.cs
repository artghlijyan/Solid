using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee() { }

        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public abstract decimal GetSalery();

        public override string ToString()
        {
            return string.Format("Id: {0}, Name {1}", Id, Name);
        }

        //public abstract decimal CalcBonus(decimal salary);
    }
}
