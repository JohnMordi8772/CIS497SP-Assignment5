/* 
 * John Mordi
 * SuperSoldier.cs
 * Assignment #5
 * necessary stats and functions for a super soldier unit
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuperSoldier : Entity
{
    string title = "Super Soldier";
    string weapon = "Space Gun";
    int dmg = 15;
    int cost = 50;
    
    public override int GetCost()
    {
        return cost;
    }

    public override int GetDmg()
    {
        return dmg;
    }

    public override string GetTitle()
    {
        return title;
    }

    public override string GetWeapon()
    {
        return weapon;
    }

}
