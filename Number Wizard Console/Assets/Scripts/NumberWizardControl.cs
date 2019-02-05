using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
using System;

public class NumberWizardControl : MonoBehaviour
{

    // Declare Variables
    int maxGuess;
    int minGuess;
    int playerGuess;

    //Other Scripts
    UITextRenderer uITextRenderer;

    // Use this for initialization
    void Start ()
    {
        DefineVariables();
        ProcessGuess();
    }

    // Used to define the global variables used
    void DefineVariables()
    {
        uITextRenderer = FindObjectOfType<UITextRenderer>();
        maxGuess = 1000;
        minGuess = 1;
        playerGuess = 500;
        maxGuess++;
    }

    // Prompt user to guess
    private void ProcessGuess()
    {
        playerGuess = (minGuess + maxGuess) / 2;
        uITextRenderer.ParseText("Is your number higher or lower than " + playerGuess + "?");
    }

    // Update is called once per frame
    public void Update ()
    {
        ProcessInput();
    }

    // Process user input
    private void ProcessInput()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minGuess = playerGuess;
            ProcessGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxGuess = playerGuess;
            ProcessGuess();
        }
        else if (Input.GetKeyUp(KeyCode.Return))
        {
            uITextRenderer.ParseText("Your number is " + playerGuess + " press Space to play again");
            
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Start();
        }
        else
        {
            //Do nothing
        }
    }


}
