using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
	public class FullPrice : BasePrice
	{
		public override double Price
		{
			get { return 250; }
		}

		public override string ToString()
		{
			return "全票";
		}
	}
}