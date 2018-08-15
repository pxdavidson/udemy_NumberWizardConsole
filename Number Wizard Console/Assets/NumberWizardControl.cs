using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class NumberWizardControl : MonoBehaviour {

    // Declare Variables
    int maxGuess;
    int minGuess;
    int playerGuess;
    
    // Use this for initialization
	void Start ()
    {
        StartGame();
        ProcessGuess();
    }

    private void StartGame()
    {
        maxGuess = 1000;
        minGuess = 1;
        playerGuess = 500;
        Debug.Log("Hello! Please think of a number...");
        Debug.Log("It must be equal to, or greater than " + minGuess);
        Debug.Log("It must be equal to, or less than " + maxGuess);
        Debug.Log("Please use the UP & DOWN arrows to indicate whether higher or lower.");
        Debug.Log("Press ENTER to confirm when your number is guessed.");
        maxGuess++;
    }

    // Prompt user to guess
    private void ProcessGuess()
    {
        playerGuess = (minGuess + maxGuess) / 2;
        Debug.Log("Is your number higher or lower than " + playerGuess + "?");
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
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Your number is " + playerGuess);
            Invoke("StartGame", 5);
        }
        else
        {
            //Do nothing
        }
    }


}
