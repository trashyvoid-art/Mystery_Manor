using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Ms_Scheele_Int__DialogueCode : IDialogueCode
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
        public Ms_Scheele_Int__DialogueCode() 
        {
            Start();
        }


        // Variables //


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Ms_Scheele_Int__de22f680f6f24185b948014f88d222ee_108d8c0328524b3abb726b64844e6603",Ms_Scheele_Int__de22f680f6f24185b948014f88d222ee_108d8c0328524b3abb726b64844e6603);
            dialogueChecks.Add("Ms_Scheele_Int__de22f680f6f24185b948014f88d222ee_04a49ac79ceb4573b98b81deb9a5ea1f",Ms_Scheele_Int__de22f680f6f24185b948014f88d222ee_04a49ac79ceb4573b98b81deb9a5ea1f);
            dialogueChecks.Add("Ms_Scheele_Int__de22f680f6f24185b948014f88d222ee_66ffc2b8f5bb494d87106b6c23b02974",Ms_Scheele_Int__de22f680f6f24185b948014f88d222ee_66ffc2b8f5bb494d87106b6c23b02974);

        }

        // Dialogue Checks //
        // From Node: de22f680-f6f2-4185-b948-014f88d222ee //
        // Choice: Where were you at the time of the murder - 108d8c03-2852-4b3a-bb72-6b64844e6603 //
        public bool Ms_Scheele_Int__de22f680f6f24185b948014f88d222ee_108d8c0328524b3abb726b64844e6603()
        {
            return (true);
        }
        // From Node: de22f680-f6f2-4185-b948-014f88d222ee //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 04a49ac7-9ceb-4573-b98b-81deb9a5ea1f //
        public bool Ms_Scheele_Int__de22f680f6f24185b948014f88d222ee_04a49ac79ceb4573b98b81deb9a5ea1f()
        {
            return (true);
        }
        // From Node: de22f680-f6f2-4185-b948-014f88d222ee //
        // Choice: Do you have any other information? - 66ffc2b8-f5bb-494d-8710-6b6c23b02974 //
        public bool Ms_Scheele_Int__de22f680f6f24185b948014f88d222ee_66ffc2b8f5bb494d87106b6c23b02974()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //

    }
}
