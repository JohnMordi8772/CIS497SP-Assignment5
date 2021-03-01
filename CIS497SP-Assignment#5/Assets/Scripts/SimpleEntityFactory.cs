/* 
 * John Mordi
 * SimpleEntityFactory.cs
 * Assignment #5
 * Sets up all instantiation of entities and displays their stats for player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleEntityFactory : MonoBehaviour
{
    public Entity[] entities = new Entity[3];
    private int toInstantiate = 0;
    public Text statText;
    Entity toSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        statText.text = "Name: " + entities[toInstantiate].GetTitle() + "\nWeapon: " + entities[toInstantiate].GetWeapon() + "\nDamage: " + entities[toInstantiate].GetDmg() + "\nCost: $" + entities[toInstantiate].GetCost();
    }

    public Entity SetUpChoice()
    {
        if(toInstantiate == 0)
        {
            toSpawn = entities[0];
            if (toSpawn.gameObject.GetComponent<Caveman>() == null)
                toSpawn.gameObject.AddComponent<Caveman>();
        }
        else if(toInstantiate == 1)
        {
            toSpawn = entities[1];
            if (toSpawn.gameObject.GetComponent<Spartan>() == null)
                toSpawn.gameObject.AddComponent<Spartan>();
        }
        else
        {
            toSpawn = entities[2];
            if (toSpawn.gameObject.GetComponent<SuperSoldier>() == null)
                toSpawn.gameObject.AddComponent<SuperSoldier>();
        }
        
        return toSpawn;
    }

    public void CavemanChoice()
    {
        toInstantiate = 0;
        
    }
    public void SpartanChoice()
    {
        toInstantiate = 1;
    }
    public void SuperSoldierChoice()
    {
        toInstantiate = 2;
    }
}
