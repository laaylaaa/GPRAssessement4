// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// -------- CHANGE THE SCENE WITH A COLLISION(TRIGGERED) --------

public class ChangeSceneTrigger : MonoBehaviour
{
    [SerializeField] private string loadLevel; // get level to load 

    // if player collides with the game object with this code, load the scene needed 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(loadLevel);
        }
    }

}
