﻿using Alphaleonis.Win32.Filesystem;
using DivinityModManager.Extensions;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivinityModManager.Models
{
	public class DivinityPathwayData : ReactiveObject
	{
		/// <summary>
		/// The path to the root game folder, i.e. SteamLibrary\steamapps\common\Baldur's Gate 3
		/// </summary>
		[Reactive] public string InstallPath { get; set; }

		/// <summary>
		/// The path to %LOCALAPPDATA%\Larian Studios\Baldur's Gate 3
		/// </summary>
		[Reactive] public string AppDataGameFolder { get; set; }

		/// <summary>
		/// The path to %LOCALAPPDATA%\Larian Studios\Baldur's Gate 3\Mods
		/// </summary>
		[Reactive] public string AppDataModsPath { get; set; }

		/// <summary>
		/// The path to %LOCALAPPDATA%\Larian Studios\Baldur's Gate 3\PlayerProfiles
		/// </summary>
		[Reactive] public string AppDataProfilesPath { get; set; }

		/// <summary>
		/// The path to %LOCALAPPDATA%\Larian Studios\Baldur's Gate 3\DMCampaigns
		/// </summary>
		[Reactive] public string AppDataCampaignsPath { get; set; }

		[Reactive] public string LastSaveFilePath { get; set; }

		[Reactive] public string ScriptExtenderLatestReleaseUrl { get; set; }
		[Reactive] public string ScriptExtenderLatestReleaseVersion { get; set; }

		public DivinityPathwayData()
		{
			InstallPath = "";
			AppDataGameFolder = "";
			AppDataModsPath = "";
			AppDataCampaignsPath = "";
			LastSaveFilePath = "";
			ScriptExtenderLatestReleaseUrl = "";
			ScriptExtenderLatestReleaseVersion = "";
		}

		public string ScriptExtenderSettingsFile(DivinityModManagerSettings settings)
		{
			if(settings.GameExecutablePath.IsExistingFile())
			{
				return Path.Combine(Path.GetDirectoryName(settings.GameExecutablePath), "ScriptExtenderSettings.json");
			}
			return "";
		}
	}
}
