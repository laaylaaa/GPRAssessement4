// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

// ---------- WARNING TEXT FUNCTIONALITY -----------
// used in level 1

public class MessagePopUp : MonoBehaviour
{
    // object to hold the text 
    public GameObject warningText;

    // if player triggers the object, then set the warning text to active
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            warningText.SetActive(true); 
        }
    }
}
