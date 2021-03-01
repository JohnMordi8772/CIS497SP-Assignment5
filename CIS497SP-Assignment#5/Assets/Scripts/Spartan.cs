/* 
 * John Mordi
 * Spartan.cs
 * Assignment #5
 * necessary stats and functions for a spartan unit
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spartan : Entity
{
    string title = "Spartan";
    string weapon = "Spear and Shield";
    int dmg = 10;
    int cost = 35;
    
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
