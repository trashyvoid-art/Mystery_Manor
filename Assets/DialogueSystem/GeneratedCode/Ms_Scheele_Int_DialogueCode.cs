using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Ms_Scheele_Int_DialogueCode : DialogueCode, IDialogueCode
    {
        public Ms_Scheele_Int_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: bc34f003-a4f8-48bd-897a-d7f0e226a48d //
string name = "Ms. Scheele";
Notes.Journal journal = Utility.Toolbox.Instance.Journal;
int choices = 0;
int locationsLearned = 0;
int infoLearned = 0;
DataTracker dt = DataTracker.Instance;


        public void Start()
        {
            // Setup //
            conditionChecks.Add("Ms_Scheele_Int_2e5d28741701475eb8fd136775e7a9af",Ms_Scheele_Int_2e5d28741701475eb8fd136775e7a9af);
            eventFunctions.Add("Ms_Scheele_Int_cb2e3459d7df4849a2881da80427682c",Ms_Scheele_Int_cb2e3459d7df4849a2881da80427682c);
            eventFunctions.Add("Ms_Scheele_Int_a28021a5226d46ae9a16f2931e9702ca",Ms_Scheele_Int_a28021a5226d46ae9a16f2931e9702ca);
            eventFunctions.Add("Ms_Scheele_Int_516232e98cfc48f28f1ce48b0faad408",Ms_Scheele_Int_516232e98cfc48f28f1ce48b0faad408);
            eventFunctions.Add("Ms_Scheele_Int_86cb36176c294d0cbb09d833c6db40f2",Ms_Scheele_Int_86cb36176c294d0cbb09d833c6db40f2);
            eventFunctions.Add("Ms_Scheele_Int_58b94c1ce19e4594b96ce00ab7769dd9",Ms_Scheele_Int_58b94c1ce19e4594b96ce00ab7769dd9);
            conditionChecks.Add("Ms_Scheele_Int_65516af0a0fb430b9224b527ce2c662c",Ms_Scheele_Int_65516af0a0fb430b9224b527ce2c662c);
            conditionChecks.Add("Ms_Scheele_Int_074278c8af6846b786db563f306b6704",Ms_Scheele_Int_074278c8af6846b786db563f306b6704);
            eventFunctions.Add("Ms_Scheele_Int_52ed881914ba4d7ea499688945fa8bff",Ms_Scheele_Int_52ed881914ba4d7ea499688945fa8bff);
            eventFunctions.Add("Ms_Scheele_Int_2a4316b0d5f940c08f2a58cee703a297",Ms_Scheele_Int_2a4316b0d5f940c08f2a58cee703a297);
            dialogueChecks.Add("Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_108d8c0328524b3abb726b64844e6603",Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_108d8c0328524b3abb726b64844e6603);
            dialogueChecks.Add("Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_04a49ac79ceb4573b98b81deb9a5ea1f",Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_04a49ac79ceb4573b98b81deb9a5ea1f);
            dialogueChecks.Add("Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_66ffc2b8f5bb494d87106b6c23b02974",Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_66ffc2b8f5bb494d87106b6c23b02974);
            dialogueChecks.Add("Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_6b2d0f09dff542e3bc62524871d43361",Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_6b2d0f09dff542e3bc62524871d43361);
            eventFunctions.Add("Ms_Scheele_Int_9f979fd012b24b3b9243e40eb880aee3",Ms_Scheele_Int_9f979fd012b24b3b9243e40eb880aee3);

        }

        // Dialogue Checks //
        // From Node: de22f680-f6f2-4185-b948-014f88d222ee //
        // Choice: Where were you at the time of the murder - 108d8c03-2852-4b3a-bb72-6b64844e6603 //
        public bool Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_108d8c0328524b3abb726b64844e6603()
        {
            return (true);
        }
        // From Node: de22f680-f6f2-4185-b948-014f88d222ee //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 04a49ac7-9ceb-4573-b98b-81deb9a5ea1f //
        public bool Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_04a49ac79ceb4573b98b81deb9a5ea1f()
        {
            return (true);
        }
        // From Node: de22f680-f6f2-4185-b948-014f88d222ee //
        // Choice: Do you have any other information? - 66ffc2b8-f5bb-494d-8710-6b6c23b02974 //
        public bool Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_66ffc2b8f5bb494d87106b6c23b02974()
        {
            return (true);
        }
        // From Node: de22f680-f6f2-4185-b948-014f88d222ee //
        // Choice: Did you kill Scarlette? - 6b2d0f09-dff5-42e3-bc62-524871d43361 //
        public bool Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_6b2d0f09dff542e3bc62524871d43361()
        {
            return (dt.clues >= 7);
        }


        // Condition Checks //
        // Condition From Node: 2e5d2874-1701-475e-b8fd-136775e7a9af //
        public bool Ms_Scheele_Int_2e5d28741701475eb8fd136775e7a9af() {
            return (choices < 3);
        }
        // Condition From Node: 65516af0-a0fb-430b-9224-b527ce2c662c //
        public bool Ms_Scheele_Int_65516af0a0fb430b9224b527ce2c662c() {
            return (locationsLearned>0);
        }
        // Condition From Node: 074278c8-af68-46b7-86db-563f306b6704 //
        public bool Ms_Scheele_Int_074278c8af6846b786db563f306b6704() {
            return (infoLearned > 0);
        }


        // Event Functions //
        // Event From Node: cb2e3459-d7df-4849-a288-1da80427682c //
        public void Ms_Scheele_Int_cb2e3459d7df4849a2881da80427682c() {
choices += 1;
        }
        // Event From Node: a28021a5-226d-46ae-9a16-f2931e9702ca //
        public void Ms_Scheele_Int_a28021a5226d46ae9a16f2931e9702ca() {
GameObject.FindObjectOfType<AudioManager>().Play("Ms Scheele 2");
        }
        // Event From Node: 516232e9-8cfc-48f2-8f1c-e48b0faad408 //
        public void Ms_Scheele_Int_516232e98cfc48f28f1ce48b0faad408() {
GameObject.FindObjectOfType<AudioManager>().Play("Ms Scheele End");
        }
        // Event From Node: 86cb3617-6c29-4d0c-bb09-d833c6db40f2 //
        public void Ms_Scheele_Int_86cb36176c294d0cbb09d833c6db40f2() {
GameObject.FindObjectOfType<AudioManager>().Play("Ms Scheele 1");

        }
        // Event From Node: 58b94c1c-e19e-4594-b96c-e00ab7769dd9 //
        public void Ms_Scheele_Int_58b94c1ce19e4594b96ce00ab7769dd9() {
journal.AddEntry("Ms. Scheele was in the entrance hall.");
locationsLearned+=1;
dt.clues+=1;
        }
        // Event From Node: 52ed8819-14ba-4d7e-a499-688945fa8bff //
        public void Ms_Scheele_Int_52ed881914ba4d7ea499688945fa8bff() {
GameObject.FindObjectOfType<AudioManager>().Play("Ms Scheele 3");

        }
        // Event From Node: 2a4316b0-d5f9-40c0-8f2a-58cee703a297 //
        public void Ms_Scheele_Int_2a4316b0d5f940c08f2a58cee703a297() {
journal.AddEntry("The Doctor and the Psychologist confrontation, Possible motive for the Doctor.");
infoLearned+=1;
dt.clues+=1;
        }
        // Event From Node: 9f979fd0-12b2-4b3b-9243-e40eb880aee3 //
        public void Ms_Scheele_Int_9f979fd012b24b3b9243e40eb880aee3() {
dt.wrongAccusations+=1;
        }

    }
}
