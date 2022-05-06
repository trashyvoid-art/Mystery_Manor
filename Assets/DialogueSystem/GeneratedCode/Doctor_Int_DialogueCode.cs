using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Doctor_Int_DialogueCode : DialogueCode, IDialogueCode
    {
        public Doctor_Int_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: dad830d9-4c63-415e-bc73-4855505290b6 //
string name = "The Doctor";
Notes.Journal journal = Utility.Toolbox.Instance.Journal;
int choices = 0;
int locationLearned = 0;
int bloodyNose = 0;
DataTracker dt = DataTracker.Instance;


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_111235d5bb624d19946e762bf1a280be",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_111235d5bb624d19946e762bf1a280be);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_c40c75f7ca644e1583da2ba6315e5b36",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_c40c75f7ca644e1583da2ba6315e5b36);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_0bda6154d9ad4951aca73576e844976e",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_0bda6154d9ad4951aca73576e844976e);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_9d0f0bd4af28482da07204fc9a87320b",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_9d0f0bd4af28482da07204fc9a87320b);
            eventFunctions.Add("Doctor_Int_54f63204944345bc8f3cd61b6056ab2f",Doctor_Int_54f63204944345bc8f3cd61b6056ab2f);
            conditionChecks.Add("Doctor_Int_e6433e341bf44500b7c8c177708cdbbe",Doctor_Int_e6433e341bf44500b7c8c177708cdbbe);
            eventFunctions.Add("Doctor_Int_293b8729313e446d86d79b9aa9b7bae3",Doctor_Int_293b8729313e446d86d79b9aa9b7bae3);
            conditionChecks.Add("Doctor_Int_5d006fd1b303432b860fdc5d51b0a59c",Doctor_Int_5d006fd1b303432b860fdc5d51b0a59c);
            eventFunctions.Add("Doctor_Int_f79854ee5eda4daa80ab07b3dc1031c7",Doctor_Int_f79854ee5eda4daa80ab07b3dc1031c7);
            conditionChecks.Add("Doctor_Int_01cdf448af4540ab9570776ac7058fb5",Doctor_Int_01cdf448af4540ab9570776ac7058fb5);
            eventFunctions.Add("Doctor_Int_882801d323e34c6488fa0b08e73b0cd7",Doctor_Int_882801d323e34c6488fa0b08e73b0cd7);
            eventFunctions.Add("Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437",Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437);
            eventFunctions.Add("Doctor_Int_22e16e9d80d941ccaef02d91b19e6e31",Doctor_Int_22e16e9d80d941ccaef02d91b19e6e31);
            eventFunctions.Add("Doctor_Int_79752f2d49eb420ab4734d48dbfe5af7",Doctor_Int_79752f2d49eb420ab4734d48dbfe5af7);
            eventFunctions.Add("Doctor_Int_ac5f27ab1cb141848befdc3d938b0e5f",Doctor_Int_ac5f27ab1cb141848befdc3d938b0e5f);
            eventFunctions.Add("Doctor_Int_5fbb3e8714954bc5a68e00794003104b",Doctor_Int_5fbb3e8714954bc5a68e00794003104b);
            eventFunctions.Add("Doctor_Int_f029878e624949f9b919d5521eb0c215",Doctor_Int_f029878e624949f9b919d5521eb0c215);
            eventFunctions.Add("Doctor_Int_5eaab823467e44a2bd1fb4cf2b41f529",Doctor_Int_5eaab823467e44a2bd1fb4cf2b41f529);
            eventFunctions.Add("Doctor_Int_b2652e289d314a3991c624b9d2e8d0d9",Doctor_Int_b2652e289d314a3991c624b9d2e8d0d9);
            eventFunctions.Add("Doctor_Int_cb87a81200c14b93ad781c4d6f216e8f",Doctor_Int_cb87a81200c14b93ad781c4d6f216e8f);
            eventFunctions.Add("Doctor_Int_88510179a3994c84b7f085fa02565841",Doctor_Int_88510179a3994c84b7f085fa02565841);

        }

        // Dialogue Checks //
        // From Node: fd9ab04b-67a8-4b9c-a18d-70bcca6dad31 //
        // Choice: What do you know about the Adventurer's bloody nose? - 87f98752-1728-4dc0-b3c9-08f1ca13cbc7 //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7()
        {
            return (dt.shamsaTalkedTo == 1);
        }
        // From Node: fd9ab04b-67a8-4b9c-a18d-70bcca6dad31 //
        // Choice: Where were you at the time of the murder? - 111235d5-bb62-4d19-946e-762bf1a280be //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_111235d5bb624d19946e762bf1a280be()
        {
            return (true);
        }
        // From Node: fd9ab04b-67a8-4b9c-a18d-70bcca6dad31 //
        // Choice: Do you know why someone would have wanted to hurt the victim? - c40c75f7-ca64-4e15-83da-2ba6315e5b36 //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_c40c75f7ca644e1583da2ba6315e5b36()
        {
            return (true);
        }
        // From Node: fd9ab04b-67a8-4b9c-a18d-70bcca6dad31 //
        // Choice: Do you have any other information about the case? - 0bda6154-d9ad-4951-aca7-3576e844976e //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_0bda6154d9ad4951aca73576e844976e()
        {
            return (true);
        }
        // From Node: fd9ab04b-67a8-4b9c-a18d-70bcca6dad31 //
        // Choice: Did you kill Scarlette? - 9d0f0bd4-af28-482d-a072-04fc9a87320b //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_9d0f0bd4af28482da07204fc9a87320b()
        {
            return (dt.clues == 7);
        }


        // Condition Checks //
        // Condition From Node: e6433e34-1bf4-4500-b7c8-c177708cdbbe //
        public bool Doctor_Int_e6433e341bf44500b7c8c177708cdbbe() {
            return (choices < 4);
        }
        // Condition From Node: 5d006fd1-b303-432b-860f-dc5d51b0a59c //
        public bool Doctor_Int_5d006fd1b303432b860fdc5d51b0a59c() {
            return (locationLearned > 0);
        }
        // Condition From Node: 01cdf448-af45-40ab-9570-776ac7058fb5 //
        public bool Doctor_Int_01cdf448af4540ab9570776ac7058fb5() {
            return (bloodyNose > 0);
        }


        // Event Functions //
        // Event From Node: 54f63204-9443-45bc-8f3c-d61b6056ab2f //
        public void Doctor_Int_54f63204944345bc8f3cd61b6056ab2f() {
choices += 1;
        }
        // Event From Node: 293b8729-313e-446d-86d7-9b9aa9b7bae3 //
        public void Doctor_Int_293b8729313e446d86d79b9aa9b7bae3() {
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez End");
        }
        // Event From Node: f79854ee-5eda-4daa-80ab-07b3dc1031c7 //
        public void Doctor_Int_f79854ee5eda4daa80ab07b3dc1031c7() {
dt.wrongAccusations += 1;
        }
        // Event From Node: 882801d3-23e3-4c64-88fa-0b08e73b0cd7 //
        public void Doctor_Int_882801d323e34c6488fa0b08e73b0cd7() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
