using Newtonsoft.Json;

using System.IO;

namespace Hub_Core.ItemSet
{
	public static class ItemSetUtils
	{
		public static ItemSet DeserializeItemSetFromFile(string filePath)
		{
			string json = File.ReadAllText(filePath);
			return DeserializeItemSetFromJson(json);
		}

		public static ItemSet DeserializeItemSetFromJson(string json)
		{
			ItemSet set = JsonConvert.DeserializeObject<ItemSet>(json);
			return set;
		}
	}
}