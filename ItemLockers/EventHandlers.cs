using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Qurre.API.Events;
using Qurre.API;
using MapGeneration.Distributors;  
using InventorySystem.Items.Pickups; 
using Qurre.API.Objects;
using UnityEngine;  
namespace ItemLockers
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public void OnStartRound()
        {
            var obj = UnityEngine.Object.FindObjectsOfType<Locker>(); 
            foreach(var locker in obj)
            {
                bool spawn = plugin.config.lockers.TryGetValue(locker.StructureType, out var list);
                bool delete = plugin.config.ItemInLockersDisabler.TryGetValue(locker.StructureType, out bool destroy) && destroy;
                foreach (LockerChamber chamb in locker.Chambers)  
                {
                    if (delete)
                    {
                        foreach(ItemPickupBase pickupdestroy in chamb._content)
                        {
                            pickupdestroy.DestroySelf();
                        }
                    }
                    else if (spawn)  
                    {
                        foreach (LockerSpawn spawner in list)
                        {
                            UnityEngine.Random random = new UnityEngine.Random();
                            if (spawner.chance < UnityEngine.Random.Range(0, 100)) return; 
                             chamb.SpawnItem(spawner.item, spawner.amount);
                        }
                    }
                }
            }
        }
    }
}
