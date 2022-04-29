using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Astronomer_Int_DialogueCode : DialogueCode, IDialogueCode
    {
        public Astronomer_Int_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 116917f5-2d17-47f4-8030-76c6415234cb //
public int shamsaTalkedTo = 0;
string name = "The Astronomer";
Notes.Journal journal = Utility.Toolbox.Instance.Journal;
int choices =0;
int locationLearned = 0;
DataTracker dt = DataTracker.Instance;


        public void Start()
        {
            // Setup //
            conditionChecks.Add("Astronomer_Int_587b23ced7f14406beb04a840ad35495",Astronomer_Int_587b23ced7f14406beb04a840ad35495);
            conditionChecks.Add("Astronomer_Int_31076eaf81fd4a68843668e39cdb0698",Astronomer_Int_31076eaf81fd4a68843668e39cdb0698);
            eventFunctions.Add("Astronomer_Int_3be24e7b4af94f8195ed1d520b2e56ab",Astronomer_Int_3be24e7b4af94f8195ed1d520b2e56ab);
            eventFunctions.Add("Astronomer_Int_d2a00e74797e4ff6a354779009fbda74",Astronomer_Int_d2a00e74797e4ff6a354779009fbda74);
            conditionChecks.Add("Astronomer_Int_70d846c3c1254aea92401a81c8691d59",Astronomer_Int_70d846c3c1254aea92401a81c8691d59);
            dialogueChecks.Add("Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_c7afa89ba4d04601b5270254eafba349",Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_c7afa89ba4d04601b5270254eafba349);
            dialogueChecks.Add("Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_571adf63a14c406898fdd5b55270f405",Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_571adf63a14c406898fdd5b55270f405);
            dialogueChecks.Add("Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_bf886ecabd8744679e362bc1ee281072",Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_bf886ecabd8744679e362bc1ee281072);
            dialogueChecks.Add("Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_8bce3ee62170433b97d5f3ccb6409263",Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_8bce3ee62170433b97d5f3ccb6409263);
            eventFunctions.Add("Astronomer_Int_07eeb4f5ec864a5ea72d8f9177d02ce8",Astronomer_Int_07eeb4f5ec864a5ea72d8f9177d02ce8);
            eventFunctions.Add("Astronomer_Int_32a284ffd0184b029c096d8b4f056bf8",Astronomer_Int_32a284ffd0184b029c096d8b4f056bf8);
            eventFunctions.Add("Astronomer_Int_7bd3c545cc974a8eb336e8e1cccff714",Astronomer_Int_7bd3c545cc974a8eb336e8e1cccff714);
            eventFunctions.Add("Astronomer_Int_9ddcd9d6d4fc4825a5b3893ebfbbc7a7",Astronomer_Int_9ddcd9d6d4fc4825a5b3893ebfbbc7a7);
            eventFunctions.Add("Astronomer_Int_c4b0fab1806a46c9af4f306b846e0b32",Astronomer_Int_c4b0fab1806a46c9af4f306b846e0b32);
            eventFunctions.Add("Astronomer_Int_2b046335ca9b428e8696b9b9937bb532",Astronomer_Int_2b046335ca9b428e8696b9b9937bb532);
            eventFunctions.Add("Astronomer_Int_c1b5c56204294dc6a8dd6234469dee05",Astronomer_Int_c1b5c56204294dc6a8dd6234469dee05);
            eventFunctions.Add("Astronomer_Int_c95d443e0122422aaedc045d9b49e28b",Astronomer_Int_c95d443e0122422aaedc045d9b49e28b);
            eventFunctions.Add("Astronomer_Int_377fdbabc6d441ce9533e4b3ab8b6b3c",Astronomer_Int_377fdbabc6d441ce9533e4b3ab8b6b3c);

        }

        // Dialogue Checks //
        // From Node: 23e0ca1f-d5ed-485a-8a06-20257e18854e //
        // Choice: Do you know why someone would have wanted to hurt the victim? - c7afa89b-a4d0-4601-b527-0254eafba349 //
        public bool Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_c7afa89ba4d04601b5270254eafba349()
        {
            return (true);
        }
        // From Node: 23e0ca1f-d5ed-485a-8a06-20257e18854e //
        // Choice: Do you have any other information about the case? - 571adf63-a14c-4068-98fd-d5b55270f405 //
        public bool Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_571adf63a14c406898fdd5b55270f405()
        {
            return (true);
        }
        // From Node: 23e0ca1f-d5ed-485a-8a06-20257e18854e //
        // Choice: Where were you at the time of the murder? - bf886eca-bd87-4467-9e36-2bc1ee281072 //
        public bool Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_bf886ecabd8744679e362bc1ee281072()
        {
            return (true);
        }
        // From Node: 23e0ca1f-d5ed-485a-8a06-20257e18854e //
        // Choice: Did you kill Scarlette? - 8bce3ee6-2170-433b-97d5-f3ccb6409263 //
        public bool Astronomer_Int_23e0ca1fd5ed485a8a0620257e18854e_8bce3ee62170433b97d5f3ccb6409263()
        {
            return (dt.clues>=7);
        }


        // Condition Checks //
        // Condition From Node: 587b23ce-d7f1-4406-beb0-4a840ad35495 //
        public bool Astronomer_Int_587b23ced7f14406beb04a840ad35495() {
            return (choices < 3);
        }
        // Condition From Node: 31076eaf-81fd-4a68-8436-68e39cdb0698 //
        public bool Astronomer_Int_31076eaf81fd4a68843668e39cdb0698() {
            return (locationLearned > 0);
        }
        // Condition From Node: 70d846c3-c125-4aea-9240-1a81c8691d59 //
        public bool Astronomer_Int_70d846c3c1254aea92401a81c8691d59() {
            return (dt.shamsaTalkedTo > 0);
        }


        // Event Functions //
        // Event From Node: 3be24e7b-4af9-4f81-95ed-1d520b2e56ab //
        public void Astronomer_Int_3be24e7b4af94f8195ed1d520b2e56ab() {
choices += 1;
        }
        // Event From Node: d2a00e74-797e-4ff6-a354-779009fbda74 //
        public void Astronomer_Int_d2a00e74797e4ff6a354779009fbda74() {
journal.AddEntry("The Adventurer had a bloody nose.");
dt.shamsaTalkedTo += 1;
dt.clues+=1;
        }
        // Event From Node: 07eeb4f5-ec86-4a5e-a72d-8f9177d02ce8 //
        public void Astronomer_Int_07eeb4f5ec864a5ea72d8f9177d02ce8() {
dt.wrongAccusations+=1;
        }
        // Event From Node: 32a284ff-d018-4b02-9c09-6d8b4f056bf8 //
        public void Astronomer_Int_32a284ffd0184b029c096d8b4f056bf8() {
GameObject.FindObjectOfType<AudioManager>().Play("Shamsa 2");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 7bd3c545-cc97-4a8e-b336-e8e1cccff714 //
        public void Astronomer_Int_7bd3c545cc974a8eb336e8e1cccff714() {
GameObject.FindObjectOfType<AudioManager>().Play("Shamsa 1");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 9ddcd9d6-d4fc-4825-a5b3-893ebfbbc7a7 //
        public void Astronomer_Int_9ddcd9d6d4fc4825a5b3893ebfbbc7a7() {
GameObject.FindObjectOfType<AudioManager>().Play("Shamsa End");
        }
        // Event From Node: c4b0fab1-806a-46c9-af4f-306b846e0b32 //
        public void Astronomer_Int_c4b0fab1806a46c9af4f306b846e0b32() {
GameObject.FindObjectOfType<AudioManager>().Play("Start Convo");
        }
        // Event From Node: 2b046335-ca9b-428e-8696-b9b9937bb532 //
        public void Astronomer_Int_2b046335ca9b428e8696b9b9937bb532() {
GameObject.FindObjectOfType<AudioManager>().Play("Shamsa 3");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: c1b5c562-0429-4dc6-a8dd-6234469dee05 //
        public void Astronomer_Int_c1b5c56204294dc6a8dd6234469dee05() {
journal.AddEntry("The Astronomer was in the infirmary.");
locationLearned += 1;
dt.clues+=1;
        }
        // Event From Node: c95d443e-0122-422a-aedc-045d9b49e28b //
        public void Astronomer_Int_c95d443e0122422aaedc045d9b49e28b() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 377fdbab-c6d4-41ce-9533-e4b3ab8b6b3c //
        public void Astronomer_Int_377fdbabc6d441ce9533e4b3ab8b6b3c() {
GameObject.FindObjectOfType<AudioManager>().Play("End Convo");
        }

    }
}
