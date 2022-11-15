using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_Part_1_Marco_st10037536
{
    internal class RangedWeapon : Weapon
    {
        private int Damage;
        private int Durability;
        private int Cost;
        private string WeaponType;
        private int Range;
        private int Number;
        public Rifle(int damage,int range, int durability, int cost, string weaponType, int number) : base(damage, range, durability, cost, weaponType, number)
        {
            this.Damage = damage;
            this.Durability = durability;
            this.Cost = cost;
            this.WeaponType = weaponType;
            this.Number = number;
            this.Range = range;
        }

        public Longbow(int damage,int range, int durability, int cost, string weaponType, int number) : base(damage, range, durability, cost, weaponType, number)
        {
            this.Damage = damage;
            this.Durability = durability;
            this.Cost = cost;
            this.WeaponType = weaponType;
            this.Number = number;
            this.Range = range;
        }

        public RangedWeapon(int type, int x, int y) : base(type, x, y)
        {
            Random random = new Random();
            x = random.Next(1, 9);
            y = random.Next(1, 15);
            type = random.Next(1, 3);

            if (type == 1)
            {
                Damage = 5;
                Durability = 3;
                Cost = 7;
                Range = 3;
                WeaponType = "Rifle";
            }

            if (type == 2)
            {
                Damage = 4;
                Durability = 4;
                Cost = 6;
                Range = 2;
                WeaponType = "Longbow";
            }

        }


        public override string ToString()
        {
            throw new NotImplementedException();
        }

        enum Types
        {
            Rifle,
            Longbow
        }
    }
}
