using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
	public class DataType
	{
		private List<MovieTicket> movieTickets = new List<MovieTicket>();

		public List<BasePrice> Prices = new List<BasePrice>() {
			new FullPrice(), new StudentPrice(), new ChildrenPrice()
		};

		public List<Discount> Discounts = new List<Discount>();

		public List<Discount> VIPs = new List<Discount>() {
			new NoVIPDiscount(), new VIPDiscount()
		};

		public void GetDiscount(BasePrice basePrice)
		{
			this.Discounts.Clear();
			this.Discounts.Add(new NoDiscount());
			Type thisType = basePrice.GetType();
			if (thisType == new StudentPrice().GetType())
			{
				this.Discounts.Add(new StudentDiscount());
			}
			else if (thisType == new ChildrenPrice().GetType())
			{
				this.Discounts.Add(new LittleChildrenDiscount());
				this.Discounts.Add(new ChildrenDiscount());
			}
		}

		public void ClearMovieTicket()
		{
			this.movieTickets.Clear();
		}

		public string AddMovieTicket(BasePrice basePrice, Discount discount, int count)
		{
			MovieTicket movieTicket = new MovieTicket(basePrice, discount, count);
			this.movieTickets.Add(movieTicket);
			return movieTicket.ToString();
		}

		public string Total(Discount vipDiscount)
		{
			double total = 0;
			foreach (MovieTicket movieTicket in movieTickets)
			{
				total += movieTicket.Calculate();
			}
			double totalDiscount = vipDiscount.Calculate(total);
			string message = string.Empty;
			if (total == totalDiscount)
			{
				message += string.Format("總計:{0}\n", total);
			}
			else {
				message += string.Format("原價:{0} 總計:{1}\n", total, totalDiscount);
			}
			this.movieTickets.Clear();
			return message;
		}
	}
}