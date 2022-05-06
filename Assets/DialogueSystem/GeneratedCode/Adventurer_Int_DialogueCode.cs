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
Astronomer_Int_DialogueCode shamsa;
string name = "The Adventurer";
Notes.Journal journal = Utility.Toolbox.Instance.Journal;
int choices = 0;
int locationLearned;
int infoLearned;
DataTracker dt = DataTracker.Instance;


        public void Start()
        {
            // Setup //
            eventFunctions.Add("Adventurer_Int_f17b7453aec04de8891514e6b84e396b",Adventurer_Int_f17b7453aec04de8891514e6b84e396b);
            conditionChecks.Add("Adventurer_Int_0efcc623b62a4e9ea6e3c6f5404dd1ba",Adventurer_Int_0efcc623b62a4e9ea6e3c6f5404dd1ba);
            eventFunctions.Add("Adventurer_Int_16ca64c016bd45a7b92c0efd6395fa37",Adventurer_Int_16ca64c016bd45a7b92c0efd6395fa37);
            eventFunctions.Add("Adventurer_Int_7c0ae52eb1f84dcab6bec82c4561acaf",Adventurer_Int_7c0ae52eb1f84dcab6bec82c4561acaf);
            conditionChecks.Add("Adventurer_Int_9fc2c948d06f46e782edd5cf12329e18",Adventurer_Int_9fc2c948d06f46e782edd5cf12329e18);
            eventFunctions.Add("Adventurer_Int_354f6bf600044894a2af0dc909fc0396",Adventurer_Int_354f6bf600044894a2af0dc909fc0396);
            conditionChecks.Add("Adventurer_Int_32827ca3b84b474cb5d39d75c91aa001",Adventurer_Int_32827ca3b84b474cb5d39d75c91aa001);
            dialogueChecks.Add("Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_656e7b9d4213420b8ecaf04cb8f1deea",Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_656e7b9d4213420b8ecaf04cb8f1deea);
            dialogueChecks.Add("Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_0291ff77c9d0449c8ea18ac119450c35",Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_0291ff77c9d0449c8ea18ac119450c35);
            dialogueChecks.Add("Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_017ba2a92591447fbddffbcebda10db4",Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_017ba2a92591447fbddffbcebda10db4);
            dialogueChecks.Add("Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_fdb9342c4c8e4584a4cef351e8ebfdc3",Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_fdb9342c4c8e4584a4cef351e8ebfdc3);
            dialogueChecks.Add("Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_579112dc3c7b4cdfbc319a81eb89eb85",Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_579112dc3c7b4cdfbc319a81eb89eb85);
            eventFunctions.Add("Adventurer_Int_87a4edc0091742bfa70a4eb1619982b4",Adventurer_Int_87a4edc0091742bfa70a4eb1619982b4);
            eventFunctions.Add("Adventurer_Int_4553f082bbb8457d81fe450c4d2f0150",Adventurer_Int_4553f082bbb8457d81fe450c4d2f0150);
            eventFunctions.Add("Adventurer_Int_f97b460f0e8a455e9b9a136dc809a9b0",Adventurer_Int_f97b460f0e8a455e9b9a136dc809a9b0);
            eventFunctions.Add("Adventurer_Int_3def0688b35945108da7c447d28c67dd",Adventurer_Int_3def0688b35945108da7c447d28c67dd);
            eventFunctions.Add("Adventurer_Int_f42b6ba011bf4eafae178b47abf8bf5e",Adventurer_Int_f42b6ba011bf4eafae178b47abf8bf5e);
            eventFunctions.Add("Adventurer_Int_a3e5432c5c4d420dafab4f7e2064cbde",Adventurer_Int_a3e5432c5c4d420dafab4f7e2064cbde);
            eventFunctions.Add("Adventurer_Int_89ba60ae207c4f97aa8c3451b2e04d4d",Adventurer_Int_89ba60ae207c4f97aa8c3451b2e04d4d);
            eventFunctions.Add("Adventurer_Int_23434503faa5426e90335f61b984ef8f",Adventurer_Int_23434503faa5426e90335f61b984ef8f);
            eventFunctions.Add("Adventurer_Int_4f7d54b5320f4bc398b9dc59f9ca68eb",Adventurer_Int_4f7d54b5320f4bc398b9dc59f9ca68eb);
            eventFunctions.Add("Adventurer_Int_576918b1887f491493facda88dc32496",Adventurer_Int_576918b1887f491493facda88dc32496);

        }

        // Dialogue Checks //
        // From Node: e2a31422-f166-4498-b906-c8cfd8eb5a35 //
        // Choice: Where were you at the time of the murder? - 656e7b9d-4213-420b-8eca-f04cb8f1deea //
        public bool Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_656e7b9d4213420b8ecaf04cb8f1deea()
        {
            return (true);
        }
        // From Node: e2a31422-f166-4498-b906-c8cfd8eb5a35 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - 0291ff77-c9d0-449c-8ea1-8ac119450c35 //
        public bool Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_0291ff77c9d0449c8ea18ac119450c35()
        {
            return (true);
        }
        // From Node: e2a31422-f166-4498-b906-c8cfd8eb5a35 //
        // Choice: Bloody Nose? - 017ba2a9-2591-447f-bddf-fbcebda10db4 //
        public bool Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_017ba2a92591447fbddffbcebda10db4()
        {
            return (dt.shamsaTalkedTo == 1);
        }
        // From Node: e2a31422-f166-4498-b906-c8cfd8eb5a35 //
        // Choice: Do you have any other information about the case? - fdb9342c-4c8e-4584-a4ce-f351e8ebfdc3 //
        public bool Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_fdb9342c4c8e4584a4cef351e8ebfdc3()
        {
            return (true);
        }
        // From Node: e2a31422-f166-4498-b906-c8cfd8eb5a35 //
        // Choice: Did you kill Scarlett? - 579112dc-3c7b-4cdf-bc31-9a81eb89eb85 //
        public bool Adventurer_Int_e2a31422f1664498b906c8cfd8eb5a35_579112dc3c7b4cdfbc319a81eb89eb85()
        {
            return (dt.clues >= 7);
        }


        // Condition Checks //
        // Condition From Node: 0efcc623-b62a-4e9e-a6e3-c6f5404dd1ba //
        public bool Adventurer_Int_0efcc623b62a4e9ea6e3c6f5404dd1ba() {
            return (choices < 4);
        }
        // Condition From Node: 9fc2c948-d06f-46e7-82ed-d5cf12329e18 //
        public bool Adventurer_Int_9fc2c948d06f46e782edd5cf12329e18() {
            return (infoLearned > 0);
        }
        // Condition From Node: 32827ca3-b84b-474c-b5d3-9d75c91aa001 //
        public bool Adventurer_Int_32827ca3b84b474cb5d39d75c91aa001() {
            return (locationLearned > 0);
        }


        // Event Functions //
        // Event From Node: f17b7453-aec0-4de8-8915-14e6b84e396b //
        public void Adventurer_Int_f17b7453aec04de8891514e6b84e396b() {
choices +=1;
        }
        // Event From Node: 16ca64c0-16bd-45a7-b92c-0efd6395fa37 //
        public void Adventurer_Int_16ca64c016bd45a7b92c0efd6395fa37() {
shamsa = new Astronomer_Int_DialogueCode();
        }
        // Event From Node: 7c0ae52e-b1f8-4dca-b6be-c82c4561acaf //
        public void Adventurer_Int_7c0ae52eb1f84dcab6bec82c4561acaf() {
dt.wrongAccusations += 1;
        }
        // Event From Node: 354f6bf6-0004-4894-a2af-0dc909fc0396 //
        public void Adventurer_Int_354f6bf600044894a2af0dc909fc0396() {
journal.AddEntry("Incident during dinner involving The Psychologist.");
dt.clues += 1;
infoLearned += 1;
        }
        // Event From Node: 87a4edc0-0917-42bf-a70a-4eb1619982b4 //
        public void Adventurer_Int_87a4edc0091742bfa70a4eb1619982b4() {
GameObject.FindObjectOfType<AudioManager>().Play("Sam End");
        }
        // Event From Node: 4553f082-bbb8-457d-81fe-450c4d2f0150 //
        public void Adventurer_Int_4553f082bbb8457d81fe450c4d2f0150() {
GameObject.FindObjectOfType<AudioManager>().Play("End Convo");
        }
        // Event From Node: f97b460f-0e8a-455e-9b9a-136dc809a9b0 //
        public void Adventurer_Int_f97b460f0e8a455e9b9a136dc809a9b0() {
GameObject.FindObjectOfType<AudioManager>().Play("Sam 1");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 3def0688-b359-4510-8da7-c447d28c67dd //
        public void Adventurer_Int_3def0688b35945108da7c447d28c67dd() {
GameObject.FindObjectOfType<AudioManager>().Play("Sam 2");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: f42b6ba0-11bf-4eaf-ae17-8b47abf8bf5e //
        public void Adventurer_Int_f42b6ba011bf4eafae178b47abf8bf5e() {
GameObject.FindObjectOfType<AudioManager>().Play("Sam 3");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: a3e5432c-5c4d-420d-afab-4f7e2064cbde //
        public void Adventurer_Int_a3e5432c5c4d420dafab4f7e2064cbde() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sam Accuse 1");
        }
        // Event From Node: 89ba60ae-207c-4f97-aa8c-3451b2e04d4d //
        public void Adventurer_Int_89ba60ae207c4f97aa8c3451b2e04d4d() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sam Accuse 2");
        }
        // Event From Node: 23434503-faa5-426e-9033-5f61b984ef8f //
        public void Adventurer_Int_23434503faa5426e90335f61b984ef8f() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sam 4");
        }
        // Event From Node: 4f7d54b5-320f-4bc3-98b9-dc59f9ca68eb //
        public void Adventurer_Int_4f7d54b5320f4bc398b9dc59f9ca68eb() {
journal.AddEntry("The Adventurer and The Doctor were in the bar together.");
dt.clues += 1;
locationLearned += 1;
        }
        // Event From Node: 576918b1-887f-4914-93fa-cda88dc32496 //
        public void Adventurer_Int_576918b1887f491493facda88dc32496() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }

    }
}
