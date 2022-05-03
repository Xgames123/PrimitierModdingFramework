using Octokit;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PMFTool
{
	public static class PMFDownloader
	{

		private static GitHubClient? s_client = null;

		private static void TryInit()
		{
			if (s_client != null)
			{
				return;
			}

			s_client = new GitHubClient(new ProductHeaderValue("XGames105-PMFTool", Assembly.GetEntryAssembly().GetName().Version.ToString()));

		}

		public static async Task<ZipArchive?> DownloadPMFLib(string version)
		{
			TryInit();

			var release = await s_client.Repository.Release.Get("XGames105", "PrimitierModdingFramework", version.ToLower());

			ReleaseAsset? pmfLibAsset = null;
			foreach (var asset in release.Assets)
			{
				if (asset.Name.StartsWith("PMFLib"))
				{
					pmfLibAsset = asset;
					break;
				}

			}
			if (pmfLibAsset == null)
			{
				throw new Exception($"Could not find PMFLib{version}.zip in release '{version}'");
			}

			using(var httpClient = new HttpClient())
			{
				var responseStream = await httpClient.GetStreamAsync(pmfLibAsset.BrowserDownloadUrl);

				var archive = new ZipArchive(responseStream);
				return archive;

			}


		}

	}
}
