using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class NumberWizardControl : MonoBehaviour {

    // Declare Variables
    int maxGuess = 1000;
    int minGuess = 1;
    int guess = 500;
    
    // Use this for initialization
	void Start ()
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Please pick a number");
        Debug.Log("It must be equal to or greater than " + minGuess);
        Debug.Log("It must be equal to or less than " + maxGuess);
        MakeAGuess();
    }
	
	// TODO: Clean the update methods for handling input to be a switch
    
    // Update is called once per frame
	public void Update ()
    {
        // Using Ifs
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("It is higher.");
            minGuess = guess;
            guess = minGuess - guess * 2;
            MakeAGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("It is lower");
            maxGuess = guess;
            guess = maxGuess - guess / 2;
            MakeAGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Your number is " + guess);
        }
        else
        {
            //Do nothing
        }
    }

    void MakeAGuess ()
    {

        Debug.Log("Is your number higher or lower than " + guess + "?");
    }
}
