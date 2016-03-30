using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
	public class NoDiscount : Discount
	{
		public override double Calculate(double price)
		{
			return price;
		}

		public override string ToString()
		{
			return "無折扣";
		}
	}
}