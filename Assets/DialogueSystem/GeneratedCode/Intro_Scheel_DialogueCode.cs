using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Intro_Scheel_DialogueCode : IDialogueCode
    {
        private Dictionary<string, IDialogueCode.EventDelegate> eventFunctions = new Dictionary<string, IDialogueCode.EventDelegate>();
        private Dictionary<string, IDialogueCode.ConditionDelegate> conditionChecks = new Dictionary<string, IDialogueCode.ConditionDelegate>();
        private Dictionary<string, IDialogueCode.ConditionDelegate> dialogueChecks = new Dictionary<string, IDialogueCode.ConditionDelegate>();
        public Dictionary<string, IDialogueCode.EventDelegate> EventFunctions => eventFunctions;
        public Dictionary<string, IDialogueCode.ConditionDelegate> ConditionChecks => conditionChecks;
        public Dictionary<string, IDialogueCode.ConditionDelegate> DialogueChecks => dialogueChecks;
        public string GetVariable(string variableName) {
            return this.GetType().GetField(variableName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(this).ToString(); 
        }
        public Intro_Scheel_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: aa94aa22-f562-41b2-a749-b6554f617cab //
string name = "Ms. Scheele";


        public void Start()
        {
            // Setup //

        }

        // Dialogue Checks //


        // Condition Checks //


        // Event Functions //

    }
}
