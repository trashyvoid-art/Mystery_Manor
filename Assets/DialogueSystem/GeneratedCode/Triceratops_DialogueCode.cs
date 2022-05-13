using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Triceratops_DialogueCode : DialogueCode, IDialogueCode
    {
        public Triceratops_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 4e002274-93b6-471e-902a-79dcabe25f03 //
Notes.Journal journal = Utility.Toolbox.Instance.Journal;


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Triceratops_4dec9dff622f4d6996420beed3809e7d",Triceratops_4dec9dff622f4d6996420beed3809e7d);

        }

        // Dialogue Checks //


        // Condition Checks //


        // Event Functions //
        // Event From Node: 4dec9dff-622f-4d69-9642-0beed3809e7d //
        public void Triceratops_4dec9dff622f4d6996420beed3809e7d() {
journal.AddEntry("A medium sized plant with large oval leaves that are light in the middle and dark around the edges.");
        }

    }
}
