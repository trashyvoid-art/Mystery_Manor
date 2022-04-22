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
            eventFunctions.Add("Doctor_Int_54f63204944345bc8f3cd61b6056ab2f",Doctor_Int_54f63204944345bc8f3cd61b6056ab2f);
            eventFunctions.Add("Doctor_Int_5fbb3e8714954bc5a68e00794003104b",Doctor_Int_5fbb3e8714954bc5a68e00794003104b);
            conditionChecks.Add("Doctor_Int_e6433e341bf44500b7c8c177708cdbbe",Doctor_Int_e6433e341bf44500b7c8c177708cdbbe);
            eventFunctions.Add("Doctor_Int_f029878e624949f9b919d5521eb0c215",Doctor_Int_f029878e624949f9b919d5521eb0c215);
            eventFunctions.Add("Doctor_Int_b2652e289d314a3991c624b9d2e8d0d9",Doctor_Int_b2652e289d314a3991c624b9d2e8d0d9);
            eventFunctions.Add("Doctor_Int_293b8729313e446d86d79b9aa9b7bae3",Doctor_Int_293b8729313e446d86d79b9aa9b7bae3);
            eventFunctions.Add("Doctor_Int_3e60f92cc75949b9982c7fa46567a7f3",Doctor_Int_3e60f92cc75949b9982c7fa46567a7f3);
            eventFunctions.Add("Doctor_Int_68891d21931645e8ac4e2aa14cfd8119",Doctor_Int_68891d21931645e8ac4e2aa14cfd8119);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_111235d5bb624d19946e762bf1a280be",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_111235d5bb624d19946e762bf1a280be);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_c40c75f7ca644e1583da2ba6315e5b36",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_c40c75f7ca644e1583da2ba6315e5b36);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_0bda6154d9ad4951aca73576e844976e",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_0bda6154d9ad4951aca73576e844976e);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_7b68b1c4df534ffc9a9fc0affc043287",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_7b68b1c4df534ffc9a9fc0affc043287);
            conditionChecks.Add("Doctor_Int_b18fc7f1744d428387910ef4404c5c55",Doctor_Int_b18fc7f1744d428387910ef4404c5c55);
            eventFunctions.Add("Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437",Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437);
            eventFunctions.Add("Doctor_Int_6af0e407c7c54b8683c1770fa9ab71ea",Doctor_Int_6af0e407c7c54b8683c1770fa9ab71ea);
            conditionChecks.Add("Doctor_Int_8cfbfa6e2c8942a2bcffc39b5faccfa6",Doctor_Int_8cfbfa6e2c8942a2bcffc39b5faccfa6);

        }

        // Dialogue Checks //
        // From Node: fd9ab04b-67a8-4b9c-a18d-70bcca6dad31 //
        // Choice: Where were you at the time of the murder? - 111235d5-bb62-4d19-946e-762bf1a280be //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_111235d5bb624d19946e762bf1a280be()
        {
            return (true);
        }
        // From Node: fd9ab04b-67a8-4b9c-a18d-70bcca6dad31 //
        // Choice: What do you know about the Adventurer's bloody nose? - 87f98752-1728-4dc0-b3c9-08f1ca13cbc7 //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7()
        {
            return (dt.shamsaTalkedTo == 1);
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
        // Choice: Did you kill Scarlette? - 7b68b1c4-df53-4ffc-9a9f-c0affc043287 //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_7b68b1c4df534ffc9a9fc0affc043287()
        {
            return (dt.clues >= 6);
        }


        // Condition Checks //
        // Condition From Node: e6433e34-1bf4-4500-b7c8-c177708cdbbe //
        public bool Doctor_Int_e6433e341bf44500b7c8c177708cdbbe() {
            return (choices < 4);
        }
        // Condition From Node: b18fc7f1-744d-4283-8791-0ef4404c5c55 //
        public bool Doctor_Int_b18fc7f1744d428387910ef4404c5c55() {
            return (locationLearned > 0);
        }
        // Condition From Node: 8cfbfa6e-2c89-42a2-bcff-c39b5faccfa6 //
        public bool Doctor_Int_8cfbfa6e2c8942a2bcffc39b5faccfa6() {
            return (bloodyNose > 0);
        }


        // Event Functions //
        // Event From Node: 54f63204-9443-45bc-8f3c-d61b6056ab2f //
        public void Doctor_Int_54f63204944345bc8f3cd61b6056ab2f() {
choices += 1;
        }
        // Event From Node: 5fbb3e87-1495-4bc5-a68e-00794003104b //
        public void Doctor_Int_5fbb3e8714954bc5a68e00794003104b() {
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 1");

        }
        // Event From Node: f029878e-6249-49f9-b919-d5521eb0c215 //
        public void Doctor_Int_f029878e624949f9b919d5521eb0c215() {
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 2");
        }
        // Event From Node: b2652e28-9d31-4a39-91c6-24b9d2e8d0d9 //
        public void Doctor_Int_b2652e289d314a3991c624b9d2e8d0d9() {
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 3");
        }
        // Event From Node: 293b8729-313e-446d-86d7-9b9aa9b7bae3 //
        public void Doctor_Int_293b8729313e446d86d79b9aa9b7bae3() {
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez End");
        }
        // Event From Node: 3e60f92c-c759-49b9-982c-7fa46567a7f3 //
        public void Doctor_Int_3e60f92cc75949b9982c7fa46567a7f3() {
dt.wrongAccusations += 1;
        }
        // Event From Node: 68891d21-9316-45e8-ac4e-2aa14cfd8119 //
        public void Doctor_Int_68891d21931645e8ac4e2aa14cfd8119() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer.");
locationLearned += 1;
dt.clues += 1;
        }
        // Event From Node: 0eb957eb-90a1-4f98-8ce3-a45a7b19a437 //
        public void Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437() {
GameObject.FindObjectOfType<AudioManager>().Play("Sanchez 5");
        }
        // Event From Node: 6af0e407-c7c5-4b86-83c1-770fa9ab71ea //
        public void Doctor_Int_6af0e407c7c54b8683c1770fa9ab71ea() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
bloodyNose += 1;
dt.clues += 1;
        }

    }
}
