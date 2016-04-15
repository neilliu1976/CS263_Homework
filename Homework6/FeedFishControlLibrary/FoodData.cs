using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedFishControlLibrary
{
	public class FoodData : EventArgs
	{
		public FoodControl foodControl { set; get; }

		public FoodData()
		{
		}

		public FoodData(FoodData foodData)
		{
			this.foodControl = foodData.foodControl;
		}

		public FoodData(FoodControl control)
		{
			this.foodControl = control;
		}

		public FoodData Clone()
		{
			return new FoodData(this);
		}
	}
}