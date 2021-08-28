using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Employee : Human
    {
        public int Position { get; set; }
        public int Salary { get; set; }
        public void SetValues()
        {
            Id = 1;
            Name = "İsmail";
            Surname = "DEDEC";
        }
    }
}
