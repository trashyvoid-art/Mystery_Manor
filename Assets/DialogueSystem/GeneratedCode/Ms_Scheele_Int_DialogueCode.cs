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


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_108d8c0328524b3abb726b64844e6603",Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_108d8c0328524b3abb726b64844e6603);
            dialogueChecks.Add("Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_04a49ac79ceb4573b98b81deb9a5ea1f",Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_04a49ac79ceb4573b98b81deb9a5ea1f);
            dialogueChecks.Add("Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_66ffc2b8f5bb494d87106b6c23b02974",Ms_Scheele_Int_de22f680f6f24185b948014f88d222ee_66ffc2b8f5bb494d87106b6c23b02974);
            eventFunctions.Add("Ms_Scheele_Int_86cb36176c294d0cbb09d833c6db40f2",Ms_Scheele_Int_86cb36176c294d0cbb09d833c6db40f2);
            eventFunctions.Add("Ms_Scheele_Int_52ed881914ba4d7ea499688945fa8bff",Ms_Scheele_Int_52ed881914ba4d7ea499688945fa8bff);
            conditionChecks.Add("Ms_Scheele_Int_2e5d28741701475eb8fd136775e7a9af",Ms_Scheele_Int_2e5d28741701475eb8fd136775e7a9af);
            eventFunctions.Add("Ms_Scheele_Int_cb2e3459d7df4849a2881da80427682c",Ms_Scheele_Int_cb2e3459d7df4849a2881da80427682c);

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


        // Condition Checks //
        // Condition From Node: 2e5d2874-1701-475e-b8fd-136775e7a9af //
        public bool Ms_Scheele_Int_2e5d28741701475eb8fd136775e7a9af() {
            return (choices < 3);
        }


        // Event Functions //
        // Event From Node: 86cb3617-6c29-4d0c-bb09-d833c6db40f2 //
        public void Ms_Scheele_Int_86cb36176c294d0cbb09d833c6db40f2() {
journal.AddEntry("Ms. Scheele was in the entrance hall.");
        }
        // Event From Node: 52ed8819-14ba-4d7e-a499-688945fa8bff //
        public void Ms_Scheele_Int_52ed881914ba4d7ea499688945fa8bff() {
journal.AddEntry("The Doctor and the Psychologist confrontation, Possible motive for the Doctor.");
        }
        // Event From Node: cb2e3459-d7df-4849-a288-1da80427682c //
        public void Ms_Scheele_Int_cb2e3459d7df4849a2881da80427682c() {
choices += 1;
        }

    }
}
