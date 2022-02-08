using Hub_Core.ItemSet;

using System;
using System.Windows.Forms;

namespace Hub_Testing
{
	public partial class ItemSetDeserialize : Form
	{
		public ItemSetDeserialize()
		{
			this.InitializeComponent();
		}

		private void button_locate_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Filter = "JSON Files (*.json)|*.json";
			fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			fileDialog.ShowDialog();

			if (string.IsNullOrEmpty(fileDialog.FileName))
			{
				return;
			}

			listBox_maps.Items.Clear();
			listBox_champs.Items.Clear();
			listBox_items.Items.Clear();

			textBox_path.Text = fileDialog.FileName;

			ItemSet set = ItemSetUtils.DeserializeItemSetFromFile(fileDialog.FileName);
			textBox_name.Text = set.Name;
			foreach (int mapId in set.MapIds)
			{
				listBox_maps.Items.Add(mapId);
			}
			foreach (int champId in set.ChampionIds)
			{
				listBox_champs.Items.Add(champId);
			}
			foreach (Block block in set.Blocks)
			{
				listBox_items.Items.Add($" == {block.Name} == ");
				foreach (Item item in block.Items)
				{
					listBox_items.Items.Add($"{item.ItemId} (x{item.Amount})");
				}
			}
		}
	}
}
