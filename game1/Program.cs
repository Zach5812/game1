Attack Punch = new Attack("Punch", 5);
Attack Kick = new Attack("Kick", 10);
Attack Fireball = new Attack("Fireball", 25);

Enemy Bob = new Enemy("Bob", 100);
Bob.AttackList.Add(Kick);
Bob.AttackList.Add(Punch);
Bob.AttackList.Add(Fireball);

// Initilizing Jim
Enemy Jim = new Enemy("Jim", 100);
Jim.AttackList.Add(Kick);
Jim.AttackList.Add(Punch);
Jim.AttackList.Add(Fireball);

Bob.RandomAttack(Bob.AttackList);
Bob.PerformAttack(Jim, Bob.AttackList[1]);

MeleeFighter John = new MeleeFighter("John");
John.Rage(Jim);
John.PerformAttack(Jim, John.AttackList[0]);
John.PerformAttack(Jim, John.AttackList[1]);
John.PerformAttack(Jim, John.AttackList[2]);

RangedFighter Jerry = new RangedFighter("Jerry", 100);
Jerry.RangedAttack(John, Jerry.AttackList[0]);
Jerry.RangedAttack(John, Jerry.AttackList[1]);
Jerry.Dash();
Jerry.RangedAttack(John, Jerry.AttackList[1]);

MagicCaster Donald = new MagicCaster("Donald");
Donald.PerformAttack(Bob, Donald.AttackList[0]);
Donald.PerformAttack(Bob, Donald.AttackList[1]);
Donald.PerformAttack(Bob, Donald.AttackList[2]);
Donald.Heal(Bob);
Jerry.RangedAttack(John, Jerry.AttackList[1]);
Donald.Heal(Donald);


