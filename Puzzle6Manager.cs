// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// https://www.youtube.com/watch?v=iwTf1yrq6-s
// used this youtube video to get the main idea on how to make and code this puzzle 
// changed it to be instead of clicking its if they click space and 
// made the box the player is on change as well

// -------- PUZZLE CODE FOR LEVEL 6 --------
// Lights out Puzzle - When player clicks one of the lights to it changes to either on or off
// depending on what it is set on once they move over the box object. 
// objective is to get all the lights to be off at the same time to win

public class Puzzle6Manager : MonoBehaviour
{
    // containing all the boxes both off and on versions
    // 0-8 is off 9-17 is on 
    public List<GameObject> boxes;

    // door for the key which has to be activated when they won and the win text
    public GameObject door, winText;

    // detect if objects have been destroyed and if key press is allowed to happen
    private bool destroyed, keyPressAllowed;

    // Update is called once per frame
    void Update()
    {
        // if they are on the object and they press E then do the puzzle
        if(keyPressAllowed && Input.GetKeyDown(KeyCode.Space))
        {
            // puzzle function
            PuzzleCheck(gameObject);
        }

        // check if all of the OFF boxes are active at the same time 
        if (boxes[0].activeInHierarchy && boxes[1].activeInHierarchy && boxes[2].activeInHierarchy 
            && boxes[3].activeInHierarchy && boxes[4].activeInHierarchy && boxes[5].activeInHierarchy && boxes[6].activeInHierarchy && boxes[7].activeInHierarchy && boxes[8].activeInHierarchy)
        {
            // destroys the boxes 
            Destroy(boxes[0]);
            Destroy(boxes[1]);
            Destroy(boxes[2]);
            Destroy(boxes[3]);
            Destroy(boxes[4]);
            Destroy(boxes[5]);
            Destroy(boxes[6]);
            Destroy(boxes[7]);
            Destroy(boxes[8]);

            // player wins! 
            winText.SetActive(true); 
            door.SetActive(false);// open the door
            destroyed = true;
        }
    }

