using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Sailor_Int_DialogueCode : DialogueCode, IDialogueCode
    {
        public Sailor_Int_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 0f54fb55-3b6d-464f-804b-3ccde1a544b9 //
string name ="The Sailor";
Notes.Journal journal = Utility.Toolbox.Instance.Journal;
int choices = 0;


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_85f8aec8871342de94f2b01aab097575",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_85f8aec8871342de94f2b01aab097575);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_3965af1839574a8f92ce52f0d9e94ce0",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_3965af1839574a8f92ce52f0d9e94ce0);
            eventFunctions.Add("Sailor_Int_80b8a9656ebf435994de754b7e064f63",Sailor_Int_80b8a9656ebf435994de754b7e064f63);
            eventFunctions.Add("Sailor_Int_465df431b06a4a9d85800e0299823d28",Sailor_Int_465df431b06a4a9d85800e0299823d28);
            conditionChecks.Add("Sailor_Int_ad42c76a391f4aeeb56effb2e7ed83a6",Sailor_Int_ad42c76a391f4aeeb56effb2e7ed83a6);

        }

        // Dialogue Checks //
        // From Node: 2496025e-e0b3-42f0-b92a-94cac6149a20 //
        // Choice: Where were you at the time of the murder? - 57059fe8-7b99-468c-8f9b-3dc22aca7f0b //
        public bool Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b()
        {
            return (true);
        }
        // From Node: 2496025e-e0b3-42f0-b92a-94cac6149a20 //
        // Choice: Do you have any other information about the case? - 85f8aec8-8713-42de-94f2-b01aab097575 //
        public bool Sailor_Int_2496025ee0b342f0b92a94cac6149a20_85f8aec8871342de94f2b01aab097575()
        {
            return (true);
        }
        // From Node: 2496025e-e0b3-42f0-b92a-94cac6149a20 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 3965af18-3957-4a8f-92ce-52f0d9e94ce0 //
        public bool Sailor_Int_2496025ee0b342f0b92a94cac6149a20_3965af1839574a8f92ce52f0d9e94ce0()
        {
            return (true);
        }


        // Condition Checks //
        // Condition From Node: ad42c76a-391f-4aee-b56e-ffb2e7ed83a6 //
        public bool Sailor_Int_ad42c76a391f4aeeb56effb2e7ed83a6() {
            return (choices < 3);
        }


        // Event Functions //
        // Event From Node: 80b8a965-6ebf-4359-94de-754b7e064f63 //
        public void Sailor_Int_80b8a9656ebf435994de754b7e064f63() {
journal.AddEntry("The Sailor was in the Observatory.");
        }
        // Event From Node: 465df431-b06a-4a9d-8580-0e0299823d28 //
        public void Sailor_Int_465df431b06a4a9d85800e0299823d28() {
choices += 1;
        }

    }
}
