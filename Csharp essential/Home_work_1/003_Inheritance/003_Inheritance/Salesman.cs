using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Inheritance
{
    class Salesman : Employee
    {
        private Director director { set; get; }

        public Salesman(int age, string name, int workExperience, double salary, Director director)
            : base(age, name, workExperience, salary)
        {
            this.director = director;
        }

    }
}
