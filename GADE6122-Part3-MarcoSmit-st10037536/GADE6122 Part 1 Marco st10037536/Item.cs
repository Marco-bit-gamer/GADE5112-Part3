using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6122_Part_1_Marco_st10037536
{
    abstract class Item : Tile
    {
        private int cost;
        private int weaponType;
        private string weaponType1;
        private int type;
        private int v;

        public Item(int x, int y) : base(x, y)
        {

        }

        public Item(int x, int y, int v) : this(x, y)
        {
            this.v = v;
        }

        public Item(int x, int y, int cost, int weaponType) : this(x, y)
        {
            this.cost = cost;
            this.weaponType = weaponType;
        }

        public Item(int x, int y, int cost, int weaponType, string weaponType1) : this(x, y, cost, weaponType)
        {
            this.weaponType1 = weaponType1;
        }

        public Item(int x, int y, int cost, int weaponType, string weaponType1, int type) : this(x, y, cost, weaponType, weaponType1)
        {
            this.type = type;
        }

        public abstract override string ToString();
    }
}
