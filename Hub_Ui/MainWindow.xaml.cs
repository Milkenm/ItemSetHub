using Hub_Core.ItemSet;

using Microsoft.Win32;

using System;
using System.Windows;

namespace Hub_Ui
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();
			this.a();
		}

		public void a()
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "JSON Files (*.json)|*.json";
			fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			fileDialog.ShowDialog();

			if (string.IsNullOrEmpty(fileDialog.FileName))
			{
				return;
			}

			ItemSet set = ItemSetUtils.DeserializeItemSetFromFile(fileDialog.FileName);

			foreach (Block block in set.Blocks)
			{
				foreach (Item item in block.Items)
				{
					itemsBlock_test.AddItem(item.ItemId, item.Amount);
				}
			}
		}
	}
}
