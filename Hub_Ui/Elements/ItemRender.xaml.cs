using Hub_Core;

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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

		public void SetItem(int itemId, int amount)
		{
			this.ItemId = itemId;
			this.Amount = amount;
		}

		private async void UpdateItem()
		{
			string itemId = await CDRAGON.ConvertItemIdToName(this.ItemId, false);
			Bitmap icon = await CDRAGON.DownloadImageAsync(itemId);

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
