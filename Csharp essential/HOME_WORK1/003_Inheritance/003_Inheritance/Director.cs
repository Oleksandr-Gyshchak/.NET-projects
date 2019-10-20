using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Inheritance
{
    class Director : Employee
    {
        private List<Salesman> subordinates = new List<Salesman>();

        public Director(int age, string name, int workExperience, double salary)
            : base(age, name, workExperience, salary)
        {
        }


        public void AddSubordinate(Salesman salesman)
        {
            subordinates.Add(salesman);
        }
        public void RemoveSubordinate(int subordinateId)
        {
            subordinates.RemoveAt(subordinateId);
        }

        public void GetsubordinateInfo(int subordinateId)
        {
            subordinates[subordinateId].ShowEmployeeInfo();
        }

        public void ShowAllSubordinateInfo()
        {
            foreach (Salesman subordinateItem in subordinates)
            {
                subordinateItem.ShowEmployeeInfo();
            }
        }

    }


}
