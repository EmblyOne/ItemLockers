using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapGeneration.Distributors;
using Qurre.API.Addons;
using Qurre.API;
using InventorySystem.Items.Pickups;
using System.ComponentModel;

namespace ItemLockers
{
    public class Config : IConfig
    {
        public string Name { get; set; } = "ItemLockers";
         

        public bool Enabled { get; set; } = true;
         
        [Description("The List with items that will spawn in locker")]
        public Dictionary<StructureType, List<LockerSpawn>> lockers = new Dictionary<StructureType, List<LockerSpawn>>
        {
            [StructureType.StandardLocker] = new List<LockerSpawn>
            {
                new LockerSpawn
                {
                    amount = 1,
                    chance = 35, 
                    item = ItemType.Medkit 
                    
                },
                new LockerSpawn
                {
                    amount = 1, 
                    chance = 10, 
                    item = ItemType.Adrenaline
                }
            }

        };
        [Description("The list with lockers which won't spawn base game items")]
        public Dictionary<StructureType, bool> ItemInLockersDisabler = new Dictionary<StructureType, bool>()
        {
            [StructureType.StandardLocker] = true
        };
    }
}
