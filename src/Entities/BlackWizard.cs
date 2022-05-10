namespace Desafio_RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name,int Level,string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lan�ou Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lan�ou Magia Negra Super efetiva com bonus de  " + Bonus;
            }
            else{
                return this.Name + " Lan�ou uma Magia Negra com for�a fraca com bonus de " + Bonus;
            }
        
            
        }
    }
}