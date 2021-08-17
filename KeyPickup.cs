// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// ------ PICKING UP THE KEY FUNCTIONALITY --------
// got this from a previous project I done :)

public class KeyPickup : MonoBehaviour
{
    [SerializeField]
    private Text pickUpText; // text for telling players how to pick up 

    // object to hold the key 
    public GameObject key; 

    // bool to ensure player can pick up the key
    private bool pickUpAllowed;

    // bool to check if the key is picked up 
    public bool keyPickedUp; 

    // Use this for initialisation
    private void Start()
    {
        pickUpText.gameObject.SetActive(false); // makes sure its set to false when game starts 
    }

    //Update is called once per frame
    private void Update()
    {
        // if pickupAllowed is true and the key E is pressed then call the pick up function 
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp(); 
    }

    // checks if player triggers the key object, if so sets the pick up text to active and changes bool
    // to allow them to pick up the key 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    // if they arent on the key make sure they cant pick it up 
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    // pick up function turns off the key object and tells code that the key has been picked up 
    private void PickUp()
    {
        key.SetActive(false); 
        keyPickedUp = true; 
    }

}
