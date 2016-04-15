using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedFishControlLibrary
{
	public partial class FishControl : MoveControl, IFoodFall
	{
		private int xOffset;
		private int yOffset;
		private bool AteMode { set; get; }
		private FoodControl foodControl;
		private int AteTick { set; get; }

		public event EventHandler AteOverEvent;

		public FishControl()
		{
			InitializeComponent();
			base.SetText("");
			base.SetName("我是魚");
			base.SetColor(Color.Yellow, Color.White, Color.FromArgb(MoveControl.myGlobal.myRandom.Next(0, 0xC0), MoveControl.myGlobal.myRandom.Next(0, 0xC0), MoveControl.myGlobal.myRandom.Next(0, 0xC0)));
			base.SetSize(new Size(120, 50));
			this.xOffset = (int)(10.0 + 5 * MoveControl.myGlobal.myRandom.NextDouble());
			this.yOffset = (int)(1.0 + 2 * MoveControl.myGlobal.myRandom.NextDouble());
			if (1 == MoveControl.myGlobal.myRandom.Next(0, 2))
			{
				this.xOffset *= -1;
			}
			if (1 == MoveControl.myGlobal.myRandom.Next(0, 2))
			{
				this.yOffset *= -1;
			}
			this.AteMode = false;
		}

		public void AddAteOver(EventHandler ateOver)
		{
			this.AteOverEvent += ateOver;
		}

		public void RemoveAteOver(EventHandler ateOver)
		{
			this.AteOverEvent -= ateOver;
		}

		public void EatFood(object sender, EventArgs e)
		{
			FoodData foodData = e as FoodData;
			if (this.MoveMode)
			{
				this.MoveMode = false;
				this.foodControl = foodData.foodControl;
				this.SetText("有食物");
			}
			else if (null != this.foodControl && this.foodControl != foodData.foodControl)
			{
				int x = (this.Left + this.Width / 2) - (this.foodControl.Left + this.foodControl.Width / 2);
				int y = (this.Top + this.Height / 2) - (this.foodControl.Top + this.foodControl.Height / 2);
				double distanceNow = Math.Sqrt(x * x + y * y);
				x = (this.Left + this.Width / 2) - (foodData.foodControl.Left + foodData.foodControl.Width / 2);
				y = (this.Top + this.Height / 2) - (foodData.foodControl.Top + foodData.foodControl.Height / 2);
				double distanceNew = Math.Sqrt(x * x + y * y);
				if (distanceNew < distanceNow)
				{
					this.foodControl = foodData.foodControl;
				}
			}
		}

		public void Moving()
		{
			int x = this.Location.X + this.xOffset;
			int y = this.Location.Y + this.yOffset;
			if (0 > x)
			{
				x = 0;
				this.xOffset *= -1;
			}
			else if (MoveControl.screenWidth < x + this.Width)
			{
				x = MoveControl.screenWidth - this.Width;
				this.xOffset *= -1;
			}
			if (0 > y)
			{
				y = 0;
				this.yOffset *= -1;
			}
			else if (MoveControl.screenHeight < y + this.Height)
			{
				y = MoveControl.screenHeight - this.Height;
				this.yOffset *= -1;
			}
			this.SetText("移動中");
			this.SetPosition(x, y);
		}

		public override void Timeup()
		{
			if (this.MoveMode)
			{
				this.Moving();
			}
			else if (this.AteMode)
			{
				if (5000 < Environment.TickCount - this.AteTick)
				{
					this.AteMode = false;
					this.MoveMode = true;
				}
			}
			else if (null != this.foodControl)
			{
				this.MoveToFood();
			}
		}

		private void MoveToFoodObject(int x, int y)
		{
			this.Left = x - this.Width / 2;
			this.Top = y - this.Height / 2;
		}

		public void MoveToFood()
		{
			if (this.foodControl.BeAte)
			{
				this.foodControl = null;
				this.MoveMode = true;
				return;
			}
			int x = (this.Left + this.Width / 2) - (this.foodControl.Left + this.foodControl.Width / 2);
			int y = (this.Top + this.Height / 2) - (this.foodControl.Top + this.foodControl.Height / 2);
			double distance = Math.Sqrt(x * x + y * y);
			if ((int)distance < 10)
			{
				this.SetText("飽餐一頓");
				this.AteMode = true;
				this.MoveToFoodObject(this.foodControl.Left + this.foodControl.Width / 2, this.foodControl.Top + this.foodControl.Height / 2);
				this.AteTick = Environment.TickCount;
				this.AteOverEvent(this, new AteData(this.foodControl));
				this.foodControl.BeAte = true;
				this.foodControl = null;
			}
			else
			{
				double rate = 10.0 / (double)distance;
				x = (this.Left + this.Width / 2) - (int)(x * rate);
				y = (this.Top + this.Height / 2) - (int)(y * rate);
				this.MoveToFoodObject(x, y);
			}
		}
	}
}