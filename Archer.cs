using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Unit
{
    public Archer(int damage, int health, int armor, int money) : base (damage, health, armor, money) { }

    public override void Attack(int damage)
    {
        System.Console.WriteLine($"I'm good Aimer {damage}");
    }
}
