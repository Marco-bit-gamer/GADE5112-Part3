using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6122_Part_1_Marco_st10037536
{
    internal class MeleeWeapon : Weapon
    {
        private int Damage;
        private int Durability;
        private int Cost;
        private string WeaponType;
        private int range;
        private int Number;
        public Dagger(int damage,int range, int durability, int cost, string weaponType, int number) : base(damage,range, durability, cost, weaponType, number)
        {
            this.Damage = damage;
            this.Durability = durability;
            this.Cost = cost;
            this.WeaponType = weaponType;
            this.Number = number;   
        }

        public Longsword(int damage,int range, int durability, int cost, string weaponType, int number) : base(damage,range, durability, cost, weaponType, number)
        {
            this.Damage = damage;
            this.Durability = durability;
            this.Cost = cost;
            this.WeaponType = weaponType;
            this.Number = number;
        }

        public MeleeWeapon(int type, int x, int y) : base(type, x, y)
        {
            Random random = new Random();
            x = random.Next(1,9);
            y = random.Next(1,15);
            type = random.Next(1,3);

            if (type == 1)
            {
                Damage = 3;
                Durability = 3;
                Cost = 3;
                WeaponType = "Dagger";
                return;
            }

            if(type == 2)
            {
                Damage = 4;
                Durability = 6;
                Cost = 5;
                WeaponType = "Longsword";
                return;
            }

        }

        public int Range { get { return range = 1; } }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        enum Types
        {
            Dagger,
            Longsword
        }
    }
}
