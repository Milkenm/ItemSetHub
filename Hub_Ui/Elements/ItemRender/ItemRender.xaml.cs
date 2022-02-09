using Hub_Core;

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using Size = System.Windows.Size;

namespace Hub_Ui.Elements
{
	/// <summary>
	/// Interaction logic for ItemRender.xaml
	/// </summary>
	public partial class ItemRender : UserControl
	{
		private int _ItemId;
		public int ItemId
		{
			get
			{
				return _ItemId;
			}
			set
			{
				_ItemId = value;
				this.UpdateItem();
			}
		}

		private int _Amount;
		public int Amount
		{
			get
			{
				return _Amount;
			}
			set
			{
				if (value > 99)
				{
					value = 99;
				}
				_Amount = value;
				this.UpdateAmount();
			}
		}

		public ItemRender()
		{
			this.InitializeComponent();
		}

		public ItemRender(int itemId, int amount)
		{
			this.InitializeComponent();
			this.SetItem(itemId, amount);
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
			double height = pictureBox_item.Height;
			double width = pictureBox_item.Width;
			Size size = new Size(width, height);
			return size;
		}

		private void SetControlSize()
		{
			Size size = this.GetControlSize();
			this.Height = size.Height;
			this.Width = size.Width;
		}

		public void SetItem(int itemId, int amount)
		{
			this.ItemId = itemId;
			this.Amount = amount;
		}

		private async void UpdateItem()
		{
			string itemId = await CDRAGON.GetInstance().ConvertItemIdToName(this.ItemId, false);
			Bitmap icon = await CDRAGON.GetInstance().GetItemImage(itemId);

			ImageSource img = this.ImageSourceFromBitmap(icon);
			pictureBox_item.Source = img;
		}

		[DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteObject([In] IntPtr hObject);
		public ImageSource ImageSourceFromBitmap(Bitmap bmp)
		{
			IntPtr handle = bmp.GetHbitmap();
			try
			{
				return Imaging.CreateBitmapSourceFromHBitmap(handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
			}
			finally { DeleteObject(handle); }
		}

		private void UpdateAmount()
		{
			if (this.Amount <= 1)
			{
				label_amount.Visibility = Visibility.Hidden;
			}
			else
			{
				label_amount.Content = this.Amount;
				label_amount.Visibility = Visibility.Visible;
			}
		}
	}
}
