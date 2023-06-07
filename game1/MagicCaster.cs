class MagicCaster : Enemy
{

    public MagicCaster(string name, int health = 80) : base(name, health)
    {
        AttackList = new List<Attack>()
{
    new Attack("Fireball", 25),
    new Attack("Lightning Bolt", 20),
    new Attack("Staff Strike", 10)
};
    }
    public void Heal(Enemy Target)
    {
        Target.Health +=40;
        Console.WriteLine($"{Target.Name}'s health is {Target.Health}");
    }
}