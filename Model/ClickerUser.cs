using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterCombatAuto.Model
{
        public class ClickerUser
        {
                public string Id { get; set; }
                public double TotalCoins { get; set; }
                public double BalanceCoins { get; set; }
                public int Level { get; set; }
                public int AvailableTaps { get; set; }
                public long LastSyncUpdate { get; set; }
                public string ExchangeId { get; set; }
                public Dictionary<string, Upgrade> Upgrades { get; set; }
                public double earnPassivePerHour { get; set; }
                public double earnPassivePerSec { get; set; }
        }

        public class Upgrade
        {
                public string Id { get; set; }
                public int Level { get; set; }
                public long LastUpgradeAt { get; set; }
        }

        public class ApiResponse
        {
                public ClickerUser ClickerUser { get; set; }
        }

}
