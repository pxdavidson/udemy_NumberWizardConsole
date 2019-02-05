using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextRenderer : MonoBehaviour
{
    Text mainBodyText;
    string defaultText = "Is your number higher or lower than 500";

    // Use this for initialization
	void Start ()
    {
        mainBodyText = GetComponent<Text>();
        ParseText(defaultText);
    }

    public void ParseText(string update)
    {
        // TODO Fix the error that Unity throws
        mainBodyText.text = update;
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
