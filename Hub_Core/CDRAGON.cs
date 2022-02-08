using Hub_Core.RitoSchemas;

using Newtonsoft.Json;

using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Hub_Core
{
	public static class CDRAGON
	{
		public static string EndPoint = "https://raw.communitydragon.org/latest/";

		public static string ItemsJson = EndPoint + "plugins/rcp-be-lol-game-data/global/default/v1/items.json";
		public static string Items = EndPoint + "plugins/rcp-be-lol-game-data/global/default/assets/items/icons2d/";

		public static string ItemsJsonCache;

		public static async Task<string> ConvertItemIdToName(int itemId, bool returnCompleteUrl)
		{
			if (string.IsNullOrEmpty(ItemsJsonCache))
			{
				ItemsJsonCache = await GetJsonFromUrl(ItemsJson);
			}

			CDN_Item[] items = JsonConvert.DeserializeObject<CDN_Item[]>(ItemsJsonCache);
			foreach (CDN_Item item in items)
			{
				if (item.Id == itemId)
				{
					if (returnCompleteUrl)
					{
						return item.IconPath.ToLower();
					}
					else
					{
						string[] itemSplit = item.IconPath.Split('/');
						return itemSplit[itemSplit.Length - 1].ToLower();
					}
				}
			}
			return null;
		}

		public static async Task<string> GetJsonFromUrl(string url)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(url, UriKind.Absolute));
			httpWebRequest.Method = WebRequestMethods.Http.Get;
			httpWebRequest.Accept = "application/json; charset=utf-8";
			string file;
			HttpWebResponse response = (HttpWebResponse)await httpWebRequest.GetResponseAsync();
			using (StreamReader sr = new StreamReader(response.GetResponseStream()))
			{
				file = sr.ReadToEnd();
			}
			return file;
		}

		public static async Task<Bitmap> DownloadImageAsync(string itemName)
		{
			WebRequest request = WebRequest.Create(new Uri(Items + itemName, UriKind.Absolute));
			WebResponse response = await request.GetResponseAsync();
			Stream responseStream = response.GetResponseStream();
			Bitmap bitmap = new Bitmap(responseStream);
			return bitmap;
		}
	}
}
