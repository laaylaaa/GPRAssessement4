// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//https://www.youtube.com/watch?v=JivuXdrIHK0&list=PLspuHF0eap3a3COI7Ectqr_T7GSboOuBC&index=3&t=581s
// used this youtube video to get the basic scripting needed for a pause menu in a game 

// ---------- PAUSE MENU MANAGER -----------

public class PauseMenu : MonoBehaviour
{
    // bool to check if the game is paused
    public static bool GameIsPaused = false;

    // game object to hold the pause menu
    public GameObject pauseMenuUI; 

    // Update is called once per frame
    void Update()
    {
        // if they player clicks the escape key, check if the game if game is paused, if so call the resume function for when player 
        // wants to resume the game else pause the game
        if (Input.GetKeyDown(KeyCode.Escape)) // if player presses the escape key 
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause(); 
            }
        }
    }

    // ALL THREE FUNCTIONS ARE USED FOR THE BUTTONS ON THE PAUSE MENU UI 
    // resume makes the pause menu false and turns time back to normal and sets game pause to false
    public void Resume()
    {
        pauseMenuUI.SetActive(false); // disables pause panel 
        Time.timeScale = 1f; // sets time to normal time 
        GameIsPaused = false; // tells code it isnt paused 
    }

    // pauses the game time and displays the pause ui, changes bool to true 
    void Pause()
    {
        pauseMenuUI.SetActive(true); // enables pause panel
        Time.timeScale = 0f; // sets time to 0 to pause game time 
        GameIsPaused = true; // tells code that game is paused 
    }

    // makes sure, when player goes back to the main menu they go back to the right scene and that time is set back to normal
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f; // sets time to normal time 
        pauseMenuUI.SetActive(false); // disables pause panel 
    }
}
