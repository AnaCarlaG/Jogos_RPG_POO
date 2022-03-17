namespace Jogos_RPG_POO.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set;}
        public int Level { get; set;}
        public string HeroType { get; set;}

        public Hero()
        {
            
        }
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + 
                    "\nLevel: " + this.Level + 
                    "\nHero Type: " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + "atacou com a espada";
        }
    }
}