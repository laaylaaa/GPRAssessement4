// Layla Darwiche 
// GPR103 
// Assessment 4 - Game Project
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://www.youtube.com/watch?v=32EIYs6Z18Q&list=PLspuHF0eap3a3COI7Ectqr_T7GSboOuBC&index=4
// used this youtube video to get the code for a scrolling background :) 
// commenting done by me from my understanding of the code! 

// ------- BACKGROUND SCROLLING EFFECT ---------

public class BackgroundMoving : MonoBehaviour
{
    // speed of the moving background
    public float speed;

    // renderer for the quad object 
    public Renderer bgRend;

    // Update is called once per frame
    void Update()
    {
        // change the offset of the material on the object to move in real time
        bgRend.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0f);
    }
}
