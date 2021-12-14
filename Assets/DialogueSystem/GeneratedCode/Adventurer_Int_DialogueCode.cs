using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Adventurer_Int_DialogueCode : DialogueCode, IDialogueCode
    {
        public Adventurer_Int_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: bff4efe7-0ca3-468c-ae35-cefbbd81a662 //
string name = "The Adventurer";
Notes.Journal journal = Utility.Toolbox.Instance.Journal;


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_656e7b9d4213420b8ecaf04cb8f1deea",Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_656e7b9d4213420b8ecaf04cb8f1deea);
            dialogueChecks.Add("Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_0291ff77c9d0449c8ea18ac119450c35",Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_0291ff77c9d0449c8ea18ac119450c35);
            dialogueChecks.Add("Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_fdb9342c4c8e4584a4cef351e8ebfdc3",Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_fdb9342c4c8e4584a4cef351e8ebfdc3);
            dialogueChecks.Add("Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_017ba2a92591447fbddffbcebda10db4",Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_017ba2a92591447fbddffbcebda10db4);
            eventFunctions.Add("Adventurer_Int_354f6bf600044894a2af0dc909fc0396",Adventurer_Int_354f6bf600044894a2af0dc909fc0396);
            eventFunctions.Add("Adventurer_Int_4f7d54b5320f4bc398b9dc59f9ca68eb",Adventurer_Int_4f7d54b5320f4bc398b9dc59f9ca68eb);

        }

        // Dialogue Checks //
        // From Node: e2a31422-f166-4498-b906-c8cfd8eb5a35 //
        // Choice: Bloody Nose? - 656e7b9d-4213-420b-8eca-f04cb8f1deea //
        public bool Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_656e7b9d4213420b8ecaf04cb8f1deea()
        {
            return (true);
        }
        // From Node: e2a31422-f166-4498-b906-c8cfd8eb5a35 //
        // Choice: Do you have any other information about the case? - 0291ff77-c9d0-449c-8ea1-8ac119450c35 //
        public bool Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_0291ff77c9d0449c8ea18ac119450c35()
        {
            return (true);
        }
        // From Node: e2a31422-f166-4498-b906-c8cfd8eb5a35 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - fdb9342c-4c8e-4584-a4ce-f351e8ebfdc3 //
        public bool Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_fdb9342c4c8e4584a4cef351e8ebfdc3()
        {
            return (true);
        }
        // From Node: e2a31422-f166-4498-b906-c8cfd8eb5a35 //
        // Choice: Where were you at the time of the murder? - 017ba2a9-2591-447f-bddf-fbcebda10db4 //
        public bool Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_017ba2a92591447fbddffbcebda10db4()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //
        // Event From Node: 354f6bf6-0004-4894-a2af-0dc909fc0396 //
        public void Adventurer_Int_354f6bf600044894a2af0dc909fc0396() {
journal.AddEntry("Incident during dinner involving The Psychologist.");
        }
        // Event From Node: 4f7d54b5-320f-4bc3-98b9-dc59f9ca68eb //
        public void Adventurer_Int_4f7d54b5320f4bc398b9dc59f9ca68eb() {
journal.AddEntry("The Adventurer and The Doctor were in the bar together.");
        }

    }
}
