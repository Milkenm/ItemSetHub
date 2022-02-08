using Newtonsoft.Json;

namespace Hub_Core.RitoSchemas
{
	public class CDN_Item
	{
		[JsonProperty("id")] public int Id;
		[JsonProperty("name")] public string Name;
		[JsonProperty("description")] public string Description;
		[JsonProperty("active")] public bool IsActive;
		[JsonProperty("inStore")] public bool IsInStore;
		[JsonProperty("from")] public int[] From;
		[JsonProperty("to")] public int[] To;
		[JsonProperty("categories")] public string[] Categories;
		[JsonProperty("maxStacks")] public int MaxStacks;
		[JsonProperty("requiredChampion")] public string RequiredChampion;
		[JsonProperty("requiredAlly")] public string RequiredAlly;
		[JsonProperty("requiredBuffCurrencyName")] public string RequiredBuffCurrencyName;
		[JsonProperty("requiredBuffCurrencyCost")] public string RequiredBuffCurrencyCost;
		[JsonProperty("specialRecipe")] public int SpecialRecipe;
		[JsonProperty("isEnchantment")] public bool IsEnchantment;
		[JsonProperty("price")] public int Price;
		[JsonProperty("priceTotal")] public int TotalPrice;
		[JsonProperty("iconPath")] public string IconPath;
	}
}
