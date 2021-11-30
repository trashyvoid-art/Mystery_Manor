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
Notes.Journal j = Utility.Toolbox.Instance.Journal;


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_111235d5bb624d19946e762bf1a280be",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_111235d5bb624d19946e762bf1a280be);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_c40c75f7ca644e1583da2ba6315e5b36",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_c40c75f7ca644e1583da2ba6315e5b36);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_0bda6154d9ad4951aca73576e844976e",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_0bda6154d9ad4951aca73576e844976e);
            dialogueChecks.Add("Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7",Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7);
            eventFunctions.Add("Doctor_Int_5fbb3e8714954bc5a68e00794003104b",Doctor_Int_5fbb3e8714954bc5a68e00794003104b);
            eventFunctions.Add("Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437",Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437);

        }

        // Dialogue Checks //
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
        // Choice: What do you know about the Adventurer's bloody nose? - 87f98752-1728-4dc0-b3c9-08f1ca13cbc7 //
        public bool Doctor_Int_fd9ab04b67a84b9ca18d70bcca6dad31_87f9875217284dc0b3c908f1ca13cbc7()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //
        // Event From Node: 5fbb3e87-1495-4bc5-a68e-00794003104b //
        public void Doctor_Int_5fbb3e8714954bc5a68e00794003104b() {
journal.AddEntry("The Doctor was in the Bar with the Adventurer."); 
        }
        // Event From Node: 0eb957eb-90a1-4f98-8ce3-a45a7b19a437 //
        public void Doctor_Int_0eb957eb90a14f988ce3a45a7b19a437() {
journal.AddEntry("Denies incident with The Adventurer, lying?");
        }

    }
}
