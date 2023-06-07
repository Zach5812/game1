public class Enemy
{
    public string Name;
    public int Health;
    public List<Attack> AttackList = new List<Attack>();

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }
    public Attack RandomAttack(List<Attack> AttackList)
    {
        Random rand = new Random();
        int AttackListPos = rand.Next(0, AttackList.Count);
        return AttackList[AttackListPos];
    }



    public void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        
        Target.Health = Target.Health - ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }


}