using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Scarlett_Dead_DialogueCode : DialogueCode, IDialogueCode
    {
        public Scarlett_Dead_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: b22151b3-4ccd-4511-b982-35306bf1c9de //
string name = "Scarlett";
Notes.Journal journal = Utility.Toolbox.Instance.Journal;


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Scarlett_Dead_77ab0a0f6f44429db2bbd9f51a955b95",Scarlett_Dead_77ab0a0f6f44429db2bbd9f51a955b95);

        }

        // Dialogue Checks //


        // Condition Checks //


        // Event Functions //
        // Event From Node: 77ab0a0f-6f44-429d-b2bb-d9f51a955b95 //
        public void Scarlett_Dead_77ab0a0f6f44429db2bbd9f51a955b95() {
journal.AddEntry("The victim is Scarlett, The Psychologist.");
        }

    }
}
