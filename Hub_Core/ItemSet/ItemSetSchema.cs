using Newtonsoft.Json;

namespace Hub_Core.ItemSet
{
	public class ItemSet
	{
		[JsonProperty("title")] public string Name;
		[JsonProperty("associatedMaps")] public int[] MapIds;
		[JsonProperty("associatedChampions")] public int[] ChampionIds;
		[JsonProperty("blocks")] public Block[] Blocks;
	}

	public class Block
	{
		[JsonProperty("items")] public Item[] Items;
		[JsonProperty("type")] public string Name;
	}

	public class Item
	{
		[JsonProperty("id")] public int ItemId;
		[JsonProperty("count")] public int Amount;
	}
}
