// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

// -------- CLICK COUNT FOR LEVEL 6 ---------
// I had to adapt the click count for level 6 to make it different from the video since it wouldnt work for my case
// I wrote this so that it works with counting how many times they press space when they can

public class ClickCount : MonoBehaviour
{
    // int to hold the count amount
    public int count;

    // to set the text for the moves
    public Text text;
    // bool to check that player is in the right place to make a move
    public bool countAllowed;
    // holds game over so it can display when they run outta moves 
    public GameObject gameOverPanel;

    // holds all the boxes they are meant to space bar to get the counts up
    public List<GameObject> boxes; 

     void Update(){

        // sets the texts and constantly updates it 
        text.text = "Moves: " + count;  

        // if they are allowed to make a move and if they press space take away one from the count
        if(countAllowed && Input.GetKeyDown(KeyCode.Space))
        {
            count -= 1;
        }

        // if count is less then 0 its game over
        if (count <= 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f; // sets time to stop time 
        }
        else
        {
            Time.timeScale = 1f; // keeps time going 
        }
     }

    // if player collides with any of the boxes in the whole list then make countAllowed true
    private void OnTriggerEnter2D(Collider2D collision)
    {
       for(int i = 0; i < boxes.Count; i++)
        {
            if(collision.gameObject == boxes[i])
            {
                countAllowed = true;
            }
        }
    }

    // if they are not on the object, make sure they can add to the count for moves 
    private void OnTriggerExit2D(Collider2D collision)
    {
        for (int i = 0; i < boxes.Count; i++)
        {
            if (collision.gameObject == boxes[i])
            {
                countAllowed = false;
            }
        }
    }
}
