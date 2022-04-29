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
int locationsLearned = 0;
DataTracker dt = DataTracker.Instance;


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Sailor_Int_465df431b06a4a9d85800e0299823d28",Sailor_Int_465df431b06a4a9d85800e0299823d28);
            conditionChecks.Add("Sailor_Int_ad42c76a391f4aeeb56effb2e7ed83a6",Sailor_Int_ad42c76a391f4aeeb56effb2e7ed83a6);
            eventFunctions.Add("Sailor_Int_80b8a9656ebf435994de754b7e064f63",Sailor_Int_80b8a9656ebf435994de754b7e064f63);
            conditionChecks.Add("Sailor_Int_12d82d657b5c4ddd9f8f188d9838173e",Sailor_Int_12d82d657b5c4ddd9f8f188d9838173e);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_85f8aec8871342de94f2b01aab097575",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_85f8aec8871342de94f2b01aab097575);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_3965af1839574a8f92ce52f0d9e94ce0",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_3965af1839574a8f92ce52f0d9e94ce0);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b);
            dialogueChecks.Add("Sailor_Int_2496025ee0b342f0b92a94cac6149a20_7ff9f792d85b402f9dc69b3a088f5951",Sailor_Int_2496025ee0b342f0b92a94cac6149a20_7ff9f792d85b402f9dc69b3a088f5951);
            eventFunctions.Add("Sailor_Int_c155a34a36ad4d0da95c10895de5194e",Sailor_Int_c155a34a36ad4d0da95c10895de5194e);
            eventFunctions.Add("Sailor_Int_d65e2a8dc36e499e917a2a17afc898e7",Sailor_Int_d65e2a8dc36e499e917a2a17afc898e7);
            eventFunctions.Add("Sailor_Int_0a68badc55b849c0b3dae6cfb475065e",Sailor_Int_0a68badc55b849c0b3dae6cfb475065e);

        }

        // Dialogue Checks //
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
        // From Node: 2496025e-e0b3-42f0-b92a-94cac6149a20 //
        // Choice: Where were you at the time of the murder? - 57059fe8-7b99-468c-8f9b-3dc22aca7f0b //
        public bool Sailor_Int_2496025ee0b342f0b92a94cac6149a20_57059fe87b99468c8f9b3dc22aca7f0b()
        {
            return (true);
        }
        // From Node: 2496025e-e0b3-42f0-b92a-94cac6149a20 //
        // Choice: Did you kill Scarlette? - 7ff9f792-d85b-402f-9dc6-9b3a088f5951 //
        public bool Sailor_Int_2496025ee0b342f0b92a94cac6149a20_7ff9f792d85b402f9dc69b3a088f5951()
        {
            return (dt.clues >= 7);
        }


        // Condition Checks //
        // Condition From Node: ad42c76a-391f-4aee-b56e-ffb2e7ed83a6 //
        public bool Sailor_Int_ad42c76a391f4aeeb56effb2e7ed83a6() {
            return (choices < 3);
        }
        // Condition From Node: 12d82d65-7b5c-4ddd-9f8f-188d9838173e //
        public bool Sailor_Int_12d82d657b5c4ddd9f8f188d9838173e() {
            return (locationsLearned > 0);
        }


        // Event Functions //
        // Event From Node: 465df431-b06a-4a9d-8580-0e0299823d28 //
        public void Sailor_Int_465df431b06a4a9d85800e0299823d28() {
choices += 1;
        }
        // Event From Node: 80b8a965-6ebf-4359-94de-754b7e064f63 //
        public void Sailor_Int_80b8a9656ebf435994de754b7e064f63() {
journal.AddEntry("The Sailor was in the Observatory.");
locationsLearned+=1;
dt.clues+=1;
        }
        // Event From Node: c155a34a-36ad-4d0d-a95c-10895de5194e //
        public void Sailor_Int_c155a34a36ad4d0da95c10895de5194e() {
dt.correctAccusations += 1;
        }
        // Event From Node: d65e2a8d-c36e-499e-917a-2a17afc898e7 //
        public void Sailor_Int_d65e2a8dc36e499e917a2a17afc898e7() {
dt.showBackgroundImage += 1;
        }
        // Event From Node: 0a68badc-55b8-49c0-b3da-e6cfb475065e //
        public void Sailor_Int_0a68badc55b849c0b3dae6cfb475065e() {
dt.showBackgroundImage = 0;
dt.currentScene = 1;
        }

    }
}
