using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PrintText : MonoBehaviour
{
    string textToPrint;
    int index;
    string expectedText;
    TextMeshProUGUI text;
    
    UnityEvent OnCharacterPrint;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        textToPrint = text.text;
    }

    // Update is called once per frame
    void Update()
    {
        if (!text.text.Equals(expectedText))
        {
            textToPrint = text.text;
            index = 0;
            text.text = string.Empty;
            expectedText = string.Empty;
        }
        else 
        {
            text.text += textToPrint[index];
            index++;
            expectedText = text.text;
            OnCharacterPrint.Invoke();
        }
    }
}
