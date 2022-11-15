using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GADE6122_Part_1_Marco_st10037536.Character;

namespace GADE6122_Part_1_Marco_st10037536
{
    internal class Leader : Item

    {
        private int Hp;
        private int MaxHp;
        private int Dmg;
        private Leader(int x, int y, int hp, int maxHp, int dmg) : base(x, y, hp, 20, 2)
        {
            this.Hp = hp;
            this.MaxHp = maxHp;
            this.Dmg = dmg;
            TileSight = new Tile[4];
        }

        public new int Damage
        {
            get { return Dmg; }
            set { Dmg = value; }
        }

        public new int HP
        {
            get { return Hp; }
            set { Hp = value; }
        }

        public new int Max_HP
        {
            get { return MaxHp; }
            set { MaxHp = value; }
        }


        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.Up)
        {
            throw new NotImplementedException();
        }

        public Tile[] TileSight;

        public override string ToString()
        {
            return $"Leader at [{X}, {Y}] ({Damage}) HP: {HP}";
        }

        internal void Move(Character.MovementEnum direction)
        {
            throw new NotImplementedException();
        }
    }
}
