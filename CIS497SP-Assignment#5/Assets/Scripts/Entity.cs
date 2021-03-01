/* 
 * John Mordi
 * Entity.cs
 * Assignment #5
 * methods necessary for all children of Entity
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Entity : MonoBehaviour
{
    
    void Attack()
    {
        //implemented in game
    }
    void Move()
    {
        //implemented in game
    }

    public abstract string GetTitle();
    public abstract string GetWeapon();
    public abstract int GetDmg();
    public abstract int GetCost();
}
