using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
using System;

public class NumberWizardControl : MonoBehaviour
{

    // Declare Variables
    [SerializeField] int maxGuess;
    [SerializeField] int minGuess;
    int playerGuess;

    //Other Scripts
    Text textRenderer;

    // Use this for initialization
    void Start ()
    {
        DefineVariables();
        ProcessGuess();
    }

    // Used to define the global variables used
    void DefineVariables()
    {
        textRenderer = FindObjectOfType<Text>();
        maxGuess++;
    }

    // Prompt user to guess
    private void ProcessGuess()
    {
        playerGuess = (minGuess + maxGuess) / 2;
    }

    // Number is lower
    public void OnPressLower()
    {
        maxGuess = playerGuess;
        ProcessGuess();
    }

    // Number is higher
    public void OnPressHigher()
    {
        minGuess = playerGuess;
        ProcessGuess();
    }

}
