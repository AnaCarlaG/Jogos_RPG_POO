using System;

namespace Jogos_RPG_POO.src.Entities
{
    public class Wizard : Hero
    {
        
        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public override string Attack(){
            return this.Name + "lançou magia";
        }
        public string Attack(int bonus){
            if(bonus>6){
                return this.Name + "Lançou magia super efetiva com bonus de " + bonus;
            }
            else{
                return this.Name + "Lançou magia com força fraca com bonus de " + bonus;
            }
        }
    }
}