using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Unit
{
    public Knight(int damage, int health, int armor, int money) : base(damage, health, armor, money) { }

    public override void Attack(int damage)
    {
        System.Console.WriteLine($"My sword has caught up with you {damage}");
    }
}
