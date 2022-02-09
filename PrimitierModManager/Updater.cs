using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimitierModManager
{
	public static class Updater
	{

		private static GitHubClient s_gitHubClient = null;
		private static Release s_LatestRelease = null;

		private static void CreateGitHubClient()
		{
			if (s_gitHubClient == null)
			{
				s_gitHubClient = new GitHubClient(new ProductHeaderValue("XGames105-PrimitierModManager", Assembly.GetEntryAssembly().GetName().Version.ToString()));
			}
		}

		public static async Task<Release> GetLatestRelease()
		{
			if (s_LatestRelease != null)
			{
				return s_LatestRelease;
			}

			CreateGitHubClient();

			var releases = await s_gitHubClient.Repository.Release.GetAll("Xgames123", "PrimitierModManager");

			foreach (var release in releases)
			{
#if DEBUG
				s_LatestRelease = release;
				return release;
				
#else
				if (release.Draft != true)
				{
					s_LatestRelease = release;
					return release;
				}
#endif

			}
			return null;
		}


	}
}
