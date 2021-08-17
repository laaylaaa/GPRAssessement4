// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ------- MANAGES LEVEL 5 TO WORK --------

public class Level5Manager : MonoBehaviour
{
    // References to all the box scripts
    // (I KNOW THERE IS PROBABLY AN EASIER WAY TO DO THIS BUT I TRIED 
    // SO MANY WAYS THIS WAY WORKS THE BEST)
    private BlueBox blueBox;
    private GreenBox greenBox;
    private OrangeBox orangeBox;
    private PinkBox pinkBox;
    private YellowBox yellowBox;

    // door which has to disappear
    public GameObject door;

    // setting the objects for the scripts 
    public GameObject blue, green, orange, pink, yellow; 

    private void Start()
    {
        // calling scripts from these objects 
        blueBox = blue.GetComponent<BlueBox>();
        greenBox = green.GetComponent<GreenBox>();
        orangeBox = orange.GetComponent<OrangeBox>();
        pinkBox = pink.GetComponent<PinkBox>();
        yellowBox = yellow.GetComponent<YellowBox>();
    }

    // keep checking if all the boxes are correct, if so open the door
    public void Update()
    {
        // if all the boxes are place correctly then open the door 
        if (blueBox.blueBoxDone == true && greenBox.greenBoxDone == true && orangeBox.orangeBoxDone == true && pinkBox.pinkBoxDone == true && yellowBox.yellowBoxDone == true) 
            door.SetActive(false); // deactivate the door 
    }
}
