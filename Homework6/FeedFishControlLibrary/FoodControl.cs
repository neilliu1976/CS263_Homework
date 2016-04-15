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
	public partial class FoodControl : MoveControl
	{
		private bool BottomMode { set; get; }
		public bool BeAte { set; get; }

		public FoodControl()
		{
			InitializeComponent();
			base.SetText("好香");
			base.SetName("魚餌");
			base.SetColor(Color.White, Color.Yellow, Color.Brown);
			base.SetSize(new Size(50, 36));
			this.BottomMode = false;
			this.BeAte = false;
		}

		public void Moving()
		{
			int y = this.Location.Y + 2;
			if (MoveControl.screenHeight < y + this.Height)
			{
				base.SetText("不香了");
				y = MoveControl.screenHeight - this.Height;
				this.BottomMode = true;
			}
			this.SetPosition(this.Location.X, y);
		}

		public override void Timeup()
		{
			if (!this.BottomMode)
			{
				this.Moving();
			}
		}
	}
}