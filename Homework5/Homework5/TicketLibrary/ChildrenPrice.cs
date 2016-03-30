using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
	public class ChildrenPrice : BasePrice
	{
		public override double Price
		{
			get { return 160; }
		}

		public override string ToString()
		{
			return "兒童票";
		}
	}
}