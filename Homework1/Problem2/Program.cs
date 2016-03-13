using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student someone = new Student
            {
                name = "老張",
                communication = new Communication
                {
                    email = "weee@eeee.eee",
                    mobile = "0910123456",
                    telephone = "0212345678"
                },
                address = new Address
                {
                    code = "100",
                    address = "台灣某一處"
                }
            };
            Console.WriteLine(someone.name);
            Console.WriteLine(someone.communication.email);
            Console.WriteLine(someone.communication.mobile);
            Console.WriteLine(someone.communication.telephone);
            Console.WriteLine(someone.address.code);
            Console.WriteLine(someone.address.address);
        }
    }
}