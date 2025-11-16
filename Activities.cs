using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace api
{
	// Token: 0x02000021 RID: 33
	internal class Activities
	{
		// Token: 0x02000069 RID: 105
		public class Charades
		{
			// Token: 0x06000322 RID: 802 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
			public static string words()
			{
				List<Activities.Charades.word> value = new List<Activities.Charades.word>
				{
					new Activities.Charades.word
					{
						EN_US = "Furry",
						Difficulty = 0
					},
					new Activities.Charades.word
					{
						EN_US = "Slugcat",
						Difficulty = 0
					},
					new Activities.Charades.word
					{
						EN_US = "Steam Machine",
						Difficulty = 0
					},
					new Activities.Charades.word
					{
						EN_US = "Your Mom",
						Difficulty = 0
					}
				};
				return JsonConvert.SerializeObject(value);
			}

			// Token: 0x02000073 RID: 115
			public class word
			{
				// Token: 0x170001AA RID: 426
				// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000D196 File Offset: 0x0000B396
				// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0000D19E File Offset: 0x0000B39E
				public string EN_US { get; set; }

				// Token: 0x170001AB RID: 427
				// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0000D1A7 File Offset: 0x0000B3A7
				// (set) Token: 0x060003F6 RID: 1014 RVA: 0x0000D1AF File Offset: 0x0000B3AF
				public int Difficulty { get; set; }
			}
		}
	}
}
