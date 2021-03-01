/* 
 * John Mordi
 * MouseClick.cs
 * Assignment #5
 * Gives player control over placement of units with mouseclicks and allows player to reset level
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MouseClick : MonoBehaviour
{
    //public List<GameObject> entities = new List<GameObject>();
    public SimpleEntityFactory factory;
    Entity toSpawn;
    public Text cashText;
    int cash = 500;

    // Update is called once per frame
    void Update()
    {
        cashText.text = "Cash: $" + cash;
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            toSpawn = factory.SetUpChoice();

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == "Ground" && toSpawn.GetCost() <= cash)
                {
                    Instantiate(toSpawn.gameObject, hitInfo.point, toSpawn.gameObject.transform.rotation, null);
                    cash -= toSpawn.GetCost();
                }
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag != "Ground")
                {
                    cash += hitInfo.collider.gameObject.GetComponent<Entity>().GetCost();
                    Destroy(hitInfo.collider.gameObject);
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
