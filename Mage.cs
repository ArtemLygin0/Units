using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Unit
{
    
public Mage(int damage, int health, int armor, int money) : base(damage, health, armor, money) { }

    

    public override void Attack(int damage)
    {
        System.Console.WriteLine($"Lololo damage {damage}");
    }


    /*
    Spell spell = Spell.FIREBALL;
     switch (Spell)
     {
        case Spell.FIREBALL:
            System.Console.WriteLine("Огненный шар");
            break;
        case Spell.ICEPRICK
            System.Console.WriteLine("Ледяной укол");
            break;
        case Spell.POISONCLOUD:
            System.Console.WriteLine("Отравленное облако");
            break;
    
     }
    */
}