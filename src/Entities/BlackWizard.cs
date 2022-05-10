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
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia Negra Super efetiva com bonus de  " + Bonus;
            }
            else{
                return this.Name + " Lançou uma Magia Negra com força fraca com bonus de " + Bonus;
            }
        
            
        }
    }
}