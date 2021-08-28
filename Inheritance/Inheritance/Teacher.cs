using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher : Employee
    {
        public int Branch { get; set; }
       public void SetValues2()
        {
            Position = 2;
            Salary = 5550;
            Branch = 12;
        }
    }
}
