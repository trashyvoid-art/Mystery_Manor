using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using DialogueSystem;
using System.Reflection;

namespace DialogueSystem.Code
{
    public class intro_Sailor_DialogueCode : DialogueCode, IDialogueCode
    {
        public intro_Sailor_DialogueCode() 
        {
            Start();
        }


        // Variables //
        // Variable(s) From Node: 1a252abf-f61f-4743-b78d-a4fcfd1eb621 //
string name = "The Sailor";


        public void Start()
        {
            // Setup //
            eventFunctions.Add("intro_Sailor_e263ef08067945db9df862fd7bd66844",intro_Sailor_e263ef08067945db9df862fd7bd66844);
            eventFunctions.Add("intro_Sailor_f1a6b74c813845b6976fb45147ea6501",intro_Sailor_f1a6b74c813845b6976fb45147ea6501);
            eventFunctions.Add("intro_Sailor_c53d7ebb61e54be0b7b597e8908598cb",intro_Sailor_c53d7ebb61e54be0b7b597e8908598cb);
            eventFunctions.Add("intro_Sailor_e3f4fd1c8ffc4a018ec165dfc9624377",intro_Sailor_e3f4fd1c8ffc4a018ec165dfc9624377);
            eventFunctions.Add("intro_Sailor_77535bc76510422e90ad0e138eff9d2e",intro_Sailor_77535bc76510422e90ad0e138eff9d2e);

        }

        // Dialogue Checks //


        // Condition Checks //


        // Event Functions //
        // Event From Node: e263ef08-0679-45db-9df8-62fd7bd66844 //
        public void intro_Sailor_e263ef08067945db9df862fd7bd66844() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sean 3");
        }
        // Event From Node: f1a6b74c-8138-45b6-976f-b45147ea6501 //
        public void intro_Sailor_f1a6b74c813845b6976fb45147ea6501() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sean 4");
        }
        // Event From Node: c53d7ebb-61e5-4be0-b7b5-97e8908598cb //
        public void intro_Sailor_c53d7ebb61e54be0b7b597e8908598cb() {
GameObject.FindObjectOfType<AudioManager>().Play("End Convo");
        }
        // Event From Node: e3f4fd1c-8ffc-4a01-8ec1-65dfc9624377 //
        public void intro_Sailor_e3f4fd1c8ffc4a018ec165dfc9624377() {
GameObject.FindObjectOfType<AudioManager>().Play("Start Convo");
GameObject.FindObjectOfType<AudioManager>().Play("Sean 1");
        }
        // Event From Node: 77535bc7-6510-422e-90ad-0e138eff9d2e //
        public void intro_Sailor_77535bc76510422e90ad0e138eff9d2e() {
GameObject.FindObjectOfType<AudioManager>().Play("Next Line");
GameObject.FindObjectOfType<AudioManager>().Play("Sean 2");
        }

    }
}
