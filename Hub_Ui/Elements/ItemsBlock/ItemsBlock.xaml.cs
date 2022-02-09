using System;
using System.Windows;
using System.Windows.Controls;

namespace Hub_Ui.Elements
{
	/// <summary>
	/// Interaction logic for ItemsBlock.xaml
	/// </summary>
	public partial class ItemsBlock : UserControl
	{
		private readonly int ItemMargin = 2;
		private readonly int ItemSize = 64;
		private readonly int ItemsPerRow = 6;

		private int Rows = 1;

		public ItemsBlock()
		{
			this.InitializeComponent();
			this.SetControlSize();
		}

		private void OnSizeChanged(object sender, SizeChangedEventArgs e)
		{
			if (e.NewSize != this.GetControlSize())
			{
				this.SetControlSize();
			}
		}

		private Size GetControlSize()
		{
			double height = textBox_title.Height + wrapPanel_items.Height;
			double width = wrapPanel_items.Width;
			Size size = new Size(width, height);
			return size;
		}

		private int CalculateNeededRows()
		{
			int childs = wrapPanel_items.Children.Count;
			double calc = childs / ItemsPerRow;
			int neededRows = Convert.ToInt32(Math.Ceiling(calc));
			return neededRows + 1;
		}

		private void SetControlSize()
		{
			Size size = this.GetControlSize();
			this.Height = size.Height;
			this.Width = size.Width;
		}

		public void AddItem(int itemId, int amount)
		{
			ItemRender itemRender = new ItemRender();
			itemRender.SetItem(itemId, amount);
			wrapPanel_items.Children.Add(itemRender);

			if (this.CalculateNeededRows() != Rows)
			{
				Rows = this.CalculateNeededRows();

				int newHeight = (ItemMargin * (2 + Rows)) + (ItemSize * Rows);
				wrapPanel_items.Height = newHeight;
				this.SetControlSize();
			}
		}
	}
}
