using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
	public abstract class Discount : IDiscount
	{
		public abstract double Calculate(double price);
	}
}