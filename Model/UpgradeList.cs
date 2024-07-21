using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterCombatCheats.Model
{
        public class UpgradeList
        {
                public string id { get; set; }
                public string name { get; set; }
                public int price { get; set; }
                public int level { get; set; }
                public int profitPerHour { get; set; }
                public int currentProfitPerHour { get; set; }
                public int profitPerHourDelta { get; set; }
                public Condition Condition { get; set; }
                public bool isAvailable { get; set; }
                public bool isExpired { get; set; }
                public int cooldownSeconds { get; set; }
                public int? maxLevel { get; set; } // Change to nullable int
        }

        public class Condition
        {
                public string _type { get; set; }
                public int level {  set; get; }
        }

        public class UpgradeResponse
        {
                public UpgradeList[] upgradesForBuy { get; set; }
        }
}
