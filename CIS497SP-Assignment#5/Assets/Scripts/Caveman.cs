/* 
 * John Mordi
 * Caveman.cs
 * Assignment #5
 * necessary stats and functions for a caveman unit
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caveman : Entity
{
    string title = "Caveman";
    string weapon = "Club";
    int dmg = 5;
    int cost = 20;

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
