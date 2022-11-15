using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_Part_1_Marco_st10037536
{
    internal class Shop
    {
        private string[] weapon = new string[3];
        private Random Random = new Random();
        private Character GoldCount;

        public Buyer(double Amount)
        {
            Amount = Character.GoldCount.Value;
        }

        public int AmountGold { get => amountGold; set => amountGold = value; }
        public double Amount { get; set; }  
        public RandomWeapon()
        {
            weapon = new string[WeweaponType(Random)]; 
        }
    }
}
