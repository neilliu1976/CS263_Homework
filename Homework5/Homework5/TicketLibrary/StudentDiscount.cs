using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
	public class StudentDiscount : Discount
	{
		public override double Calculate(double price)
		{
			return price * 0.8;
		}

		public override string ToString()
		{
			return "持學生證";
		}
	}
}