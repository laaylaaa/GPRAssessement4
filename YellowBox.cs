// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

// -------- YELLOW BOX FUNCTIONALITY ---------

public class YellowBox : MonoBehaviour
{
    // true or false for if object is correct
    public bool yellowBoxDone;
    // holds text for if they put wrong colour in and the door which closes when box is placed correct 
    public GameObject correctColourPlease, boxDoor;

    // if the correct box "YellowBox" collides with the placement then sets the bool to true and actives the door
    // prints a debug.log for checking purposes.
    // if the collision is with the player, do nothing 
    // if the collision is with the wrong box then send it to the "BoxRespawn" and set the text to true
    // also checks to make sure the text isnt already set to true
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "YellowBox")
        {
            yellowBoxDone = true;
            boxDoor.SetActive(true);
            Debug.Log("Yellow Place Correct ");// for checking 
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            return; // do nothing 
        }
        else if (collision.gameObject.name != "YellowBox")
        {
            if (correctColourPlease.activeSelf == false)
            {
                collision.transform.position = GameObject.Find("BoxRespawn").transform.position;// move the wrong box to the box respawn
                correctColourPlease.SetActive(true);
            }
            else
            {
                collision.transform.position = GameObject.Find("BoxRespawn").transform.position;// move the wrong box to the box respawn
                return; 
            }
        }
    }
}
