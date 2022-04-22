using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Plant_DialogueCode : DialogueCode, IDialogueCode
    {
        public Plant_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 2b6d429f-08e9-4658-81b2-46e73bc43198 //
Notes.Journal journal = Utility.Toolbox.Instance.Journal;


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Plant_4dec9dff622f4d6996420beed3809e7d",Plant_4dec9dff622f4d6996420beed3809e7d);

        }

        // Dialogue Checks //


        // Condition Checks //


        // Event Functions //
        // Event From Node: 4dec9dff-622f-4d69-9642-0beed3809e7d //
        public void Plant_4dec9dff622f4d6996420beed3809e7d() {
journal.AddEntry("A medium sized plant with large oval leaves that are light in the middle and dark around the edges.");
        }

    }
}
