class MeleeFighter : Enemy
{

    public MeleeFighter(string name, int health = 120) : base(name, health)
    {
        AttackList = new List<Attack>()
{
    new Attack("Punch", 20),
    new Attack("Kick", 10),
    new Attack("Tackle", 25)
};
    }
    public void Rage(Enemy Target)
    {
        Random rand = new Random();
        int AttackListPos = rand.Next(0, AttackList.Count);
        AttackList[AttackListPos].DamageAmount += 10;
        PerformAttack(Target, AttackList[AttackListPos]);
        AttackList[AttackListPos].DamageAmount -= 10;
    }
}