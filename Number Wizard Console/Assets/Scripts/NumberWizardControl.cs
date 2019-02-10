using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class NumberWizardControl : MonoBehaviour
{

    // Declare Variables
    [SerializeField] int maxGuess;
    [SerializeField] int minGuess;
    int playerGuess;

    //Other Scripts
    [SerializeField] Text guessText;

    // Use this for initialization
    void Start ()
    {
        UpdateGuess();
    }

    // Update playerGuess var
    private void UpdateGuess()
    {
        playerGuess = Random.Range(minGuess, maxGuess);
        UpdateText();
    }

    // Update the guessText var
    private void UpdateText()
    {
        guessText.text = playerGuess.ToString();
    }

    // Number is lower
    public void OnPressLower()
    {
        maxGuess = playerGuess -1;
        UpdateGuess();
    }

    // Number is higher
    public void OnPressHigher()
    {
        minGuess = playerGuess +1;
        UpdateGuess();
    }
}
