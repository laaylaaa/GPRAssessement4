// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// https://www.youtube.com/watch?v=HmHPJL-OcQE&list=PLspuHF0eap3a3COI7Ectqr_T7GSboOuBC&index=5
// for the time stuff, like changing it to a string and setting up timer to work i got code 
// from this youtube video and adapted it to work with my game! 

// --------- GAME OVER MECHANISM WITH TIMER STUFF ----------

public class GameOver : MonoBehaviour
{
    // Level needed to be loaded string
    [SerializeField] private string loadLevel; 

    // game objects for the panel and pauseMenu, doors in the level, the timer text and key
    public GameObject gameOverPanel, pauseMenuPanel, doors, timerText, key;
    // Text varaible to set what the timer text has to say 
    public Text timer;
    // for checking if the levels are either 5 or 6 since they require different approaches 
    public bool level5, level6;
    // bool for if the timer is allowed to start 
    bool startTimerAllowed; 
    // set a basic value for the time
    public float timeValue; 

     void Update()
    {
        if (pauseMenuPanel.activeSelf == false)
        {
            Time.timeScale = 1f; // sets time to normal time 

            if (gameOverPanel.activeSelf == false)
            {
                // if level 5 
                if (level5)
                {
                    // check is the doors are active, if they are then display time and start timer
                    if (doors.activeSelf == true)
                    {
                        // Time.timeScale = 1f; // sets time to normal time 
                        DisplayTime(timeValue);
                    }
                    else // else do nothing 
                        return;
                }

                // if level 6
                if (level6 && startTimerAllowed)
                {
                    // check to see if the key has been picked up or not, if so display time and start timer  
                    if (key.activeSelf == true)
                    {
                        //Time.timeScale = 1f; // sets time to normal time 
                        DisplayTime(timeValue);
                    }
                    else // do nothing
                        return;
                }

                // if its any other level just display and start timer 
                if (!level5 && !level6)
                {
                    //Time.timeScale = 1f; // sets time to normal time 
                    DisplayTime(timeValue);
                }
                else
                    return;
            }
        }else if(pauseMenuPanel.activeSelf == true)
        {
            Time.timeScale = 0f; 
        }
    }

    // check if they player collided with the empty gameObject and all the timer to start 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            startTimerAllowed = true; 
        }
    }

    // Function from the youtube video 
    // caluclates the time and then converts the float into minutes and seconds 
    // and displays it to the screen in the timerText
    void DisplayTime(float timeToDisplay)
    {
        // displays the text 
        timerText.gameObject.SetActive(true);

        // if the time isnt 0 
        if (timeValue > 0)
            timeValue -= Time.deltaTime; // takes away from timer 
        else if(timeValue <= 0){
            // if it is 0 time ran out and display GAMEOVER
            timeValue = 0; // sets to 0 
            timeToDisplay = 0; 
            gameOverPanel.SetActive(true); // displays game over panel 
            Time.timeScale = 0f; // sets time to stop time 
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); // calc minutes 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // check how many full mintues, takes it away and returns whats left

        if(timeToDisplay < 0) // make sure time isnt less then 0, if so make sure it only displays 0 
            timeToDisplay = 0; 
        else if(timeToDisplay > 0)
            timeToDisplay += 1;

        // set timer text to format we want it to look like 
        timer.text = "Time Left " + string.Format("{0:00}:{1:00}", minutes, seconds); 
    }

    // function for restarting the level 
    public void LoadLevel()
    {
        Time.timeScale = 1f; 
        gameOverPanel.SetActive(false); // disables pause panel 
        timeValue += timeValue; // set timer back to what it was 
        SceneManager.LoadScene(loadLevel);
    }
}
