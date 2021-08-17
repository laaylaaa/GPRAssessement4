// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// -------- BASIC CLOSE DOORS FOR LEVEL 5 ---------

public class CloseDoors : MonoBehaviour
{
    // holds the doors 
    public GameObject doors;

    // checks if the player triggers the empty game object code is on, 
    // if so sets the doors active to close the player into the field with the boxes in level 5
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            doors.SetActive(true); 
        }
    }
}
