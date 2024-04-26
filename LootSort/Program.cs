using System;
using System.Collections.Generic;

namespace LootSort
{
    public class Program
    {
        private static void Main()
        {
            // We'll place the loot in this list
            List<Loot> lootList = new List<Loot>();

            // Add various loot to the set
            lootList.Add(new Loot(LootType.Ammo, "Good 45mm rounds", 12.5f));
            lootList.Add(new Loot(LootType.Collectible, "Unique ruby", 500f));
            lootList.Add(new Loot(LootType.Health, "Powerup +50HP", 7.5f));
            lootList.Add(new Loot(LootType.Shield, "Powerup +75AP", 42.5f));
            lootList.Add(new Loot(LootType.Weapon, "Colt Revolver", 83.75f));
            lootList.Add(new Loot(LootType.Ammo, "Less good 45mm rounds", 12.5f));
            lootList.Add(new Loot(LootType.Ammo, "Pristine 45mm rounds", 12.5f));
            lootList.Add(new Loot(LootType.Shield, "Powerup +75AP", 42.5f));
            lootList.Add(new Loot(LootType.Weapon, "Colt Revolver", 83.75f));
            lootList.Add(new Loot(LootType.Shield, "Powerup +25AP", 21.25f));
            lootList.Add(new Loot(LootType.Weapon, "S&W Revolver", 67.25f));
            lootList.Add(null);

            // Sort the list
            // This will fail if the Loot class doesn't implement IComparable<Loot>)
            lootList.Sort();

            // Print the contents of the sorted loot list
            foreach (Loot loot in lootList)
            {
                // This will implicitly call loot.ToString()
                Console.WriteLine(loot);
            }

            // Expected output:
            //
            // [           Ammo]	12.50	Good 45mm rounds
            // [           Ammo]	12.50	Less good 45mm rounds
            // [           Ammo]	12.50	Pristine 45mm rounds
            // [    Collectible]	500.00	Unique ruby
            // [         Health]	7.50	Powerup +50HP
            // [         Shield]	42.50	Powerup +75AP
            // [         Shield]	42.50	Powerup +75AP
            // [         Shield]	21.25	Powerup +25AP
            // [         Weapon]	83.75	Colt Revolver
            // [         Weapon]	83.75	Colt Revolver
            // [         Weapon]	67.25	S&W Revolver
        }
    }
}
