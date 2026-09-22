using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Mage : Hero
    {
        public int mana;
        private int spellPower;

        public override void Attack(GameEntity target)
        {
            base.Attack(target);
        }

        public void CastSpell(GameEntity target) { }
    }
}
