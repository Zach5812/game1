Attack Punch = new Attack("Punch", 5);
Attack Kick = new Attack("Kick", 10);
Attack Fireball = new Attack("Fireball", 25);

Enemy Bob = new Enemy("Bob", 100);
Bob.AttackList.Add(Kick);
Bob.AttackList.Add(Punch);
Bob.AttackList.Add(Fireball);

Console.WriteLine(Bob.RandomAttack(Bob.AttackList).Name);
