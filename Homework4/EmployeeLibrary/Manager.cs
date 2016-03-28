using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager : Sales
    {
        private int manageEmployees;

        public int ManageEmployees
        {
            set
            {
                if (0 > value)
                {
                    this.manageEmployees = 0;
                }
                else
                {
                    this.manageEmployees = value;
                }
            }
            get { return this.manageEmployees; }
        }

        public Manager()
        {
        }

        public Manager(string id, string name, int baseSalary, int performance, int manage)
            : base(id, name, baseSalary, performance)
        {
            this.ManageEmployees = manage;
        }

        public Manager(string id, string name, string baseSalary, string performance, string manage)
            : this(id, name, int.Parse(baseSalary), int.Parse(performance), int.Parse(manage))
        {
        }

        public override double BaseSalary
        {
            get
            {
                return base.BaseSalary;
            }
            set
            {
                if (30000 > value)
                {
                    base.baseSalary = 30000;
                }
                else if (50000 < value)
                {
                    base.baseSalary = 50000;
                }
                else
                {
                    base.baseSalary = value;
                }
            }
        }

        public override double Salary
        {
            get { return this.BaseSalary + this.Performance + this.ManageEmployees * 500; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n管理人數:{0}"
                , this.ManageEmployees);
        }
    }
}