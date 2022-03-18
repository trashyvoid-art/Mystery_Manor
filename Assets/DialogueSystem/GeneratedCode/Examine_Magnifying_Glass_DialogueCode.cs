using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Examine_Magnifying_Glass_DialogueCode : DialogueCode, IDialogueCode
    {
        public Examine_Magnifying_Glass_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 0d44e9de-84f1-4a20-add7-f755edf1657e //
string name = "Knife";
Notes.Journal journal = Utility.Toolbox.Instance.Journal;


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Examine_Magnifying_Glass_d83f1542254944c1b8a9de8c04b2dd21",Examine_Magnifying_Glass_d83f1542254944c1b8a9de8c04b2dd21);
            dialogueChecks.Add("Examine_Magnifying_Glass_35d8df2afc67423ab7ea9b6f6a0bcc01_ce0f594c127a4f2c9966cbd167d16e3a",Examine_Magnifying_Glass_35d8df2afc67423ab7ea9b6f6a0bcc01_ce0f594c127a4f2c9966cbd167d16e3a);

        }

        // Dialogue Checks //
        // From Node: 35d8df2a-fc67-423a-b7ea-9b6f6a0bcc01 //
        // Choice: This is the murder weapon used to kill Scarlett... - ce0f594c-127a-4f2c-9966-cbd167d16e3a //
        public bool Examine_Magnifying_Glass_35d8df2afc67423ab7ea9b6f6a0bcc01_ce0f594c127a4f2c9966cbd167d16e3a()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //
        // Event From Node: d83f1542-2549-44c1-b8a9-de8c04b2dd21 //
        public void Examine_Magnifying_Glass_d83f1542254944c1b8a9de8c04b2dd21() {
journal.AddEntry("A hollow base? A concealed weapon perhaps?");
        }

    }
}
