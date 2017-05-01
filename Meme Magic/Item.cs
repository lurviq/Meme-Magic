using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Item
    {
        // Ubiquitous values
        int identification;
        string description;
        string name;
        int strengthBoost;
        int dexterityBoost;
        int intelligenceBoost;
        int autismBoost;
        int healthBoost;
        int armorBoost;
        int slot;
        int use;
        bool consume;
        float weight;
        int amount;
        bool stackable;
        // Weapon Stats
        bool melee;
        float range;
        int ammo;
        int damage;
        int accuracy;
        int burst;
        bool twohanded;
        public Item(int id, string whatName,string whatDescription, int howmany , bool stackable,float howHeavy, int useable, bool consumable, int slotnumber = 0, int hpBoost = 0, int armorBoost = 0, int strBoost = 0, int dexBoost = 0, int intBoost = 0, int autismBoost = 0,bool isMelee = false,int whatDamage = 0,int whatAccuracy = 0,int whatBurst = 0,int whatAmmo = 0,float whatRange = 0, bool twoHanded = false)

        {
            melee = isMelee;
            name = whatName;
            ammo = whatAmmo;
            damage = whatDamage;
            accuracy = whatAccuracy;
            burst = whatBurst;

        }
    }
}
