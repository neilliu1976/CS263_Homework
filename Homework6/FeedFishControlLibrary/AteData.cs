using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedFishControlLibrary
{
	public class AteData : EventArgs
	{
		public FoodControl foodControl { set; get; }

		public AteData()
		{
		}

		public AteData(AteData ateData)
		{
			this.foodControl = ateData.foodControl;
		}

		public AteData(FoodControl control)
		{
			this.foodControl = control;
		}

		public AteData Clone()
		{
			return new AteData(this);
		}
	}
}