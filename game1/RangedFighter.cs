class RangedFighter : Enemy
{
    public int Distance;

    public RangedFighter(string name, int health, int distance = 5) : base(name, health)
    {
        AttackList = new List<Attack>()
{
    new Attack("Arrow", 20),
    new Attack("Knife", 15)
};
    }
    public void RangedAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Distance<10)
        {
        Target.Health = Target.Health - ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
        }
        else
        {
            Console.WriteLine($"{Name} was too far away from {Target.Name} to make an attack.");
        }
    }
    public int Dash()
    {
        return Distance = 20;
    }
}