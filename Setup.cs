using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace start
{
	class Setup
	{
		public static bool firsttime = false;
		public static void setup()
		{
			//sets up all the important files so openrec doesnt crash like lame vaultserver xD
			Console.WriteLine("Setting up... (May take a minute to download everything.)");
			Directory.CreateDirectory("SaveData\\App\\");
			Directory.CreateDirectory("SaveData\\Profile\\");
			Directory.CreateDirectory("SaveData\\Images\\");
			Directory.CreateDirectory("SaveData\\Rooms\\");
			Directory.CreateDirectory("SaveData\\Images\\");
			Directory.CreateDirectory("SaveData\\Rooms\\Downloaded\\");
			if (!(File.Exists("SaveData\\App\\firsttime.txt")))
			{
				File.WriteAllText("SaveData\\App\\firsttime.txt", "I goon to femboys but nobody will know because this is a secret file that only the program can see");
				firsttime = true;	
			}
			if (!(File.Exists("SaveData\\avatar.txt")))
			{
				File.WriteAllText("SaveData\\avatar.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/XenonSolutions/OpenRec/master/Download/avatar.txt"));
				Console.WriteLine("Downloaded avatar.txt");
			}
			else if (File.ReadAllText("SaveData\\avatar.txt") == "")
            {
				File.WriteAllText("SaveData\\avatar.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/XenonSolutions/Hyperion/master/Download/avatar.txt"));
				Console.WriteLine("Downloaded avatar.txt");
			}
			if (!(File.Exists("SaveData\\avataritems.txt")))
			{
				File.WriteAllText("SaveData\\avataritems.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/XenonSolutions/Hyperion/master/Download/avataritems.txt"));
				Console.WriteLine("Downloaded avataritems.txt");
			}
			if (!(File.Exists("SaveData\\avataritems2.txt")))
			{
				File.WriteAllText("SaveData\\avataritems2.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/XenonSolutions/Hyperion/master/Download/avataritems2.txt"));
				Console.WriteLine("Downloaded avataritems2.txt");
			}
			if (!(File.Exists("SaveData\\equipment.txt")))
			{
				File.WriteAllText("SaveData\\equipment.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/XenonSolutions/Hyperion/master/Download/equipment.txt"));
				Console.WriteLine("Downloaded equipment.txt");
			}
			if (!(File.Exists("SaveData\\consumables.txt")))
			{
				File.WriteAllText("SaveData\\consumables.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/XenonSolutions/Hyperion/master/Download/consumables.txt"));
				Console.WriteLine("Downloaded consumables.txt");
			}
			if (!(File.Exists("SaveData\\gameconfigs.txt")))
			{
				File.WriteAllText("SaveData\\gameconfigs.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/XenonSolutions/Hyperion/master/Download/gameconfigs.txt"));
				Console.WriteLine("Downloaded gameconfigs.txt");
			}
			if (!(File.Exists("SaveData\\storefronts2.txt")))
			{
				File.WriteAllText("SaveData\\storefronts2.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/XenonSolutions/Hyperion/master/Download/storefront2.txt"));
				Console.WriteLine("Downloaded storefronts2.txt");
			}
			if (!(File.Exists("SaveData\\baserooms.txt")))
			{
				File.WriteAllText("SaveData\\baserooms.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/XenonSolutions/Hyperion/master/Download/baserooms.txt"));
				Console.WriteLine("Downloaded baserooms.txt");
			}
			if (!(File.Exists("SaveData\\Profile\\username.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\username.txt", "Hyperion User#" + new Random().Next(0, 1000000));
				Console.WriteLine("Created username.txt");
			}
			if (!(File.Exists("SaveData\\Profile\\level.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\level.txt", "10");
				Console.WriteLine("Created level.txt");
			}
			if (!(File.Exists("SaveData\\Profile\\userid.txt")))
			{
				File.WriteAllText("SaveData\\Profile\\userid.txt", "10000000");
				Console.WriteLine("Created userid.txt");
			}
			if (!(File.Exists("SaveData\\myrooms.txt")))
			{
				File.WriteAllText("SaveData\\myrooms.txt", "[]");
				Console.WriteLine("Cleared myrooms.txt");
			}
			if (!(File.Exists("SaveData\\settings.txt")))
			{
				File.WriteAllText("SaveData\\settings.txt", Newtonsoft.Json.JsonConvert.SerializeObject(api.Settings.CreateDefaultSettings()));
				Console.WriteLine("Created settings.txt");
			}
			if (!(File.Exists("SaveData\\profileimage.png")))
			{
				File.WriteAllBytes("SaveData\\profileimage.png", new WebClient().DownloadData("https://github.com/XenonSolutions/Hyperion/master/Download/profileimage.png"));
				Console.WriteLine("Downloaded profileimage.png");
			}
			if (!(File.Exists("SaveData\\App\\privaterooms.txt")))
			{
				File.WriteAllText("SaveData\\App\\privaterooms.txt", "Disabled");
				Console.WriteLine("Created privaterooms.txt");
			}
			if (!(File.Exists("SaveData\\App\\showhyperioninfo.txt")))
			{
				File.WriteAllText("SaveData\\App\\showhyperioninfo.txt", "Enabled");
				Console.WriteLine("Created showhyperioninfo.txt");
			}
			if (!(File.Exists("SaveData\\App\\facefeaturesadd.txt")))
			{
				File.WriteAllText("SaveData\\App\\facefeaturesadd.txt", new WebClient().DownloadString("https://raw.githubusercontent.com/XenonSolutions/Hyperion/master/Download/facefeaturesadd.txt"));
				Console.WriteLine("Downloaded facefeaturesadd.txt");
			}
			goto tryagain;

		tryagain:
			Console.WriteLine("Done!");
			Console.Clear();
		}
	}
}
