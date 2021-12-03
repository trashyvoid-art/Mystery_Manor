using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class Accusations_DialogueCode : DialogueCode, IDialogueCode
    {
        public Accusations_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 44ea825c-02aa-4942-a11c-5767b6404ae6 //
string name = 'The Paleontologist'';
string name2 = 'The Adventurer';
string name3 = 'The Doctor';
string name4 = 'The Astronomer';
string name5 = 'Ms. Scheele';
string name6 = 'The Sailor';


        public void Start()
        {
            // Setup //
            dialogueChecks.Add("Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_fb20b13150ce40478f780955195ca66e",Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_fb20b13150ce40478f780955195ca66e);
            dialogueChecks.Add("Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_a64cc014c531437c92f4ed92b41fdb85",Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_a64cc014c531437c92f4ed92b41fdb85);
            dialogueChecks.Add("Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_3e2046031e424859b1022d9aab786a37",Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_3e2046031e424859b1022d9aab786a37);
            dialogueChecks.Add("Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_2c9425237ff2403fb6185bf3337bc3b3",Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_2c9425237ff2403fb6185bf3337bc3b3);
            dialogueChecks.Add("Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_dc5225ae659e4077a939dd0ce33cee94",Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_dc5225ae659e4077a939dd0ce33cee94);

        }

        // Dialogue Checks //
        // From Node: bc5ab7aa-87f9-4e2e-848f-da9e4d8f6e65 //
        // Choice: The Adventurer - fb20b131-50ce-4047-8f78-0955195ca66e //
        public bool Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_fb20b13150ce40478f780955195ca66e()
        {
            return (true);
        }
        // From Node: bc5ab7aa-87f9-4e2e-848f-da9e4d8f6e65 //
        // Choice: The Doctor - a64cc014-c531-437c-92f4-ed92b41fdb85 //
        public bool Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_a64cc014c531437c92f4ed92b41fdb85()
        {
            return (true);
        }
        // From Node: bc5ab7aa-87f9-4e2e-848f-da9e4d8f6e65 //
        // Choice: The Astronomer - 3e204603-1e42-4859-b102-2d9aab786a37 //
        public bool Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_3e2046031e424859b1022d9aab786a37()
        {
            return (true);
        }
        // From Node: bc5ab7aa-87f9-4e2e-848f-da9e4d8f6e65 //
        // Choice: Ms. Scheele - 2c942523-7ff2-403f-b618-5bf3337bc3b3 //
        public bool Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_2c9425237ff2403fb6185bf3337bc3b3()
        {
            return (true);
        }
        // From Node: bc5ab7aa-87f9-4e2e-848f-da9e4d8f6e65 //
        // Choice: The Sailor - dc5225ae-659e-4077-a939-dd0ce33cee94 //
        public bool Accusations_bc5ab7aa87f94e2e848fda9e4d8f6e65_dc5225ae659e4077a939dd0ce33cee94()
        {
            return (true);
        }


        // Condition Checks //


        // Event Functions //

    }
}
