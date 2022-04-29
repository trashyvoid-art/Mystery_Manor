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
int body = 0;
int hands = 0;
int blood = 0;
DataTracker dt = DataTracker.Instance;
Notes.Journal journal = Utility.Toolbox.Instance.Journal;
int choices = 0;


        public void Start()
        {
            // Setup //
            conditionChecks.Add("Psych_Body_939df39a2ae3488ca989ba6394d81f52",Psych_Body_939df39a2ae3488ca989ba6394d81f52);
            eventFunctions.Add("Psych_Body_b2a41c09e3fe4890b19fd14b391ad51f",Psych_Body_b2a41c09e3fe4890b19fd14b391ad51f);
            eventFunctions.Add("Psych_Body_0ad39360e60e4c0292ab6178b976c4b7",Psych_Body_0ad39360e60e4c0292ab6178b976c4b7);
            conditionChecks.Add("Psych_Body_761caa1eb9724d338731c9953d7b45a9",Psych_Body_761caa1eb9724d338731c9953d7b45a9);
            eventFunctions.Add("Psych_Body_791c15739eda4790af9bd0ef93a01c7b",Psych_Body_791c15739eda4790af9bd0ef93a01c7b);
            conditionChecks.Add("Psych_Body_aab88120a9174c6fb20bfdcb6384cfb7",Psych_Body_aab88120a9174c6fb20bfdcb6384cfb7);
            conditionChecks.Add("Psych_Body_f1c70959a853458aaa312421f36b7a69",Psych_Body_f1c70959a853458aaa312421f36b7a69);
            eventFunctions.Add("Psych_Body_37d5097f6e1947bab51fd27057cd9537",Psych_Body_37d5097f6e1947bab51fd27057cd9537);
            dialogueChecks.Add("Psych_Body_f122eae0c0054e53924aeda199421940_7db36f922d7d4486a45c0c56f1fa7dea",Psych_Body_f122eae0c0054e53924aeda199421940_7db36f922d7d4486a45c0c56f1fa7dea);
            dialogueChecks.Add("Psych_Body_f122eae0c0054e53924aeda199421940_20212544bc2243e6a4c183dc617dd63a",Psych_Body_f122eae0c0054e53924aeda199421940_20212544bc2243e6a4c183dc617dd63a);
            dialogueChecks.Add("Psych_Body_f122eae0c0054e53924aeda199421940_2d199e62b0bc4e5e93c55e7cf2026b89",Psych_Body_f122eae0c0054e53924aeda199421940_2d199e62b0bc4e5e93c55e7cf2026b89);

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
        // From Node: f122eae0-c005-4e53-924a-eda199421940 //
        // Choice: Examine Blood - 2d199e62-b0bc-4e5e-93c5-5e7cf2026b89 //
        public bool Psych_Body_f122eae0c0054e53924aeda199421940_2d199e62b0bc4e5e93c55e7cf2026b89()
        {
            return (true);
        }


        // Condition Checks //
        // Condition From Node: 939df39a-2ae3-488c-a989-ba6394d81f52 //
        public bool Psych_Body_939df39a2ae3488ca989ba6394d81f52() {
            return (choices < 3);
        }
        // Condition From Node: 761caa1e-b972-4d33-8731-c9953d7b45a9 //
        public bool Psych_Body_761caa1eb9724d338731c9953d7b45a9() {
            return (body > 0);
        }
        // Condition From Node: aab88120-a917-4c6f-b20b-fdcb6384cfb7 //
        public bool Psych_Body_aab88120a9174c6fb20bfdcb6384cfb7() {
            return (hands > 0);
        }
        // Condition From Node: f1c70959-a853-458a-aa31-2421f36b7a69 //
        public bool Psych_Body_f1c70959a853458aaa312421f36b7a69() {
            return (blood > 0);
        }


        // Event Functions //
        // Event From Node: b2a41c09-e3fe-4890-b19f-d14b391ad51f //
        public void Psych_Body_b2a41c09e3fe4890b19fd14b391ad51f() {
choices += 1;
        }
        // Event From Node: 0ad39360-e60e-4c02-92ab-6178b976c4b7 //
        public void Psych_Body_0ad39360e60e4c0292ab6178b976c4b7() {
journal.AddEntry("The assailant had dark hair? Well that could be almost anyone...");
dt.clues += 1;
hands += 1;
        }
        // Event From Node: 791c1573-9eda-4790-af9b-d0ef93a01c7b //
        public void Psych_Body_791c15739eda4790af9bd0ef93a01c7b() {
journal.AddEntry("Psychologist's body had two stab wounds in the abdomen area.");
dt.clues += 1;
body += 1;
        }
        // Event From Node: 37d5097f-6e19-47ba-b51f-d27057cd9537 //
        public void Psych_Body_37d5097f6e1947bab51fd27057cd9537() {
journal.AddEntry("Footprints and trail of blood from Scarlette's body leads out further into the office, but end abrubtly.");
dt.clues += 1;
blood += 1;
        }

    }
}
