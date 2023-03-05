using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    protected int Damage;
    protected int Health;
    protected int Armor;
    protected int Money;

    protected Unit (int damage, int health, int armor, int money)
    {
        Damage = damage;        
        Health = health;
        Armor = armor;
        Money = money;
    }

    public abstract void Attack(int damage);

    public void InputDamage(int damage)
    {
        if (Armor > damage)     //Если защита больше урона
            Armor -= damage;
        else                    //Если защита меньше урона
        {
            Health += Armor - damage;
            Armor = 0;
        }
        
        if (Health <= 0)
            System.Console.WriteLine("Персонаж погиб");
    }

    public void ShowInfo()
    {
        System.Console.WriteLine($"Damage: {Damage}");
        System.Console.WriteLine($"Health: {Health}");
        System.Console.WriteLine($"Armor: {Armor}");
        System.Console.WriteLine($"Money: {Money}");
    }

    public int getDamage() { return Damage; }
    public void setDamage(int damage) { Damage = damage; }

    public int getHealth() { return Health; }
    public void setHealth(int health) { Health = health; }

    public int getArmor() { return Armor; }
    public void setArmor(int armor) { Armor = armor; }

    public int getMoney() { return Money; }
    public void setMoney(int money) { Money = money; }
}