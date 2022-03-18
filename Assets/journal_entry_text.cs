using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class journal_entry_text : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI text;
    
    // Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Notes.Journal journal = Utility.Toolbox.Instance.Journal;
        string entry = string.Empty; // This is a list of all the entries as strings
        for (int i = 0; i < journal.EntryCount; i++) // We need to loop through the journal cus we can't get an array directly yet
        {
            Notes.Entry note = journal.GetEntryAtIndex(i); // We grab the note at an index in the journal
            entry += note.Note + "\n\n"; // Then we add that note to our list
        }
        text.text = entry;
        // Here we can do whatever we want to the 'entries' list like make new UI components and what not
    }
}
