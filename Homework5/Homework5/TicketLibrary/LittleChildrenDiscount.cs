using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
	public class LittleChildrenDiscount : Discount
	{
		public override double Calculate(double price)
		{
			return price * 0.3;
		}

		public override string ToString()
		{
			return "未滿10歳";
		}
	}
}