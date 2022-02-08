using Hub_Core.RitoSchemas;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Hub_Core
{
	public class CDRAGON
	{
		private static CDRAGON instance;

		public static CDRAGON GetInstance()
		{
			return instance ?? new CDRAGON();
		}

		public CDRAGON()
		{
			instance = this;
		}

		public static string EndPoint = "https://raw.communitydragon.org/latest/";

		public static string ItemsJson = EndPoint + "plugins/rcp-be-lol-game-data/global/default/v1/items.json";
		public static string Items = EndPoint + "plugins/rcp-be-lol-game-data/global/default/assets/items/icons2d/";

		public string ItemsJsonCache;
		public Dictionary<string, Bitmap> ItemImageCache = new Dictionary<string, Bitmap>();
		public int ItemImageCacheMaxSize = 50;
		public List<string> ItemsBeingDownloaded = new List<string>();

		public async Task<string> ConvertItemIdToName(int itemId, bool returnCompleteUrl)
		{
			if (string.IsNullOrEmpty(ItemsJsonCache))
			{
				ItemsJsonCache = await this.GetJsonFromUrl(ItemsJson);
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

		public async Task<string> GetJsonFromUrl(string url)
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

		public async Task<Bitmap> GetItemImage(string itemName)
		{
			if (ItemImageCache.ContainsKey(itemName))
			{
				Trace.WriteLine($"Load from cache ({itemName})");
				Bitmap img = ItemImageCache[itemName];
				return img;
			}
			else if (ItemsBeingDownloaded.Contains(itemName))
			{
				Trace.WriteLine($"Wait for download ({itemName})");
				await Task.Delay(5);
				return await this.GetItemImage(itemName);
			}
			else
			{
				ItemsBeingDownloaded.Add(itemName);
				WebRequest request = WebRequest.Create(new Uri(Items + itemName, UriKind.Absolute));
				WebResponse response = await request.GetResponseAsync();
				Stream responseStream = response.GetResponseStream();
				Bitmap bitmap = new Bitmap(responseStream);
				if (!ItemImageCache.ContainsKey(itemName))
				{
					Trace.WriteLine($"Add to cache ({itemName})");
					if (ItemImageCache.Count > ItemImageCacheMaxSize)
					{
						Trace.WriteLine($"Remove from cache ({ItemImageCache.Keys.First()})");
						ItemImageCache.Remove(ItemImageCache.Keys.First());
					}
					ItemImageCache.Add(itemName, bitmap);
					ItemsBeingDownloaded.Remove(itemName);
				}
				return bitmap;
			}
		}
	}
}
