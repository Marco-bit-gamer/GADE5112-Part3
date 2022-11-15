using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_Part_1_Marco_st10037536
{
    abstract class Weapon : Item
    {
        private int Damage;
        private int Range;
        private int Durability;
        private int Cost;
        private string WeaponType;
        private int Type;
        protected Weapon(int damage,int range, int durability, int cost, string weaponType, int type) : base(damage,range, durability, cost, weaponType, type)
        {
            this.Damage = damage;
            this.Range = range; 
            this.Durability = durability;
            this.Cost = cost;
            this.WeaponType = weaponType;
            this.Type = type;
        }

        public weaponType(int x, int y, int type): base (x, y, 0)
        {
            switch (type)
            {
                case 1:
                    Damage = 3;
                    Durability = 3;
                    Cost = 3;
                    Range = 1;
                    WeaponType = "Dagger";
                    break;
                case 2:
                    Damage = 4;
                    Durability = 6;
                    Cost = 5;
                    Range = 1;
                    WeaponType = "Longsword";
                    break;
                case 3:
                    Damage = 5;
                    Durability = 3;
                    Cost = 7;
                    Range = 3;
                    WeaponType = "Rifle";
                    break;
                case 4:
                    Damage = 4;
                    Durability = 4;
                    Cost = 6;
                    Range = 2;
                    WeaponType = "Longbow";
                    break;
                case default:
                    Damage = 0;
                    Durability = 0;
                    Cost = 0;
                    Range = 0;
                    WeaponType = "Fist";
                    break;
            }
            return;

    }
}}
