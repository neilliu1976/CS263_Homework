using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
	public class MovieTicket
	{
		public MovieTicket()
		{
		}

		public MovieTicket(BasePrice basePrice, Discount discount, int count)
		{
			this.basePrice = basePrice;
			this.discount = discount;
			this.Count = count;
		}

		public MovieTicket(BasePrice basePrice, Discount discount, string count) :
			this(basePrice, discount, int.Parse(count))
		{
		}

		public int Count { get; set; }

		public BasePrice basePrice;

		public void SetBasePrice(BasePrice basePrice)
		{
			this.basePrice = basePrice;
		}

		public Discount discount;

		public void SetDiscount(Discount discount)
		{
			this.discount = discount;
		}

		public double Calculate()
		{
			if (null == this.basePrice)
			{
				this.basePrice = new FullPrice();
			}
			if (null == this.discount)
			{
				this.discount = new NoDiscount();
			}
			return this.discount.Calculate(this.basePrice.Price) * this.Count;
		}

		public override string ToString()
		{
			double orginPirce = this.basePrice.Price;
			double discountPrice = this.discount.Calculate(this.basePrice.Price);

			if (orginPirce == discountPrice)
			{
				return string.Format("{0}張{1} 原價:{2} 小計:{3}\n",
					this.Count, this.basePrice, orginPirce, discountPrice * this.Count
					);
			}
			else {
				return string.Format("{0}張{1} 原價:{2} 特價:{3} 小計:{4}\n",
					this.Count, this.basePrice, orginPirce, discountPrice, discountPrice * this.Count
					);
			}
		}
	}
}