using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
	public class NoVIPDiscount : NoDiscount
	{
		public override string ToString()
		{
			return "無VIP卡";
		}
	}
}