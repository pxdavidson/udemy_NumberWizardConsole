using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextRenderer : MonoBehaviour
{
    string greeting = "Hello";
    Text mainBodyText;

    // Use this for initialization
	void Start ()
    {
        mainBodyText = GetComponent<Text>();
        ParseText();
    }

    void ParseText()
    {
        mainBodyText.text = greeting;
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
