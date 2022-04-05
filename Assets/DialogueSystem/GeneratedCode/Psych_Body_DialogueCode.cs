using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Psych_Body_DialogueCode : DialogueCode, IDialogueCode
    {
        public Psych_Body_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 925071b6-c5b9-456f-bc20-ff5e6dae9dc2 //
string name = "Dead Body";
Notes.Journal journal = Utility.Toolbox.Instance.Journal;
int choices = 0;


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Psych_Body_f122eae0c0054e53924aeda199421940_7db36f922d7d4486a45c0c56f1fa7dea",Psych_Body_f122eae0c0054e53924aeda199421940_7db36f922d7d4486a45c0c56f1fa7dea);
            dialogueChecks.Add("Psych_Body_f122eae0c0054e53924aeda199421940_20212544bc2243e6a4c183dc617dd63a",Psych_Body_f122eae0c0054e53924aeda199421940_20212544bc2243e6a4c183dc617dd63a);
            eventFunctions.Add("Psych_Body_0ad39360e60e4c0292ab6178b976c4b7",Psych_Body_0ad39360e60e4c0292ab6178b976c4b7);
            conditionChecks.Add("Psych_Body_939df39a2ae3488ca989ba6394d81f52",Psych_Body_939df39a2ae3488ca989ba6394d81f52);
            eventFunctions.Add("Psych_Body_791c15739eda4790af9bd0ef93a01c7b",Psych_Body_791c15739eda4790af9bd0ef93a01c7b);
            eventFunctions.Add("Psych_Body_b2a41c09e3fe4890b19fd14b391ad51f",Psych_Body_b2a41c09e3fe4890b19fd14b391ad51f);

        }

        // Dialogue Checks //
        // From Node: f122eae0-c005-4e53-924a-eda199421940 //
        // Choice: Exanime Body - 7db36f92-2d7d-4486-a45c-0c56f1fa7dea //
        public bool Psych_Body_f122eae0c0054e53924aeda199421940_7db36f922d7d4486a45c0c56f1fa7dea()
        {
            return (true);
        }
        // From Node: f122eae0-c005-4e53-924a-eda199421940 //
        // Choice: Examine Hands - 20212544-bc22-43e6-a4c1-83dc617dd63a //
        public bool Psych_Body_f122eae0c0054e53924aeda199421940_20212544bc2243e6a4c183dc617dd63a()
        {
            return (true);
        }


        // Condition Checks //
        // Condition From Node: 939df39a-2ae3-488c-a989-ba6394d81f52 //
        public bool Psych_Body_939df39a2ae3488ca989ba6394d81f52() {
            return (choices < 2);
        }


        // Event Functions //
        // Event From Node: 0ad39360-e60e-4c02-92ab-6178b976c4b7 //
        public void Psych_Body_0ad39360e60e4c0292ab6178b976c4b7() {
journal.AddEntry("The assailant had dark hair? Well that could be almost anyone...");
        }
        // Event From Node: 791c1573-9eda-4790-af9b-d0ef93a01c7b //
        public void Psych_Body_791c15739eda4790af9bd0ef93a01c7b() {
journal.AddEntry("Psychologist's body had two stab wounds in the abdomen area.");
        }
        // Event From Node: b2a41c09-e3fe-4890-b19f-d14b391ad51f //
        public void Psych_Body_b2a41c09e3fe4890b19fd14b391ad51f() {
choices += 1;
        }

    }
}
