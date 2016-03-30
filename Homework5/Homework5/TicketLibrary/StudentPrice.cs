using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
	public class StudentPrice : BasePrice
	{
		public override double Price
		{
			get { return 200; }
		}

		public override string ToString()
		{
			return "學生票";
		}
	}
}