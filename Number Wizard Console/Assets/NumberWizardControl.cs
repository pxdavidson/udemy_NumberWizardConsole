using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class NumberWizardControl : MonoBehaviour {

    // Declare Variables
    int maxGuess = 1000;
    int minGuess = 1;
    
    // Use this for initialization
	void Start ()
    {
       

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Please pick a number");
        Debug.Log("It must be equal to or greater than " + minGuess);
        Debug.Log("It must be equal to or less than " + maxGuess);
    }
	
	// TODO: Clean the update methos for handling input to be a switch
    
    // Update is called once per frame
	public void Update ()
    {
        // testing Switch
        var selectedKey = Input.inputString;
        switch (selectedKey)
        {
            case "A":
                Debug.Log("You Pressed A");
                break;
            case "B":
                Debug.Log("You Pressed B");
                break;
        }

        // Using Ifs
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You Selected Higher");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You Selected Lower");
        }
    }
}
