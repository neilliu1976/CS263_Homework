using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
	public class ChildrenDiscount : Discount
	{
		public override double Calculate(double price)
		{
			return price * 0.7;
		}

		public override string ToString()
		{
			return "滿10歲";
		}
	}
}