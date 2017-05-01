using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ItemList
    {
        List<Item> list;
        public ItemList()
        {
            // Melee Weapons 
            // list.Add(new Item(0, "", "", 0, false, 0, 0, false,  0, 0, 0, 0, 0, 0, 0, true, 0, 0, 0, 0, 0, true/false));
            // Clean slate ^^^^^^^^^^   id name description amount stackable? weight use consumable slot hp armor str dex int autism melee damage accuracy burst ammo range twohanded

            // Short sword tree, low damage, high accuracy, high burst
            list.Add(new Item(0, "Poultrion Tusk", "Gleaming ivory tooth of the savage Giganigger's prized chicken", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 5, 75, 5, 0, 1, false));
            list.Add(new Item(0, "Gladius", "A rapid, robust little blade", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 3, 75, 5, 0 , 1, false));
            list.Add(new Item(0, "Short Sword", "A large iron knife", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 2, 75, 4, 0, 1, false));
            list.Add(new Item(0, "Broken Off Hilt", "A ruined sword, a small nub of metal left as any remnant of a blade", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 1, 70, 3, 0, 1, false));

            // Greatsword tree, high damage, low acuracy, low burst
            list.Add(new Item(0, "Relic Sword", "Inlaid in the hilt is a powerful field generator, multiplying the force of this weapon's blows", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 14, 65, 1, 0, 3, true));
            list.Add(new Item(0, "Zweihänder", "A savage blade of epic proportions, serrated teeth leaving pulped and bloody corpses galore", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 12, 65, 1, 0, 3, true));
            list.Add(new Item(0, "Claymore", "A noble blade, blood of a Yoma is faintly visible on the edges", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 10, 65, 1, 0, 3, true));
            list.Add(new Item(0, "Longsword", "Weapon of kings", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 8, 65, 1, 0, 3, true));

            // Fist tree, low damage, high accuracy high burst
            list.Add(new Item(0, "Pneumatic Fist", "A powerful piston mechanism lies behind the knuckles of this metal glove, a deafening roar followed by a disturbing crunch when applied. ", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 8, 75, 2, 0, 0, true));
            list.Add(new Item(0, "Bladed Caestus", "A bronze frame similar to a skeleton, however on the knuckles lie sharp talons", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 3, 80, 6, 0, 0, false));
            list.Add(new Item(0, "Brass Knuckles", "Piece of metal worn around your knuckles meant to amplify your blows", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 2, 85, 5, 0, 0, false));
            list.Add(new Item(0, "Fists", "Find a weapon", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 1, 85, 3, 0, 0, false));

            // Whip tree, moderate damage, low accuracy, high bursts
            list.Add(new Item(0, "Living Lash", "Scavenged from the body of a tentacle beast, does double damage versus school girls", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 7, 50, 4, 0, 4, false));
            list.Add(new Item(0, "Spiked Whip", "Make them bleed", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 4, 50, 4, 0, 4, false));
            list.Add(new Item(0, "Steel Whip", "Leaves brutal lacerations and can even break bones", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 3, 50, 4, 0, 4, false));
            list.Add(new Item(0, "Leather Whip", "This is why they call us crackers", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 2, 50, 4, 0, 4, false));

            // Fencing tree, Moderate damage, High accuracy, Medium burst
            list.Add(new Item(0, "E-Saber", "An elegant weapon for a more civilized age", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 6, 75, 3, 0, 2, false));
            list.Add(new Item(0, "Rapier", "A slender rod of steel, good for poking out eyes", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 4, 75, 3, 0, 2, false));
            list.Add(new Item(0, "Epee", "A sharpened Piece of aluminum", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 3, 75, 3, 0, 2, false));
            list.Add(new Item(0, "Fire Poker", "Move logs, rupture organs", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, true, 2, 70, 3, 0, 2, false));

            // Ranged Weapons
            // list.Add(new Item(0, "", "", 0, false, 0, 0, false,  0, 0, 0, 0, 0, 0, 0, false, 0, 0, 0, 0, 0, true/false));
            // Clean slate ^^^^^^^^^^   id name description amount stackable weight use consumeable slot hp armor str dex int autism melee damage accuracy burst ammo range twohanded

            // Rifle tree, Medium damage, Medium Accuracy, Medium Burst
            list.Add(new Item(0, "Laser Rifle","Flashlight", 0, false, 0, 0,false, 0, 0, 0, 0, 0, 0, 0, false, 10, 30, 6, 30, 10, true));
            list.Add(new Item(0, "Kalashnikov", "Trustworthy and powerful", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, false, 8, 25, 0, 0, 10, true));
            list.Add(new Item(0, "Ar-15", "49 faggots and one dune doon", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, false, 6, 25, 0, 0, 10, true));
            list.Add(new Item(0, "Air Rifle", "A toy", 0, false, 0, 0, false, 0, 0, 0, 0, 0, 0, 0, false, 3, 20, 10, 60, 7, true));

            // Sniper tree

            // Lmg tree

            




        }

    }
}