    // check if the player is ontop of the object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            keyPressAllowed = true;
        }
    }
    // if there off it dont let them change it 
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            keyPressAllowed = false; 
        }
    }

    // checks every single box to see which game objects in the hierarchy is active currently
    // and chnage it to be fit to what it needs to be
    private void PuzzleCheck(GameObject box)
    {
        // if object is box 1
        if (box.gameObject.CompareTag("Box1"))
        {
            // TOP LEFT BOX --- CHANGES RIGHT AND BELOW
            // if box 2 ON is active (to the right of box 1)
            if (boxes[10].activeInHierarchy)
            {
                // disable box 2 ON
                boxes[10].SetActive(false);
                // activate other box 2 OFF 
                boxes[1].SetActive(true);
            }
            else if (boxes[1].activeInHierarchy)
            { // if box 2 is OFF

                // disable other box 2 OFF
                boxes[1].SetActive(false);
                // enable ON
                boxes[10].SetActive(true);
            }

            // if box 4 is ON (below box 1)
            if (boxes[12].activeInHierarchy)
            {
                boxes[12].SetActive(false);
                // activate it OFF
                boxes[3].SetActive(true);
            }
            else if (boxes[3].activeInHierarchy)
            {
                boxes[3].SetActive(false);
                // activate it ON
                boxes[12].SetActive(true);
            }

            // Change box player is on!
            if (boxes[0].activeInHierarchy)
            {
                boxes[0].SetActive(false);
                boxes[9].SetActive(true);
            }
            else if(boxes[9].activeInHierarchy){
                boxes[9].SetActive(false);
                boxes[0].SetActive(true);
            }
        }

        // if object is box 2
        if (box.gameObject.CompareTag("Box2"))
        {
            // TOP MIDDLE BOX --- CHANGES RIGHT, LEFT AND BELOW
            // if box 1 ON is active (right of box 2)
            if (boxes[9].activeInHierarchy)
            {
                boxes[9].SetActive(false);
                // activate it OFF
                boxes[0].SetActive(true);
            }
            else if (boxes[0].activeInHierarchy)
            { // if box 1 is OFF

                boxes[0].SetActive(false);
                // activate it ON
                boxes[9].SetActive(true);
            }

            // if box 3 is ON (left of box 2)
            if (boxes[11].activeInHierarchy)
            {
                boxes[11].SetActive(false);
                // activate it OFF
                boxes[2].SetActive(true);
            }
            else if (boxes[2].activeInHierarchy)
            {
                boxes[2].SetActive(false);
                // activate it ON
                boxes[11].SetActive(true);
            }

            // if box 5 is ON (below of box 2)
            if (boxes[13].activeInHierarchy)
            {
                boxes[13].SetActive(false);
                // activate it OFF
                boxes[4].SetActive(true);
            }
            else if (boxes[4].activeInHierarchy)
            {
                boxes[4].SetActive(false);
                // activate it ON
                boxes[13].SetActive(true);
            }

            // Change box player is on!
            if (boxes[1].activeInHierarchy)
            {
                boxes[1].SetActive(false);
                boxes[10].SetActive(true);
            }
            else if (boxes[10].activeInHierarchy)
            {
                boxes[10].SetActive(false);
                boxes[1].SetActive(true);
            }
        }

        // if object is box 3
        if (box.gameObject.CompareTag("Box3"))
        {
            // TOP RIGHT BOX --- CHANGES LEFT AND BELOW
            // if box 2 ON is active (left of box 3)
            if (boxes[10].activeInHierarchy)
            {
                boxes[10].SetActive(false);
                // activate it OFF
                boxes[1].SetActive(true);
            }
            else if (boxes[1].activeInHierarchy)
            { // if box 2 is OFF

                // disable OFF
                boxes[1].SetActive(false);
                // activate it ON
                boxes[10].SetActive(true);
            }

            // if box 6 is ON (below box 3)
            if (boxes[14].activeInHierarchy)
            {
                boxes[14].SetActive(false);
                // activate it OFF
                boxes[5].SetActive(true);
            }
            else if (boxes[5].activeInHierarchy)
            {
                boxes[5].SetActive(false);
                // activate it ON
                boxes[14].SetActive(true);
            }

            // Change box player is on!
            if (boxes[2].activeInHierarchy)
            {
                boxes[2].SetActive(false);
                boxes[11].SetActive(true);
            }
            else if (boxes[11].activeInHierarchy)
            {
                boxes[11].SetActive(false);
                boxes[2].SetActive(true);
            }
        }

        // if object is box 4
        if (box.gameObject.CompareTag("Box4"))
        {
            // LEFT MIDDLE BOX --- CHANGES ABOVE, BELOW AND RIGHT
            // if box 1 ON is active (above box 4)
            if (boxes[9].activeInHierarchy)
            {
                boxes[9].SetActive(false);
                // activate it OFF
                boxes[0].SetActive(true);
            }
            else if (boxes[0].activeInHierarchy)
            { // if box 1 is OFF

                boxes[0].SetActive(false);
                // activate it ON
                boxes[9].SetActive(true);
            }

            // if box 7 is ON (below box 4)
            if (boxes[15].activeInHierarchy)
            {
                boxes[15].SetActive(false);
                // activate it OFF
                boxes[6].SetActive(true);
            }
            else if (boxes[6].activeInHierarchy)
            {
                boxes[6].SetActive(false);
                // activate it ON
                boxes[15].SetActive(true);
            }

            // if box 5 is ON (right to box 4)
            if (boxes[13].activeInHierarchy)
            {
                boxes[13].SetActive(false);
                // activate it OFF
                boxes[4].SetActive(true);
            }
            else if (boxes[4].activeInHierarchy)
            {
                boxes[4].SetActive(false);
                // activate it ON
                boxes[13].SetActive(true);
            }

            // Change box player is on!
            if (boxes[3].activeInHierarchy)
            {
                boxes[3].SetActive(false);
                boxes[12].SetActive(true);
            }
            else if (boxes[12].activeInHierarchy)
            {
                boxes[12].SetActive(false);
                boxes[3].SetActive(true);
            }
        }

        // if object is box 5
        if (box.gameObject.CompareTag("Box5"))
        {
            // MIDDLE BOX --- CHANGES ABOVE, BELOW, LEFT AND RIGHT
            // if box 2 ON is active (above box 5)
            if (boxes[10].activeInHierarchy)
            {
                boxes[10].SetActive(false);
                // activate it OFF
                boxes[1].SetActive(true);
            }
            else if (boxes[1].activeInHierarchy)
            { // if box 2 is OFF

                boxes[1].SetActive(false);
                // activate it ON
                boxes[10].SetActive(true);
            }

            // if box 8 is ON (below box 5)
            if (boxes[16].activeInHierarchy)
            {
                boxes[16].SetActive(false);
                // activate it OFF
                boxes[7].SetActive(true);
            }
            else if (boxes[7].activeInHierarchy)
            {
                boxes[7].SetActive(false);
                // activate it ON
                boxes[16].SetActive(true);
            }

            // if box 4 is ON (left to box 5)
            if (boxes[12].activeInHierarchy)
            {
                boxes[12].SetActive(false);
                // activate it OFF
                boxes[3].SetActive(true);
            }
            else if (boxes[3].activeInHierarchy)
            {
                boxes[3].SetActive(false);
                // activate it ON
                boxes[12].SetActive(true);
            }

            // if box 6 is ON (right box 5)
            if (boxes[14].activeInHierarchy)
            {
                boxes[14].SetActive(false);
                // activate it OFF
                boxes[5].SetActive(true);
            }
            else if (boxes[5].activeInHierarchy)
            {
                boxes[5].SetActive(false);
                // activate it ON
                boxes[14].SetActive(true);
            }

            // Change box player is on!
            if (boxes[4].activeInHierarchy)
            {
                boxes[4].SetActive(false);
                boxes[13].SetActive(true);
            }
            else if (boxes[13].activeInHierarchy)
            {
                boxes[13].SetActive(false);
                boxes[4].SetActive(true);
            }
        }

        // if object is box 6
        if (box.gameObject.CompareTag("Box6"))
        {
            // RIGHT MIDDLE BOX --- CHANGES LEFT, ABOVE AND BELOW
            // if box 5 ON is active (left to box 6)
            if (boxes[13].activeInHierarchy)
            {
                boxes[13].SetActive(false);
                // activate it OFF
                boxes[4].SetActive(true);
            }
            else if (boxes[4].activeInHierarchy)
            { // if box 5 is OFF

                boxes[4].SetActive(false);
                // activate it ON
                boxes[13].SetActive(true);
            }

            // if box 3 is ON (above box 6)
            if (boxes[11].activeInHierarchy)
            {
                boxes[11].SetActive(false);
                // activate it OFF
                boxes[2].SetActive(true);
            }
            else if (boxes[2].activeInHierarchy)
            {
                boxes[2].SetActive(false);
                // activate it ON
                boxes[11].SetActive(true);
            }

            // if box 9 is ON (below box 6)
            if (boxes[17].activeInHierarchy)
            {
                boxes[17].SetActive(false);
                // activate it OFF
                boxes[8].SetActive(true);
            }
            else if (boxes[8].activeInHierarchy)
            {
                boxes[8].SetActive(false);
                // activate it ON
                boxes[17].SetActive(true);
            }

            // Change box player is on!
            if (boxes[5].activeInHierarchy)
            {
                boxes[5].SetActive(false);
                boxes[14].SetActive(true);
            }
            else if (boxes[14].activeInHierarchy)
            {
                boxes[14].SetActive(false);
                boxes[5].SetActive(true);
            }
        }

        // if box is button 7
        if (box.gameObject.CompareTag("Box7"))
        {
            // BOTTOM LEFT BOX --- CHANGES ABOVE AND RIGHT
            // if box 4 is ON (above box 7)
            if (boxes[12].activeInHierarchy)
            {
                boxes[12].SetActive(false);
                // activate it OFF
                boxes[3].SetActive(true);
            }
            else if (boxes[3].activeInHierarchy)
            {
                boxes[3].SetActive(false);
                // activate it ON
                boxes[12].SetActive(true);
            }

            // if box 8 is ON (right box 7)
            if (boxes[16].activeInHierarchy)
            {
                boxes[16].SetActive(false);
                // activate it OFF
                boxes[7].SetActive(true);
            }
            else if (boxes[7].activeInHierarchy)
            {
                boxes[7].SetActive(false);
                // activate it ON
                boxes[16].SetActive(true);
            }

            // Change box player is on!
            if (boxes[6].activeInHierarchy)
            {
                boxes[6].SetActive(false);
                boxes[15].SetActive(true);
            }
            else if (boxes[15].activeInHierarchy)
            {
                boxes[15].SetActive(false);
                boxes[6].SetActive(true);
            }
        }

        // if object is button 8
        if (box.gameObject.CompareTag("Box8"))
        {
            // BOTTOM MIDDLE BOX --- CHANGES ABOVE, LEFT AND RIGHT
            // if box 5 ON is active (above box 8)
            if (boxes[13].activeInHierarchy)
            {
                boxes[13].SetActive(false);
                // activate it OFF
                boxes[4].SetActive(true);
            }
            else if (boxes[4].activeInHierarchy)
            { // if box 5 is OFF

                boxes[4].SetActive(false);
                // activate it ON
                boxes[13].SetActive(true);
            }

            // if box 7 is ON (left to box 8)
            if (boxes[15].activeInHierarchy)
            {
                boxes[15].SetActive(false);
                // activate it OFF
                boxes[6].SetActive(true);
            }
            else if (boxes[6].activeInHierarchy)
            {
                boxes[6].SetActive(false);
                // activate it ON
                boxes[15].SetActive(true);
            }

            // if box 9 is ON (right to box 8)
            if (boxes[17].activeInHierarchy)
            {
                boxes[17].SetActive(false);
                // activate it OFF
                boxes[8].SetActive(true);
            }
            else if (boxes[8].activeInHierarchy)
            {
                boxes[8].SetActive(false);
                // activate it ON
                boxes[17].SetActive(true);
            }

            // Change box player is on!
            if (boxes[7].activeInHierarchy)
            {
                boxes[7].SetActive(false);
                boxes[16].SetActive(true);
            }
            else if (boxes[16].activeInHierarchy)
            {
                boxes[16].SetActive(false);
                boxes[7].SetActive(true);
            }
        }

        // if object is box 9
        if (box.gameObject.CompareTag("Box9"))
        {
            // BOTTOM RIGHT --- CHANGES ABOVE AND LEFT
            // if box 6 ON is active (above box 9)
            if (boxes[14].activeInHierarchy)
            {
                boxes[14].SetActive(false);
                // activate it OFF
                boxes[5].SetActive(true);
            }
            else if (boxes[5].activeInHierarchy)
            {
                boxes[5].SetActive(false);
                // activate it ON
                boxes[14].SetActive(true);
            }

            // if box 8 is ON (left to box 9)
            if (boxes[16].activeInHierarchy)
            {
                boxes[16].SetActive(false);
                // activate it OFF
                boxes[7].SetActive(true);
            }
            else if (boxes[7].activeInHierarchy)
            {
                boxes[7].SetActive(false);
                // activate it ON
                boxes[16].SetActive(true);
            }

            // Change box player is on!
            if (boxes[8].activeInHierarchy)
            {
                boxes[8].SetActive(false);
                boxes[17].SetActive(true);
            }
            else if (boxes[17].activeInHierarchy)
            {
                boxes[17].SetActive(false);
                boxes[8].SetActive(true);
            }
        }
    }
}