using FeedFishControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedFish
{
	public partial class Form1 : Form
	{
		private List<FishControl> fishControls;
		private List<FoodControl> foodControls;

		public delegate void FoodFall(object sender, EventArgs e);

		public event FoodFall FoodFallEvent;

		public Form1()
		{
			InitializeComponent();
			this.fishControls = new List<FishControl>();
			this.foodControls = new List<FoodControl>();
			MoveControl moveControl = new MoveControl();
			moveControl.SetRange(this.ClientRectangle.Width, this.ClientRectangle.Height);
		}

		private void AddFishControl(FishControl control)
		{
			control.AddAteOver(this.AteOver);
			this.fishControls.Add(control);
			this.Controls.Add(control);
			this.FoodFallEvent += control.EatFood;
		}

		private void RemoveFishControl(FishControl control)
		{
			control.RemoveAteOver(this.AteOver);
			this.fishControls.Remove(control);
			this.Controls.Remove(control);
			this.FoodFallEvent -= control.EatFood;
		}

		private void AddFoodControl(FoodControl control)
		{
			this.foodControls.Add(control);
			this.Controls.Add(control);
			if (!this.mainTimer.Enabled && 0 < this.foodControls.Count)
			{
				this.mainTimer.Enabled = true;
			}
		}

		private void RemoveFoodControl(FoodControl control)
		{
			this.foodControls.Remove(control);
			this.Controls.Remove(control);
			if (this.mainTimer.Enabled && 0 == this.foodControls.Count)
			{
				this.mainTimer.Enabled = false;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (this.addFishRadioButton.Checked)
			{
				FishControl fishControl = new FishControl();
				fishControl.SetPosition(e.X, e.Y);
				fishControl.Run();
				this.AddFishControl(fishControl);
			}
			else if (this.addFoodRadioButton.Checked)
			{
				FoodControl foodControl = new FoodControl();
				foodControl.SetPosition(e.X, e.Y);
				foodControl.Run();
				this.AddFoodControl(foodControl);
			}
		}

		private void mainTimer_Tick(object sender, EventArgs e)
		{
			foreach (var food in this.foodControls)
			{
				FoodData foodData = new FoodData(food);
				this.OnFoodFallEvent(foodData);
			}
		}

		private void OnFoodFallEvent(FoodData foodData)
		{
			if (null != this.FoodFallEvent)
			{
				this.FoodFallEvent(this, foodData.Clone());
			}
		}

		public void AteOver(object sender, EventArgs e)
		{
			AteData ateData = e as AteData;
			this.RemoveFoodControl(ateData.foodControl);
		}
	}
}