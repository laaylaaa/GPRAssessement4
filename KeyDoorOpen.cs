// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ------- SIMPLE DOOR AND KEY OPENING SYSTEM --------

public class KeyDoorOpen : MonoBehaviour
{
    // both key and door object
    public GameObject key, door; 

    // KeyPickUp script reference 
    KeyPickup keyPickup; 

    // Start is called before the first frame update
    void Start()
    {
        keyPickup = key.GetComponent<KeyPickup>(); // Getting the script component 
    }

    // check the collision, if the player collides with the door, and they have a key open the door
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(keyPickup.keyPickedUp == true)
            {
                door.SetActive(false); 
            }
        }
    }
}
