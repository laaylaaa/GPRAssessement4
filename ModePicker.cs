// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// --------- CHECKING IF THEY PICKED HARD OR EASY --------------- 
// ( I wrote this code to use it for an idea I had but didnt really work but im not sure
//   if i actually use this for anything but thought I might as well keep it in case) 
// works well for checking in the modes scenes 

public class ModePicker : MonoBehaviour
{ 
    // bool to set to true is easy or hard was selected
    public bool easyModeSelected, hardModeSelected = false;

    // getting the two buttons being clicked
    public Button hardButton, easyButton; 

    // Start is called before the first frame update
    void Start()
    {
        // get the button component
        Button btn = hardButton.GetComponent<Button>();
        Button btn2 = easyButton.GetComponent<Button>();

        // check which button was clicked and call the function to run depending on it 
        btn.onClick.AddListener(HardMode);
        btn2.onClick.AddListener(EasyMode);
    }

    // prints out that easy mode was picked and change the bool to true
    void EasyMode()
    {
        easyModeSelected = true; 
        print("Easy Mode picked " + easyModeSelected);
    }

    // prints out that hard mode was picked and change the bool to true
    void HardMode()
    {
        hardModeSelected = true;
        print("Hard Mode picked " + hardModeSelected);
    }

}