dt.clues += 1;
bloodyNose += 1;
        }
        // Event From Node: 0eb957eb-90a1-4f98-8ce3-a45a7b19a437 //
        public void Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437() {
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 5");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 22e16e9d-80d9-41cc-aef0-2d91b19e6e31 //
        public void Doctor_Int_22e16e9d80d941ccaef02d91b19e6e31() {
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 4");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 79752f2d-49eb-420a-b473-4d48dbfe5af7 //
        public void Doctor_Int_79752f2d49eb420ab4734d48dbfe5af7() {
GameObject.FindObjectOfType<AudioManager>().Play("Start Convo");
        }
        // Event From Node: ac5f27ab-1cb1-4184-8bef-dc3d938b0e5f //
        public void Doctor_Int_ac5f27ab1cb141848befdc3d938b0e5f() {
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 1");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 5fbb3e87-1495-4bc5-a68e-00794003104b //
        public void Doctor_Int_5fbb3e8714954bc5a68e00794003104b() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer.");
dt.clues += 1;
locationLearned += 1;
        }
        // Event From Node: f029878e-6249-49f9-b919-d5521eb0c215 //
        public void Doctor_Int_f029878e624949f9b919d5521eb0c215() {
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 2");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: 5eaab823-467e-44a2-bd1f-b4cf2b41f529 //
        public void Doctor_Int_5eaab823467e44a2bd1fb4cf2b41f529() {
GameObject.FindObjectOfType<AudioManager>().Play("End Convo");
        }
        // Event From Node: b2652e28-9d31-4a39-91c6-24b9d2e8d0d9 //
        public void Doctor_Int_b2652e289d314a3991c624b9d2e8d0d9() {
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 3");
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }
        // Event From Node: cb87a812-00c1-4b93-ad78-1c4d6f216e8f //
        public void Doctor_Int_cb87a81200c14b93ad781c4d6f216e8f() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez Accuse");
        }
        // Event From Node: 88510179-a399-4c84-b7f0-85fa02565841 //
        public void Doctor_Int_88510179a3994c84b7f085fa02565841() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
        }

    }
}
