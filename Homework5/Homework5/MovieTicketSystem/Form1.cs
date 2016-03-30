using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketLibrary;

namespace MovieTicketSystem
{
	public partial class Form1 : Form
	{
		private DataType dataType = new DataType();

		public Form1()
		{
			InitializeComponent();
			this.RefreshComboBox();
		}

		public void RefreshComboBox()
		{
			this.ticketComboBox.Items.Clear();
			foreach (BasePrice basePrice in dataType.Prices)
			{
				this.ticketComboBox.Items.Add(basePrice);
			}
			this.ticketComboBox.SelectedIndex = 0;
			this.vipComboBox.Items.Clear();
			foreach (Discount discount in dataType.VIPs)
			{
				this.vipComboBox.Items.Add(discount);
			}
			this.vipComboBox.SelectedIndex = 0;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			int count = 0;
			if (!int.TryParse(this.countTextBox.Text, out count) || 0 == count)
			{
				this.messageRichTextBox.Text += "張數輸入錯誤!\n";
				return;
			}
			this.messageRichTextBox.Text += this.dataType.AddMovieTicket(
				(BasePrice)this.ticketComboBox.Items[this.ticketComboBox.SelectedIndex],
				(Discount)this.discountComboBox.Items[this.discountComboBox.SelectedIndex],
				count);
		}

		private void ticketComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.discountComboBox.Items.Clear();
			dataType.GetDiscount(dataType.Prices[this.ticketComboBox.SelectedIndex]);
			foreach (Discount discount in dataType.Discounts)
			{
				this.discountComboBox.Items.Add(discount);
			}
			if (0 < this.discountComboBox.Items.Count)
			{
				this.discountComboBox.SelectedIndex = 0;
			}
		}

		private void totalButton_Click(object sender, EventArgs e)
		{
			this.messageRichTextBox.Text +=
				this.dataType.Total((Discount)this.vipComboBox.Items[this.vipComboBox.SelectedIndex]);
			this.ticketComboBox.SelectedIndex = 0;
			this.discountComboBox.SelectedIndex = 0;
			this.vipComboBox.SelectedIndex = 0;
			this.countTextBox.Text = "0";
		}
	}
}