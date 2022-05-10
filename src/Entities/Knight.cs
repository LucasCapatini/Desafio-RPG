namespace Desafio_RPG.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name,int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com a Espada";
        }

        public string Attack(int Critico)
        {
            if (Critico > 5)
            {
                return this.Name + " Atacou com a Espada e deu  " + Critico + " de dano Critico!!";
            }
            else{
                return this.Name + " Lançou um ataque basico de " + Critico + " de dano";
            }
    }
    }
}