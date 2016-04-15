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
	public partial class MoveControl : UserControl
	{
		public static MyGlobal myGlobal;
		protected static int screenWidth;
		protected static int screenHeight;
		protected bool MoveMode { set; get; }

		public MoveControl()
		{
			InitializeComponent();
			if (null == myGlobal)
			{
				MoveControl.myGlobal = new MyGlobal();
			}
		}

		public void SetRange(int width, int height)
		{
			MoveControl.screenWidth = width;
			MoveControl.screenHeight = height;
		}

		public virtual void Timeup()
		{
		}

		public void SetSize(Size size)
		{
			this.textLabel.Location = new Point(0, 0);
			this.nameLabel.Location = new Point(0, 14);
			this.textLabel.Size = new Size(size.Width, 14);
			this.nameLabel.Size = new Size(size.Width, size.Height - 14);
			this.Size = size;
		}

		public void SetColor(Color textColor, Color nameColor, Color backColor)
		{
			this.textLabel.ForeColor = textColor;
			this.textLabel.BackColor = backColor;
			this.nameLabel.ForeColor = nameColor;
			this.nameLabel.BackColor = backColor;
		}

		public void SetText(string text)
		{
			this.textLabel.Text = text;
		}

		public void SetName(string name)
		{
			this.nameLabel.Text = name;
		}

		public void SetPosition(int x, int y)
		{
			this.Location = new Point(x, y);
		}

		public void Run()
		{
			this.actionTimer.Enabled = true;
			this.MoveMode = true;
		}

		private void actionTimer_Tick(object sender, EventArgs e)
		{
			this.Timeup();
		}
	}
}