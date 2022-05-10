namespace Desafio_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name,int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com a Kunai";
        }

        public string Attack(int Jutsu)
        {
            if (Jutsu > 5)
            {
                return this.Name + " Atacou com a Kunai e usuou um Jutsu avançado para dar " + Jutsu + " a mais de dano!";
            }
            else{
                return this.Name + " Usou um Jutsu basico e deu " + Jutsu + " a mais de dano";
            }
    }
    }
}