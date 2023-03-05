using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static void Test()
    {
        //damage, health, armor, money
        Mage mage = new Mage(300, 500, 350, 666);
        Archer archer = new Archer(100, 750, 200, 555);
        Knight knight = new Knight(200, 1000, 400, 888);
        
        mage.InputDamage(archer.getDamage());    //-100hp
        archer.InputDamage(knight.getDamage());    //-200hp       
        knight.InputDamage(mage.getDamage());    //-300hp

        Unit currentUnit = mage;
        currentUnit.Attack(mage.getHealth());

        currentUnit = archer;
        currentUnit.Attack(archer.getHealth());

        currentUnit = knight;
        currentUnit.Attack(knight.getHealth());

        mage.ShowInfo();
        archer.ShowInfo();
        knight.ShowInfo();
    }
}