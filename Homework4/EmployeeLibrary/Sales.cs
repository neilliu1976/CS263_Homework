using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Sales : Employee
    {
        protected int performance;

        public int Performance
        {
            get { return this.performance; }
            set
            {
                if (value < 0)
                    this.performance = 0;
                else
                    this.performance = value;
            }
        }

        public Sales()
        {
        }

        public Sales(string id, string name, int baseSalary, int performance)
            : base(id, name, baseSalary)
        {
            this.Performance = performance;
        }

        public Sales(string id, string name, string baseSalary, string performance)
            : this(id, name, int.Parse(baseSalary), int.Parse(performance))
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
                base.baseSalary = 22000;
            }
        }

        public override double Salary
        {
            get { return this.BaseSalary + this.Performance; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n業績:{0}"
                , this.Performance);
        }
    }
}