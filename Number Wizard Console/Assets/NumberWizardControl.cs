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
	
	// TODO: Clean the update methods for handling input to be a switch
    
    // Update is called once per frame
	public void Update ()
    {
        // testing Switch
        var selectedKey = Input.inputString;
        switch (selectedKey)
        {
            case "a":
                Debug.Log("You Pressed A");
                break;
            case "b":
                Debug.Log("You Pressed B");
                break;
            case "UpArrow":
                Debug.Log("You Selected Higher");
                break;
            case "DownArrow":
                Debug.Log("You Selected Lower");
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
